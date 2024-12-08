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
    public partial class UsersReport2 : Form
    {
        public UsersReport2()
        {
            InitializeComponent();
        }

        private void UsersReport2_Load(object sender, EventArgs e)
        {
            CrystalReport3 c = new CrystalReport3();
            crystalReportViewer3.ReportSource = c;
        }
    }
}
