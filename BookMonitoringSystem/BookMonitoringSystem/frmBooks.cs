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
    public partial class frmBooks : Form
    {
        OleDbConnection con;
        public frmBooks()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\etc\\2nd year 2nd sem\\BMS-20240507T055843Z-001\\BMS - Copy\\Book Monitoring System.mdb");
        }

        private void loadDatagrid()
        {
            con.Open();

            OleDbCommand com = new OleDbCommand("Select * from Book", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView2.DataSource = tab;

            con.Close();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbBookID.Text = dataGridView2.Rows[e.RowIndex].Cells["bookID"].Value.ToString();
            txbTitle.Text = dataGridView2.Rows[e.RowIndex].Cells["title"].Value.ToString();
            txbAuthor.Text = dataGridView2.Rows[e.RowIndex].Cells["author"].Value.ToString();
        }

        private void CleanTextBox()
        {
            txbBookID.Text = txbTitle.Text = txbAuthor.Text = "";
        }

        private string GetLastBookIDValue(DataGridView dataGridView)
        {
            int columnIndex = dataGridView.Columns["bookID"].Index;

            for (int rowIndex = dataGridView.Rows.Count - 1; rowIndex >= 0; rowIndex--)
            {
                DataGridViewRow row = dataGridView.Rows[rowIndex];
                DataGridViewCell cell = row.Cells[columnIndex];

                if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    return cell.Value.ToString();
                }
            }

            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            txbTitle.Text = "";
            txbAuthor.Text = "";

            con.Open();

            OleDbCommand com = new OleDbCommand("Select * from Book order by bookid asc", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);

            string lastBookID = GetLastBookIDValue(dataGridView2);
            int lastCount = int.Parse(lastBookID);
            txbBookID.Text = (lastCount + 1).ToString();

            txbTitle.Enabled = true;
            txbAuthor.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false ;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dataGridView2.Enabled = false;

            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txbTitle.Text) && !string.IsNullOrEmpty(txbAuthor.Text))
                {
                    lblErrorSave.Text = "";
                    dataGridView2.Enabled = true;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = false;
                    con.Open();

                    OleDbCommand com = new OleDbCommand("Insert into book values ('" +
                        txbBookID.Text + "', '" + txbTitle.Text + "', '" + txbAuthor.Text + "', 'Available')", con);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Successsully SAVED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                    loadDatagrid();

                    CleanTextBox();
                    txbTitle.Enabled = false;
                    txbAuthor.Enabled = false;
                    btnAdd.Enabled = true;
                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Form INCOMPLETE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving a book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbBookID.Text) && !string.IsNullOrEmpty(txbTitle.Text) && !string.IsNullOrEmpty(txbAuthor.Text))
            {
                if (!string.IsNullOrEmpty(txbTitle.Text) && !string.IsNullOrEmpty(txbAuthor.Text))
                {
                    btnUpdate.Enabled = true;
                    btnEdit.Enabled = false;
                    txbTitle.Enabled = true;
                    txbAuthor.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = true;
                    txbTitle.Enabled = false;
                    txbAuthor.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No valid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txbTitle.Text) || !string.IsNullOrEmpty(txbAuthor.Text))
            {
                con.Open();
                int no = int.Parse(txbBookID.Text);

                OleDbCommand com = new OleDbCommand("Update book SET title= '" + txbTitle.Text + "', author='" + txbAuthor.Text + "' where bookID= " + no + "", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Update is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                loadDatagrid();

                btnEdit.Enabled = true;
                txbBookID.Enabled = false;
                txbTitle.Enabled = false;
                txbAuthor.Enabled = false;
                btnUpdate.Enabled = false;
                CleanTextBox();
            }
            else
            {
                MessageBox.Show("No changes made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /*else
            {
                MessageBox.Show("No valid input in the \"Book Details\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbBookID.Text) && !string.IsNullOrEmpty(txbTitle.Text) && !string.IsNullOrEmpty(txbAuthor.Text))
            {
                con.Open();
                int num = (int.Parse(txbBookID.Text));

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand com = new OleDbCommand("Delete from book where bookID= " + num + "", con);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Book successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Action cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No valid input in the \"Book Details\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
            loadDatagrid();

            CleanTextBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbBookID.Text) || !string.IsNullOrEmpty(txbTitle.Text) || !string.IsNullOrEmpty(txbAuthor.Text))
            {
                dataGridView2.Enabled = true;
                btnSave.Enabled = false;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                CleanTextBox();
                txbTitle.Enabled = false;
                txbAuthor.Enabled = false;
                MessageBox.Show("Fields are cleared", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnSave.Enabled = false;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                MessageBox.Show("Nothing to clear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearch.Text == "Book ID" || cbxSearch.Text == "Title" || cbxSearch.Text == "Author")
            {
                txbSearchBox.Enabled = true;
                txbSearchBox.Text = "";
            }
        }

        private void txbSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (cbxSearch.Text == "Book ID")
            {
                con.Open();

                OleDbCommand com = new OleDbCommand("Select * from book where bookID like'%" + txbSearchBox.Text + "%'", con);
                com.ExecuteNonQuery();

                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                dataGridView2.DataSource = tab;

                con.Close();
            }
            else if (cbxSearch.Text == "Title")
            {
                con.Open();

                OleDbCommand com = new OleDbCommand("Select * from book where title like'%" + txbSearchBox.Text + "%'", con);
                com.ExecuteNonQuery();

                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                dataGridView2.DataSource = tab;

                con.Close();
            }
            else if (cbxSearch.Text == "Author")
            {
                con.Open();

                OleDbCommand com = new OleDbCommand("Select * from book where author like'%" + txbSearchBox.Text + "%'", con);
                com.ExecuteNonQuery();

                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                dataGridView2.DataSource = tab;

                con.Close();
            }
        }

        private void txbBookID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
