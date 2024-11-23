namespace Muong_Thanh_Hotel.User_Control
{
    partial class uc_XoaPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.txtSoPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblConfirm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFine = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.lblConfirm);
            this.guna2Panel1.Controls.Add(this.btnFine);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnXoa);
            this.guna2Panel1.Controls.Add(this.txtSoPhong);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.guna2Panel1.Location = new System.Drawing.Point(3, 17);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(506, 674);
            this.guna2Panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 38);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nhập thông tin phòng cần xóa";
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.DefaultAutoSize = true;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.IndicateFocus = true;
            this.btnXoa.Location = new System.Drawing.Point(285, 313);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(153, 43);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa phòng";
            this.btnXoa.UseTransparentBackground = true;
            this.btnXoa.Visible = false;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.AutoRoundedCorners = true;
            this.txtSoPhong.BorderColor = System.Drawing.Color.Black;
            this.txtSoPhong.BorderRadius = 19;
            this.txtSoPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoPhong.DefaultText = "";
            this.txtSoPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSoPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Location = new System.Drawing.Point(15, 178);
            this.txtSoPhong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.PasswordChar = '\0';
            this.txtSoPhong.PlaceholderText = "Nhập vào số phòng muốn xóa";
            this.txtSoPhong.SelectedText = "";
            this.txtSoPhong.Size = new System.Drawing.Size(307, 40);
            this.txtSoPhong.TabIndex = 35;
            this.txtSoPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblConfirm
            // 
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblConfirm.Location = new System.Drawing.Point(49, 242);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(376, 25);
            this.lblConfirm.TabIndex = 42;
            this.lblConfirm.Text = "Vui lòng kiểm tra lại thông tin nhân viên cần xóa";
            this.lblConfirm.Visible = false;
            // 
            // btnFine
            // 
            this.btnFine.AutoRoundedCorners = true;
            this.btnFine.BackColor = System.Drawing.Color.Transparent;
            this.btnFine.BorderRadius = 16;
            this.btnFine.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnFine.BorderThickness = 1;
            this.btnFine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.btnFine.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFine.ForeColor = System.Drawing.Color.White;
            this.btnFine.Location = new System.Drawing.Point(341, 184);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(124, 34);
            this.btnFine.TabIndex = 41;
            this.btnFine.Text = "Find";
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // uc_XoaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "uc_XoaPhong";
            this.Size = new System.Drawing.Size(512, 680);
            this.Load += new System.EventHandler(this.uc_XoaPhong_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSoPhong;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirm;
        private Guna.UI2.WinForms.Guna2Button btnFine;
    }
}
