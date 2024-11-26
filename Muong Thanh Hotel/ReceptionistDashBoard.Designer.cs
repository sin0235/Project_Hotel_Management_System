namespace Muong_Thanh_Hotel
{
    partial class ReceptionistDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistDashBoard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_CheckOut1 = new Muong_Thanh_Hotel.User_Control.UC_CheckOut(cccdNhanVien);
            this.uC_QuanLiKhachHang1 = new Muong_Thanh_Hotel.User_Control.UC_QuanLiKhachHang();
            this.uc_DangKiTrucTiep1 = new Muong_Thanh_Hotel.User_Control.uc_DangKiTrucTiep();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDatPhong);
            this.panel2.Controls.Add(this.btnHoaDon);
            this.panel2.Controls.Add(this.btnPhong);
            this.panel2.Location = new System.Drawing.Point(12, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 1022);
            this.panel2.TabIndex = 18;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 1F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(37, 78);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(253, 253);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 10;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("iCiel Koni", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 63);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lễ tân";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BorderRadius = 18;
            this.btnDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatPhong.FillColor = System.Drawing.Color.White;
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.Black;
            this.btnDatPhong.Location = new System.Drawing.Point(39, 579);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(251, 116);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "Check-In";
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BorderRadius = 18;
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.FillColor = System.Drawing.Color.White;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Location = new System.Drawing.Point(39, 762);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(251, 116);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "Check-Out";
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BorderRadius = 18;
            this.btnPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhong.FillColor = System.Drawing.Color.White;
            this.btnPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.Color.Black;
            this.btnPhong.Location = new System.Drawing.Point(39, 400);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.PressedColor = System.Drawing.Color.White;
            this.btnPhong.Size = new System.Drawing.Size(251, 116);
            this.btnPhong.TabIndex = 7;
            this.btnPhong.Text = " Đặt phòng";
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(1867, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(63, 55);
            this.guna2Button2.TabIndex = 19;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel1.Controls.Add(this.uc_DangKiTrucTiep1);
            this.guna2Panel1.Controls.Add(this.uC_CheckOut1);
            this.guna2Panel1.Controls.Add(this.uC_QuanLiKhachHang1);
            this.guna2Panel1.Location = new System.Drawing.Point(357, 46);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1562, 1017);
            this.guna2Panel1.TabIndex = 21;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.BackColor = System.Drawing.Color.Transparent;
            this.uC_CheckOut1.Location = new System.Drawing.Point(3, 3);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1552, 1018);
            this.uC_CheckOut1.TabIndex = 2;
            this.uC_CheckOut1.Visible = false;
            // 
            // uC_QuanLiKhachHang1
            // 
            this.uC_QuanLiKhachHang1.BackColor = System.Drawing.Color.Transparent;
            this.uC_QuanLiKhachHang1.ForeColor = System.Drawing.Color.Transparent;
            this.uC_QuanLiKhachHang1.Location = new System.Drawing.Point(3, 3);
            this.uC_QuanLiKhachHang1.Name = "uC_QuanLiKhachHang1";
            this.uC_QuanLiKhachHang1.Size = new System.Drawing.Size(1520, 1000);
            this.uC_QuanLiKhachHang1.TabIndex = 1;
            this.uC_QuanLiKhachHang1.Visible = false;
            // 
            // uc_DangKiTrucTiep1
            // 
            this.uc_DangKiTrucTiep1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_DangKiTrucTiep1.BackColor = System.Drawing.Color.Transparent;
            this.uc_DangKiTrucTiep1.Location = new System.Drawing.Point(22, 15);
            this.uc_DangKiTrucTiep1.Name = "uc_DangKiTrucTiep1";
            this.uc_DangKiTrucTiep1.Size = new System.Drawing.Size(1540, 1014);
            this.uc_DangKiTrucTiep1.TabIndex = 0;
            this.uc_DangKiTrucTiep1.Visible = false;
            // 
            // ReceptionistDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Button2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionistDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceptionistDashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReceptionistDashBoard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDatPhong;
        private Guna.UI2.WinForms.Guna2Button btnPhong;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private User_Control.uc_DangKiTrucTiep uc_DangKiTrucTiep1;
        private User_Control.UC_QuanLiKhachHang uC_QuanLiKhachHang1;
        private User_Control.UC_CheckOut uC_CheckOut1;
    }
}