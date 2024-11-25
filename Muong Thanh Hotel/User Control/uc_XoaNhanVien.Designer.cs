namespace Muong_Thanh_Hotel.User_Control
{
    partial class uc_XoaNhanVien
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.lblConfirm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.lblNhapThongTin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnXoa);
            this.guna2Panel1.Controls.Add(this.lblConfirm);
            this.guna2Panel1.Controls.Add(this.btnFind);
            this.guna2Panel1.Controls.Add(this.lblNhapThongTin);
            this.guna2Panel1.Controls.Add(this.txtCCD);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.guna2Panel1.Location = new System.Drawing.Point(20, 66);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(439, 353);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderColor = System.Drawing.Color.Red;
            this.btnXoa.BorderRadius = 17;
            this.btnXoa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(248, 213);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(183, 37);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xác nhận xóa";
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblConfirm.Location = new System.Drawing.Point(27, 137);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(376, 25);
            this.lblConfirm.TabIndex = 40;
            this.lblConfirm.Text = "Vui lòng kiểm tra lại thông tin nhân viên cần xóa";
            this.lblConfirm.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.AutoRoundedCorners = true;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BorderRadius = 16;
            this.btnFind.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnFind.BorderThickness = 1;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(298, 79);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(124, 34);
            this.btnFind.TabIndex = 39;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblNhapThongTin
            // 
            this.lblNhapThongTin.BackColor = System.Drawing.Color.Transparent;
            this.lblNhapThongTin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapThongTin.Location = new System.Drawing.Point(43, 14);
            this.lblNhapThongTin.Name = "lblNhapThongTin";
            this.lblNhapThongTin.Size = new System.Drawing.Size(360, 33);
            this.lblNhapThongTin.TabIndex = 38;
            this.lblNhapThongTin.Text = "Loại bỏ nhân viên khỏi danh sách";
            this.lblNhapThongTin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCCD
            // 
            this.txtCCD.AutoRoundedCorners = true;
            this.txtCCD.BorderColor = System.Drawing.Color.Black;
            this.txtCCD.BorderRadius = 16;
            this.txtCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCD.DefaultText = "";
            this.txtCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCD.Location = new System.Drawing.Point(16, 78);
            this.txtCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCCD.Name = "txtCCD";
            this.txtCCD.PasswordChar = '\0';
            this.txtCCD.PlaceholderText = "CCCD nhân viên cần xóa";
            this.txtCCD.SelectedText = "";
            this.txtCCD.Size = new System.Drawing.Size(253, 35);
            this.txtCCD.TabIndex = 36;
            this.txtCCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // uc_XoaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "uc_XoaNhanVien";
            this.Size = new System.Drawing.Size(487, 691);
            this.Load += new System.EventHandler(this.uc_XoaNhanVien_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNhapThongTin;
        private Guna.UI2.WinForms.Guna2TextBox txtCCD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirm;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
