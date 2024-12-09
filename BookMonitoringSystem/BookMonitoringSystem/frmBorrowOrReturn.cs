using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BookMonitoringSystem
{
    public partial class frmBorrowOrReturn : Form
    {
        OleDbConnection con;
        public frmBorrowOrReturn()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\3rd year 1st sem\\BMS-20240507T055843Z-001\\BMS - Copy\\Book Monitoring System.mdb");
        }
        private void frmBorrow_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            loadDatagrid();
            gridBorrower.DefaultCellStyle.ForeColor = Color.Black;
            gridBooks.DefaultCellStyle.ForeColor = Color.Black;
            gridBorrowedbooks.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void loadDatagrid()
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("Select * from Book where status = 'Available' order by bookid asc", con);
            com.ExecuteNonQuery();
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            gridBooks.DataSource = tab;

            com = new OleDbCommand("Select * from borrower order by borrowerid asc", con);
            com.ExecuteNonQuery();
            adap = new OleDbDataAdapter(com);
            tab = new DataTable();
            adap.Fill(tab);
            gridBorrower.DataSource = tab;

            com = new OleDbCommand("Select * from borrowedbook where borrowerid='" + txbBorrowerID.Text + "'", con);
            com.ExecuteNonQuery();
            adap = new OleDbDataAdapter(com);
            tab = new DataTable();
            adap.Fill(tab);
            gridBorrowedbooks.DataSource = tab;

            con.Close();
        }


        private void txbSearchBook_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand com = new OleDbCommand("Select * from book where title like'%" + txbSearchBook.Text + "%'", con);
            com.ExecuteNonQuery();
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            gridBooks.DataSource = tab;

            con.Close();
        }

        private void txbSearchBorrower_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("Select * from borrower where Firstname like'%" + txbSearchBorrower.Text + "%'", con);
            com.ExecuteNonQuery();
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            gridBorrower.DataSource = tab;
            con.Close();
        }

        private void gridBorrower_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnBorrow.Enabled = true;
                if (e.RowIndex >= 0)
                {
                    gridBorrowedbooks.Enabled = true;
                    gridBooks.Enabled = true;

                    txbBorrowerID.Text = gridBorrower.Rows[e.RowIndex].Cells["borrowerid"].Value.ToString();
                    txbFirstname.Text = gridBorrower.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                    txbLastname.Text = gridBorrower.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                    txbContact.Text = gridBorrower.Rows[e.RowIndex].Cells["contactno"].Value.ToString();

                    txbBookID.Text = "";
                    txbAuthor.Text = "";
                    txbStatus.Text = "";
                    txbTitle.Text = "";

                    loadDatagrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting a borrower: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnBorrow.Enabled = true;
                    btnReturn.Enabled = false;

                    txbBookID.Text = gridBooks.Rows[e.RowIndex].Cells["bookID"].Value.ToString();
                    txbTitle.Text = gridBooks.Rows[e.RowIndex].Cells["title"].Value.ToString();
                    txbAuthor.Text = gridBooks.Rows[e.RowIndex].Cells["author"].Value.ToString();
                    txbStatus.Text = gridBooks.Rows[e.RowIndex].Cells["status"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting a book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gridBorrowedbooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnReturn.Enabled = true;
                    btnBorrow.Enabled = false;
                    DataGridViewRow row = gridBorrowedbooks.Rows[e.RowIndex];
                    string bookID = row.Cells["BookID"].Value.ToString();

                    con.Open();
                    OleDbCommand com = new OleDbCommand("SELECT * FROM Book WHERE bookID = " + bookID + "", con);
                    OleDbDataReader reader = com.ExecuteReader();

                    if (reader.Read())
                    {
                        string status = reader["status"].ToString();
                        if (status == "Not Available")
                        {
                            txbBookID.Text = reader["bookID"].ToString();
                            txbTitle.Text = reader["title"].ToString();
                            txbAuthor.Text = reader["author"].ToString();
                            txbStatus.Text = status;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting a borrowed book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrow_Click_1(object sender, EventArgs e)
        {
            try
            {
                gridBooks.Enabled = false;
                if (btnBorrowCondition())
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("Select * from Borrowedbook order by borrowid asc", con);
                    com.ExecuteNonQuery();

                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable tab = new DataTable();

                    adap.Fill(tab);
                    string borrowid = (tab.Rows.Count + 1).ToString();
                    com = new OleDbCommand("Insert into borrowedbook values ('" + borrowid + "', '" + txbBorrowerID.Text + "', '" + txbBookID.Text + "')", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("New Borrowed Book Added.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    com = new OleDbCommand("Update book SET status='Not Available' where bookid= " + txbBookID.Text, con);
                    com.ExecuteNonQuery();

                    Clearfiels();

                    con.Close();
                    loadDatagrid();
                }

                else
                {
                    MessageBox.Show("Form INCOMPLETE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while borrowing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSearchBorrower_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearchBorrower.Text == "Borrower ID" || cbxSearchBorrower.Text == "Firstname" || cbxSearchBorrower.Text == "Lastname" || cbxSearchBorrower.Text == "Contact No")
            {
                txbSearchBorrower.Enabled = true;
                txbSearchBook.Text = "";
            }
        }

        private void cbxSearchBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearchBook.Text == "Book ID" || cbxSearchBook.Text == "Title" || cbxSearchBook.Text == "Author")
            {
                txbSearchBook.Enabled = true;
                txbSearchBook.Text = "";
            }
        }

        private void txbSearchBook_TextChanged_2(object sender, EventArgs e)
        {
            try
            {
                if (cbxSearchBook.Text == "Book ID")
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("Select * from book where bookID like'%" + txbSearchBook.Text + "%'", con);
                    com.ExecuteNonQuery();
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable tab = new DataTable();
                    adap.Fill(tab);
                    gridBooks.DataSource = tab;
                    con.Close();
                }
                else if (cbxSearchBook.Text == "Title")
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("Select * from book where title like'%" + txbSearchBook.Text + "%'", con);
                    com.ExecuteNonQuery();
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable tab = new DataTable();
                    adap.Fill(tab);
                    gridBooks.DataSource = tab;
                    con.Close();
                }
                else if (cbxSearchBook.Text == "Author")
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("Select * from book where author like'%" + txbSearchBook.Text + "%'", con);
                    com.ExecuteNonQuery();
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable tab = new DataTable();
                    adap.Fill(tab);
                    gridBooks.DataSource = tab;

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for a book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txbSearchBorrower_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbxSearchBorrower.Text == "Borrower ID")
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("Select * from borrower where borrowerID like'%" + txbSearchBorrower.Text + "%'", con);
                    com.ExecuteNonQuery();
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable tab = new DataTable();
                    adap.Fill(tab);
                    gridBorrower.DataSource = tab;
                    con.Close();
                }
                else if (cbxSearchBorrower.Text == "Firstname")
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("Select * from borrower where Firstname like'%" + txbSearchBorrower.Text + "%'", con);
                    com.ExecuteNonQuery();
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable tab = new DataTable();
                    adap.Fill(tab);
                    gridBorrower.DataSource = tab;
                    con.Close();
                }
                else if (cbxSearchBorrower.Text == "Lastname")
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("Select * from borrower where Lastname like'%" + txbSearchBorrower.Text + "%'", con);
                    com.ExecuteNonQuery();
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable tab = new DataTable();
                    adap.Fill(tab);
                    gridBorrower.DataSource = tab;

                    con.Close();
                }

                else if (cbxSearchBorrower.Text == "Contact No")
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("Select * from borrower where ContactNo like'%" + txbSearchBorrower.Text + "%'", con);
                    com.ExecuteNonQuery();
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable tab = new DataTable();
                    adap.Fill(tab);
                    gridBorrower.DataSource = tab;

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for a borrower: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clearfiels()
        {
            txbBorrowerID.Text = "";
            txbFirstname.Text = "";
            txbLastname.Text = "";
            txbContact.Text = "";

            txbBookID.Text = "";
            txbAuthor.Text = "";
            txbStatus.Text = "";
            txbTitle.Text = "";
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txbBorrowerID.Text) || !string.IsNullOrEmpty(txbBookID.Text))
                {
                    gridBorrowedbooks.Enabled = false;
                    gridBooks.Enabled = false;
                    btnBorrow.Enabled = true;
                    btnReturn.Enabled = false;

                    Clearfiels();

                    loadDatagrid();
                    MessageBox.Show("Fields Cleared Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nothing to Clear in the Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while clearing the fields: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool btnBorrowCondition()
        {
            if (!string.IsNullOrEmpty(txbBorrowerID.Text) && !string.IsNullOrEmpty(txbBookID.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                gridBooks.Enabled = false;
                if (!string.IsNullOrEmpty(txbBorrowerID.Text) && !string.IsNullOrEmpty(txbBookID.Text))
                {
                    con.Open();

                    OleDbCommand com = new OleDbCommand("Select * from Borrowedbook order by BookID asc", con);
                    com.ExecuteNonQuery();
                    OleDbDataReader reader = com.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        com = new OleDbCommand("DELETE FROM Borrowedbook WHERE BookID = '" + txbBookID.Text + "'", con);
                        com.ExecuteNonQuery();
                        com = new OleDbCommand("UPDATE Book SET status = 'Available' WHERE bookid = " + txbBookID.Text + "", con);
                        com.ExecuteNonQuery();

                        Clearfiels();
                        MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBorrow.Enabled = false;
                        btnReturn.Enabled = false;

                        con.Close();
                        loadDatagrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while returning a book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridBorrowedbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}
