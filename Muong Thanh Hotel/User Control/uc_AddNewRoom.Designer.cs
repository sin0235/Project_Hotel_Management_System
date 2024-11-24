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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labAddNewRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.soPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiGiuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhSachPhongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataDataSet1 = new Muong_Thanh_Hotel.ProjectDataDataSet1();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFindAndEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemPhong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.danhSachPhongTableAdapter1 = new Muong_Thanh_Hotel.ProjectDataDataSet1TableAdapters.danhSachPhongTableAdapter();
            this.uc_TimKiemChinhSua1 = new Muong_Thanh_Hotel.User_Control.uc_TimKiemChinhSua();
            this.uc_XoaPhong1 = new Muong_Thanh_Hotel.User_Control.uc_XoaPhong();
            this.uc_ThemPhongMoi1 = new Muong_Thanh_Hotel.User_Control.uc_ThemPhongMoi();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachPhongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAddNewRoom
            // 
            this.labAddNewRoom.BackColor = System.Drawing.Color.Transparent;
            this.labAddNewRoom.Font = new System.Drawing.Font("iCiel Cadena", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddNewRoom.Location = new System.Drawing.Point(21, 12);
            this.labAddNewRoom.Name = "labAddNewRoom";
            this.labAddNewRoom.Size = new System.Drawing.Size(193, 43);
            this.labAddNewRoom.TabIndex = 0;
            this.labAddNewRoom.Text = "Quản lý phòng";
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataTable.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTable.ColumnHeadersHeight = 25;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soPhongDataGridViewTextBoxColumn,
            this.loaiPhongDataGridViewTextBoxColumn,
            this.soTangDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.trangThaiPhongDataGridViewTextBoxColumn,
            this.loaiGiuongDataGridViewTextBoxColumn,
            this.isAvailableDataGridViewTextBoxColumn});
            this.dataTable.DataSource = this.danhSachPhongBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dataTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataTable.Location = new System.Drawing.Point(21, 73);
            this.dataTable.Name = "dataTable";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(940, 917);
            this.dataTable.TabIndex = 1;
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
            this.dataTable.ThemeStyle.HeaderStyle.Height = 25;
            this.dataTable.ThemeStyle.ReadOnly = false;
            this.dataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataTable.ThemeStyle.RowsStyle.Height = 24;
            this.dataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // soPhongDataGridViewTextBoxColumn
            // 
            this.soPhongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soPhongDataGridViewTextBoxColumn.DataPropertyName = "soPhong";
            this.soPhongDataGridViewTextBoxColumn.HeaderText = "Số phòng";
            this.soPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soPhongDataGridViewTextBoxColumn.Name = "soPhongDataGridViewTextBoxColumn";
            this.soPhongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soPhongDataGridViewTextBoxColumn.Width = 114;
            // 
            // loaiPhongDataGridViewTextBoxColumn
            // 
            this.loaiPhongDataGridViewTextBoxColumn.DataPropertyName = "loaiPhong";
            this.loaiPhongDataGridViewTextBoxColumn.HeaderText = "Loại phòng";
            this.loaiPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiPhongDataGridViewTextBoxColumn.Name = "loaiPhongDataGridViewTextBoxColumn";
            // 
            // soTangDataGridViewTextBoxColumn
            // 
            this.soTangDataGridViewTextBoxColumn.DataPropertyName = "soTang";
            this.soTangDataGridViewTextBoxColumn.HeaderText = "Tầng";
            this.soTangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTangDataGridViewTextBoxColumn.Name = "soTangDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá phòng";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // trangThaiPhongDataGridViewTextBoxColumn
            // 
            this.trangThaiPhongDataGridViewTextBoxColumn.DataPropertyName = "trangThaiPhong";
            this.trangThaiPhongDataGridViewTextBoxColumn.HeaderText = "Trạng thái phòng";
            this.trangThaiPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiPhongDataGridViewTextBoxColumn.Name = "trangThaiPhongDataGridViewTextBoxColumn";
            // 
            // loaiGiuongDataGridViewTextBoxColumn
            // 
            this.loaiGiuongDataGridViewTextBoxColumn.DataPropertyName = "loaiGiuong";
            this.loaiGiuongDataGridViewTextBoxColumn.HeaderText = "Loại giường";
            this.loaiGiuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiGiuongDataGridViewTextBoxColumn.Name = "loaiGiuongDataGridViewTextBoxColumn";
            // 
            // isAvailableDataGridViewTextBoxColumn
            // 
            this.isAvailableDataGridViewTextBoxColumn.DataPropertyName = "isAvailable";
            this.isAvailableDataGridViewTextBoxColumn.HeaderText = "Trạng thái thuê";
            this.isAvailableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isAvailableDataGridViewTextBoxColumn.Name = "isAvailableDataGridViewTextBoxColumn";
            // 
            // danhSachPhongBindingSource1
            // 
            this.danhSachPhongBindingSource1.DataMember = "danhSachPhong";
            this.danhSachPhongBindingSource1.DataSource = this.projectDataDataSet1BindingSource;
            // 
            // projectDataDataSet1BindingSource
            // 
            this.projectDataDataSet1BindingSource.DataSource = this.projectDataDataSet1;
            this.projectDataDataSet1BindingSource.Position = 0;
            // 
            // projectDataDataSet1
            // 
            this.projectDataDataSet1.DataSetName = "ProjectDataDataSet1";
            this.projectDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(76)))), ((int)(((byte)(173)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.btnFindAndEdit);
            this.guna2Panel2.Controls.Add(this.btnXoaPhong);
            this.guna2Panel2.Controls.Add(this.btnThemPhong);
            this.guna2Panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.guna2Panel2.Location = new System.Drawing.Point(1003, 73);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(537, 99);
            this.guna2Panel2.TabIndex = 20;
            // 
            // btnFindAndEdit
            // 
            this.btnFindAndEdit.BorderRadius = 15;
            this.btnFindAndEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindAndEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindAndEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindAndEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindAndEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(160)))), ((int)(((byte)(251)))));
            this.btnFindAndEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAndEdit.ForeColor = System.Drawing.Color.White;
            this.btnFindAndEdit.Location = new System.Drawing.Point(383, 20);
            this.btnFindAndEdit.Name = "btnFindAndEdit";
            this.btnFindAndEdit.Size = new System.Drawing.Size(139, 64);
            this.btnFindAndEdit.TabIndex = 2;
            this.btnFindAndEdit.Text = "Tìm kiếm cập nhật";
            this.btnFindAndEdit.Click += new System.EventHandler(this.btnFindAndEdit_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BorderRadius = 15;
            this.btnXoaPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(160)))), ((int)(((byte)(251)))));
            this.btnXoaPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhong.Location = new System.Drawing.Point(201, 20);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(139, 64);
            this.btnXoaPhong.TabIndex = 1;
            this.btnXoaPhong.Text = "Xóa phòng";
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            uc_XoaPhong1.RoomDeleted += uc_XoaPhong1_RoomDeleted;
            uc_XoaPhong1.RoomSearched += uc_XoaPhong1_changeTable;

            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BorderRadius = 15;
            this.btnThemPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(160)))), ((int)(((byte)(251)))));
            this.btnThemPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.ForeColor = System.Drawing.Color.White;
            this.btnThemPhong.Location = new System.Drawing.Point(19, 20);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(139, 64);
            this.btnThemPhong.TabIndex = 0;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.uc_TimKiemChinhSua1);
            this.guna2Panel1.Controls.Add(this.uc_XoaPhong1);
            this.guna2Panel1.Controls.Add(this.uc_ThemPhongMoi1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.guna2Panel1.Location = new System.Drawing.Point(984, 207);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(553, 714);
            this.guna2Panel1.TabIndex = 19;
            // 
            // danhSachPhongTableAdapter1
            // 
            this.danhSachPhongTableAdapter1.ClearBeforeFill = true;
            // 
            // uc_TimKiemChinhSua1
            // 
            this.uc_TimKiemChinhSua1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.uc_TimKiemChinhSua1.Location = new System.Drawing.Point(19, 14);
            this.uc_TimKiemChinhSua1.Name = "uc_TimKiemChinhSua1";
            this.uc_TimKiemChinhSua1.Size = new System.Drawing.Size(512, 680);
            this.uc_TimKiemChinhSua1.TabIndex = 2;
            this.uc_TimKiemChinhSua1.Visible = false;
            uc_TimKiemChinhSua1.RoomSearched += uc_TimKiemChinhSua1_RoomSearch;
            uc_TimKiemChinhSua1.EditRoom += uc_TimKiemChinhSua1_EditRoom;
            // 
            // uc_XoaPhong1
            // 
            this.uc_XoaPhong1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.uc_XoaPhong1.Location = new System.Drawing.Point(31, 13);
            this.uc_XoaPhong1.Name = "uc_XoaPhong1";
            this.uc_XoaPhong1.Size = new System.Drawing.Size(500, 360);
            this.uc_XoaPhong1.TabIndex = 1;
            this.uc_XoaPhong1.Visible = false;
            // 
            // uc_ThemPhongMoi1
            // 
            this.uc_ThemPhongMoi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.uc_ThemPhongMoi1.Location = new System.Drawing.Point(19, 13);
            this.uc_ThemPhongMoi1.Name = "uc_ThemPhongMoi1";
            this.uc_ThemPhongMoi1.Size = new System.Drawing.Size(512, 681);
            this.uc_ThemPhongMoi1.TabIndex = 0;
            this.uc_ThemPhongMoi1.Visible = false;
            uc_ThemPhongMoi1.RoomAdded += uc_ThemPhongMoi1_RoomAdded;
            // 
            // uc_AddNewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.labAddNewRoom);
            this.Name = "uc_AddNewRoom";
            this.Size = new System.Drawing.Size(1552, 1018);
            this.Load += new System.EventHandler(this.uc_AddNewRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachPhongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labAddNewRoom;
        private Guna.UI2.WinForms.Guna2DataGridView dataTable;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnFindAndEdit;
        private Guna.UI2.WinForms.Guna2Button btnXoaPhong;
        private Guna.UI2.WinForms.Guna2Button btnThemPhong;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private uc_ThemPhongMoi uc_ThemPhongMoi1;
        private uc_XoaPhong uc_XoaPhong1;
        private uc_TimKiemChinhSua uc_TimKiemChinhSua1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiGiuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource danhSachPhongBindingSource1;
        private System.Windows.Forms.BindingSource projectDataDataSet1BindingSource;
        private ProjectDataDataSet1 projectDataDataSet1;
        private ProjectDataDataSet1TableAdapters.danhSachPhongTableAdapter danhSachPhongTableAdapter1;
    }
}
