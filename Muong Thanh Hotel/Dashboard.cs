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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_AddRoom1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            closeAll();
            uC_QuanLiKhachHang1.Visible = true;
            uC_QuanLiKhachHang1.BringToFront();

        }

        private void PanelMoving_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_CustomerRes1_Load(object sender, EventArgs e)
        {

        }

        private void uC_CustomerRes1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            closeAll();
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_AddNewRoom1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            closeAll();
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }
        private void closeAll()
        {
            uC_Room1.Visible = false;
            uC_QuanLiKhachHang1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_CheckOut1.Visible = false;

            
        }

        private void uC_CheckOut1_Load(object sender, EventArgs e)
        {

        }

        private void uC_AddRoom1_Load_2(object sender, EventArgs e)
        {

        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            closeAll();
            uC_Room1.Visible = true;
            uC_Room1.BringToFront();

        }

        private void uC_QuanLiKhachHang1_Load(object sender, EventArgs e)
        {

        }
    }
}
