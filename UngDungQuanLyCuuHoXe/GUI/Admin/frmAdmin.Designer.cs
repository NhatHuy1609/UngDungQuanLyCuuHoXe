
namespace UngDungQuanLyCuuHoXe.GUI
{
    partial class frmAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhươngTiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCứuHộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roleUserLabel = new System.Windows.Forms.Label();
            this.nameUserLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbSignIn = new System.Windows.Forms.GroupBox();
            this.dangNhapBtn = new System.Windows.Forms.Button();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelBanner = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýNgườiDùngToolStripMenuItem,
            this.quảnLýCứuHộToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.chuyểnĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNgườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNgườiDùngToolStripMenuItem,
            this.thôngTinPhươngTiệnToolStripMenuItem});
            this.quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            this.quảnLýNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý người dùng";
            this.quảnLýNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgườiDùngToolStripMenuItem_Click);
            // 
            // thôngTinNgườiDùngToolStripMenuItem
            // 
            this.thôngTinNgườiDùngToolStripMenuItem.Name = "thôngTinNgườiDùngToolStripMenuItem";
            this.thôngTinNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.thôngTinNgườiDùngToolStripMenuItem.Text = "Thông tin người dùng";
            this.thôngTinNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNgườiDùngToolStripMenuItem_Click);
            // 
            // thôngTinPhươngTiệnToolStripMenuItem
            // 
            this.thôngTinPhươngTiệnToolStripMenuItem.Name = "thôngTinPhươngTiệnToolStripMenuItem";
            this.thôngTinPhươngTiệnToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.thôngTinPhươngTiệnToolStripMenuItem.Text = "Thông tin phương tiện";
            this.thôngTinPhươngTiệnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinPhươngTiệnToolStripMenuItem_Click);
            // 
            // quảnLýCứuHộToolStripMenuItem
            // 
            this.quảnLýCứuHộToolStripMenuItem.Name = "quảnLýCứuHộToolStripMenuItem";
            this.quảnLýCứuHộToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.quảnLýCứuHộToolStripMenuItem.Text = "Quản lý cứu hộ";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // chuyểnĐổiToolStripMenuItem
            // 
            this.chuyểnĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLSQLToolStripMenuItem});
            this.chuyểnĐổiToolStripMenuItem.Name = "chuyểnĐổiToolStripMenuItem";
            this.chuyểnĐổiToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.chuyểnĐổiToolStripMenuItem.Text = "Chuyển đổi";
            // 
            // xMLSQLToolStripMenuItem
            // 
            this.xMLSQLToolStripMenuItem.Name = "xMLSQLToolStripMenuItem";
            this.xMLSQLToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.xMLSQLToolStripMenuItem.Text = "SQL -> XML";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roleUserLabel);
            this.groupBox1.Controls.Add(this.nameUserLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(958, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // roleUserLabel
            // 
            this.roleUserLabel.AutoSize = true;
            this.roleUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.roleUserLabel.Location = new System.Drawing.Point(180, 91);
            this.roleUserLabel.Name = "roleUserLabel";
            this.roleUserLabel.Size = new System.Drawing.Size(60, 22);
            this.roleUserLabel.TabIndex = 3;
            this.roleUserLabel.Text = "Admin";
            // 
            // nameUserLabel
            // 
            this.nameUserLabel.AutoSize = true;
            this.nameUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameUserLabel.Location = new System.Drawing.Point(106, 41);
            this.nameUserLabel.Name = "nameUserLabel";
            this.nameUserLabel.Size = new System.Drawing.Size(173, 22);
            this.nameUserLabel.TabIndex = 2;
            this.nameUserLabel.Text = "Phạm Văn Nhật Huy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quyền tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UngDungQuanLyCuuHoXe.Properties.Resources.car_repair;
            this.panel1.Controls.Add(this.grbSignIn);
            this.panel1.Controls.Add(this.labelBanner);
            this.panel1.Location = new System.Drawing.Point(12, 185);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 375);
            this.panel1.TabIndex = 2;
            // 
            // grbSignIn
            // 
            this.grbSignIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbSignIn.Controls.Add(this.dangNhapBtn);
            this.grbSignIn.Controls.Add(this.tbMatKhau);
            this.grbSignIn.Controls.Add(this.tbTaiKhoan);
            this.grbSignIn.Controls.Add(this.label4);
            this.grbSignIn.Controls.Add(this.label5);
            this.grbSignIn.Location = new System.Drawing.Point(184, 102);
            this.grbSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSignIn.Name = "grbSignIn";
            this.grbSignIn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSignIn.Size = new System.Drawing.Size(626, 239);
            this.grbSignIn.TabIndex = 14;
            this.grbSignIn.TabStop = false;
            // 
            // dangNhapBtn
            // 
            this.dangNhapBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.dangNhapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dangNhapBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dangNhapBtn.Location = new System.Drawing.Point(198, 165);
            this.dangNhapBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dangNhapBtn.Name = "dangNhapBtn";
            this.dangNhapBtn.Size = new System.Drawing.Size(269, 59);
            this.dangNhapBtn.TabIndex = 13;
            this.dangNhapBtn.Text = "Đăng nhập";
            this.dangNhapBtn.UseVisualStyleBackColor = false;
            this.dangNhapBtn.Click += new System.EventHandler(this.dangNhapBtn_Click);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMatKhau.Location = new System.Drawing.Point(202, 106);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(314, 35);
            this.tbMatKhau.TabIndex = 12;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTaiKhoan.Location = new System.Drawing.Point(202, 29);
            this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(314, 35);
            this.tbTaiKhoan.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(71, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(71, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tài khoản:";
            // 
            // labelBanner
            // 
            this.labelBanner.AutoSize = true;
            this.labelBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBanner.ForeColor = System.Drawing.Color.Orange;
            this.labelBanner.Location = new System.Drawing.Point(302, 38);
            this.labelBanner.Name = "labelBanner";
            this.labelBanner.Size = new System.Drawing.Size(387, 46);
            this.labelBanner.TabIndex = 4;
            this.labelBanner.Text = "Đăng nhập tài khoản";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbSignIn.ResumeLayout(false);
            this.grbSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roleUserLabel;
        private System.Windows.Forms.Label nameUserLabel;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBanner;
        private System.Windows.Forms.ToolStripMenuItem chuyểnĐổiToolStripMenuItem;
        internal System.Windows.Forms.Button dangNhapBtn;
        internal System.Windows.Forms.TextBox tbMatKhau;
        internal System.Windows.Forms.TextBox tbTaiKhoan;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem xMLSQLToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbSignIn;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhươngTiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCứuHộToolStripMenuItem;
    }
}