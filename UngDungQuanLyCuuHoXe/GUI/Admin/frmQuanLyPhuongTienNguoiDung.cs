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
    public partial class frmQuanLyPhuongTienNguoiDung : Form
    {
        HandleXML handleXML = new HandleXML();
        HandlePhuongTien handlePhuongTien = new HandlePhuongTien();
        Dictionary<string, string> category = new Dictionary<string, string>();

        public frmQuanLyPhuongTienNguoiDung()
        {
            InitializeComponent();
        }

        private void initPhuongTienDataGridView()
        {
            DataTable phuongTienData = new DataTable();
            phuongTienData = handleXML.LayDuLieuXML("PhuongTien.xml");
            grvPhuongTien.DataSource = phuongTienData;
        }

        private void frmQuanLyPhuongTienNguoiDung_Load(object sender, EventArgs e)
        {
            initPhuongTienDataGridView();
            cbTimKiem.SelectedIndex = 0;

            category.Add("Mã phương tiện", "MaPhuongTien");
            category.Add("Loại phương tiện", "LoaiPhuongTien");
            category.Add("Tên phương tiện", "TenPhuongTien");
            category.Add("Biển số", "BienSo");
            category.Add("Mã người dùng", "MaNguoiDung");
        }

        private void grvPhuongTien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grvPhuongTien.CurrentRow.Index;
            tbMaPT.Text = grvPhuongTien.Rows[index].Cells[0].Value.ToString();
            tbLoai.Text = grvPhuongTien.Rows[index].Cells[1].Value.ToString();
            tbTen.Text = grvPhuongTien.Rows[index].Cells[2].Value.ToString();
            tbBienSo.Text = grvPhuongTien.Rows[index].Cells[3].Value.ToString();
            tbMaND.Text = grvPhuongTien.Rows[index].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhuongTien = tbMaPT.Text.Trim();
            string loai = tbLoai.Text.Trim();
            string ten = tbTen.Text.Trim();
            string bienSo = tbBienSo.Text.Trim();
            string maNguoiDung = tbMaND.Text.Trim();

            if (maPhuongTien == "" || loai == "" || ten == "" || bienSo == "" || maNguoiDung == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }

            if (handlePhuongTien.KiemTra("MaPhuongTien", maPhuongTien) || handlePhuongTien.KiemTra("BienSo", bienSo))
            {
                MessageBox.Show("Thông tin không được trùng lặp");
                return;
            }

            handlePhuongTien.ThemPhuongTien(maPhuongTien, loai, ten, bienSo, maNguoiDung);
            MessageBox.Show("Thêm phương tiện thành công");
            initPhuongTienDataGridView();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maPhuongTien = tbMaPT.Text.Trim();
            string loai = tbLoai.Text.Trim();
            string ten = tbTen.Text.Trim();
            string bienSo = tbBienSo.Text.Trim();
            string maNguoiDung = tbMaND.Text.Trim();

            if (maPhuongTien == "" || loai == "" || ten == "" || bienSo == "" || maNguoiDung == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }

            handlePhuongTien.CapNhatPhuongTien(maPhuongTien, loai, ten, bienSo, maNguoiDung);
            MessageBox.Show("Cập nhật phương tiện thành công");
            initPhuongTienDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhuongTien = tbMaPT.Text.Trim();

            if (maPhuongTien == "")
            {
                MessageBox.Show("Vui lòng chọn phương tiện để xóa");
                return;
            }

            handlePhuongTien.XoaPhuongTien(maPhuongTien);
            MessageBox.Show("Xóa phương tiện thành công");
            initPhuongTienDataGridView();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaPT.Text = "";
            tbLoai.Text = "";
            tbTen.Text = "";
            tbLoai.Text = "";
            tbMaND.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable phuongTienData = new DataTable();
            string filteredField = category[cbTimKiem.Text.ToString()];
            phuongTienData = handlePhuongTien.getPhuongTienFilteredData(filteredField, tbTimKiem.Text.ToString().Trim());
            grvPhuongTien.DataSource = phuongTienData;
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiem.Text.ToString().Trim() == "")
            {
                initPhuongTienDataGridView();
            }
        }
    }
}
