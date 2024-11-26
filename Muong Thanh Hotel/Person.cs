using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muong_Thanh_Hotel
{
    public class Person
    {
        private string _name;
        private  DateTime _birthDate;
        private string _gender;
        private int _identityNumber;
        private string _phoneNumber;
        private string _address;
        private string _nationality;

        public string name{get { return _name; } set { _name = value; }}
        public DateTime birthDate{ get { return _birthDate; } set { _birthDate = value; } }
        public string gender{ get { return _gender; } set {_gender = value; } }
        public int identityNumber {get { return _identityNumber; } set { _identityNumber = value; }}
        public string phoneNumber {  get { return _phoneNumber; } set { _phoneNumber = value; } }
        public string address { get { return _address; } set { _address = value; } }
        public string nationality { get { return _nationality; } set { _nationality = value; } }

        public Person(string name, DateTime birthDate, string gender, int identityNumber, string phoneNumber, string address, string nationality)
        {
            _name = name;
            _birthDate = birthDate;
            _gender = gender;
            _identityNumber = identityNumber;
            _phoneNumber = phoneNumber;
            _address = address;
            _nationality = nationality;
        }

        public Person()
        {
        }
    }
}