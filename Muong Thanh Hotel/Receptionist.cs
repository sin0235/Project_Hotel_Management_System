using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Muong_Thanh_Hotel
{

    public class Receptionist : Person, Interfaces.IMappingToDSNhanVien
    {
        float luongThucNhan = 10000000;

        private string _username;
        private string _password;

        private ReceptionistDashBoard newForm;

        private DateTime _hireDate;

        public DateTime hireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }


        public string username
        {

            set { _username = value; }
        }

        public string password { set { _password = value; } }

        public Receptionist() { }

        public Receptionist(string name, DateTime birthDate, string gender, int indentityNumber, string phoneNumber, string address, string nationality) : base(name, birthDate, gender, indentityNumber, phoneNumber, address, nationality)
        {

        }

        public danhSachNhanVien mapping()
        {
            return new danhSachNhanVien()
            {
                hoTen = name,
                CCCD = identityNumber,
                ngaySInh = birthDate,
                gioiTinh = gender,
                diaChi = address,
                hireDate = hireDate,
                sdt = phoneNumber,
                quocTich = nationality
            };
        }

        public override void func()
        {
            newForm = new ReceptionistDashBoard(identityNumber);
            newForm.Show();
        }

        public void TinhLuong()
        {
            try
            {
                using (var db = new projectDatadbmlDataContext())
                {
                    string maGiaoDich = $"{identityNumber}{hireDate.Day:D2}{DateTime.Now.Month:D2}{DateTime.Now.Year}";
                    var checkNV = db.luongs.FirstOrDefault(e => e.maGiaoDich == maGiaoDich);

                    if (checkNV == null)
                    {

                        if (DateTime.Now.Day == hireDate.Day || DateTime.Now.Day - hireDate.Day > 0)
                        {
                            var luongNV = new luong()
                            {
                                CCCD = identityNumber,
                                ngayNhan = DateTime.Now,
                                luong1 = luongThucNhan,
                                maGiaoDich = maGiaoDich,
                            };

                            db.luongs.InsertOnSubmit(luongNV);
                            db.SubmitChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}