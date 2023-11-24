
namespace UngDungQuanLyCuuHoXe.GUI.Admin
{
    partial class frmQuanLyPhuongTienNguoiDung
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.grvPhuongTien = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbMaND = new System.Windows.Forms.TextBox();
            this.tbBienSo = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbLoai = new System.Windows.Forms.TextBox();
            this.tbMaPT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.labelHoten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhuongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(950, 381);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(131, 46);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTimKiem.Location = new System.Drawing.Point(643, 387);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(268, 30);
            this.tbTimKiem.TabIndex = 44;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // grvPhuongTien
            // 
            this.grvPhuongTien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grvPhuongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPhuongTien.Location = new System.Drawing.Point(56, 444);
            this.grvPhuongTien.Name = "grvPhuongTien";
            this.grvPhuongTien.RowHeadersWidth = 62;
            this.grvPhuongTien.RowTemplate.Height = 28;
            this.grvPhuongTien.Size = new System.Drawing.Size(1080, 222);
            this.grvPhuongTien.TabIndex = 42;
            this.grvPhuongTien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPhuongTien_CellContentClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLamMoi.Location = new System.Drawing.Point(643, 316);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(131, 46);
            this.btnLamMoi.TabIndex = 41;
            this.btnLamMoi.Text = "Làm mới form";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(470, 316);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 46);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.Location = new System.Drawing.Point(299, 316);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(131, 46);
            this.btnCapNhat.TabIndex = 39;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(127, 316);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 46);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbMaND
            // 
            this.tbMaND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMaND.Location = new System.Drawing.Point(847, 172);
            this.tbMaND.Name = "tbMaND";
            this.tbMaND.Size = new System.Drawing.Size(268, 30);
            this.tbMaND.TabIndex = 36;
            // 
            // tbBienSo
            // 
            this.tbBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBienSo.Location = new System.Drawing.Point(847, 116);
            this.tbBienSo.Name = "tbBienSo";
            this.tbBienSo.Size = new System.Drawing.Size(268, 30);
            this.tbBienSo.TabIndex = 35;
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTen.Location = new System.Drawing.Point(333, 223);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(268, 30);
            this.tbTen.TabIndex = 33;
            // 
            // tbLoai
            // 
            this.tbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLoai.Location = new System.Drawing.Point(333, 172);
            this.tbLoai.Name = "tbLoai";
            this.tbLoai.Size = new System.Drawing.Size(268, 30);
            this.tbLoai.TabIndex = 32;
            // 
            // tbMaPT
            // 
            this.tbMaPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMaPT.Location = new System.Drawing.Point(333, 116);
            this.tbMaPT.Name = "tbMaPT";
            this.tbMaPT.Size = new System.Drawing.Size(268, 30);
            this.tbMaPT.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Wheat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(675, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mã người dùng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Wheat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(675, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Biển số:";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.BackColor = System.Drawing.Color.Wheat;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTenDangNhap.Location = new System.Drawing.Point(122, 223);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(160, 25);
            this.lbTenDangNhap.TabIndex = 26;
            this.lbTenDangNhap.Text = "Tên phương tiện:";
            // 
            // labelHoten
            // 
            this.labelHoten.AutoSize = true;
            this.labelHoten.BackColor = System.Drawing.Color.Wheat;
            this.labelHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHoten.Location = new System.Drawing.Point(122, 172);
            this.labelHoten.Name = "labelHoten";
            this.labelHoten.Size = new System.Drawing.Size(162, 25);
            this.labelHoten.TabIndex = 25;
            this.labelHoten.Text = "Loại phương tiện:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(122, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã phương tiện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(292, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "QUẢN LÝ PHƯƠNG TIỆN NGƯỜI DÙNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(294, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tìm kiếm:";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã phương tiện",
            "Loại phương tiện",
            "Tên phương tiện",
            "Biển số",
            "Mã người dùng"});
            this.cbTimKiem.Location = new System.Drawing.Point(397, 384);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(204, 33);
            this.cbTimKiem.TabIndex = 47;
            // 
            // frmQuanLyPhuongTienNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UngDungQuanLyCuuHoXe.Properties.Resources.background_admin;
            this.ClientSize = new System.Drawing.Size(1195, 678);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.grvPhuongTien);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbMaND);
            this.Controls.Add(this.tbBienSo);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbLoai);
            this.Controls.Add(this.tbMaPT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.labelHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyPhuongTienNguoiDung";
            this.Text = "frmQuanLyPhuongTienNguoiDung";
            this.Load += new System.EventHandler(this.frmQuanLyPhuongTienNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvPhuongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.DataGridView grvPhuongTien;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbMaND;
        private System.Windows.Forms.TextBox tbBienSo;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbLoai;
        private System.Windows.Forms.TextBox tbMaPT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label labelHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTimKiem;
    }
}