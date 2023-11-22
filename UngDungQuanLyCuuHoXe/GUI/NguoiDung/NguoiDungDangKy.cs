using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungQuanLyCuuHoXe.Class;
using UngDungQuanLyCuuHoXe.Class.NguoiDung;

namespace UngDungQuanLyCuuHoXe.GUI.NguoiDung
{
    public partial class NguoiDungDangKy : Form
    {
        HandleXML handleXML = new HandleXML();
        DangKy dangky = new DangKy();
        public NguoiDungDangKy()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (dangky.KiemTra(tbUsername.Text) == true)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
            }
            else
            {
                dangky.Them(tbUsername.Text, tbPassword.Text, tbHoTen.Text, tbDiaChi.Text, tbSoDienThoai.Text, tbEmail.Text, 1);
                MessageBox.Show("Đăng ký tài khoản thành công!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
