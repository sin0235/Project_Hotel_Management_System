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
    public partial class uc_QuanLiDichVu : UserControl
    {
        public uc_QuanLiDichVu()
        {
            InitializeComponent();
        }

        private void uc_QuanLiDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu();
        }


        private void LoadDichVu()
        {
            try
            {
              
                using (var db = new projectDatadbmlDataContext())
                {
                   dataTable.DataSource = db.dichVus.ToList();
                   dataTable.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaDichVu.Text) ||
                    string.IsNullOrWhiteSpace(txtTenDichVu.Text) ||
                    string.IsNullOrWhiteSpace(txtDonGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maDichVu = txtMaDichVu.Text.Trim();
                string tenDichVu = txtTenDichVu.Text.Trim();
                double donGia;

                if (!double.TryParse(txtDonGia.Text.Trim(), out donGia) || donGia < 0)
                {
                    MessageBox.Show("Đơn giá không hợp lệ. Vui lòng nhập một số lớn hơn hoặc bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new projectDatadbmlDataContext())
                {
                    var dichVuDaTonTai = db.dichVus.FirstOrDefault(dv => dv.maDichVu == maDichVu);
                    if (dichVuDaTonTai != null)
                    {
                        MessageBox.Show("Mã dịch vụ đã tồn tại. Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var dichVuMoi = new dichVu()
                    {
                        maDichVu = maDichVu,
                        tenDichVu = tenDichVu,
                        donGia = donGia
                    };

                    db.dichVus.InsertOnSubmit(dichVuMoi);
                    db.SubmitChanges();

                    MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaDichVu.Clear();
                    txtTenDichVu.Clear();
                    txtDonGia.Clear();

                    LoadDichVu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private dichVu ketQua;
        private void txtSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaDichVuChinhSua.Text))
                {
                    MessageBox.Show("Vui lòng nhập thông tin để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string keyword = txtMaDichVuChinhSua.Text.Trim().ToLower();

                using (var db = new projectDatadbmlDataContext())
                {
                    ketQua = db.dichVus
                                   .Where(dv => dv.maDichVu == keyword).SingleOrDefault();
                    if (ketQua == null)
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dataTable.DataSource = ketQua;
                    dataTable.Columns["MaDichVu"].HeaderText = "Mã Dịch Vụ";
                    dataTable.Columns["TenDichVu"].HeaderText = "Tên Dịch Vụ";
                    dataTable.Columns["DonGia"].HeaderText = "Đơn Giá";
                    dataTable.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maDichVu = txtMaDichVu.Text.Trim();
                string tenDichVu = txtTenDichVu.Text.Trim();
                double donGia;

                if (string.IsNullOrEmpty(maDichVu))
                {
                    MessageBox.Show("Vui lòng nhập mã dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(tenDichVu))
                {
                    MessageBox.Show("Vui lòng nhập tên dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtDonGia.Text.Trim(), out donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (var db = new projectDatadbmlDataContext())
                {
                    var dichVu = db.dichVus.FirstOrDefault(dv => dv.maDichVu == maDichVu);
                    if (dichVu == null)
                    {
                        MessageBox.Show("Không tìm thấy dịch vụ với mã dịch vụ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dichVu.tenDichVu = tenDichVu;
                    dichVu.donGia = donGia;

                    db.SubmitChanges();

                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   LoadDichVu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string maDichVu = txtMaDichVu.Text.Trim();
                if (string.IsNullOrEmpty(maDichVu))
                {
                    MessageBox.Show("Vui lòng nhập mã dịch vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.No)
                {
                    return; 
                }

                using (var db = new projectDatadbmlDataContext())
                {
                    var dichVu = db.dichVus.FirstOrDefault(dv => dv.maDichVu == maDichVu);

                    if (dichVu == null)
                    {
                        MessageBox.Show("Không tìm thấy dịch vụ với mã này trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    db.dichVus.DeleteOnSubmit(dichVu);
                    db.SubmitChanges();

                    MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDichVu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
