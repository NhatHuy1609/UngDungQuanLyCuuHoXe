
namespace UngDungQuanLyCuuHoXe
{
    partial class TrangChu
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
            this.Label3 = new System.Windows.Forms.Label();
            this.adminBtn = new System.Windows.Forms.Button();
            this.btnNguoiDung = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(367, 80);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(0, 17);
            this.Label3.TabIndex = 30;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adminBtn.Location = new System.Drawing.Point(391, 297);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(224, 59);
            this.adminBtn.TabIndex = 28;
            this.adminBtn.Text = "Trang admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNguoiDung.Location = new System.Drawing.Point(391, 185);
            this.btnNguoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(224, 59);
            this.btnNguoiDung.TabIndex = 27;
            this.btnNguoiDung.Text = "Trang người dùng";
            this.btnNguoiDung.UseVisualStyleBackColor = false;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Orange;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(263, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(472, 46);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "ỨNG DỤNG CỨU HỘ XE";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::UngDungQuanLyCuuHoXe.Properties.Resources.car_repair;
            this.ClientSize = new System.Drawing.Size(949, 501);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.btnNguoiDung);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrangChu";
            this.Text = "Trang chu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button adminBtn;
        internal System.Windows.Forms.Button btnNguoiDung;
        internal System.Windows.Forms.Label Label1;
    }
}