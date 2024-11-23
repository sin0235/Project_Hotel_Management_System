using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muong_Thanh_Hotel.User_Control
{
    public partial class uc_AddNewRoom : UserControl
    {
        public uc_AddNewRoom()
        {
            InitializeComponent();
        }

        private void lblSoPhong_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_ThemPhongMoi1.BringToFront();
            uc_ThemPhongMoi1.Visible = true;
        }


        private void closeAll()
        {
            uc_ThemPhongMoi1.Visible = false;
            uc_XoaPhong1.Visible = false;
            uc_TimKiemChinhSua1.Visible = false;
        }
        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_XoaPhong1.BringToFront();
            uc_XoaPhong1.Visible = true;

        }

        private void uc_AddNewRoom_Load(object sender, EventArgs e)
        {
            closeAll();
        }

        private void btnFindAndEdit_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_TimKiemChinhSua1.BringToFront();
            uc_TimKiemChinhSua1.Visible = true;
        }
    }
}
