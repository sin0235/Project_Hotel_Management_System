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
    public partial class uc_QuanLyDatPhong : UserControl
    {
        public uc_QuanLyDatPhong()
        {
            InitializeComponent();
        }

        private void btnRevation_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new projectDatadbmlDataContext())
                {
                    var danhSachYeuCau = db.danhSachYeuCaus
                                            .Where(y => y.trangThaiXuLi == "Pending")
                                            .Join(db.danhSachKhachHangs,
                                                  yc => yc.CCCD,
                                                  kh => kh.CCCD,
                                                  (yc, kh) => new { yc, kh })
                                            .Join(db.danhSachPhongs,
                                                  ycKh => ycKh.yc.soPhong,
                                                  p => p.soPhong,
                                                  (ycKh, p) => new
                                                  {
                                                      ycKh.kh.hoTen,
                                                      ycKh.kh.CCCD,
                                                      ycKh.kh.sdt,
                                                      ycKh.yc.soPhong,
                                                      p.loaiPhong,
                                                      p.soTang,
                                                      p.loaiGiuong
                                                  })
                                            .ToList();


                    dataTable.DataSource = danhSachYeuCau;
                    dataTable.Columns["hoTen"].HeaderText = "Tên khách hàng";
                    dataTable.Columns["CCCD"].HeaderText = "Căn cước công dân";
                    dataTable.Columns["sdt"].HeaderText = "Số điện thoại";
                    dataTable.Columns["soPhong"].HeaderText = "Số phòng";
                    dataTable.Columns["loaiPhong"].HeaderText = "Loại phòng";
                    dataTable.Columns["loaiGiuong"].HeaderText = "Loại giường";
                    dataTable.Columns["soTang"].HeaderText = "Số tầng";
                    dataTable.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new projectDatadbmlDataContext())
            {
                var dsKhachHang = db.danhSachYeuCaus.Where(y => y.trangThaiXuLi == "Processed")
                    .Join(db.danhSachKhachHangs,
                    yc => yc.CCCD,
                    kh => kh.CCCD,
                    (yc, kh) => new { yc, kh })
                    .Join(db.danhSachPhongs,
                    ycKh => ycKh.yc.soPhong,
                    p => p.soPhong,
                    (ycKh, p) => new
                    {
                        ycKh.kh.hoTen,
                        ycKh.kh.CCCD,
                        ycKh.yc.soPhong,
                        ycKh.kh.ngayThue

                    }).ToList();


                dataTable.DataSource = null;
                dataTable.DataSource = dsKhachHang;
                dataTable.Columns["hoTen"].HeaderText = "Họ và tên";
                dataTable.Columns["CCCD"].HeaderText = "Số CCCD";
                dataTable.Columns["soPhong"].HeaderText = "Số phòng";
                dataTable.Columns["ngayThue"].HeaderText = "Ngày check-in";

                dataTable.Refresh();

            }
        }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi load dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
