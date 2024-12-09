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


namespace BookMonitoringSystem
{
    public partial class frmBorrower : Form
    {
        OleDbConnection con;
        public frmBorrower()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\3rd year 1st sem\\BMS-20240507T055843Z-001\\BMS - Copy\\Book Monitoring System.mdb");
        }

        private void loadDatagrid()
        {
            con.Open();

            OleDbCommand com = new OleDbCommand("Select * from Borrower", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView11.DataSource = tab;

            con.Close();
        }

        private void Borrower_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txbBorrowerID.Text = dataGridView11.Rows[e.RowIndex].Cells["BorrowerID"].Value.ToString();
            txbFirstname.Text = dataGridView11.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
            txbLastname.Text = dataGridView11.Rows[e.RowIndex].Cells["Lastname"].Value.ToString();
            txbContactNo.Text = dataGridView11.Rows[e.RowIndex].Cells["ContactNo"].Value.ToString();
        }

        private void CleanTextBox()
        {
            txbBorrowerID.Text = txbFirstname.Text = txbLastname.Text = txbContactNo.Text = "";
        }

        private string GetLastBorrowerIDValue(DataGridView dataGridView)
        {
            int columnIndex = dataGridView.Columns["BorrowerID"].Index;

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

        private void btnAdd1_Click_1(object sender, EventArgs e)
        {
            btnAdd1.Enabled = false;
            CleanTextBox();

            con.Open();

            OleDbCommand com = new OleDbCommand("Select * from Borrower order by BorrowerID asc", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);

            string lastBorrowerID = GetLastBorrowerIDValue(dataGridView11);
            int lastCount = int.Parse(lastBorrowerID);
            txbBorrowerID.Text = (lastCount + 1).ToString();

            txbFirstname.Enabled = true;
            txbLastname.Enabled = true;
            txbContactNo.Enabled = true;

            btnSave1.Enabled = true;
            btnUpdate1.Enabled = false;
            btnEdit1.Enabled = false;
            btnDelete1.Enabled = false;
            dataGridView11.Enabled = false;

            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbFirstname.Text) && !string.IsNullOrEmpty(txbLastname.Text) && !string.IsNullOrEmpty(txbContactNo.Text))
            {
                dataGridView11.Enabled = true;
                btnAdd1.Enabled = false;
                btnSave1.Enabled = false;
                con.Open();

                OleDbCommand com = new OleDbCommand("Insert into Borrower values ('" +
                    txbBorrowerID.Text + "', '" + txbFirstname.Text + "', '"+ txbLastname.Text + "', '" + txbContactNo.Text + "')", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Borrower is saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                loadDatagrid();

                CleanTextBox();
                txbFirstname.Enabled = false;
                txbLastname.Enabled = false;
                txbContactNo.Enabled = false;
                btnAdd1.Enabled = true;
                btnSave1.Enabled = false;
                btnAdd1.Enabled = true;
                btnUpdate1.Enabled = true;
                btnEdit1.Enabled = true;
                btnDelete1.Enabled = true;
            }

            else
            {
                MessageBox.Show("Form is incomplete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbFirstname.Text) && !string.IsNullOrEmpty(txbLastname.Text) && !string.IsNullOrEmpty(txbContactNo.Text))
            {
                btnUpdate1.Enabled = true;
                btnEdit1.Enabled = false;
                txbFirstname.Enabled = true;
                txbLastname.Enabled = true;
                txbContactNo.Enabled = true;
            }
            else
            {
                btnUpdate1.Enabled = true;
                txbFirstname.Enabled = false;
                txbLastname.Enabled = false;
                txbContactNo.Enabled = false;
                MessageBox.Show("No valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbFirstname.Text) && !string.IsNullOrEmpty(txbLastname.Text) && !string.IsNullOrEmpty(txbContactNo.Text))
            {
                con.Open();
                int no = int.Parse(txbBorrowerID.Text);

                OleDbCommand com = new OleDbCommand("Update Borrower SET Firstname= '" + txbFirstname.Text + "', Lastname='" + txbLastname.Text+ "', ContactNo='" + txbContactNo.Text + "' where BorrowerID= " + no + "", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Borrowers are updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                loadDatagrid();

                btnEdit1.Enabled = true;
                txbFirstname.Enabled = false;
                txbLastname.Enabled = false;
                txbContactNo.Enabled = false;
                btnUpdate1.Enabled = false;
                CleanTextBox();
            }
            else
            {
                MessageBox.Show("No valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbFirstname.Text) && !string.IsNullOrEmpty(txbLastname.Text) && !string.IsNullOrEmpty(txbContactNo.Text))
            {
                con.Open();
                int num = (int.Parse(txbBorrowerID.Text));

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this borrower?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand com = new OleDbCommand("Delete from Borrower where BorrowerID= " + num + "", con);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Borrower Deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Action Cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
            loadDatagrid();

            CleanTextBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbBorrowerID.Text) || !string.IsNullOrEmpty(txbFirstname.Text) || !string.IsNullOrEmpty(txbLastname.Text) || !string.IsNullOrEmpty(txbContactNo.Text))
            {
                dataGridView11.Enabled = true;
                btnSave1.Enabled = false;
                btnAdd1.Enabled = true;
                btnUpdate1.Enabled = true;
                btnEdit1.Enabled = true;
                btnDelete1.Enabled = true;
                CleanTextBox();
                txbFirstname.Enabled = false;
                txbLastname.Enabled = false;
                txbContactNo.Enabled = false;
                MessageBox.Show("Fields are cleared.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnSave1.Enabled = false;
                btnAdd1.Enabled = true;
                btnEdit1.Enabled = true;
                btnDelete1.Enabled = true;
                MessageBox.Show("Nothing to clear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearch1.Text == "Borrower ID" || cbxSearch1.Text == "Firstname" || cbxSearch1.Text == "Lastname" || cbxSearch1.Text == "Contact No.")
            {
                txbSearchBox1.Enabled = true;
                txbSearchBox1.Text = "";
            }
        }

        private void txbSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (cbxSearch1.Text == "Borrower ID")
            {
                con.Open();

                OleDbCommand com = new OleDbCommand("Select * from Borrower where BorrowerID like'%" + txbSearchBox1.Text + "%'", con);
                com.ExecuteNonQuery();

                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                dataGridView11.DataSource = tab;

                con.Close();
            }
            else if (cbxSearch1.Text == "Firstname")
            {
                con.Open();

                OleDbCommand com = new OleDbCommand("Select * from Borrower where Firstname like'%" + txbSearchBox1.Text + "%'", con);
                com.ExecuteNonQuery();

                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                dataGridView11.DataSource = tab;

                con.Close();
            }
            else if (cbxSearch1.Text == "Lastname")
            {
                con.Open();

                OleDbCommand com = new OleDbCommand("Select * from Borrower where Lastname like'%" + txbSearchBox1.Text + "%'", con);
                com.ExecuteNonQuery();

                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                dataGridView11.DataSource = tab;

                con.Close();
            }

            else if (cbxSearch1.Text == "Contact No.")
            {
                con.Open();

                OleDbCommand com = new OleDbCommand("Select * from Borrower where ContactNo like'%" + txbSearchBox1.Text + "%'", con);
                com.ExecuteNonQuery();

                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                dataGridView11.DataSource = tab;

                con.Close();
            }
        }

        private void txbBorrowerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbContNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbFirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
