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
                            ManagerDashboard newForm = new ManagerDashboard();
                            newForm.Show();
                        }
                        else
                        {
                            ReceptionistDashBoard receptionistFrn = new ReceptionistDashBoard(user.CCCD);
                            this.Hide();
                            receptionistFrn.Show();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
