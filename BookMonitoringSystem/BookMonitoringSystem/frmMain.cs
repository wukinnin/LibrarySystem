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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers b = new frmUsers();
            b.ShowDialog();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooks b = new frmBooks();
            b.ShowDialog();
        }

        private void borrowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrower b = new frmBorrower();
            b.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void masterFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void borrowOrReturnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowOrReturn b = new frmBorrowOrReturn();
            b.ShowDialog();
        }
    }
}
