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
    public partial class dangKiPhong : Form
    {
        Guest newGuest;


        public dangKiPhong()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                    throw new Exception("Họ và tên không được để trống.");
                if (txtGioiTinh.SelectedItem == null)
                    throw new Exception("Vui lòng chọn giới tính.");
                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                    throw new Exception("Số điện thoại không được để trống.");
                if (string.IsNullOrWhiteSpace(txtQuocTich.Text))
                    throw new Exception("Quốc tịch không được để trống.");
                if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                    throw new Exception("Địa chỉ không được để trống.");
                if (string.IsNullOrWhiteSpace(txtCCCD.Text))
                    throw new Exception("CCCD không được để trống.");
                newGuest = new Guest();
                if (!int.TryParse(txtCCCD.Text, out int identityNumber))
                    throw new Exception("CCCD phải là một số hợp lệ.");
                newGuest.name = txtHoVaTen.Text.Trim();
                newGuest.gender = txtGioiTinh.SelectedItem.ToString();
                newGuest.phoneNumber = txtSDT.Text.Trim();
                newGuest.nationality = txtQuocTich.Text.Trim();
                newGuest.birthDate = dtNgaySinh.Value;
                newGuest.address = txtDiaChi.Text.Trim();
                newGuest.identityNumber = identityNumber;

                MessageBox.Show("Đăng kí thông tin thành công, quý khách vui lòng chọn phòng",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                lblThanhCong.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            }

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {

            try
            {
                if (newGuest == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                using (var db = new projectDatadbmlDataContext())
                {
                    int soPhong = int.Parse(cmbChonPhong.SelectedValue.ToString());
                    var room = db.danhSachPhongs.SingleOrDefault(r => r.soPhong == soPhong);
                    room.isAvailable = "Not Available";

                    db.danhSachKhachHangs.InsertOnSubmit(newGuest.mappingDanhSachKhachHang());
                    StringBuilder maYC = new StringBuilder();
                    maYC.Append(newGuest.identityNumber.ToString());
                    maYC.Append(room.soPhong.ToString());

                    danhSachYeuCau newDS = new danhSachYeuCau()
                    {
                        CCCD = newGuest.identityNumber,
                        maYeuCau = maYC.ToString(),
                        soPhong = soPhong,
                        trangThaiXuLi = "Pending"

                    };

                    db.danhSachYeuCaus.InsertOnSubmit(newDS);
                    db.SubmitChanges();

                    MessageBox.Show("Quy trình đặt phòng hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        private void btnLocPhong_Click(object sender, EventArgs e)
        {
            try
            {

                string loaiPhong = cmbLoaiPhong.SelectedItem.ToString();
                string loaiGiuong = cmbLoaiGiuong.SelectedItem.ToString();


                using (var db = new projectDatadbmlDataContext())
                {
                    var danhSachPhong = db.danhSachPhongs
                                          .Where(p => p.loaiPhong == loaiPhong &&
                                                      p.loaiGiuong == loaiGiuong &&
                                                      p.isAvailable == "Available")
                                          .Select(p => new
                                          {
                                              p.soPhong,
                                              p.loaiPhong,
                                              p.loaiGiuong,
                                              p.gia,
                                              p.soTang
                                          })
                                          .ToList();

                    dataTable.DataSource = danhSachPhong;
                    dataTable.Refresh();


                    cmbChonPhong.DataSource = cmbChonPhong.DataSource = db.danhSachPhongs.Where(p => p.loaiPhong == loaiPhong && p.loaiGiuong == loaiGiuong && p.isAvailable == "Available")
                        .Select(p => new
                        {
                            p.soPhong
                        }).ToList();

                    cmbChonPhong.DisplayMember = "soPhong";
                    cmbChonPhong.ValueMember = "soPhong";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dangKiPhong_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
