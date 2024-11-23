using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Muong_Thanh_Hotel.User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dataTable.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            
        }
        
        private void closeAll()
        {
            
            uc_XoaPhong1.Visible = false;
            uc_TimKiemChinhSua1.Visible = false;
            uc_ThemThongTin1.Visible = false;
            
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            closeAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this,null);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_XoaPhong1.BringToFront();
            uc_XoaPhong1.Visible = true;
        }

        private void btnFindAndEdit_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_TimKiemChinhSua1.BringToFront();
            uc_TimKiemChinhSua1.Visible = true;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_ThemThongTin1.BringToFront();
            uc_ThemThongTin1.Visible=true;
        }

        private void uc_ThemThongTin1_Load(object sender, EventArgs e)
        {

        }
    }
}
