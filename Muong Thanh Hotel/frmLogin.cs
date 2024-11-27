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
    public partial class frmLogin : Form
    {
        public frmLogin()
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
                using (var db = new projectDatadbmlDataContext())
                {
                    string username = txtUsername.Text.Trim();
                    string password = txtPassword.Text.Trim();

                    var user = db.quanLiTaiKhoans
                                 .FirstOrDefault(u => u.username == username && u.password == password);

                    if (user != null)
                    {
                        
                        if (user.chucVu == "Manager")
                        {
                            var ql = db.danhSachNhanViens
                                 .Where(q => q.CCCD == user.CCCD)
                                 .FirstOrDefault();
                            var quanLi = mappingToManager(ql);

                            quanLi.func();
                            this.Hide();
                        }
                        else
                        {
                            var nv = db.danhSachNhanViens
                                  .Where(q => q.CCCD == user.CCCD)
                                  .FirstOrDefault();
                            var leTan = mappingToReceptionist(nv);
                            leTan.func();
                            this.Hide();
                            
                        }
                    }
                    else
                    {
                        labelError.Visible = true;
                        txtPassword.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Receptionist mappingToReceptionist(danhSachNhanVien nv)
        {
            quanLiTaiKhoan acc;
            using (var db = new projectDatadbmlDataContext())
            {
                acc = db.quanLiTaiKhoans
                    .Where(tk => tk.CCCD == nv.CCCD)
                    .FirstOrDefault();
            }    
            return new Receptionist()
            {
                name = nv.hoTen,
                identityNumber = nv.CCCD,
                birthDate = nv.ngaySInh,
                hireDate = nv.hireDate,
                gender = nv.gioiTinh,
                address = nv.diaChi,
                phoneNumber = nv.sdt,
                nationality = nv.quocTich,
                username = acc.username,
                password = acc.password
            };
        }

        private Manager mappingToManager(danhSachNhanVien quanLi)
        {
            quanLiTaiKhoan acc;
            using (var db = new projectDatadbmlDataContext())
            {
                acc = db.quanLiTaiKhoans
                    .Where(tk => tk.CCCD == quanLi.CCCD)
                    .FirstOrDefault();
            }
            return new Manager()
            {
                name = quanLi.hoTen,
                identityNumber = quanLi.CCCD,
                birthDate = quanLi.ngaySInh,  
                gender = quanLi.gioiTinh,
                address = quanLi.diaChi,
                phoneNumber = quanLi.sdt,
                nationality = quanLi.quocTich,
                username = acc.username,
                password = acc.password
            };

        }
    }
}
