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
    public partial class frmQuanLyNguoiDung : Form
    {
        HandleXML handleXML = new HandleXML();
        HandleNguoiDung handleNguoiDung = new HandleNguoiDung();

        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void initNguoiDungDataGridView()
        {
            DataTable nguoiDungData = new DataTable();
            nguoiDungData = handleNguoiDung.getNguoiDungFilteredData("MaQuyen", "1");
            grvNguoiDung.DataSource = nguoiDungData;
        }

        private void grvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grvNguoiDung.CurrentRow.Index;
            tbMaND.Text = grvNguoiDung.Rows[index].Cells[0].Value.ToString();
            tbTenDangNhap.Text = grvNguoiDung.Rows[index].Cells[1].Value.ToString();
            tbMatKhau.Text = grvNguoiDung.Rows[index].Cells[2].Value.ToString();
            tbHoTen.Text = grvNguoiDung.Rows[index].Cells[3].Value.ToString();
            tbDiaChi.Text = grvNguoiDung.Rows[index].Cells[4].Value.ToString();
            tbSdt.Text = grvNguoiDung.Rows[index].Cells[5].Value.ToString();
            tbEmail.Text = grvNguoiDung.Rows[index].Cells[6].Value.ToString();
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            initNguoiDungDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNguoiDung = tbMaND.Text.Trim();
            string tenDangNhap = tbTenDangNhap.Text.Trim();
            string matKhau = tbMatKhau.Text.Trim();
            string hoTen = tbHoTen.Text.Trim();
            string diaChi = tbDiaChi.Text.Trim();
            string sdt = tbSdt.Text.Trim();
            string email = tbEmail.Text.Trim();

            if (maNguoiDung == "" || tenDangNhap == "" || matKhau == "" || hoTen == "" || diaChi == "" || sdt == "" || email == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }

            if (handleNguoiDung.KiemTra("MaNguoiDung", maNguoiDung) || 
                handleNguoiDung.KiemTra("TenDangNhap", tenDangNhap) || 
                handleNguoiDung.KiemTra("MatKhau", matKhau) ||
                handleNguoiDung.KiemTra("Email", email) ||
                handleNguoiDung.KiemTra("SoDienThoai", sdt))
            {
                MessageBox.Show("Thông tin không được trùng lặp");
                return;
            }

            handleNguoiDung.ThemNguoiDung(maNguoiDung, tenDangNhap, matKhau, hoTen, diaChi, sdt, email);
            MessageBox.Show("Thêm người dùng thành công");
            initNguoiDungDataGridView();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaND.Text = "";
            tbTenDangNhap.Text = "";
            tbMatKhau.Text = "";
            tbHoTen.Text = "";
            tbDiaChi.Text = "";
            tbSdt.Text = "";
            tbEmail.Text = "";
            initNguoiDungDataGridView();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maNguoiDung = tbMaND.Text.Trim();
            string tenDangNhap = tbTenDangNhap.Text.Trim();
            string matKhau = tbMatKhau.Text.Trim();
            string hoTen = tbHoTen.Text.Trim();
            string diaChi = tbDiaChi.Text.Trim();
            string sdt = tbSdt.Text.Trim();
            string email = tbEmail.Text.Trim();

            if (maNguoiDung == "" || tenDangNhap == "" || matKhau == "" || hoTen == "" || diaChi == "" || sdt == "" || email == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }

            handleNguoiDung.CapNhatNguoiDung(maNguoiDung, tenDangNhap, matKhau, hoTen, diaChi, sdt, email);
            MessageBox.Show("Cập nhật người dùng thành công");
            initNguoiDungDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNguoiDung = tbMaND.Text.Trim();

            if (maNguoiDung == "")
            {
                MessageBox.Show("Vui lòng chọn người dùng để xóa");
                return;
            }

            handleNguoiDung.XoaNguoiDung(maNguoiDung);
            MessageBox.Show("Xóa người dùng thành công");
            initNguoiDungDataGridView();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable nguoiDungData = new DataTable();
            nguoiDungData = handleNguoiDung.getNguoiDungFilteredData("MaNguoiDung", tbTimKiem.Text.ToString().Trim());
            grvNguoiDung.DataSource = nguoiDungData;
        }

        private void tbTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            if (tbTimKiem.Text.ToString().Trim() == "")
            {
                initNguoiDungDataGridView();
            }
        }
    }
}
