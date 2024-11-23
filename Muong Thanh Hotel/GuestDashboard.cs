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
    public partial class GuestDashboard : Form
    {
        public GuestDashboard()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            
        }
        

        

        

        private void GuestDashboard_Load(object sender, EventArgs e)
        {

        }

        private void uc_ThemPhongMoiChoKhach1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           

        }

        private void uc_Roomforguest2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {

                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button7.Text = "Đã đặt phòng";
                guna2Button7.ForeColor = Color.Red;
                guna2Button7.Enabled = false;

            }
        }

        

        private void uc_ThemThongTin2_Load(object sender, EventArgs e)
        {
            uc_ThemThongTin2.Visible=false;

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {

                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button1.Text = "Đã đặt phòng";
                guna2Button1.ForeColor = Color.Red;
                guna2Button1.Enabled = false;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {

                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button4.Text = "Đã đặt phòng";
                guna2Button4.ForeColor = Color.Red;
                guna2Button4.Enabled = false;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {

                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button5.Text = "Đã đặt phòng";
                guna2Button5.ForeColor = Color.Red;
                guna2Button5.Enabled = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button3.Text = "Đã đặt phòng";
                guna2Button3.ForeColor = Color.Red;
                guna2Button3.Enabled = false;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {

                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button6.Text = "Đã đặt phòng";
                guna2Button6.ForeColor = Color.Red;
                guna2Button6.Enabled = false;
            }
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button17.Text = "Đã đặt phòng";
                guna2Button17.ForeColor = Color.Red;
                guna2Button17.Enabled = false;
            }
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button14.Text = "Đã đặt phòng";
                guna2Button14.ForeColor = Color.Red;
                guna2Button14.Enabled = false;
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button15.Text = "Đã đặt phòng";
                guna2Button15.ForeColor = Color.Red;
                guna2Button15.Enabled = false;
            }
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button16.Text = "Đã đặt phòng";
                guna2Button16.ForeColor = Color.Red;
                guna2Button16.Enabled = false;
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button13.Text = "Đã đặt phòng";
                guna2Button13.ForeColor = Color.Red;
                guna2Button13.Enabled = false;
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button11.Text = "Đã đặt phòng";
                guna2Button11.ForeColor = Color.Red;
                guna2Button11.Enabled = false;
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button10.Text = "Đã đặt phòng";
                guna2Button10.ForeColor = Color.Red;
                guna2Button10.Enabled = false;
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button12.Text = "Đã đặt phòng";
                guna2Button12.ForeColor = Color.Red;
                guna2Button12.Enabled = false;
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button8.Text = "Đã đặt phòng";
                guna2Button8.ForeColor = Color.Red;
                guna2Button8.Enabled = false;
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                uc_ThemThongTin2.Visible = true;
                uc_ThemThongTin2.BringToFront();
                guna2Button9.Text = "Đã đặt phòng";
                guna2Button9.ForeColor = Color.Red;
                guna2Button9.Enabled = false;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
