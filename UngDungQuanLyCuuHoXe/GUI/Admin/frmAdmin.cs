﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungQuanLyCuuHoXe.Class;
using UngDungQuanLyCuuHoXe.GUI.Admin;

namespace UngDungQuanLyCuuHoXe.GUI
{
    public partial class frmAdmin : Form
    {
        HandleXML handleXML = new HandleXML();

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void showUserInformationView(string name = "", string role = "")
        {
            nameUserLabel.Text = name;
            roleUserLabel.Text = role;
        }

        // Cho truy cập các tính năng khác trên strip menu nếu ngươi dùng đã đăng nhập thành công
        // True: Đã đăng nhập
        // False: Chưa đăng nhập
        private void authorizeView(bool isSignedIn)
        {
            đăngNhậpToolStripMenuItem.Enabled = !isSignedIn;
            đổiMậtKhẩuToolStripMenuItem.Enabled = isSignedIn;
            đăngXuấtToolStripMenuItem.Enabled = isSignedIn;

            quảnLýNgườiDùngToolStripMenuItem.Enabled = isSignedIn;
            chuyểnĐổiToolStripMenuItem.Enabled = isSignedIn;

            string banner = "";
            if (isSignedIn)
            {
                banner = "Trang Admin";
            }
            else
            {
                banner = "Đăng nhập tài khoản";
            }

            labelBanner.Text = banner;
            grbSignIn.Visible = !isSignedIn;
        }

        private void dangNhapBtn_Click(object sender, EventArgs e)
        {
            DataTable nguoiDungTable = handleXML.LayDuLieuXML("NguoiDung.xml");

            string taikhoan = tbTaiKhoan.Text.Trim().ToString();
            string matkhau = tbMatKhau.Text.Trim().ToString();

            DataRow[] foundRows = nguoiDungTable.Select($"TenDangNhap = '{taikhoan}' AND MatKhau = '{matkhau}' AND MaQuyen = {2}");
            if (foundRows.Length > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                authorizeView(true);
                showUserInformationView(foundRows[0]["Hoten"].ToString(), "Admin");

                tbTaiKhoan.Text = "";
                tbMatKhau.Text = "";
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
                tbTaiKhoan.Text = "";
                tbMatKhau.Text = "";
                authorizeView(false);
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            authorizeView(false);
            showUserInformationView();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorizeView(false);
            showUserInformationView();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminDoiMatKhau frm = new frmAdminDoiMatKhau();
            frm.ShowDialog();
        }
    }
}