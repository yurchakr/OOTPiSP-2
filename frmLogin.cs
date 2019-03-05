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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbUserName_MouseDown(object sender, MouseEventArgs e)
        {
            tbUserName.SelectAll();
        }

        private void tbPass_MouseDown(object sender, MouseEventArgs e)
        {
            tbPass.SelectAll();
        }

        private void tbName_MouseDown(object sender, MouseEventArgs e)
        {
            tbName.SelectAll();
        }

        private void tbMail_MouseDown(object sender, MouseEventArgs e)
        {
            tbMail.SelectAll();
        }

        private void bMakeAcc_Click(object sender, EventArgs e)
        {
            bLogIn.Visible = false;
            bMakeAcc.Visible = false;

            tbName.Visible = true;
            tbMail.Visible = true;
            bRegister.Visible = true;
            bBack.Visible = true;

            pLogin.Height = 360;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            bLogIn.Visible = true;
            bMakeAcc.Visible = true;

            tbName.Visible = false;
            tbMail.Visible = false;
            bRegister.Visible = false;
            bBack.Visible = false;

            pLogin.Height = 270;
        }

    }
}
