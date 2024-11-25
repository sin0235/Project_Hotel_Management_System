using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muong_Thanh_Hotel.User_Control
{
    public partial class uc_QuanLiNhanVien : UserControl
    {
        public uc_QuanLiNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_ThemNhanVien1.BringToFront();
            uc_ThemNhanVien1.Visible = true;
            napDuLieu();
        }
        public void uc_SearchEdit1_SuaNhanVien(object sender, EventArgs e)
        {
            napDuLieu();
        }

        private void closeAll()
        {
            uc_ThemNhanVien1.Visible = false;
            uc_XoaNhanVien1.Visible = false;
            uc_SearchEdit1.Visible = false;
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_XoaNhanVien1.BringToFront();
            uc_XoaNhanVien1.Visible = true;
            napDuLieu();
        }

        private void uc_XoaNhanVien1_Load(object sender, EventArgs e)
        {

        }

        private void btnFindAndEdit_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_SearchEdit1.BringToFront();
            uc_SearchEdit1.Visible = true;
            napDuLieu();
        }
        private void napDuLieu()
        {
            try
            {
                using (var db = new projectDatadbmlDataContext())
                {
                    dataTableOfEmployee.DataSource = db.danhSachNhanViens.Select
                        (e => new
                        {
                            e.hoTen,
                            e.gioiTinh,
                            e.CCCD,
                            e.sdt,
                            e.diaChi,
                            e.ngaySInh,
                            e.quocTich,
                            e.hireDate
                        }).ToList();
                    dataTableOfEmployee.Refresh();

                }
        }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void uc_QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            closeAll();
            uc_ThemNhanVien1.Visible = true;
            napDuLieu();

        }

        private void uc_ThemNhanVien1_themNhanVien(object sender, EventArgs e)
        {
            napDuLieu();
        }

        private void DisplayRoomInDataGridView(danhSachNhanVien nv)
        {
            var nvList = new List<danhSachNhanVien> { nv };
            dataTableOfEmployee.DataSource = null;
            dataTableOfEmployee.DataSource = nvList;
            dataTableOfEmployee.Refresh();
        }

        private void uc_XoaNhanVien1_TimDanhSachNhanVien(object sender, danhSachNhanVien nv)
        {
            if(nv != null)
            {
                DisplayRoomInDataGridView(nv);
            }
        }

        public void uc_XoaNhanVien1_XoaNhanVien(object sender, EventArgs e)
        {
            napDuLieu();
        }
    }
}
