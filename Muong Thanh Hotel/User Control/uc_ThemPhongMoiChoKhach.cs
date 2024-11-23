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
    public partial class uc_ThemPhongMoiChoKhach : UserControl
    {
        public uc_ThemPhongMoiChoKhach()
        {
            InitializeComponent();
        }

        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm phòng ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
            {
                DialogResult result1 = MessageBox.Show("Bạn có muốn thêm dịch vụ không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.Yes)
                {

                }
            }
        }
    }
}
