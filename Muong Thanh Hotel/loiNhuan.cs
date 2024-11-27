using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muong_Thanh_Hotel
{
    public partial class loiNhuan : Form
    {
        public loiNhuan()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
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

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {

                int nam = int.Parse(cmbNam.SelectedItem.ToString());

                using (var db = new projectDatadbmlDataContext())
                {
                    var doanhThuTheoNam = db.doanhThus
                                             .Where(d => d.ngayNhan.Year == nam)
                                             .GroupBy(d => d.ngayNhan.Month)
                                             .Select(g => new
                                             {
                                                 Thang = g.Key,
                                                 TongDoanhThu = g.Sum(d => d.tienPhong + d.tienDichVu)
                                             }).ToList();

                    var luongTheoNam = db.luongs
                                         .Where(l => l.ngayNhan.Year == nam)
                                         .GroupBy(l => l.ngayNhan.Month)
                                         .Select(g => new
                                         {
                                             Thang = g.Key,
                                             TongLuong = g.Sum(l => l.luong1)
                                         }).ToList();

                    var loiNhuanTheoNam = (from dt in doanhThuTheoNam
                                           join lg in luongTheoNam on dt.Thang equals lg.Thang into temp
                                           from lg in temp.DefaultIfEmpty()
                                           select new
                                           {
                                               Thang = dt.Thang,
                                               TongDoanhThu = dt.TongDoanhThu,
                                               TongLuong = lg != null ? lg.TongLuong : 0,
                                               TongLoiNhuan = dt.TongDoanhThu - (lg != null ? lg.TongLuong : 0)
                                           }).ToList();

                    dataTable.DataSource = loiNhuanTheoNam;
                    dataTable.Columns["Thang"].HeaderText = "Tháng";
                    dataTable.Columns["TongDoanhThu"].HeaderText = "Tổng doanh thu";
                    dataTable.Columns["TongLuong"].HeaderText = "Tổng lương nhân viên";
                    dataTable.Columns["TongLoiNhuan"].HeaderText = "Tổng lợi nhuận";
                    dataTable.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            try
            {

                int nam = int.Parse(cmbNam.SelectedItem.ToString());

                using (var db = new projectDatadbmlDataContext())
                {
                    var doanhThuTheoNam = db.doanhThus
                                             .Where(d => d.ngayNhan.Year == nam)
                                             .GroupBy(d => d.ngayNhan.Month)
                                             .Select(g => new
                                             {
                                                 Thang = g.Key,
                                                 TongDoanhThu = g.Sum(d => d.tienPhong + d.tienDichVu)
                                             }).ToList();

                    var luongTheoNam = db.luongs
                                         .Where(l => l.ngayNhan.Year == nam)
                                         .GroupBy(l => l.ngayNhan.Month)
                                         .Select(g => new
                                         {
                                             Thang = g.Key,
                                             TongLuong = g.Sum(l => l.luong1)
                                         }).ToList();

                    var loiNhuanTheoNam = (from dt in doanhThuTheoNam
                                           join lg in luongTheoNam on dt.Thang equals lg.Thang into temp
                                           from lg in temp.DefaultIfEmpty()
                                           select new
                                           {
                                               Thang = dt.Thang,
                                               TongDoanhThu = dt.TongDoanhThu,
                                               TongLuong = lg != null ? lg.TongLuong : 0,
                                               TongLoiNhuan = dt.TongDoanhThu - (lg != null ? lg.TongLuong : 0)
                                           }).ToList();

                    using(var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add($"Báo cáo lợi nhuận năm {nam}");
                        worksheet.Cells[1, 1].Value = "Tháng";
                        worksheet.Cells[1, 2].Value = "Tổng doanh thu";
                        worksheet.Cells[1, 3].Value = "Tổng lương";
                        worksheet.Cells[1, 4].Value = "Tổng lợi nhuận";
                        int row = 2;
                        foreach(var item in loiNhuanTheoNam)
                        {
                            worksheet.Cells[row, 1].Value = item.Thang;
                            worksheet.Cells[row, 2].Value = item.TongDoanhThu;
                            worksheet.Cells[row, 3].Value = item.TongLuong;
                            worksheet.Cells[row, 4].Value = item.TongDoanhThu;
                            row++;
                        }    
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Lưu báo cáo";
                        if(saveFileDialog.ShowDialog() == DialogResult.OK)
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
