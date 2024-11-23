namespace Muong_Thanh_Hotel.User_Control
{
    partial class uc_AddNewRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labAddNewRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtIsAvailable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTinhTrang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLoaiGiuong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTypeOfBed = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoTang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewRoom = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIsAvailable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTinhTrang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLoaiPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAddNewRoom
            // 
            this.labAddNewRoom.BackColor = System.Drawing.Color.Transparent;
            this.labAddNewRoom.Font = new System.Drawing.Font("SVN-Cookies", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddNewRoom.Location = new System.Drawing.Point(21, 14);
            this.labAddNewRoom.Name = "labAddNewRoom";
            this.labAddNewRoom.Size = new System.Drawing.Size(223, 43);
            this.labAddNewRoom.TabIndex = 0;
            this.labAddNewRoom.Text = "Quản lý phòng";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(21, 73);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(964, 921);
            this.guna2DataGridView1.TabIndex = 1;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txtIsAvailable);
            this.guna2Panel1.Controls.Add(this.txtTinhTrang);
            this.guna2Panel1.Controls.Add(this.txtLoaiGiuong);
            this.guna2Panel1.Controls.Add(this.txtLoaiPhong);
            this.guna2Panel1.Controls.Add(this.lblTypeOfBed);
            this.guna2Panel1.Controls.Add(this.txtSoTang);
            this.guna2Panel1.Controls.Add(this.txtSoPhong);
            this.guna2Panel1.Controls.Add(this.txtGiaPhong);
            this.guna2Panel1.Controls.Add(this.btnAddNewRoom);
            this.guna2Panel1.Controls.Add(this.lblPrice);
            this.guna2Panel1.Controls.Add(this.lblIsAvailable);
            this.guna2Panel1.Controls.Add(this.lblTinhTrang);
            this.guna2Panel1.Controls.Add(this.lblTang);
            this.guna2Panel1.Controls.Add(this.lblLoaiPhong);
            this.guna2Panel1.Controls.Add(this.lblSoPhong);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.guna2Panel1.Location = new System.Drawing.Point(1018, 223);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(505, 542);
            this.guna2Panel1.TabIndex = 19;
            // 
            // txtIsAvailable
            // 
            this.txtIsAvailable.AutoRoundedCorners = true;
            this.txtIsAvailable.BackColor = System.Drawing.Color.Transparent;
            this.txtIsAvailable.BorderRadius = 17;
            this.txtIsAvailable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtIsAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIsAvailable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIsAvailable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIsAvailable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIsAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtIsAvailable.ItemHeight = 30;
            this.txtIsAvailable.Items.AddRange(new object[] {
            "Available",
            "Not available"});
            this.txtIsAvailable.Location = new System.Drawing.Point(236, 343);
            this.txtIsAvailable.Name = "txtIsAvailable";
            this.txtIsAvailable.Size = new System.Drawing.Size(241, 36);
            this.txtIsAvailable.TabIndex = 32;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.AutoRoundedCorners = true;
            this.txtTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.txtTinhTrang.BorderRadius = 17;
            this.txtTinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTinhTrang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtTinhTrang.ItemHeight = 30;
            this.txtTinhTrang.Items.AddRange(new object[] {
            "Tốt",
            "Đang sửa chữa",
            "Cần sửa chữa"});
            this.txtTinhTrang.Location = new System.Drawing.Point(236, 279);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(241, 36);
            this.txtTinhTrang.TabIndex = 31;
            // 
            // txtLoaiGiuong
            // 
            this.txtLoaiGiuong.AutoRoundedCorners = true;
            this.txtLoaiGiuong.BackColor = System.Drawing.Color.Transparent;
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
            this.txtLoaiGiuong.Location = new System.Drawing.Point(236, 215);
            this.txtLoaiGiuong.Name = "txtLoaiGiuong";
            this.txtLoaiGiuong.Size = new System.Drawing.Size(241, 36);
            this.txtLoaiGiuong.TabIndex = 30;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.AutoRoundedCorners = true;
            this.txtLoaiPhong.BackColor = System.Drawing.Color.Transparent;
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
            this.txtLoaiPhong.Location = new System.Drawing.Point(236, 151);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(241, 36);
            this.txtLoaiPhong.TabIndex = 29;
            this.txtLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // lblTypeOfBed
            // 
            this.lblTypeOfBed.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeOfBed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfBed.Location = new System.Drawing.Point(42, 220);
            this.lblTypeOfBed.Name = "lblTypeOfBed";
            this.lblTypeOfBed.Size = new System.Drawing.Size(115, 30);
            this.lblTypeOfBed.TabIndex = 28;
            this.lblTypeOfBed.Text = "Loại giường:";
            // 
            // txtSoTang
            // 
            this.txtSoTang.Animated = true;
            this.txtSoTang.AutoRoundedCorners = true;
            this.txtSoTang.BorderRadius = 16;
            this.txtSoTang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtSoTang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTang.DefaultText = "Nhập số tầng";
            this.txtSoTang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoTang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoTang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoTang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTang.Location = new System.Drawing.Point(236, 89);
            this.txtSoTang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTang.Name = "txtSoTang";
            this.txtSoTang.PasswordChar = '\0';
            this.txtSoTang.PlaceholderText = "";
            this.txtSoTang.SelectedText = "";
            this.txtSoTang.Size = new System.Drawing.Size(241, 34);
            this.txtSoTang.TabIndex = 27;
            this.txtSoTang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Animated = true;
            this.txtSoPhong.AutoRoundedCorners = true;
            this.txtSoPhong.BorderRadius = 16;
            this.txtSoPhong.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtSoPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoPhong.DefaultText = "Nhập số phòng";
            this.txtSoPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSoPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Location = new System.Drawing.Point(236, 27);
            this.txtSoPhong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.PasswordChar = '\0';
            this.txtSoPhong.PlaceholderText = "";
            this.txtSoPhong.SelectedText = "";
            this.txtSoPhong.Size = new System.Drawing.Size(241, 34);
            this.txtSoPhong.TabIndex = 26;
            this.txtSoPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoPhong.TextChanged += new System.EventHandler(this.txtSoPhong_TextChanged);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Animated = true;
            this.txtGiaPhong.AutoRoundedCorners = true;
            this.txtGiaPhong.BorderRadius = 16;
            this.txtGiaPhong.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtGiaPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaPhong.DefaultText = "Nhập vào giá phòng";
            this.txtGiaPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaPhong.Location = new System.Drawing.Point(236, 407);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.PasswordChar = '\0';
            this.txtGiaPhong.PlaceholderText = "";
            this.txtGiaPhong.SelectedText = "";
            this.txtGiaPhong.Size = new System.Drawing.Size(241, 34);
            this.txtGiaPhong.TabIndex = 25;
            this.txtGiaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddNewRoom
            // 
            this.btnAddNewRoom.AutoRoundedCorners = true;
            this.btnAddNewRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewRoom.BorderRadius = 21;
            this.btnAddNewRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnAddNewRoom.BorderThickness = 1;
            this.btnAddNewRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.btnAddNewRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAddNewRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddNewRoom.Location = new System.Drawing.Point(159, 477);
            this.btnAddNewRoom.Name = "btnAddNewRoom";
            this.btnAddNewRoom.Size = new System.Drawing.Size(204, 45);
            this.btnAddNewRoom.TabIndex = 24;
            this.btnAddNewRoom.Text = "Thêm phòng";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(42, 409);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(101, 30);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Giá phòng:";
            // 
            // lblIsAvailable
            // 
            this.lblIsAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblIsAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAvailable.Location = new System.Drawing.Point(42, 346);
            this.lblIsAvailable.Name = "lblIsAvailable";
            this.lblIsAvailable.Size = new System.Drawing.Size(149, 30);
            this.lblIsAvailable.TabIndex = 22;
            this.lblIsAvailable.Text = "Tình trạng thuê:";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.lblTinhTrang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(42, 283);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(165, 30);
            this.lblTinhTrang.TabIndex = 21;
            this.lblTinhTrang.Text = "Tình trạng phòng:";
            // 
            // lblTang
            // 
            this.lblTang.BackColor = System.Drawing.Color.Transparent;
            this.lblTang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTang.Location = new System.Drawing.Point(42, 94);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(53, 30);
            this.lblTang.TabIndex = 20;
            this.lblTang.Text = "Tầng:";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(42, 157);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(108, 30);
            this.lblLoaiPhong.TabIndex = 19;
            this.lblLoaiPhong.Text = "Loại phòng:";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhong.Location = new System.Drawing.Point(42, 31);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(91, 30);
            this.lblSoPhong.TabIndex = 18;
            this.lblSoPhong.Text = "Số phòng:";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // uc_AddNewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.labAddNewRoom);
            this.Name = "uc_AddNewRoom";
            this.Size = new System.Drawing.Size(1552, 1018);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labAddNewRoom;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTypeOfBed;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTang;
        private Guna.UI2.WinForms.Guna2TextBox txtSoPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaPhong;
        private Guna.UI2.WinForms.Guna2Button btnAddNewRoom;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIsAvailable;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTinhTrang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoaiPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoPhong;
        private Guna.UI2.WinForms.Guna2ComboBox txtIsAvailable;
        private Guna.UI2.WinForms.Guna2ComboBox txtTinhTrang;
        private Guna.UI2.WinForms.Guna2ComboBox txtLoaiGiuong;
        private Guna.UI2.WinForms.Guna2ComboBox txtLoaiPhong;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
