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
    public partial class UC_CheckOut : UserControl
    {

        private double tongTienDichVu;
        private double tongTienPhong;
        private int idenNum;
        public UC_CheckOut(int idenNum)
        {
            InitializeComponent();
            this.idenNum = idenNum;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCCCD.Text.Trim(), out int cccd))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số CCCD.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtSoPhong.Text.Trim(), out int soPhong))
                {
                    MessageBox.Show("Số phòng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maGiaoDich = $"{cccd}_{soPhong}";

                using (var db = new projectDatadbmlDataContext())
                {

                    var giaoDichTonTai = db.doanhThus.FirstOrDefault(d => d.maGiaoDich == maGiaoDich);
                    if (giaoDichTonTai != null)
                    {
                        MessageBox.Show("Giao dịch đã tồn tại trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var doanhThuMoi = new doanhThu
                    {
                        maGiaoDich = maGiaoDich,
                        tienDichVu = tongTienDichVu,
                        tienPhong = tongTienPhong,
                        ngayNhan = DateTime.Now,
                        cccd = idenNum
                    };

                    db.doanhThus.InsertOnSubmit(doanhThuMoi);

                    var phong = db.danhSachPhongs.FirstOrDefault(p => p.soPhong == soPhong);
                    if (phong != null)
                    {
                        phong.isAvailable = "Available";
                    }

                    var yeuCau = db.danhSachYeuCaus.FirstOrDefault(yc => yc.CCCD == cccd);
                    if (yeuCau != null)
                    {
                        db.danhSachYeuCaus.DeleteOnSubmit(yeuCau);
                    }
                    var dichVuKhachHang = db.danhSachQuanLiDichVus.Where(dv => dv.CCCD == cccd).ToList();
                    if (dichVuKhachHang.Any())
                    {
                        db.danhSachQuanLiDichVus.DeleteAllOnSubmit(dichVuKhachHang);
                    }
                    var khachHang = db.danhSachKhachHangs.FirstOrDefault(kh => kh.CCCD == cccd);
                    if (khachHang != null)
                    {
                        db.danhSachKhachHangs.DeleteOnSubmit(khachHang);
                    }

                    db.SubmitChanges();

                    MessageBox.Show("Thanh toán thành công. Dữ liệu đã được lưu vào bảng doanh thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UC_CheckOut_Load(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnKiemTraHoaDon_Click(object sender, EventArgs e)
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

                    var khachHang = db.danhSachKhachHangs.FirstOrDefault(kh => kh.CCCD == cccd);

                    var yeuCau = db.danhSachYeuCaus.FirstOrDefault(yc => yc.CCCD == cccd && yc.trangThaiXuLi == "Processed");

                    if (khachHang != null && yeuCau != null)
                    {

                        var phong = db.danhSachPhongs.FirstOrDefault(p => p.soPhong == yeuCau.soPhong);

                        if (phong != null)
                        {
                            txtTen.Text = khachHang.hoTen;
                            txtSDT.Text = khachHang.sdt;
                            txtDiaChi.Text = khachHang.diaChi;
                            txtGioiTinh.Text = khachHang.gioiTinh;
                            txttCCCD.Text = khachHang.CCCD.ToString();

                            txtSoPhong.Text = phong.soPhong.ToString();
                            txtLoaiPHong.Text = phong.loaiPhong;
                            txtLoaiGiuong.Text = phong.loaiGiuong;

                            txtNgayNhan.Text = khachHang.ngayThue?.ToString("dd/MM/yyyy");
                            txtNgayTra.Text = DateTime.Now.ToString("dd/MM/yyyy");

                            pnlThongTin.Visible = true;
                            pnlHoaDon.Visible = true;
                            dataTable.Visible = true;
                            lblChiTietHoaDon.Visible = true;

                            var dsDichVu = from dv in db.dichVus
                                           join ql in db.danhSachQuanLiDichVus on dv.maDichVu equals ql.maDichVu
                                           where ql.CCCD == cccd
                                           select new
                                           {
                                               dv.maDichVu,
                                               dv.tenDichVu,
                                               dv.donGia,
                                           };
                            dataTable.DataSource = dsDichVu.ToList();
                            dataTable.Columns["maDichVu"].HeaderText = "Mã dịch vụ";
                            dataTable.Columns["tenDichVu"].HeaderText = "Tên dịch vụ";
                            dataTable.Columns["donGia"].HeaderText = "Đơn giá";
                            dataTable.Refresh();

                            if (khachHang.ngayThue.HasValue)
                            {
                                int soNgayThue = (DateTime.Now - khachHang.ngayThue.Value).Days;
                                txtSoNgayThue.Text = soNgayThue.ToString();

                                tongTienPhong = (double)(soNgayThue * phong.gia);
                                txtSoNgayThue.Text = $"Tổng số ngày thuê của quý khách là: {soNgayThue.ToString()} ngày";
                                txtTienPhong.Text = $"Tổng hóa đơn dịch vụ của quý khách: {tongTienPhong.ToString("N0")}";
                                tongTienDichVu = (dsDichVu != null && dsDichVu.Any()) ? (double)dsDichVu.Sum(dv => dv.donGia) : 0;
                                txtTongTienDichVu.Text = $"Tổng tiền phòng của quý khách: {soNgayThue}*{phong.gia} = {tongTienDichVu.ToString("N0")}";
                                double tongTienThanhToan = tongTienPhong + tongTienDichVu;
                                txtTongHoaDon.Text = $"Tổng hóa đơn cần thanh toán {tongTienPhong} + {tongTienDichVu} = {tongTienThanhToan.ToString("N0")}";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin phòng của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin khách hàng hoặc trạng thái phòng chưa xử lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            pnlHoaDon.Visible = false;
            pnlThongTin.Visible = false;
            dataTable.Visible = false;
        }
    }
}
