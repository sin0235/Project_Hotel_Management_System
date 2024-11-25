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
    public partial class uc_ThemNhanVien : UserControl
    {
        private Receptionist newRec;
        public uc_ThemNhanVien()
        {
            InitializeComponent();
        }

        public event EventHandler themNhanVien;
        
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (string.IsNullOrWhiteSpace(txtCCCD.Text)) throw new Exception("Không thể bỏ trống số CCCD");
                if (string.IsNullOrWhiteSpace(txtTen.Text)) throw new Exception("Không thể bỏ trống họ và tên");
                if (string.IsNullOrWhiteSpace(txtDiaChi.Text)) throw new Exception("Không thể bỏ trống địa chỉ");
                if (string.IsNullOrWhiteSpace(txtQuocTich.Text)) throw new Exception("Không thể bỉ trống quốc tịch");
                if (cmbGioiTinh.SelectedIndex == -1) throw new Exception("Không thể bỏ trống giới tính");
                if(string.IsNullOrWhiteSpace(txtSDT.Text)) throw new Exception("Không thể bỏ trống số điện thoại");
                if(birthDay.Value == DateTime.MinValue) throw new Exception("Vui lòng chọn ngày sinh");
                if(hireDay.Value == DateTime.MinValue) throw new Exception("Vui lòng chọn ngày làm việc");

                using (var db = new projectDatadbmlDataContext()) {
                    newRec = new Receptionist()
                    {
                        name = txtTen.Text,
                        indentityNumber = int.Parse(txtCCCD.Text),
                        gender =cmbGioiTinh.SelectedItem.ToString(),
                        phoneNumber = txtSDT.Text,
                        birthDate = birthDay.Value,
                        hireDate = hireDay.Value,
                        address  = txtDiaChi.Text,
                        nationality = txtQuocTich.Text
                    };

                    db.danhSachNhanViens.InsertOnSubmit(newRec.mapping());
                    db.SubmitChanges();
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    themNhanVien?.Invoke(this, EventArgs.Empty);
                }



            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
