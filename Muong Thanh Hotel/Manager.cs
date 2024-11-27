using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muong_Thanh_Hotel
{
    public class Manager : Person
    {
        private ManagerDashboard newForm;
        private string _username;
        private string _password;

        public string username
        {

            set { _username = value; }
        }

        public string password {  set { _password = value; } }

        public Manager() { }

        public Manager(string name, DateTime birthDate, string gender, int indentityNumber, string phoneNumber, string address, string nationality):base(name, birthDate, gender, indentityNumber , phoneNumber, address, nationality)
        {
           
        }

        
        public override void func()
        {
            this.newForm = new ManagerDashboard();
            newForm.Show();
        }
    }
}