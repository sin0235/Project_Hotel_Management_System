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
    public partial class uc_XoaNhanVien : UserControl
    {
        public uc_XoaNhanVien()
        {
            InitializeComponent();
        }

        private void uc_XoaNhanVien_Load(object sender, EventArgs e)
        {

        }


        public event EventHandler<danhSachNhanVien> timDanhSachNhanVien;
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int cccd;

                if (!int.TryParse(txtCCD.Text, out cccd))
                {

                    MessageBox.Show("Vui lòng nhập số phòng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               
                if (string.IsNullOrWhiteSpace(txtCCD.Text)) throw new Exception("Vui lòng nhập CCCD nhân viên muốn xóa");
                using (var db = new projectDatadbmlDataContext())
                {
                    var nv = db.danhSachNhanViens.SingleOrDefault(newNv => newNv.CCCD == cccd);
                    if (nv != null) {
                        btnXoa.Visible = true;
                        lblConfirm.Visible = true;
                        timDanhSachNhanVien?.Invoke(this, nv);
                        MessageBox.Show("Tìm thấy nhân viên, kiểm tra lại thông tin trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        public event EventHandler xoaNhanVien;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int cccd;
                if (!int.TryParse(txtCCD.Text, out cccd))
                {
                    MessageBox.Show("Vui lòng nhập số phòng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using(var db = new projectDatadbmlDataContext())
                {
                    var nv = db.danhSachNhanViens.SingleOrDefault(em => em.CCCD == cccd);
                    if (nv != null) { 
                        db.danhSachNhanViens.DeleteOnSubmit(nv);
                        db.SubmitChanges();
                        MessageBox.Show("Đã xóa nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        xoaNhanVien?.Invoke(this, EventArgs.Empty);
                    }

                }    

            }
            catch( Exception ex) { }
        }
    }
}
