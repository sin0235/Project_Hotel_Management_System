namespace Muong_Thanh_Hotel.User_Control
{
    partial class uc_QuanLiDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labAddNewRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTenDichVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblThemDichVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaDichVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.lblDonGia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaDichVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenDichVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTenDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSuaDichVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaDichVuChinhSua = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaDichVuCanXoa1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnXoaPhong = new Guna.UI2.WinForms.Guna2Button();
            this.projectDataDataSet1 = new Muong_Thanh_Hotel.ProjectDataDataSet1();
            this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dichVuTableAdapter = new Muong_Thanh_Hotel.ProjectDataDataSet1TableAdapters.dichVuTableAdapter();
            this.maDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataTable.AutoGenerateColumns = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataTable.ColumnHeadersHeight = 30;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDichVuDataGridViewTextBoxColumn,
            this.tenDichVuDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn});
            this.dataTable.DataSource = this.dichVuBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dataTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataTable.Location = new System.Drawing.Point(3, 62);
            this.dataTable.Name = "dataTable";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(940, 917);
            this.dataTable.TabIndex = 3;
            this.dataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTable.ThemeStyle.HeaderStyle.Height = 30;
            this.dataTable.ThemeStyle.ReadOnly = false;
            this.dataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataTable.ThemeStyle.RowsStyle.Height = 24;
            this.dataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // labAddNewRoom
            // 
            this.labAddNewRoom.BackColor = System.Drawing.Color.Transparent;
            this.labAddNewRoom.Font = new System.Drawing.Font("iCiel Cadena", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddNewRoom.Location = new System.Drawing.Point(3, 1);
            this.labAddNewRoom.Name = "labAddNewRoom";
            this.labAddNewRoom.Size = new System.Drawing.Size(205, 43);
            this.labAddNewRoom.TabIndex = 2;
            this.labAddNewRoom.Text = "Quản lý dịch vụ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 1;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txtTenDichVu);
            this.guna2Panel1.Controls.Add(this.lblTenDichVu);
            this.guna2Panel1.Controls.Add(this.lblThemDichVu);
            this.guna2Panel1.Controls.Add(this.txtDonGia);
            this.guna2Panel1.Controls.Add(this.txtMaDichVu);
            this.guna2Panel1.Controls.Add(this.btnThemNhanVien);
            this.guna2Panel1.Controls.Add(this.lblDonGia);
            this.guna2Panel1.Controls.Add(this.lblMaDichVu);
            this.guna2Panel1.Location = new System.Drawing.Point(957, 62);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(586, 261);
            this.guna2Panel1.TabIndex = 4;
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDichVu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDichVu.Location = new System.Drawing.Point(29, 142);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(94, 27);
            this.lblTenDichVu.TabIndex = 60;
            this.lblTenDichVu.Text = "Tên dịch vụ";
            // 
            // lblThemDichVu
            // 
            this.lblThemDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblThemDichVu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemDichVu.Location = new System.Drawing.Point(202, 3);
            this.lblThemDichVu.Name = "lblThemDichVu";
            this.lblThemDichVu.Size = new System.Drawing.Size(147, 33);
            this.lblThemDichVu.TabIndex = 58;
            this.lblThemDichVu.Text = "Thêm dịch vụ";
            this.lblThemDichVu.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Animated = true;
            this.txtDonGia.AutoRoundedCorners = true;
            this.txtDonGia.BorderColor = System.Drawing.Color.Black;
            this.txtDonGia.BorderRadius = 16;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "";
            this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Location = new System.Drawing.Point(155, 201);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.Size = new System.Drawing.Size(263, 34);
            this.txtDonGia.TabIndex = 56;
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.AutoRoundedCorners = true;
            this.txtMaDichVu.BorderColor = System.Drawing.Color.Black;
            this.txtMaDichVu.BorderRadius = 16;
            this.txtMaDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDichVu.DefaultText = "";
            this.txtMaDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDichVu.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMaDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDichVu.Location = new System.Drawing.Point(155, 69);
            this.txtMaDichVu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.PasswordChar = '\0';
            this.txtMaDichVu.PlaceholderText = "";
            this.txtMaDichVu.SelectedText = "";
            this.txtMaDichVu.Size = new System.Drawing.Size(263, 34);
            this.txtMaDichVu.TabIndex = 55;
            this.txtMaDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Animated = true;
            this.btnThemNhanVien.AutoRoundedCorners = true;
            this.btnThemNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNhanVien.BorderRadius = 20;
            this.btnThemNhanVien.BorderThickness = 1;
            this.btnThemNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNhanVien.DefaultAutoSize = true;
            this.btnThemNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.btnThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThemNhanVien.IndicateFocus = true;
            this.btnThemNhanVien.Location = new System.Drawing.Point(473, 69);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemNhanVien.Size = new System.Drawing.Size(95, 43);
            this.btnThemNhanVien.TabIndex = 54;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseTransparentBackground = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // lblDonGia
            // 
            this.lblDonGia.BackColor = System.Drawing.Color.Transparent;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(30, 208);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(67, 27);
            this.lblDonGia.TabIndex = 53;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblMaDichVu
            // 
            this.lblMaDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblMaDichVu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDichVu.Location = new System.Drawing.Point(30, 76);
            this.lblMaDichVu.Name = "lblMaDichVu";
            this.lblMaDichVu.Size = new System.Drawing.Size(90, 27);
            this.lblMaDichVu.TabIndex = 52;
            this.lblMaDichVu.Text = "Mã dịch vụ";
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.AutoRoundedCorners = true;
            this.txtTenDichVu.BorderColor = System.Drawing.Color.Black;
            this.txtTenDichVu.BorderRadius = 16;
            this.txtTenDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDichVu.DefaultText = "";
            this.txtTenDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDichVu.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTenDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDichVu.Location = new System.Drawing.Point(155, 135);
            this.txtTenDichVu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.PasswordChar = '\0';
            this.txtTenDichVu.PlaceholderText = "";
            this.txtTenDichVu.SelectedText = "";
            this.txtTenDichVu.Size = new System.Drawing.Size(263, 34);
            this.txtTenDichVu.TabIndex = 61;
            this.txtTenDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 1;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.txtSearch);
            this.guna2Panel2.Controls.Add(this.txtTenDV);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.lblSuaDichVu);
            this.guna2Panel2.Controls.Add(this.txtGia);
            this.guna2Panel2.Controls.Add(this.txtMaDichVuChinhSua);
            this.guna2Panel2.Controls.Add(this.txtSua);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Location = new System.Drawing.Point(957, 372);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(586, 261);
            this.guna2Panel2.TabIndex = 62;
            // 
            // txtTenDV
            // 
            this.txtTenDV.AutoRoundedCorners = true;
            this.txtTenDV.BorderColor = System.Drawing.Color.Black;
            this.txtTenDV.BorderRadius = 16;
            this.txtTenDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDV.DefaultText = "";
            this.txtTenDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTenDV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDV.Location = new System.Drawing.Point(155, 135);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.PasswordChar = '\0';
            this.txtTenDV.PlaceholderText = "";
            this.txtTenDV.SelectedText = "";
            this.txtTenDV.Size = new System.Drawing.Size(263, 34);
            this.txtTenDV.TabIndex = 61;
            this.txtTenDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(29, 142);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(94, 27);
            this.guna2HtmlLabel1.TabIndex = 60;
            this.guna2HtmlLabel1.Text = "Tên dịch vụ";
            // 
            // lblSuaDichVu
            // 
            this.lblSuaDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblSuaDichVu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuaDichVu.Location = new System.Drawing.Point(202, 3);
            this.lblSuaDichVu.Name = "lblSuaDichVu";
            this.lblSuaDichVu.Size = new System.Drawing.Size(193, 33);
            this.lblSuaDichVu.TabIndex = 58;
            this.lblSuaDichVu.Text = "Chỉnh sửa dịch vụ";
            this.lblSuaDichVu.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGia
            // 
            this.txtGia.Animated = true;
            this.txtGia.AutoRoundedCorners = true;
            this.txtGia.BorderColor = System.Drawing.Color.Black;
            this.txtGia.BorderRadius = 16;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.DefaultText = "";
            this.txtGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGia.Location = new System.Drawing.Point(155, 201);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.PlaceholderText = "";
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(263, 34);
            this.txtGia.TabIndex = 56;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaDichVuChinhSua
            // 
            this.txtMaDichVuChinhSua.AutoRoundedCorners = true;
            this.txtMaDichVuChinhSua.BorderColor = System.Drawing.Color.Black;
            this.txtMaDichVuChinhSua.BorderRadius = 16;
            this.txtMaDichVuChinhSua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDichVuChinhSua.DefaultText = "";
            this.txtMaDichVuChinhSua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDichVuChinhSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDichVuChinhSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDichVuChinhSua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDichVuChinhSua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDichVuChinhSua.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMaDichVuChinhSua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDichVuChinhSua.Location = new System.Drawing.Point(29, 66);
            this.txtMaDichVuChinhSua.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaDichVuChinhSua.Name = "txtMaDichVuChinhSua";
            this.txtMaDichVuChinhSua.PasswordChar = '\0';
            this.txtMaDichVuChinhSua.PlaceholderText = "Nhập vào mã dịch vụ cần cập nhật";
            this.txtMaDichVuChinhSua.SelectedText = "";
            this.txtMaDichVuChinhSua.Size = new System.Drawing.Size(422, 34);
            this.txtMaDichVuChinhSua.TabIndex = 55;
            this.txtMaDichVuChinhSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSua
            // 
            this.txtSua.Animated = true;
            this.txtSua.AutoRoundedCorners = true;
            this.txtSua.BackColor = System.Drawing.Color.Transparent;
            this.txtSua.BorderRadius = 20;
            this.txtSua.BorderThickness = 1;
            this.txtSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.txtSua.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSua.IndicateFocus = true;
            this.txtSua.Location = new System.Drawing.Point(473, 135);
            this.txtSua.Name = "txtSua";
            this.txtSua.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSua.Size = new System.Drawing.Size(95, 43);
            this.txtSua.TabIndex = 54;
            this.txtSua.Text = "Save";
            this.txtSua.UseTransparentBackground = true;
            this.txtSua.Click += new System.EventHandler(this.txtSua_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(30, 208);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(67, 27);
            this.guna2HtmlLabel3.TabIndex = 53;
            this.guna2HtmlLabel3.Text = "Đơn giá";
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSearch.IndicateFocus = true;
            this.txtSearch.Location = new System.Drawing.Point(473, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.Size = new System.Drawing.Size(95, 43);
            this.txtSearch.TabIndex = 62;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseTransparentBackground = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderRadius = 1;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.lblConfirm);
            this.guna2Panel3.Controls.Add(this.btnXoaPhong);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel3.Controls.Add(this.txtMaDichVuCanXoa1);
            this.guna2Panel3.Location = new System.Drawing.Point(957, 682);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(586, 167);
            this.guna2Panel3.TabIndex = 63;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(202, 3);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(128, 33);
            this.guna2HtmlLabel4.TabIndex = 58;
            this.guna2HtmlLabel4.Text = "Xóa dịch vụ";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaDichVuCanXoa1
            // 
            this.txtMaDichVuCanXoa1.AutoRoundedCorners = true;
            this.txtMaDichVuCanXoa1.BorderColor = System.Drawing.Color.Black;
            this.txtMaDichVuCanXoa1.BorderRadius = 16;
            this.txtMaDichVuCanXoa1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDichVuCanXoa1.DefaultText = "";
            this.txtMaDichVuCanXoa1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDichVuCanXoa1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDichVuCanXoa1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDichVuCanXoa1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDichVuCanXoa1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDichVuCanXoa1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMaDichVuCanXoa1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDichVuCanXoa1.Location = new System.Drawing.Point(23, 68);
            this.txtMaDichVuCanXoa1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaDichVuCanXoa1.Name = "txtMaDichVuCanXoa1";
            this.txtMaDichVuCanXoa1.PasswordChar = '\0';
            this.txtMaDichVuCanXoa1.PlaceholderText = "Nhập vào mã dịch vụ cần xóa";
            this.txtMaDichVuCanXoa1.SelectedText = "";
            this.txtMaDichVuCanXoa1.Size = new System.Drawing.Size(351, 34);
            this.txtMaDichVuCanXoa1.TabIndex = 55;
            this.txtMaDichVuCanXoa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConfirm
            // 
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblConfirm.Location = new System.Drawing.Point(29, 119);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(351, 25);
            this.lblConfirm.TabIndex = 65;
            this.lblConfirm.Text = "Vui lòng kiểm tra lại thông tin phòng cần xóa";
            this.lblConfirm.Visible = false;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Animated = true;
            this.btnXoaPhong.AutoRoundedCorners = true;
            this.btnXoaPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaPhong.BorderColor = System.Drawing.Color.Red;
            this.btnXoaPhong.BorderRadius = 18;
            this.btnXoaPhong.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnXoaPhong.BorderThickness = 1;
            this.btnXoaPhong.DefaultAutoSize = true;
            this.btnXoaPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.btnXoaPhong.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnXoaPhong.ForeColor = System.Drawing.Color.Red;
            this.btnXoaPhong.IndicateFocus = true;
            this.btnXoaPhong.Location = new System.Drawing.Point(399, 68);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(163, 39);
            this.btnXoaPhong.TabIndex = 64;
            this.btnXoaPhong.Text = "Xác nhận xóa";
            this.btnXoaPhong.UseTransparentBackground = true;
            this.btnXoaPhong.Visible = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // projectDataDataSet1
            // 
            this.projectDataDataSet1.DataSetName = "ProjectDataDataSet1";
            this.projectDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dichVuBindingSource
            // 
            this.dichVuBindingSource.DataMember = "dichVu";
            this.dichVuBindingSource.DataSource = this.projectDataDataSet1;
            // 
            // dichVuTableAdapter
            // 
            this.dichVuTableAdapter.ClearBeforeFill = true;
            // 
            // maDichVuDataGridViewTextBoxColumn
            // 
            this.maDichVuDataGridViewTextBoxColumn.DataPropertyName = "maDichVu";
            this.maDichVuDataGridViewTextBoxColumn.HeaderText = "Mã dịch vụ";
            this.maDichVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDichVuDataGridViewTextBoxColumn.Name = "maDichVuDataGridViewTextBoxColumn";
            // 
            // tenDichVuDataGridViewTextBoxColumn
            // 
            this.tenDichVuDataGridViewTextBoxColumn.DataPropertyName = "tenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.HeaderText = "Tên dịch vụ";
            this.tenDichVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDichVuDataGridViewTextBoxColumn.Name = "tenDichVuDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "donGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // uc_QuanLiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.labAddNewRoom);
            this.Name = "uc_QuanLiDichVu";
            this.Size = new System.Drawing.Size(1552, 1018);
            this.Load += new System.EventHandler(this.uc_QuanLiDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataTable;
        private Guna.UI2.WinForms.Guna2HtmlLabel labAddNewRoom;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDichVu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenDichVu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThemDichVu;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDichVu;
        private Guna.UI2.WinForms.Guna2Button btnThemNhanVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDonGia;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaDichVu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDV;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSuaDichVu;
        private Guna.UI2.WinForms.Guna2TextBox txtGia;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDichVuChinhSua;
        private Guna.UI2.WinForms.Guna2Button txtSua;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDichVuCanXoa1;
        private System.Windows.Forms.BindingSource dichVuBindingSource;
        private ProjectDataDataSet1 projectDataDataSet1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirm;
        private Guna.UI2.WinForms.Guna2Button btnXoaPhong;
        private ProjectDataDataSet1TableAdapters.dichVuTableAdapter dichVuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDichVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
