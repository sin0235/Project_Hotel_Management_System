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
    public partial class uc_ThemThongTin : UserControl
    {
        public uc_ThemThongTin()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn yêu cầu thêm dịch vụ không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                Dichvu dv = new Dichvu();
                dv.Show();
                this.Visible = false;
            }
            if (result == DialogResult.No)
            {
                this.Visible = false;
            }
            
        }
    }
}
