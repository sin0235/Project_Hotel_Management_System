using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muong_Thanh_Hotel
{
    public class Guest : Person, Interfaces.IMappingToDSKhachHang
    {
        private GuestInterface frm;
        public Guest()
        {
        }

        public Guest(string name, DateTime birthDate, string gender, int indentityNumber, string phoneNumber, string address, string nationality) : base(name, birthDate, gender, indentityNumber, phoneNumber, address, nationality)
        {
        }

        public danhSachKhachHang mapping()
        {
            danhSachKhachHang kh = new danhSachKhachHang();
            kh.hoTen = name;
            kh.diaChi = address;
            kh.ngaySinh = birthDate;
            kh.gioiTinh = gender;
            kh.CCCD = identityNumber;
            kh.sdt = phoneNumber;
            kh.quocTich = nationality;
            return kh;
        }
        private int soPhong;
        public void funcExecute(int soPhong)
        {
            this.soPhong = soPhong;
        }


        public override void func()
        {
            frm = new GuestInterface(identityNumber, soPhong);
            frm.Show();
        }
    }

}