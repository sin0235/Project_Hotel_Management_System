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
    public partial class ReceptionistDashBoard : Form
    {
        private int cccdNhanVien;
        public ReceptionistDashBoard(int cccdNhanVien)
        {
            InitializeComponent();
            this.cccdNhanVien = cccdNhanVien;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_DangKiTrucTiep1.Visible = true;
        }

        private void closeAll()
        {
            uc_DangKiTrucTiep1.Visible = false;
            uC_QuanLiKhachHang1.Visible = false;
            uC_CheckOut1.Visible = false;

        }

        private void ReceptionistDashBoard_Load(object sender, EventArgs e)
        {
            closeAll();
            uc_DangKiTrucTiep1.Visible=true;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            closeAll();
            uC_QuanLiKhachHang1.Visible=true;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            closeAll();
            uC_CheckOut1.Visible=true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
