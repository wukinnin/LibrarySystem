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
    public partial class frmUsers2 : Form
    {
        OleDbConnection con;
        public frmUsers2()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\etc\\2nd year 2nd sem\\BMS-20240507T055843Z-001\\BMS\\Book Monitoring System.mdb");
        }

        private void loadDatagrid()
        {
            con.Open();

            OleDbCommand com = new OleDbCommand("Select * from Users", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView11.DataSource = tab;

            con.Close();
        }

        private void frmUsers2_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbUserID.Text = dataGridView11.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
            txbFirstname.Text = dataGridView11.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
            txbLastname.Text = dataGridView11.Rows[e.RowIndex].Cells["Lastname"].Value.ToString();
            txbContNum.Text = dataGridView11.Rows[e.RowIndex].Cells["ContactNo"].Value.ToString();
        }
        private void CleanTextBox()
        {
            txbUserID.Text = txbFirstname.Text = txbLastname.Text = txbContNum.Text = "";
        }

        private string GetLastUserIDValue(DataGridView dataGridView)
        {
            int columnIndex = dataGridView.Columns["UserID"].Index;

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

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            btnAdd1.Enabled = false;
            CleanTextBox();

            con.Open();

            OleDbCommand com = new OleDbCommand("Select * from Users order by UserID asc", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);

            string lastUserID = GetLastUserIDValue(dataGridView11);
            int lastCount = int.Parse(lastUserID);
            txbUserID.Text = (lastCount + 1).ToString();

            txbFirstname.Enabled = true;
            txbLastname.Enabled = true;
            txbContNum.Enabled = true;

            btnSave1.Enabled = true;
            btnUpdate1.Enabled = false;
            btnEdit1.Enabled = false;
            btnDelete1.Enabled = false;
            dataGridView11.Enabled = false;

            con.Close();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbFirstname.Text) && !string.IsNullOrEmpty(txbLastname.Text) && !string.IsNullOrEmpty(txbContNum.Text))
            {
                dataGridView11.Enabled = true;
                btnAdd1.Enabled = false;
                btnSave1.Enabled = false;
                con.Open();

                OleDbCommand com = new OleDbCommand("Insert into Users values ('" +
                    txbUserID.Text + "', '" + txbFirstname.Text + "', '" + txbLastname.Text + "', '" + txbContNum.Text + "')", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successsully SAVED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                loadDatagrid();

                CleanTextBox();
                txbFirstname.Enabled = false;
                txbLastname.Enabled = false;
                txbContNum.Enabled = false;
                btnAdd1.Enabled = true;
                btnSave1.Enabled = false;
                btnAdd1.Enabled = true;
                btnUpdate1.Enabled = true;
                btnEdit1.Enabled = true;
                btnDelete1.Enabled = true;
            }

            else
            {
                MessageBox.Show("Form INCOMPLETE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbFirstname.Text) && !string.IsNullOrEmpty(txbLastname.Text) && !string.IsNullOrEmpty(txbContNum.Text))
            {
                btnUpdate1.Enabled = true;
                btnEdit1.Enabled = false;
                txbFirstname.Enabled = true;
                txbLastname.Enabled = true;
                txbContNum.Enabled = true;
            }
            else
            {
                btnUpdate1.Enabled = true;
                txbFirstname.Enabled = false;
                txbLastname.Enabled = false;
                txbContNum.Enabled = false;
                MessageBox.Show("No valid input in the \"Boorrower Details\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbFirstname.Text) && !string.IsNullOrEmpty(txbLastname.Text) && !string.IsNullOrEmpty(txbContNum.Text))
            {
                con.Open();
                int no = int.Parse(txbUserID.Text);

                OleDbCommand com = new OleDbCommand("Update Users SET Firstname= '" + txbFirstname.Text + "', Lastname='" + txbLastname.Text + "', ContactNo='" + txbContNum.Text + "' where UserID= " + no + "", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successsully UPDATED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                loadDatagrid();

                btnEdit1.Enabled = true;
                txbFirstname.Enabled = false;
                txbLastname.Enabled = false;
                txbContNum.Enabled = false;
                btnUpdate1.Enabled = false;
                CleanTextBox();
            }
            else
            {
                MessageBox.Show("No valid input in the \"Boorrower Details\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbFirstname.Text) && !string.IsNullOrEmpty(txbLastname.Text) && !string.IsNullOrEmpty(txbContNum.Text))
            {
                con.Open();
                int num = (int.Parse(txbUserID.Text));

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confim Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand com = new OleDbCommand("Delete from Users where UserID= " + num + "", con);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Successsully DELETED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CANCELED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No valid input in the \"Boorrower Details\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
            loadDatagrid();

            CleanTextBox();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbUserID.Text) || !string.IsNullOrEmpty(txbFirstname.Text) || !string.IsNullOrEmpty(txbLastname.Text) || !string.IsNullOrEmpty(txbContNum.Text))
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
                txbContNum.Enabled = false;
                MessageBox.Show("Successfully CLEARED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbxSearch1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearch1.Text == "Users ID" || cbxSearch1.Text == "Firstname" || cbxSearch1.Text == "Lastname" || cbxSearch1.Text == "Contact No.")
            {
                txbSearchBox1.Enabled = true;
                txbSearchBox1.Text = "";
            }
        }

        private void txbSearchBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbxSearch1.Text == "Users ID")
            {
                con.Open();

                OleDbCommand com = new OleDbCommand("Select * from Users where UserID like'%" + txbSearchBox1.Text + "%'", con);
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

                OleDbCommand com = new OleDbCommand("Select * from Users where Firstname like'%" + txbSearchBox1.Text + "%'", con);
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

                OleDbCommand com = new OleDbCommand("Select * from Users where Lastname like'%" + txbSearchBox1.Text + "%'", con);
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

                OleDbCommand com = new OleDbCommand("Select * from Users where ContactNo like'%" + txbSearchBox1.Text + "%'", con);
                com.ExecuteNonQuery();

                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                dataGridView11.DataSource = tab;

                con.Close();
            }
        }


    }
}
