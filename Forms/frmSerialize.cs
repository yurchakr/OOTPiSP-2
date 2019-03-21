using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTPiSP__2.Forms
{
    public partial class frmProcessFile : Form
    {
        public string TypeSerialization
        {
            get
            {
                return gbSerialType.Controls.Cast<RadioButton>().Where(c => c.Checked == true).Select(c => c).First().Text;
            }
        }

        public frmProcessFile()
        {
            InitializeComponent();
        }

        private void frmSerialize_Load(object sender, EventArgs e)
        {

        }
    }
}
