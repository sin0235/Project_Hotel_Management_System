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
    public partial class UC_QuanLiKhachHang : UserControl
    {
        public UC_QuanLiKhachHang()
        {
            InitializeComponent();
        }

        private void UC_QuanLiKhachHang_Load(object sender, EventArgs e)
        {
            pnlThongTin.Visible = false;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCCCD.Text.Trim(), out int cccd))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số CCCD.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new projectDatadbmlDataContext())
                {
                    var checkInInfo = (from yc in db.danhSachYeuCaus
                                       join kh in db.danhSachKhachHangs on yc.CCCD equals kh.CCCD
                                       join p in db.danhSachPhongs on yc.soPhong equals p.soPhong
                                       where yc.CCCD == cccd && yc.trangThaiXuLi == "Pending"
                                       select new
                                       {
                                           kh.hoTen,
                                           kh.gioiTinh,
                                           kh.sdt,
                                           kh.diaChi,
                                           p.soPhong,
                                           p.loaiPhong,
                                           p.loaiGiuong,
                                           p.soTang,
                                           p.gia
                                       }).FirstOrDefault();

                    if (checkInInfo != null)
                    {
                       
                        txtTen.Text = checkInInfo.hoTen;
                        txtGioiTinh.Text = checkInInfo.gioiTinh;
                        txtSDT.Text = checkInInfo.sdt;
                        txtDiaChi.Text = checkInInfo.diaChi;
                        txtSoPhong.Text = checkInInfo.soPhong.ToString();
                        txtLoaiPHong.Text = checkInInfo.loaiPhong;
                        txtLoaiGiuong.Text = checkInInfo.loaiGiuong;
                        txtSoTang.Text = checkInInfo.soTang.ToString();
                        txtGia.Text = checkInInfo.gia.ToString();
                        
                        MessageBox.Show("Thông tin khách hàng đã sẵn sàng. Vui lòng xác nhận Check-In!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlThongTin.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin hoặc yêu cầu chưa được phê duyệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCCCD.Text.Trim(), out int cccd))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số CCCD.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new projectDatadbmlDataContext())
                {
                    var yeuCau = db.danhSachYeuCaus
                                   .FirstOrDefault(yc => yc.CCCD == cccd && yc.trangThaiXuLi == "Pending");

                    if (yeuCau != null)
                    {

                        int soPhong = (int)yeuCau.soPhong;

                        var phong = db.danhSachPhongs.FirstOrDefault(p => p.soPhong == soPhong);
                        var kh = db.danhSachKhachHangs.FirstOrDefault(k => k.CCCD == cccd);

                        if (phong != null)
                        {
                            yeuCau.trangThaiXuLi = "Processed";

                            phong.isAvailable = "Not Available";
                            kh.ngayThue = DateTime.Now;

                            db.SubmitChanges();

                            MessageBox.Show($"Khách hàng đã nhận phòng thành công! Số phòng: {soPhong}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin phòng tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy yêu cầu với CCCD này hoặc trạng thái không phải Pending.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
