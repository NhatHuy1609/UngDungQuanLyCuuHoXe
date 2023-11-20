
namespace UngDungQuanLyCuuHoXe.GUI.Admin
{
    partial class frmAdminDoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.dangNhapBtn = new System.Windows.Forms.Button();
            this.tbMatKhauCu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMatKhauMoiXacNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dangNhapBtn
            // 
            this.dangNhapBtn.BackColor = System.Drawing.Color.Tomato;
            this.dangNhapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dangNhapBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dangNhapBtn.Location = new System.Drawing.Point(448, 359);
            this.dangNhapBtn.Name = "dangNhapBtn";
            this.dangNhapBtn.Size = new System.Drawing.Size(196, 59);
            this.dangNhapBtn.TabIndex = 18;
            this.dangNhapBtn.Text = "Hủy";
            this.dangNhapBtn.UseVisualStyleBackColor = false;
            // 
            // tbMatKhauCu
            // 
            this.tbMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMatKhauCu.Location = new System.Drawing.Point(349, 140);
            this.tbMatKhauCu.Name = "tbMatKhauCu";
            this.tbMatKhauCu.Size = new System.Drawing.Size(315, 35);
            this.tbMatKhauCu.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(72, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mật khẩu cũ:";
            // 
            // tbMatKhauMoi
            // 
            this.tbMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMatKhauMoi.Location = new System.Drawing.Point(349, 203);
            this.tbMatKhauMoi.Name = "tbMatKhauMoi";
            this.tbMatKhauMoi.Size = new System.Drawing.Size(315, 35);
            this.tbMatKhauMoi.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(72, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // tbMatKhauMoiXacNhan
            // 
            this.tbMatKhauMoiXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMatKhauMoiXacNhan.Location = new System.Drawing.Point(349, 272);
            this.tbMatKhauMoiXacNhan.Name = "tbMatKhauMoiXacNhan";
            this.tbMatKhauMoiXacNhan.Size = new System.Drawing.Size(315, 35);
            this.tbMatKhauMoiXacNhan.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(72, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(165, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 59);
            this.button1.TabIndex = 23;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAdminDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMatKhauMoiXacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMatKhauMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dangNhapBtn);
            this.Controls.Add(this.tbMatKhauCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminDoiMatKhau";
            this.Text = "frmAdminDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button dangNhapBtn;
        internal System.Windows.Forms.TextBox tbMatKhauCu;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox tbMatKhauMoi;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox tbMatKhauMoiXacNhan;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button button1;
    }
}