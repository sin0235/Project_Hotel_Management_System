using Guna.UI2.WinForms;
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
    public partial class uc_AddNewRoom : UserControl
    {
        projectDatadbmlDataContext ds = new projectDatadbmlDataContext();
        danhSachPhong dsPhong = new danhSachPhong();

        public uc_AddNewRoom()
        {
            InitializeComponent();
        }


        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_ThemPhongMoi1.BringToFront();
            uc_ThemPhongMoi1.Visible = true;
        }


        private void closeAll()
        {
            uc_ThemPhongMoi1.Visible = false;
            uc_XoaPhong1.Visible = false;
            uc_TimKiemChinhSua1.Visible = false;
        }
        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_XoaPhong1.BringToFront();
            uc_XoaPhong1.Visible = true;

        }

        private void uc_AddNewRoom_Load(object sender, EventArgs e)
        {
            closeAll();

            LoadRoomData();
            uc_ThemPhongMoi1.Visible = true;

        }

        private void btnFindAndEdit_Click(object sender, EventArgs e)
        {
            closeAll();
            uc_TimKiemChinhSua1.BringToFront();
            uc_TimKiemChinhSua1.Visible = true;
        }

        private void LoadRoomData()
        {
            using (var db = new projectDatadbmlDataContext())
            {
                dataTable.DataSource = db.danhSachPhongs.ToList();
            }
        }
        private void uc_ThemPhongMoi1_RoomAdded(object sender, EventArgs e)
        {
            LoadRoomData();
        }



        private void DisplayRoomInDataGridView(danhSachPhong room)
        {
            var roomList = new List<danhSachPhong> { room };
            dataTable.DataSource = null;
            dataTable.DataSource = roomList;
            dataTable.Refresh();
        }

        public void uc_XoaPhong1_RoomDeleted(object sender, EventArgs e)
        {
            LoadRoomData();
        }
        public void uc_XoaPhong1_changeTable(object sender, danhSachPhong room)
        {
            if (room != null)
            {
                DisplayRoomInDataGridView(room);
            }
        }

        public void uc_TimKiemChinhSua1_RoomSearch(object sender, danhSachPhong room)
        {
            if (room != null)
            {
                DisplayRoomInDataGridView(room);
            }
        }

        public void uc_TimKiemChinhSua1_EditRoom(object sender, EventArgs e)
        {
            LoadRoomData();
        }

        private void uc_TimKiemChinhSua1_Load(object sender, EventArgs e)
        {

        }
    }
}
