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
    public partial class frmDoiMatKhau : Form
    {
        HandleXML handleXML = new HandleXML();
        MatKhau matKhau = new MatKhau();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public void SetMaNguoiDung(string maNguoiDung)
        {
            lbMaNguoiDung.Text = maNguoiDung;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String matKhauCu = tbOldPassword.Text;
            String matKhauMoi = tbNewPassword.Text;
            String matKhauMoiXacNhan = tbConfirmNewPassword.Text;

            if (matKhauCu.Trim() == "" || matKhauMoi.Trim() == "" || matKhauMoiXacNhan.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }

            if (!handleXML.LayGiaTri("NguoiDung.xml", "MaNguoiDung", lbMaNguoiDung.Text, "MatKhau").Equals(matKhauCu))
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
                bool result = matKhau.DoiMatKhau(lbMaNguoiDung.Text, matKhauMoi);

                if (result)
                    MessageBox.Show("Đổi mật khẩu thành công");
                else
                    MessageBox.Show("Đổi mật khẩu thất bại");

                Close();
            }
            else
            {
                tbOldPassword.Text = "";
                tbNewPassword.Text = "";
                tbConfirmNewPassword.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
