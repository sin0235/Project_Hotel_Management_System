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
    public partial class uc_SearchEdit : UserControl
    {
        public uc_SearchEdit()
        {
            InitializeComponent();
        }

        private void lblNgayLam_Click(object sender, EventArgs e)
        {

        }

        private void hireDay_ValueChanged(object sender, EventArgs e)
        {

        }
        public event EventHandler<danhSachNhanVien> timDanhSachNhanVien;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int cccd;

                if (!int.TryParse(txtCCCD.Text, out cccd))
                {

                    MessageBox.Show("Vui lòng nhập số phòng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCCCD.Text)) throw new Exception("Vui lòng nhập CCCD nhân viên muốn xóa");
                using (var db = new projectDatadbmlDataContext())
                {
                    var nv = db.danhSachNhanViens.SingleOrDefault(newNv => newNv.CCCD == cccd);
                    if (nv != null)
                    {

                        timDanhSachNhanVien?.Invoke(this, nv);
                        MessageBox.Show("Tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên không tồn tại, vui lòng kiểm tra lại CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public event EventHandler suaNhanVien;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int cccd;
            try
            {

                if (!int.TryParse(txtCCCD.Text, out cccd))
                {
                    MessageBox.Show("Vui lòng nhập số phòng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new projectDatadbmlDataContext())
                {

                    var nv = db.danhSachNhanViens.SingleOrDefault(r => r.CCCD == cccd);
                    if (nv == null)
                    {
                        MessageBox.Show("Không tìm thấy phòng với số phòng này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    nv.gioiTinh = cmbGioiTinh.SelectedItem.ToString();
                    nv.sdt = txtSDT.Text;
                    nv.hoTen = txtTen.Text;
                    nv.ngaySInh = birthDay.Value;
                    nv.hireDate = hireDay.Value;
                    nv.quocTich = txtQuocTich.Text;
                    nv.diaChi = txtDiaChi.Text;

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    suaNhanVien?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
