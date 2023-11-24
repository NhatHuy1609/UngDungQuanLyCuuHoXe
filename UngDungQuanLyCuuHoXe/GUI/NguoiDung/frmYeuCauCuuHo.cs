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
    public partial class frmYeuCauCuuHo : Form
    {
        HandleXML handleXML = new HandleXML();
        PhuongTien phuongtien = new PhuongTien();
        string MaPhuongTien, LoaiPhuongTien, TenPhuongTien, BienSoXe, MaNguoiDung;

        public frmYeuCauCuuHo()
        {
            InitializeComponent();
        }

        public void SetMaNguoiDung(string maNguoiDung)
        {
            lbMaNguoiDung.Text = maNguoiDung;
        }

        public void LoadDuLieu()
        {
            MaPhuongTien = tbMaPhuongTien.Text;
            LoaiPhuongTien = tbLoaiPhuongTien.Text;
            TenPhuongTien = tbTenPhuongTien.Text;
            BienSoXe = tbBienSoXe.Text;
            MaNguoiDung = lbMaNguoiDung.Text;
        }

        

        public void hienThiPhuongTien()
        {
            DataTable dt = new DataTable();
            dt = handleXML.LayDuLieuXML("PhuongTien.xml");
            dgvPhuongTien.DataSource = dt;
        }

        

        private void frmYeuCauCuuHo_Load(object sender, EventArgs e)
        {
            hienThiPhuongTien();
        }

        private void dgvPhuongTien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvPhuongTien.CurrentRow.Index;
            tbMaPhuongTien.Text = dgvPhuongTien.Rows[d].Cells[0].Value.ToString();
            tbLoaiPhuongTien.Text = dgvPhuongTien.Rows[d].Cells[1].Value.ToString();
            tbTenPhuongTien.Text = dgvPhuongTien.Rows[d].Cells[2].Value.ToString();
            tbBienSoXe.Text = dgvPhuongTien.Rows[d].Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            if (phuongtien.KiemTra(MaPhuongTien) == true)
            {
                MessageBox.Show("Mã phương tiện đã tồn tại");
            }
            else
            {
                phuongtien.Them(tbMaPhuongTien.Text, tbLoaiPhuongTien.Text, tbTenPhuongTien.Text, tbBienSoXe.Text, lbMaNguoiDung.Text);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            phuongtien.Sua(tbMaPhuongTien.Text, tbLoaiPhuongTien.Text, tbTenPhuongTien.Text, tbBienSoXe.Text, lbMaNguoiDung.Text);
            MessageBox.Show("Cập nhật thành công@");
            hienThiPhuongTien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            phuongtien.Xoa(tbMaPhuongTien.Text);
            MessageBox.Show("Đã xóa!");
            hienThiPhuongTien();
        }
    }
}
