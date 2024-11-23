using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Muong_Thanh_Hotel.User_Control;

namespace Muong_Thanh_Hotel
{
    public partial class frmLoginForManager : Form
    {
        public frmLoginForManager()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text == "kha" && txtPassword.Text == "123456")
            {
                labelError.Visible = false;
                ManagerDashboard ds= new ManagerDashboard();
                this.Hide();
                ds.Show();

            }
            
            
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
