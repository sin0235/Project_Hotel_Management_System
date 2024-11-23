using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muong_Thanh_Hotel
{
    public partial class frmLoginForRecepytionist : Form
    {
        public frmLoginForRecepytionist()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "toan" && txtPassword.Text == "123456")
            {
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();

            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
