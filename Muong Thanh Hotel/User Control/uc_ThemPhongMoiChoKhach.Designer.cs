namespace Muong_Thanh_Hotel.User_Control
{
    partial class uc_ThemPhongMoiChoKhach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlThemPhong = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNhapThongTin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLoaiGiuong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTypeOfBed = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoTang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewRoom = new Guna.UI2.WinForms.Guna2Button();
            this.lblTang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLoaiPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlThemPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThemPhong
            // 
            this.pnlThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.pnlThemPhong.BorderColor = System.Drawing.Color.Transparent;
            this.pnlThemPhong.BorderRadius = 30;
            this.pnlThemPhong.Controls.Add(this.guna2DateTimePicker2);
            this.pnlThemPhong.Controls.Add(this.guna2DateTimePicker1);
            this.pnlThemPhong.Controls.Add(this.guna2HtmlLabel2);
            this.pnlThemPhong.Controls.Add(this.guna2HtmlLabel1);
            this.pnlThemPhong.Controls.Add(this.lblNhapThongTin);
            this.pnlThemPhong.Controls.Add(this.txtLoaiGiuong);
            this.pnlThemPhong.Controls.Add(this.txtLoaiPhong);
            this.pnlThemPhong.Controls.Add(this.lblTypeOfBed);
            this.pnlThemPhong.Controls.Add(this.txtSoTang);
            this.pnlThemPhong.Controls.Add(this.txtSoPhong);
            this.pnlThemPhong.Controls.Add(this.btnAddNewRoom);
            this.pnlThemPhong.Controls.Add(this.lblTang);
            this.pnlThemPhong.Controls.Add(this.lblLoaiPhong);
            this.pnlThemPhong.Controls.Add(this.lblSoPhong);
            this.pnlThemPhong.CustomBorderColor = System.Drawing.Color.Transparent;
            this.pnlThemPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.pnlThemPhong.Location = new System.Drawing.Point(3, 6);
            this.pnlThemPhong.Name = "pnlThemPhong";
            this.pnlThemPhong.Size = new System.Drawing.Size(506, 674);
            this.pnlThemPhong.TabIndex = 21;
            // 
            // lblNhapThongTin
            // 
            this.lblNhapThongTin.BackColor = System.Drawing.Color.Transparent;
            this.lblNhapThongTin.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapThongTin.Location = new System.Drawing.Point(177, 13);
            this.lblNhapThongTin.Name = "lblNhapThongTin";
            this.lblNhapThongTin.Size = new System.Drawing.Size(129, 32);
            this.lblNhapThongTin.TabIndex = 33;
            this.lblNhapThongTin.Text = "Chọn phòng";
            this.lblNhapThongTin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLoaiGiuong
            // 
            this.txtLoaiGiuong.AutoRoundedCorners = true;
            this.txtLoaiGiuong.BackColor = System.Drawing.Color.Transparent;
            this.txtLoaiGiuong.BorderColor = System.Drawing.Color.Black;
            this.txtLoaiGiuong.BorderRadius = 17;
            this.txtLoaiGiuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtLoaiGiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLoaiGiuong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiGiuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiGiuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLoaiGiuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtLoaiGiuong.ItemHeight = 30;
            this.txtLoaiGiuong.Items.AddRange(new object[] {
            "Single ",
            "Double ",
            "Family"});
            this.txtLoaiGiuong.Location = new System.Drawing.Point(212, 288);
            this.txtLoaiGiuong.Name = "txtLoaiGiuong";
            this.txtLoaiGiuong.Size = new System.Drawing.Size(260, 36);
            this.txtLoaiGiuong.TabIndex = 30;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.AutoRoundedCorners = true;
            this.txtLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.txtLoaiPhong.BorderColor = System.Drawing.Color.Black;
            this.txtLoaiPhong.BorderRadius = 17;
            this.txtLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtLoaiPhong.ItemHeight = 30;
            this.txtLoaiPhong.Items.AddRange(new object[] {
            "Economy",
            "Luxury"});
            this.txtLoaiPhong.Location = new System.Drawing.Point(212, 216);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(260, 36);
            this.txtLoaiPhong.TabIndex = 29;
            // 
            // lblTypeOfBed
            // 
            this.lblTypeOfBed.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeOfBed.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfBed.Location = new System.Drawing.Point(38, 292);
            this.lblTypeOfBed.Name = "lblTypeOfBed";
            this.lblTypeOfBed.Size = new System.Drawing.Size(124, 33);
            this.lblTypeOfBed.TabIndex = 28;
            this.lblTypeOfBed.Text = "Loại giường:";
            // 
            // txtSoTang
            // 
            this.txtSoTang.Animated = true;
            this.txtSoTang.AutoRoundedCorners = true;
            this.txtSoTang.BorderColor = System.Drawing.Color.Black;
            this.txtSoTang.BorderRadius = 16;
            this.txtSoTang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTang.DefaultText = "";
            this.txtSoTang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoTang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoTang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoTang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTang.Location = new System.Drawing.Point(212, 146);
            this.txtSoTang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTang.Name = "txtSoTang";
            this.txtSoTang.PasswordChar = '\0';
            this.txtSoTang.PlaceholderText = "Nhập vào số tầng";
            this.txtSoTang.SelectedText = "";
            this.txtSoTang.Size = new System.Drawing.Size(260, 35);
            this.txtSoTang.TabIndex = 27;
            this.txtSoTang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.AutoRoundedCorners = true;
            this.txtSoPhong.BorderColor = System.Drawing.Color.Black;
            this.txtSoPhong.BorderRadius = 18;
            this.txtSoPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoPhong.DefaultText = "";
            this.txtSoPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSoPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Location = new System.Drawing.Point(212, 76);
            this.txtSoPhong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.PasswordChar = '\0';
            this.txtSoPhong.PlaceholderText = "Nhập vào số phòng";
            this.txtSoPhong.SelectedText = "";
            this.txtSoPhong.Size = new System.Drawing.Size(260, 39);
            this.txtSoPhong.TabIndex = 26;
            this.txtSoPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddNewRoom
            // 
            this.btnAddNewRoom.AutoRoundedCorners = true;
            this.btnAddNewRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewRoom.BorderRadius = 30;
            this.btnAddNewRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnAddNewRoom.BorderThickness = 1;
            this.btnAddNewRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.btnAddNewRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAddNewRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddNewRoom.Location = new System.Drawing.Point(257, 499);
            this.btnAddNewRoom.Name = "btnAddNewRoom";
            this.btnAddNewRoom.Size = new System.Drawing.Size(204, 62);
            this.btnAddNewRoom.TabIndex = 24;
            this.btnAddNewRoom.Text = "Thêm phòng";
            this.btnAddNewRoom.Click += new System.EventHandler(this.btnAddNewRoom_Click);
            // 
            // lblTang
            // 
            this.lblTang.BackColor = System.Drawing.Color.Transparent;
            this.lblTang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTang.Location = new System.Drawing.Point(38, 148);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(57, 33);
            this.lblTang.TabIndex = 20;
            this.lblTang.Text = "Tầng:";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(38, 220);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(117, 33);
            this.lblLoaiPhong.TabIndex = 19;
            this.lblLoaiPhong.Text = "Loại phòng:";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoPhong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhong.Location = new System.Drawing.Point(38, 76);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(99, 33);
            this.lblSoPhong.TabIndex = 18;
            this.lblSoPhong.Text = "Số phòng:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(38, 368);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(180, 33);
            this.guna2HtmlLabel1.TabIndex = 34;
            this.guna2HtmlLabel1.Text = "Ngày nhận phòng";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(38, 440);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(156, 33);
            this.guna2HtmlLabel2.TabIndex = 35;
            this.guna2HtmlLabel2.Text = "Ngày trả phòng";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(231, 362);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(241, 36);
            this.guna2DateTimePicker1.TabIndex = 36;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 11, 22, 2, 20, 23, 925);
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(231, 434);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(241, 36);
            this.guna2DateTimePicker2.TabIndex = 37;
            this.guna2DateTimePicker2.Value = new System.DateTime(2024, 11, 22, 2, 20, 23, 925);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // uc_ThemPhongMoiChoKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.pnlThemPhong);
            this.Name = "uc_ThemPhongMoiChoKhach";
            this.Size = new System.Drawing.Size(512, 680);
            this.pnlThemPhong.ResumeLayout(false);
            this.pnlThemPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlThemPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNhapThongTin;
        private Guna.UI2.WinForms.Guna2ComboBox txtLoaiGiuong;
        private Guna.UI2.WinForms.Guna2ComboBox txtLoaiPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTypeOfBed;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTang;
        private Guna.UI2.WinForms.Guna2TextBox txtSoPhong;
        private Guna.UI2.WinForms.Guna2Button btnAddNewRoom;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoaiPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoPhong;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
