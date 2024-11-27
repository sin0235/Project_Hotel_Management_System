using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Muong_Thanh_Hotel.User_Control;

namespace Muong_Thanh_Hotel
{
    public partial class frmLoginForGuest : Form
    {
        projectDatadbmlDataContext db = new projectDatadbmlDataContext();

        public frmLoginForGuest()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCCCD.Text))
                    throw new Exception("Mã CCCD không thể để trống");
                if (string.IsNullOrWhiteSpace(txtSoPhong.Text))
                    throw new Exception("Số phòng không được để trống");
                int cccd = int.Parse(txtCCCD.Text.Trim());
                int soPhong = int.Parse(txtSoPhong.Text.Trim());

                if (cccd == 0 || soPhong == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin CCCD và Số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new projectDatadbmlDataContext())
                {
                    var yeuCau = db.danhSachYeuCaus
                                  .Where(y => y.CCCD == cccd && y.soPhong == soPhong && y.trangThaiXuLi == "Processed")
                                  .FirstOrDefault();

                    if (yeuCau != null)
                    {
                        MessageBox.Show("Đăng nhập thành công! Chào mừng quý khách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var kh = db.danhSachKhachHangs
                            .Where(g=> g.CCCD == cccd)
                            .FirstOrDefault();
                        var khachHang = mapping(kh);
                        khachHang.funcExecute(soPhong);
                    }
                    else
                    {
                        MessageBox.Show("Thông tin không hợp lệ hoặc yêu cầu chưa được duyệt. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các trường thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            dangKiPhong newForm = new dangKiPhong();
            newForm.Show();
        }

        private Guest mapping(danhSachKhachHang kh)
        {
            return new Guest()
            { 
                name = kh.hoTen,
                gender = kh.gioiTinh,
                birthDate = kh.ngaySinh,
                identityNumber = kh.CCCD,
                phoneNumber  = kh.sdt,
                nationality = kh.quocTich,
                address = kh.diaChi
            };

        }
    }
}
