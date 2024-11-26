using Rebus.Messages;
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
    public partial class uc_BaoCao : UserControl
    {
        public uc_BaoCao()
        {
            InitializeComponent();
        }

        private void uc_BaoCao_Load(object sender, EventArgs e)
        {
            FillYearComboBox();
        }

        private void FillYearComboBox()
        {
            cmbNam.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 5; i <= currentYear; i++)
            {
                cmbNam.Items.Add(i.ToString());
            }
            cmbNam.SelectedIndex = cmbNam.Items.Count - 1;
        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLocPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNam.SelectedIndex == 0) throw new Exception("Vui lòng chọn tháng");
                int thang = int.Parse(cmbThang.SelectedItem.ToString());
                ; int nam = int.Parse(cmbNam.SelectedItem.ToString());

                using (var db = new projectDatadbmlDataContext())
                {
                    var doanhThuThang = (from d in db.doanhThus
                                         join nv in db.danhSachNhanViens on d.cccd equals nv.CCCD
                                         where d.ngayNhan.Month == thang && d.ngayNhan.Year == nam
                                         select new
                                         {
                                             maGiaoDich = d.maGiaoDich,
                                             tenNhanVien = nv.hoTen, 
                                             tienPhong = d.tienPhong,
                                             tienDichVu = d.tienDichVu,
                                             ngayNhan = d.ngayNhan
                                         }).ToList();

                    dataTableOfProfit.DataSource = doanhThuThang;
                    dataTableOfProfit.Columns["maGiaoDich"].HeaderText = "Mã giao dịch";
                    dataTableOfProfit.Columns["tienPhong"].HeaderText = "Tiền phòng";
                    dataTableOfProfit.Columns["tienDichVu"].HeaderText = "Tiền dịch vụ";
                    dataTableOfProfit.Columns["ngayNhan"].HeaderText = "Ngày nhận";
                    dataTableOfProfit.Columns["tenNhanVien"].HeaderText = "Thu ngân";
                    dataTableOfProfit.Refresh();


                    var luongNhanVien = (from luong in db.luongs
                                         join nv in db.danhSachNhanViens on luong.CCCD equals nv.CCCD
                                         where luong.ngayNhan.Month == thang && luong.ngayNhan.Year == nam
                                         select new
                                         {
                                             TenNhanVien = nv.hoTen,
                                             CCCD = nv.CCCD,
                                             Luong = luong.luong1,
                                             NgayNhanLuong = luong.ngayNhan
                                         }).ToList();

                    dataTableOfSalary.DataSource = luongNhanVien;
                    dataTableOfSalary.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                    dataTableOfSalary.Columns["CCCD"].HeaderText = "CCCD";
                    dataTableOfSalary.Columns["Luong"].HeaderText = "Lương";
                    dataTableOfSalary.Columns["NgayNhanLuong"].HeaderText = "Ngày nhận lương";
                    dataTableOfSalary.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaoCaoLoiNhuan_Click(object sender, EventArgs e)
        {
            loiNhuan newForm = new loiNhuan();
            newForm.Show();
        }
    }
}
