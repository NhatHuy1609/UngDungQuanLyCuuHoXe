
namespace UngDungQuanLyCuuHoXe.GUI.NguoiDung
{
    partial class frmYeuCauCuuHo
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
            this.tbLoaiPhuongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenPhuongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBienSoXe = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvPhuongTien = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbViTri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMoTaVanDe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaPhuongTien = new System.Windows.Forms.TextBox();
            this.lbMaNguoiDung = new System.Windows.Forms.Label();
            this.btnYeuCau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLoaiPhuongTien
            // 
            this.tbLoaiPhuongTien.Location = new System.Drawing.Point(235, 191);
            this.tbLoaiPhuongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLoaiPhuongTien.Name = "tbLoaiPhuongTien";
            this.tbLoaiPhuongTien.Size = new System.Drawing.Size(190, 26);
            this.tbLoaiPhuongTien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại phương tiện:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên phương tiện:";
            // 
            // tbTenPhuongTien
            // 
            this.tbTenPhuongTien.Location = new System.Drawing.Point(235, 252);
            this.tbTenPhuongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenPhuongTien.Name = "tbTenPhuongTien";
            this.tbTenPhuongTien.Size = new System.Drawing.Size(190, 26);
            this.tbTenPhuongTien.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biển số xe:";
            // 
            // tbBienSoXe
            // 
            this.tbBienSoXe.Location = new System.Drawing.Point(235, 316);
            this.tbBienSoXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBienSoXe.Name = "tbBienSoXe";
            this.tbBienSoXe.Size = new System.Drawing.Size(190, 26);
            this.tbBienSoXe.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 388);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(200, 388);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 42);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(328, 388);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 42);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvPhuongTien
            // 
            this.dgvPhuongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuongTien.Location = new System.Drawing.Point(486, 145);
            this.dgvPhuongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPhuongTien.Name = "dgvPhuongTien";
            this.dgvPhuongTien.RowHeadersWidth = 51;
            this.dgvPhuongTien.RowTemplate.Height = 24;
            this.dgvPhuongTien.Size = new System.Drawing.Size(544, 204);
            this.dgvPhuongTien.TabIndex = 9;
            this.dgvPhuongTien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuongTien_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vị trí:";
            // 
            // tbViTri
            // 
            this.tbViTri.Location = new System.Drawing.Point(200, 478);
            this.tbViTri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbViTri.Multiline = true;
            this.tbViTri.Name = "tbViTri";
            this.tbViTri.Size = new System.Drawing.Size(794, 68);
            this.tbViTri.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 588);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mô tả vấn đề:";
            // 
            // tbMoTaVanDe
            // 
            this.tbMoTaVanDe.Location = new System.Drawing.Point(200, 588);
            this.tbMoTaVanDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMoTaVanDe.Multiline = true;
            this.tbMoTaVanDe.Name = "tbMoTaVanDe";
            this.tbMoTaVanDe.Size = new System.Drawing.Size(794, 68);
            this.tbMoTaVanDe.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã phương tiện:";
            // 
            // tbMaPhuongTien
            // 
            this.tbMaPhuongTien.Location = new System.Drawing.Point(235, 139);
            this.tbMaPhuongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaPhuongTien.Name = "tbMaPhuongTien";
            this.tbMaPhuongTien.Size = new System.Drawing.Size(190, 26);
            this.tbMaPhuongTien.TabIndex = 16;
            // 
            // lbMaNguoiDung
            // 
            this.lbMaNguoiDung.AutoSize = true;
            this.lbMaNguoiDung.Location = new System.Drawing.Point(62, 82);
            this.lbMaNguoiDung.Name = "lbMaNguoiDung";
            this.lbMaNguoiDung.Size = new System.Drawing.Size(26, 20);
            this.lbMaNguoiDung.TabIndex = 18;
            this.lbMaNguoiDung.Text = "ID";
            this.lbMaNguoiDung.Visible = false;
            // 
            // btnYeuCau
            // 
            this.btnYeuCau.Location = new System.Drawing.Point(440, 678);
            this.btnYeuCau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYeuCau.Name = "btnYeuCau";
            this.btnYeuCau.Size = new System.Drawing.Size(159, 42);
            this.btnYeuCau.TabIndex = 19;
            this.btnYeuCau.Text = "Gửi yêu cầu";
            this.btnYeuCau.UseVisualStyleBackColor = true;
            this.btnYeuCau.Click += new System.EventHandler(this.btnYeuCau_Click);
            // 
            // frmYeuCauCuuHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 788);
            this.Controls.Add(this.btnYeuCau);
            this.Controls.Add(this.lbMaNguoiDung);
            this.Controls.Add(this.tbMaPhuongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMoTaVanDe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbViTri);
            this.Controls.Add(this.dgvPhuongTien);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBienSoXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTenPhuongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLoaiPhuongTien);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmYeuCauCuuHo";
            this.Text = "frmYeuCauCuuHo";
            this.Load += new System.EventHandler(this.frmYeuCauCuuHo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoaiPhuongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenPhuongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBienSoXe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvPhuongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbViTri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMoTaVanDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaPhuongTien;
        private System.Windows.Forms.Label lbMaNguoiDung;
        private System.Windows.Forms.Button btnYeuCau;
    }
}