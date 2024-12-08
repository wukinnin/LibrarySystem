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
    public partial class BorrowerReport : Form
    {
        public BorrowerReport()
        {
            InitializeComponent();
        }

        private void BorrowerReport_Load(object sender, EventArgs e)
        {
            CrystalReport2 c = new CrystalReport2();
            crystalReportViewer2.ReportSource = c;
        }
    }
}
