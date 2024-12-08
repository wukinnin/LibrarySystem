using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMonitoringSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textboxUsername.Text) || !string.IsNullOrEmpty(textboxPassword.Text))
            {
                if (textboxUsername.Text == "Nimu" && textboxPassword.Text == "password")
                {                 
                    frmMain n = new frmMain();
                    n.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Form INCOMPLETE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textboxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
