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
using UngDungQuanLyCuuHoXe.Class.Admin;

namespace UngDungQuanLyCuuHoXe.GUI.Admin
{
    public partial class frmAdminDoiMatKhau : Form
    {
        HandleXML handleXML = new HandleXML();
        MatKhau matKhau = new MatKhau();

        public frmAdminDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmAdminDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            String matKhauCu = tbMatKhauCu.Text;
            String matKhauMoi = tbMatKhauMoi.Text;
            String matKhauMoiXacNhan = tbMatKhauMoiXacNhan.Text;

            if (matKhauCu.Trim() == "" || matKhauMoi.Trim() == "" || matKhauMoiXacNhan.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }

            if (!handleXML.LayGiaTri("NguoiDung.xml", "MaNguoiDung", frmAdmin.maAdmin, "MatKhau").Equals(matKhauCu))
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }

            if (matKhauMoi.Equals(matKhauCu))
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ");
                return;
            }

            if (!matKhauMoi.Equals(matKhauMoiXacNhan))
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn đổi mật khẩu không?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool result = matKhau.DoiMatKhau(frmAdmin.maAdmin, matKhauMoi);

                if (result)
                    MessageBox.Show("Đổi mật khẩu thành công");
                else
                    MessageBox.Show("Đổi mật khẩu thất bại");

                Close();
            } else
            {
                tbMatKhauCu.Text = "";
                tbMatKhauMoi.Text = "";
                tbMatKhauMoiXacNhan.Text = "";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
