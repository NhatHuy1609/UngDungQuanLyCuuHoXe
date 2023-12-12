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
using UngDungQuanLyCuuHoXe.GUI.NguoiDung;

namespace UngDungQuanLyCuuHoXe.GUI
{
    public partial class frmNguoiDung : Form
    {
        HandleXML handleXML = new HandleXML();
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        public string GetMaNguoiDung()
        {
            return lbMaNguoiDung.Text;
        }

        private void showUserInformationView(string name = "", string role = "", string id = "")
        {
            lbUserName.Text = name;
            lbUserRole.Text = role;
            lbMaNguoiDung.Text = id;
        }

        private void authorizedView(bool isSignIn)
        {
            tabTaiKhoan.Enabled = !isSignIn;
            tabQuanLiNguoiDung.Enabled = isSignIn;
            tabCuuHo.Enabled = isSignIn;

            panelSignIn.Visible = !isSignIn;
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            authorizedView(false);
            showUserInformationView();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            DataTable nguoiDungTable = handleXML.LayDuLieuXML("NguoiDung.xml");

            string username = tbUsername.Text.Trim().ToString();
            string password = tbPassword.Text.Trim().ToString();

            DataRow[] foundRows = nguoiDungTable.Select($"TenDangNhap = '{username}' AND MatKhau = '{password}' AND MaQuyen = {1}");
            if(foundRows.Length > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                authorizedView(true);
                lbUserName.Text = tbUsername.Text;
                showUserInformationView(foundRows[0]["Hoten"].ToString(), "Người dùng", foundRows[0]["MaNguoiDung"].ToString());

                tbUsername.Text = "";
                tbPassword.Text = "";
            } else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                authorizedView(false);
            }
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            authorizedView(false);

            lbUserName.Text = "";
            lbUserRole.Text = "";
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            NguoiDungDangKy frm = new NguoiDungDangKy();
            frm.ShowDialog();
        }

        private void subTabDangKy_Click(object sender, EventArgs e)
        {
            NguoiDungDangKy frm = new NguoiDungDangKy();
            frm.ShowDialog();
        }

        private void tabCuuHo_Click(object sender, EventArgs e)
        {
        }

        private void gửiYêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYeuCauCuuHo frm = new frmYeuCauCuuHo();
            frm.SetMaNguoiDung(GetMaNguoiDung());
            frm.ShowDialog();
        }

        private void sQLXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    HT.TaoXML();
            //    MessageBox.Show("Tạo XML thành công");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("" + ex);
            //}
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.SetMaNguoiDung(GetMaNguoiDung());
            frm.ShowDialog();
        }
    }
}
