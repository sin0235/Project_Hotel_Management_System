namespace Muong_Thanh_Hotel.User_Control
{
    partial class uc_QuanLiNhanVien
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
            this.dataTableOfEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblQuanLINhanVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlFunc = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFindAndEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemNV = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.uc_SearchEdit1 = new Muong_Thanh_Hotel.User_Control.uc_SearchEdit();
            this.uc_XoaNhanVien1 = new Muong_Thanh_Hotel.User_Control.uc_XoaNhanVien();
            this.uc_ThemNhanVien1 = new Muong_Thanh_Hotel.User_Control.uc_ThemNhanVien();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.projectDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataDataSet1 = new Muong_Thanh_Hotel.ProjectDataDataSet1();
            this.danhSachNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhSachNhanVienTableAdapter = new Muong_Thanh_Hotel.ProjectDataDataSet1TableAdapters.danhSachNhanVienTableAdapter();
            this.cCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySInhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quocTichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOfEmployee)).BeginInit();
            this.pnlFunc.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
        
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableOfEmployee
            // 
            this.dataTableOfEmployee.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dataTableOfEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTableOfEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataTableOfEmployee.AutoGenerateColumns = false;
            this.dataTableOfEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataTableOfEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableOfEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTableOfEmployee.ColumnHeadersHeight = 25;
            this.dataTableOfEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTableOfEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCCDDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySInhDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.quocTichDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn});
            this.dataTableOfEmployee.DataSource = this.danhSachNhanVienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableOfEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTableOfEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dataTableOfEmployee.Location = new System.Drawing.Point(14, 64);
            this.dataTableOfEmployee.Name = "dataTableOfEmployee";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableOfEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTableOfEmployee.RowHeadersVisible = false;
            this.dataTableOfEmployee.RowHeadersWidth = 51;
            this.dataTableOfEmployee.RowTemplate.Height = 24;
            this.dataTableOfEmployee.Size = new System.Drawing.Size(940, 929);
            this.dataTableOfEmployee.TabIndex = 22;
            this.dataTableOfEmployee.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dataTableOfEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dataTableOfEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTableOfEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTableOfEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTableOfEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTableOfEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTableOfEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dataTableOfEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dataTableOfEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTableOfEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTableOfEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTableOfEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTableOfEmployee.ThemeStyle.HeaderStyle.Height = 25;
            this.dataTableOfEmployee.ThemeStyle.ReadOnly = false;
            this.dataTableOfEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dataTableOfEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTableOfEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTableOfEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataTableOfEmployee.ThemeStyle.RowsStyle.Height = 24;
            this.dataTableOfEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dataTableOfEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblQuanLINhanVien
            // 
            this.lblQuanLINhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLINhanVien.Font = new System.Drawing.Font("iCiel Cadena", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLINhanVien.Location = new System.Drawing.Point(18, 8);
            this.lblQuanLINhanVien.Name = "lblQuanLINhanVien";
            this.lblQuanLINhanVien.Size = new System.Drawing.Size(238, 43);
            this.lblQuanLINhanVien.TabIndex = 21;
            this.lblQuanLINhanVien.Text = "Quản lý nhân viên";
            // 
            // pnlFunc
            // 
            this.pnlFunc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(76)))), ((int)(((byte)(173)))));
            this.pnlFunc.BorderRadius = 10;
            this.pnlFunc.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.pnlFunc.BorderThickness = 2;
            this.pnlFunc.Controls.Add(this.btnFindAndEdit);
            this.pnlFunc.Controls.Add(this.btnXoaNhanVien);
            this.pnlFunc.Controls.Add(this.btnThemNV);
            this.pnlFunc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.pnlFunc.Location = new System.Drawing.Point(996, 64);
            this.pnlFunc.Name = "pnlFunc";
            this.pnlFunc.Size = new System.Drawing.Size(537, 99);
            this.pnlFunc.TabIndex = 24;
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
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.BorderRadius = 15;
            this.btnXoaNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(160)))), ((int)(((byte)(251)))));
            this.btnXoaNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnXoaNhanVien.Location = new System.Drawing.Point(201, 20);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(139, 64);
            this.btnXoaNhanVien.TabIndex = 1;
            this.btnXoaNhanVien.Text = "Xóa nhân viên";
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BorderRadius = 15;
            this.btnThemNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(160)))), ((int)(((byte)(251)))));
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(19, 20);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(139, 64);
            this.btnThemNV.TabIndex = 0;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Blue;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.uc_SearchEdit1);
            this.guna2Panel1.Controls.Add(this.uc_XoaNhanVien1);
            this.guna2Panel1.Controls.Add(this.uc_ThemNhanVien1);
            this.guna2Panel1.Location = new System.Drawing.Point(968, 185);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(573, 784);
            this.guna2Panel1.TabIndex = 25;
            // 
            // uc_SearchEdit1
            // 
            this.uc_SearchEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.uc_SearchEdit1.Location = new System.Drawing.Point(36, 18);
            this.uc_SearchEdit1.Name = "uc_SearchEdit1";
            this.uc_SearchEdit1.Size = new System.Drawing.Size(498, 691);
            this.uc_SearchEdit1.TabIndex = 2;
            this.uc_SearchEdit1.Visible = false;
            // 
            // uc_XoaNhanVien1
            // 
            this.uc_XoaNhanVien1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.uc_XoaNhanVien1.Location = new System.Drawing.Point(47, 24);
            this.uc_XoaNhanVien1.Name = "uc_XoaNhanVien1";
            this.uc_XoaNhanVien1.Size = new System.Drawing.Size(487, 691);
            this.uc_XoaNhanVien1.TabIndex = 1;
            this.uc_XoaNhanVien1.Visible = false;
            this.uc_XoaNhanVien1.Load += new System.EventHandler(this.uc_XoaNhanVien1_Load);
            // 
            // uc_ThemNhanVien1
            // 
            this.uc_ThemNhanVien1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.uc_ThemNhanVien1.Location = new System.Drawing.Point(43, 24);
            this.uc_ThemNhanVien1.Name = "uc_ThemNhanVien1";
            this.uc_ThemNhanVien1.Size = new System.Drawing.Size(491, 691);
            this.uc_ThemNhanVien1.TabIndex = 0;
            this.uc_ThemNhanVien1.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
       
            this.projectDataDataSetBindingSource.Position = 0;
            // 
            // projectDataDataSet1
            // 
            this.projectDataDataSet1.DataSetName = "ProjectDataDataSet1";
            this.projectDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhSachNhanVienBindingSource
            // 
            this.danhSachNhanVienBindingSource.DataMember = "danhSachNhanVien";
            this.danhSachNhanVienBindingSource.DataSource = this.projectDataDataSet1;
            // 
            // danhSachNhanVienTableAdapter
            // 
            this.danhSachNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // ngaySInhDataGridViewTextBoxColumn
            // 
            this.ngaySInhDataGridViewTextBoxColumn.DataPropertyName = "ngaySInh";
            this.ngaySInhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySInhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySInhDataGridViewTextBoxColumn.Name = "ngaySInhDataGridViewTextBoxColumn";
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sdtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "diaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // quocTichDataGridViewTextBoxColumn
            // 
            this.quocTichDataGridViewTextBoxColumn.DataPropertyName = "quocTich";
            this.quocTichDataGridViewTextBoxColumn.HeaderText = "Quốc tịch";
            this.quocTichDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quocTichDataGridViewTextBoxColumn.Name = "quocTichDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "hireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            // 
            // uc_QuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dataTableOfEmployee);
            this.Controls.Add(this.lblQuanLINhanVien);
            this.Controls.Add(this.pnlFunc);
            this.Name = "uc_QuanLiNhanVien";
            this.Size = new System.Drawing.Size(1552, 1018);
            this.Load += new System.EventHandler(this.uc_QuanLiNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOfEmployee)).EndInit();
            this.pnlFunc.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataTableOfEmployee;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuanLINhanVien;
        private Guna.UI2.WinForms.Guna2Panel pnlFunc;
        private Guna.UI2.WinForms.Guna2Button btnFindAndEdit;
        private Guna.UI2.WinForms.Guna2Button btnXoaNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnThemNV;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private uc_ThemNhanVien uc_ThemNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private uc_XoaNhanVien uc_XoaNhanVien1;
        private uc_SearchEdit uc_SearchEdit1;
        private System.Windows.Forms.BindingSource danhSachNhanVienBindingSource;
        private ProjectDataDataSet1 projectDataDataSet1;
        private System.Windows.Forms.BindingSource projectDataDataSetBindingSource;
        private ProjectDataDataSet1TableAdapters.danhSachNhanVienTableAdapter danhSachNhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySInhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quocTichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
    }
}
