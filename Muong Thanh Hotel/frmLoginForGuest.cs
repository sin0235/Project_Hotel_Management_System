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
    public partial class frmLoginForGuest : Form
    {
        public frmLoginForGuest()
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
            Dichvu dv = new Dichvu();
            dv.Show();
            //Chưa hoàn chỉnh nhen, sau sẽ lấy từ data base
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            dangKiPhong newForm = new dangKiPhong();
            newForm.Show();
        }
    }
}
