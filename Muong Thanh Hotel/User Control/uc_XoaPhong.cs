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
    public partial class uc_XoaPhong : UserControl
    {
        public uc_XoaPhong()
        {
            InitializeComponent();
        }

        private void uc_XoaPhong_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler<danhSachPhong> RoomSearched;

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int soPhong;
                if (!int.TryParse(txtSoPhong.Text, out soPhong))
                {
                    MessageBox.Show("Vui lòng nhập số phòng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new projectDatadbmlDataContext())
                {
                    var room = db.danhSachPhongs.SingleOrDefault(r => r.soPhong == soPhong);
                    if (room != null)
                    {
                        lblConfirm.Visible = true;
                        RoomSearched?.Invoke(this, room);
                        lblConfirm.Visible = true;
                        btnXoaPhong.Visible = true;
                        MessageBox.Show("Tìm thấy phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phòng với số phòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public event EventHandler RoomDeleted;

        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int soPhong = int.Parse(txtSoPhong.Text); 

                using (var db = new projectDatadbmlDataContext())
                {
                    var roomToDelete = db.danhSachPhongs.SingleOrDefault(r => r.soPhong == soPhong);
                    if (roomToDelete != null)
                    {
                        db.danhSachPhongs.DeleteOnSubmit(roomToDelete);
                        db.SubmitChanges();
                        RoomDeleted?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }


    }
}
