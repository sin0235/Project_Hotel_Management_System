﻿using System;
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
    public partial class uc_TimKiemChinhSua : UserControl
    {
        public uc_TimKiemChinhSua()
        {
            InitializeComponent();
        }
        public event EventHandler<danhSachPhong> RoomSearched;
        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
          
        }

        public event EventHandler EditRoom;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int soPhong;
            try
            {

                if (!int.TryParse(txtSo_Phong.Text, out soPhong))
                {
                    MessageBox.Show("Vui lòng nhập số phòng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new projectDatadbmlDataContext())
                {

                    var room = db.danhSachPhongs.SingleOrDefault(r => r.soPhong == soPhong);
                    if (room == null)
                    {
                        MessageBox.Show("Không tìm thấy phòng với số phòng này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    room.loaiPhong = txtLoaiPhong.SelectedItem.ToString();
                    room.soTang = int.Parse(txtSoTang.Text);
                    room.gia = float.Parse(txtGiaPhong.Text);
                    room.trangThaiPhong = txtTinhTrang.SelectedItem.ToString();
                    room.loaiGiuong = txtLoaiGiuong.SelectedItem.ToString();
                    room.isAvailable = txtIsAvailable.SelectedItem.ToString();

                    db.SubmitChanges();



                    MessageBox.Show("Cập nhật thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EditRoom?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int soPhong;
                if (!int.TryParse(txtSo_Phong.Text, out soPhong))
                {
                    MessageBox.Show("Vui lòng nhập số phòng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new projectDatadbmlDataContext())
                {
                    var room = db.danhSachPhongs.SingleOrDefault(r => r.soPhong == soPhong);
                    if (room != null)
                    {
                        
                        MessageBox.Show("Tìm thấy phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RoomSearched?.Invoke(this, room);
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
    }
}


