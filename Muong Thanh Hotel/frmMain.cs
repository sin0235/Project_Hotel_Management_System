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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
           frmLogin convert1 = new frmLogin();
            convert1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoginForGuest newForm = new frmLoginForGuest();
            
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tắt ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tinhLuong();
        }

        private void tinhLuong()
        {
            try
            {
                using (var db = new projectDatadbmlDataContext())
                {
                   var danhSachNhanVien = (from nv in db.danhSachNhanViens
                                           join acc in db.quanLiTaiKhoans on nv.CCCD equals acc.CCCD
                                           where acc.chucVu == "Receptionist"
                                           select nv)
                                           .ToList();
                    foreach (var nv in danhSachNhanVien)
                    {
                        
                        Receptionist nhanVien = mapping(nv);
                        nhanVien.TinhLuong();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private Receptionist mapping(danhSachNhanVien nv)
        {
            return new Receptionist()
            {
                name = nv.hoTen,
                identityNumber = nv.CCCD,
                gender = nv.gioiTinh,
                address = nv.diaChi,
                nationality = nv.quocTich,
                birthDate = nv.ngaySInh,
                hireDate = nv.hireDate,
                phoneNumber = nv.sdt
            };
        }
    }
}
