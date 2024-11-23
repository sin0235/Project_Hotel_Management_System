using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muong_Thanh_Hotel.User_Control
{
    public partial class uc_QuanLiNhanVien : UserControl
    {
        public uc_QuanLiNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_ThemNhanVien1.BringToFront();
            uc_ThemNhanVien1.Visible = true;
        }

        private void closeAll()
        {
            uc_ThemNhanVien1.Visible = false;
            uc_XoaNhanVien1.Visible = false;
            uc_SearchEdit1.Visible = false;
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_XoaNhanVien1.BringToFront();
            uc_XoaNhanVien1.Visible = true;            
        }

        private void uc_XoaNhanVien1_Load(object sender, EventArgs e)
        {

        }

        private void btnFindAndEdit_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_SearchEdit1.BringToFront();
            uc_SearchEdit1.Visible = true;
        }

        private void uc_QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            closeAll();
        }
    }
}
