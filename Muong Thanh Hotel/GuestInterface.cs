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
    public partial class GuestInterface : Form
    {
        private int cccd, soPhong;
        public GuestInterface(int cccd, int soPhong)
        {
            InitializeComponent();
            this.cccd = cccd;
            this.soPhong = soPhong;
        }

        private void GuestInterface_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataDataSet1.dichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.projectDataDataSet1.dichVu);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> danhSachMaDichVu = new List<string>();

                foreach (DataGridViewRow row in dataTable.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["chonDichVu"].Value);

                    if (isSelected)
                    {
                        string maDichVu = row.Cells["maDichVu"].Value.ToString(); 
                        danhSachMaDichVu.Add(maDichVu);
                    }
                }

                if (danhSachMaDichVu.Count > 0)
                {
                    using (var db = new projectDatadbmlDataContext())
                    {
                        foreach (string maDichVu in danhSachMaDichVu)
                        {
                            danhSachQuanLiDichVu newQuanLyDichVu = new danhSachQuanLiDichVu
                            {
                                CCCD = cccd,
                                maDichVu = maDichVu
                            };

                            db.danhSachQuanLiDichVus.InsertOnSubmit(newQuanLyDichVu);
                        }
                        db.SubmitChanges();

                        MessageBox.Show("Lưu thông tin dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        foreach (DataGridViewRow row in dataTable.Rows)
                        {
                            row.Cells["chonDichVu"].Value = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dịch vụ nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
