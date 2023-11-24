
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaPhuongTien = new System.Windows.Forms.TextBox();
            this.lbMaNguoiDung = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLoaiPhuongTien
            // 
            this.tbLoaiPhuongTien.Location = new System.Drawing.Point(209, 153);
            this.tbLoaiPhuongTien.Name = "tbLoaiPhuongTien";
            this.tbLoaiPhuongTien.Size = new System.Drawing.Size(169, 22);
            this.tbLoaiPhuongTien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại phương tiện:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên phương tiện:";
            // 
            // tbTenPhuongTien
            // 
            this.tbTenPhuongTien.Location = new System.Drawing.Point(209, 202);
            this.tbTenPhuongTien.Name = "tbTenPhuongTien";
            this.tbTenPhuongTien.Size = new System.Drawing.Size(169, 22);
            this.tbTenPhuongTien.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biển số xe:";
            // 
            // tbBienSoXe
            // 
            this.tbBienSoXe.Location = new System.Drawing.Point(209, 253);
            this.tbBienSoXe.Name = "tbBienSoXe";
            this.tbBienSoXe.Size = new System.Drawing.Size(169, 22);
            this.tbBienSoXe.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(191, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(345, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvPhuongTien
            // 
            this.dgvPhuongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuongTien.Location = new System.Drawing.Point(438, 112);
            this.dgvPhuongTien.Name = "dgvPhuongTien";
            this.dgvPhuongTien.RowHeadersWidth = 51;
            this.dgvPhuongTien.RowTemplate.Height = 24;
            this.dgvPhuongTien.Size = new System.Drawing.Size(487, 163);
            this.dgvPhuongTien.TabIndex = 9;
            this.dgvPhuongTien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuongTien_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vị trí:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 390);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(706, 55);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mô tả vấn đề:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 472);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(706, 55);
            this.textBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã phương tiện:";
            // 
            // tbMaPhuongTien
            // 
            this.tbMaPhuongTien.Location = new System.Drawing.Point(209, 111);
            this.tbMaPhuongTien.Name = "tbMaPhuongTien";
            this.tbMaPhuongTien.Size = new System.Drawing.Size(169, 22);
            this.tbMaPhuongTien.TabIndex = 16;
            // 
            // lbMaNguoiDung
            // 
            this.lbMaNguoiDung.AutoSize = true;
            this.lbMaNguoiDung.Location = new System.Drawing.Point(55, 66);
            this.lbMaNguoiDung.Name = "lbMaNguoiDung";
            this.lbMaNguoiDung.Size = new System.Drawing.Size(21, 17);
            this.lbMaNguoiDung.TabIndex = 18;
            this.lbMaNguoiDung.Text = "ID";
            this.lbMaNguoiDung.Visible = false;
            // 
            // frmYeuCauCuuHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 591);
            this.Controls.Add(this.lbMaNguoiDung);
            this.Controls.Add(this.tbMaPhuongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaPhuongTien;
        private System.Windows.Forms.Label lbMaNguoiDung;
    }
}