namespace Muong_Thanh_Hotel.User_Control
{
    partial class uc_SearchEdit
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.hireDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayLam = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.birthDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTypeOfBed = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIsAvailable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTinhTrang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLoaiPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCCCD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTimKiem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.hireDay);
            this.guna2Panel2.Controls.Add(this.lblNgayLam);
            this.guna2Panel2.Controls.Add(this.birthDay);
            this.guna2Panel2.Controls.Add(this.guna2TextBox3);
            this.guna2Panel2.Controls.Add(this.guna2TextBox2);
            this.guna2Panel2.Controls.Add(this.guna2TextBox1);
            this.guna2Panel2.Controls.Add(this.lblTypeOfBed);
            this.guna2Panel2.Controls.Add(this.txtTen);
            this.guna2Panel2.Controls.Add(this.lblIsAvailable);
            this.guna2Panel2.Controls.Add(this.lblTinhTrang);
            this.guna2Panel2.Controls.Add(this.lblLoaiPhong);
            this.guna2Panel2.Controls.Add(this.lblSoPhong);
            this.guna2Panel2.Controls.Add(this.btnCapNhat);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Location = new System.Drawing.Point(6, 144);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(483, 527);
            this.guna2Panel2.TabIndex = 51;
            // 
            // hireDay
            // 
            this.hireDay.BackColor = System.Drawing.Color.Transparent;
            this.hireDay.BorderRadius = 5;
            this.hireDay.BorderThickness = 1;
            this.hireDay.Checked = true;
            this.hireDay.FillColor = System.Drawing.Color.White;
            this.hireDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hireDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.hireDay.IndicateFocus = true;
            this.hireDay.Location = new System.Drawing.Point(201, 380);
            this.hireDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.hireDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.hireDay.Name = "hireDay";
            this.hireDay.Size = new System.Drawing.Size(263, 34);
            this.hireDay.TabIndex = 76;
            this.hireDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hireDay.UseTransparentBackground = true;
            this.hireDay.Value = new System.DateTime(2024, 11, 20, 23, 27, 8, 418);
            this.hireDay.ValueChanged += new System.EventHandler(this.hireDay_ValueChanged);
            // 
            // lblNgayLam
            // 
            this.lblNgayLam.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayLam.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLam.Location = new System.Drawing.Point(9, 380);
            this.lblNgayLam.Name = "lblNgayLam";
            this.lblNgayLam.Size = new System.Drawing.Size(188, 27);
            this.lblNgayLam.TabIndex = 75;
            this.lblNgayLam.Text = "Ngày bắt đầu làm việc:";
            this.lblNgayLam.Click += new System.EventHandler(this.lblNgayLam_Click);
            // 
            // birthDay
            // 
            this.birthDay.BackColor = System.Drawing.Color.Transparent;
            this.birthDay.BorderRadius = 5;
            this.birthDay.BorderThickness = 1;
            this.birthDay.Checked = true;
            this.birthDay.FillColor = System.Drawing.Color.White;
            this.birthDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.birthDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.birthDay.IndicateFocus = true;
            this.birthDay.Location = new System.Drawing.Point(206, 120);
            this.birthDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.birthDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(263, 34);
            this.birthDay.TabIndex = 74;
            this.birthDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthDay.UseTransparentBackground = true;
            this.birthDay.Value = new System.DateTime(2024, 11, 20, 23, 27, 8, 418);
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Animated = true;
            this.guna2TextBox3.AutoRoundedCorners = true;
            this.guna2TextBox3.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox3.BorderRadius = 16;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(206, 315);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(263, 34);
            this.guna2TextBox3.TabIndex = 73;
            this.guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.AutoRoundedCorners = true;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox2.BorderRadius = 16;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(206, 250);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(263, 34);
            this.guna2TextBox2.TabIndex = 72;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 16;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(206, 185);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(263, 34);
            this.guna2TextBox1.TabIndex = 71;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTypeOfBed
            // 
            this.lblTypeOfBed.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeOfBed.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfBed.Location = new System.Drawing.Point(14, 185);
            this.lblTypeOfBed.Name = "lblTypeOfBed";
            this.lblTypeOfBed.Size = new System.Drawing.Size(111, 27);
            this.lblTypeOfBed.TabIndex = 70;
            this.lblTypeOfBed.Text = "Số điện thoại:";
            // 
            // txtTen
            // 
            this.txtTen.AutoRoundedCorners = true;
            this.txtTen.BorderColor = System.Drawing.Color.Black;
            this.txtTen.BorderRadius = 16;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Location = new System.Drawing.Point(212, 55);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.PlaceholderText = "";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(263, 34);
            this.txtTen.TabIndex = 69;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIsAvailable
            // 
            this.lblIsAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblIsAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAvailable.Location = new System.Drawing.Point(14, 315);
            this.lblIsAvailable.Name = "lblIsAvailable";
            this.lblIsAvailable.Size = new System.Drawing.Size(83, 27);
            this.lblIsAvailable.TabIndex = 68;
            this.lblIsAvailable.Text = "Quốc tịch:";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.lblTinhTrang.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(14, 250);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(63, 27);
            this.lblTinhTrang.TabIndex = 67;
            this.lblTinhTrang.Text = "Địa chỉ:";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(14, 120);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(180, 27);
            this.lblLoaiPhong.TabIndex = 66;
            this.lblLoaiPhong.Text = "Ngày tháng năm sinh:";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhong.Location = new System.Drawing.Point(14, 55);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(84, 27);
            this.lblSoPhong.TabIndex = 65;
            this.lblSoPhong.Text = "Họ và tên:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.BorderThickness = 1;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(127)))), ((int)(((byte)(246)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(250, 456);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(214, 46);
            this.btnCapNhat.TabIndex = 64;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(118, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(198, 32);
            this.guna2HtmlLabel1.TabIndex = 63;
            this.guna2HtmlLabel1.Text = "Cập nhật thông tin";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Panel1.Controls.Add(this.txtCCCD);
            this.guna2Panel1.Controls.Add(this.lblCCCD);
            this.guna2Panel1.Controls.Add(this.lblTimKiem);
            this.guna2Panel1.Location = new System.Drawing.Point(4, 19);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(485, 111);
            this.guna2Panel1.TabIndex = 50;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(127)))), ((int)(((byte)(246)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(360, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 37);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            // 
            // txtCCCD
            // 
            this.txtCCCD.AutoRoundedCorners = true;
            this.txtCCCD.BorderColor = System.Drawing.Color.Black;
            this.txtCCCD.BorderRadius = 14;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(94, 54);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PlaceholderText = "Nhập vào CCCD của nhân viên";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(251, 30);
            this.txtCCCD.TabIndex = 39;
            this.txtCCCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCCCD
            // 
            this.lblCCCD.BackColor = System.Drawing.Color.Transparent;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(9, 55);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(52, 25);
            this.lblCCCD.TabIndex = 38;
            this.lblCCCD.Text = "CCCD:";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(191, 5);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(98, 32);
            this.lblTimKiem.TabIndex = 37;
            this.lblTimKiem.Text = "Tìm kiếm";
            this.lblTimKiem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_SearchEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "uc_SearchEdit";
            this.Size = new System.Drawing.Size(498, 691);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCCCD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimKiem;
        private Guna.UI2.WinForms.Guna2DateTimePicker hireDay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayLam;
        private Guna.UI2.WinForms.Guna2DateTimePicker birthDay;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTypeOfBed;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIsAvailable;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTinhTrang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoaiPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoPhong;
    }
}
