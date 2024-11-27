using OfficeOpenXml;
using Rebus.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
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
                    using (var package = new ExcelPackage())
                    {
                        var worksheet1 = package.Workbook.Worksheets.Add("Báo cáo Doanh thu");
                        worksheet1.Cells[1, 1].Value = "Mã giao dịch";
                        worksheet1.Cells[1, 2].Value = "Tiền phòng";
                        worksheet1.Cells[1, 3].Value = "Tiền dịch vụ";
                        worksheet1.Cells[1, 4].Value = "Ngày nhận";
                        int row = 2;
                        foreach (var item in doanhThuThang)
                        {
                            worksheet1.Cells[row, 1].Value = item.maGiaoDich;
                            worksheet1.Cells[row, 2].Value = item.tienPhong;
                            worksheet1.Cells[row, 3].Value = item.tienDichVu;
                            worksheet1.Cells[row, 4].Value = item.ngayNhan.ToString("dd/MM/yyyy");
                            row++;
                        }

                        var worksheet2 = package.Workbook.Worksheets.Add("Báo cáo Lương");
                        worksheet2.Cells[1, 1].Value = "Họ và tên";
                        worksheet2.Cells[1, 2].Value = "CCCC";
                        worksheet2.Cells[1, 3].Value = "Lương";
                        worksheet2.Cells[1, 4].Value = "Ngày nhận lương";
                        row = 2;
                        foreach (var item in luongNhanVien)
                        {
                            worksheet2.Cells[row, 1].Value = item.TenNhanVien;
                            worksheet2.Cells[row, 2].Value = item.CCCD;
                            worksheet2.Cells[row, 3].Value = item.Luong;
                            worksheet2.Cells[row, 4].Value = item.NgayNhanLuong.ToString("dd/MM/yyyy");
                            row++;
                        }

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Lưu báo cáo";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            package.SaveAs(fileInfo);
                            MessageBox.Show("Báo cáo đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
