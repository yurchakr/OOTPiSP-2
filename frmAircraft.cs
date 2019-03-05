using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTPiSP__2
{
    public partial class frmAircraft : Form
    {
        public frmAircraft()
        {
            InitializeComponent();
        }

        private void tbName_MouseDown(object sender, MouseEventArgs e)
        {
            tbName.SelectAll();
        }

        private void tbTailNum_MouseDown(object sender, MouseEventArgs e)
        {
            tbTailNum.SelectAll();
        }

        private void tbMaxSp_MouseDown(object sender, MouseEventArgs e)
        {
            tbMaxSp.SelectAll();
        }

        private void tbFlDist_MouseDown(object sender, MouseEventArgs e)
        {
            tbFlDist.SelectAll();
        }

        private void tbRotDiam_MouseDown(object sender, MouseEventArgs e)
        {
            tbRotDiam.SelectAll();
        }

        private void tbWingspan_MouseDown(object sender, MouseEventArgs e)
        {
            tbWingspan.SelectAll();
        }

        private void tbLoadCap_MouseDown(object sender, MouseEventArgs e)
        {
            tbLoadCap.SelectAll();
        }

        private void tbEngPwr_MouseDown(object sender, MouseEventArgs e)
        {
            tbEngPwr.SelectAll();
        }
    }
}
