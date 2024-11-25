using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muong_Thanh_Hotel
{
    public class Receptionist : Person
    {

        private string _username;
        private string _password;

        private float _luong;
        private DateTime _hireDate;

        public DateTime hireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }

        public float luong
        {
            get { return _luong; }
        }

        public string username
        {

            set { _username = value; }
        }

        public string passwork { set { _password = value; } }

        public Receptionist() { }

        public Receptionist(string name, DateTime birthDate, string gender, int indentityNumber, string phoneNumber, string address, string nationality) : base(name, birthDate, gender, indentityNumber, phoneNumber, address, nationality)
        {

        }

        public danhSachNhanVien mapping()
        {

            return new danhSachNhanVien()
            {
                hoTen = name,
                CCCD = indentityNumber,
                ngaySInh = birthDate,
                gioiTinh = gender,
                diaChi = address, 
                hireDate = hireDate,
                sdt = phoneNumber,
                quocTich = nationality
            };
        }
    }
}