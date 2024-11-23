using Muong_Thanh_Hotel.User_Control;
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
    public partial class ManagerDashboard : Form
    {

        public ManagerDashboard()
        {
            
            InitializeComponent();

        }


        private void btnQuanLiPhong_Click_1(object sender, EventArgs e)
        {
            closeAll();
            uc_AddNewRoom1.Visible = true;
            uc_AddNewRoom1.BringToFront();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
        }

        private void closeAll()
        {
            uc_AddNewRoom1.Visible=false;
            uc_QuanLiNhanVien1.Visible=false;
            uc_QuanLyDatPhong1.Visible = false;
            uc_BaoCao1.Visible=false;
        }


        private void uc_QuanLiNhanVien1_Load(object sender, EventArgs e)
        {
        }

        private void btnQuanLiKhachHang_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_QuanLyDatPhong1.BringToFront();
            uc_QuanLyDatPhong1.Visible=true;
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_BaoCao1.BringToFront();
            uc_BaoCao1.Visible=true;
        }

        private void btnQuanLiNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLiNhanVien_Click_1(object sender, EventArgs e)
        {
            closeAll();
            uc_QuanLiNhanVien1.BringToFront();
            uc_QuanLiNhanVien1.Visible = true;
        }
    }
}
