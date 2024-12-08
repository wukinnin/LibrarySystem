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
    public partial class BookReport : Form
    {
        public BookReport()
        {
            InitializeComponent();
        }

        private void BookReport_Load(object sender, EventArgs e)
        {
            CrystalReport1 c = new CrystalReport1();
            crystalReportViewer1.ReportSource = c;
        }
    }
}
