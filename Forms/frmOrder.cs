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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void tbFlDur_MouseDown(object sender, MouseEventArgs e)
        {
            tbFlDur.SelectAll();
        }

        private void tbFlDur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((Convert.ToChar("0") <= e.KeyChar) && (Convert.ToChar("9") >= e.KeyChar)) || ((char)Keys.Back == e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
