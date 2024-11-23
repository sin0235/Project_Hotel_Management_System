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
    }
}