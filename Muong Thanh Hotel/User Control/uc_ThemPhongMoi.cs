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
    public partial class uc_ThemPhongMoi : UserControl
    {
        projectDatadbmlDataContext ds = new projectDatadbmlDataContext();
        Room newRoom = new Room();
        public uc_ThemPhongMoi()
        {
            InitializeComponent();
        }

        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            projectDatadbmlDataContext ds = new projectDatadbmlDataContext();
            Room newRoom = new Room();
            try
            {
                if (!string.IsNullOrEmpty(txtSoPhong.Text) &&
                    !string.IsNullOrEmpty(txtSoTang.Text) &&
                    !string.IsNullOrEmpty(txtGiaPhong.Text) &&
                    txtIsAvailable.SelectedIndex != -1 &&
                    txtLoaiPhong.SelectedIndex != -1 &&
                    txtLoaiGiuong.SelectedIndex != -1 &&
                    txtTinhTrang.SelectedIndex != -1)
                {
                    int soPhong = int.Parse(txtSoPhong.Text);
                    var existingRoom = ds.danhSachPhongs.FirstOrDefault(p => p.soPhong == soPhong);

                    if (existingRoom != null)
                    {
                        MessageBox.Show("Số phòng này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSoPhong.Focus();
                        return;
                    }

                    if (!int.TryParse(txtSoPhong.Text, out _))
                    {
                        MessageBox.Show("Số phòng phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(txtSoTang.Text, out _))
                    {
                        MessageBox.Show("Số tầng phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!float.TryParse(txtGiaPhong.Text, out float gia) || gia <= 0)
                    {
                        MessageBox.Show("Giá phòng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    newRoom.soPhong = soPhong;
                    newRoom.soTang = int.Parse(txtSoTang.Text);
                    newRoom.trangThaiPhong = txtTinhTrang.SelectedItem.ToString();
                    newRoom.loaiGiuong = txtLoaiGiuong.SelectedItem.ToString();
                    newRoom.loaiPhong = txtLoaiPhong.SelectedItem.ToString();
                    newRoom.isAvailable = txtIsAvailable.SelectedItem.ToString();
                    newRoom.gia = gia;

                    ds.danhSachPhongs.InsertOnSubmit(newRoom.mapDanhSachPhong());
                    ds.SubmitChanges();

                    MessageBox.Show("Thêm phòng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSoPhong.Clear();
                    txtSoTang.Clear();
                    txtGiaPhong.Clear();
                    txtIsAvailable.SelectedIndex = -1;
                    txtLoaiPhong.SelectedIndex = -1;
                    txtLoaiGiuong.SelectedIndex = -1;
                    txtTinhTrang.SelectedIndex = -1;
                    lblConfirm.Visible = false;

                    RoomAdded?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    lblConfirm.Text = "Vui lòng nhập đầy đủ thông tin phòng!";
                    lblConfirm.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           public event EventHandler RoomAdded;

    }
}
