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
    public partial class frmQuanLyYeuCauCuuHo : Form
    {
        HandleXML handleXML = new HandleXML();
        HandleYeuCauCuuHo handleYeuCauCuuHo = new HandleYeuCauCuuHo();
        Dictionary<string, string> category = new Dictionary<string, string>();

        public frmQuanLyYeuCauCuuHo()
        {
            InitializeComponent();
        }

        private void initCuuHoDataGridView()
        {
            DataTable cuuHoData = new DataTable();
            cuuHoData = handleXML.LayDuLieuXML("YeuCauCuuHo.xml");
            dgvYeuCau.DataSource = cuuHoData;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCH = tbMaCH.Text.Trim();
            string moTa = rtbMoTa.Text.Trim();
            string thoiGian = dtpThoiGian.Value.ToString("yyyy-MM-ddTHH:mm:sszzz");
            string viTri = tbViTri.Text.Trim();
            string trangThai = tbTrangThai.Text.Trim();
            string maPT = tbMaPT.Text.Trim();
            string maND = tbMaND.Text.Trim();

            if (maCH == "" || moTa == "" || thoiGian == "" || viTri == "" || trangThai == "" || maPT == "" || maND == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }

            if (handleYeuCauCuuHo.KiemTra("MaCuuHo", maCH))
            {
                MessageBox.Show("Thông tin không được trùng lặp");
                return;
            }

            handleYeuCauCuuHo.ThemYeuCauCuuHo(maCH, moTa, thoiGian, viTri, trangThai, maPT, maND);
            MessageBox.Show("Thêm yêu cầu cứu hộ thành công");
            initCuuHoDataGridView();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maCH = tbMaCH.Text.Trim();
            string moTa = rtbMoTa.Text.Trim();
            string thoiGian = dtpThoiGian.Value.ToString("yyyy-MM-ddTHH:mm:sszzz");
            string viTri = tbViTri.Text.Trim();
            string trangThai = tbTrangThai.Text.Trim();
            string maPT = tbMaPT.Text.Trim();
            string maND = tbMaND.Text.Trim();

            if (maCH == "" || moTa == "" || thoiGian == "" || viTri == "" || trangThai == "" || maPT == "" || maND == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }

            handleYeuCauCuuHo.CapNhatYeuCauCuuHo(maCH, moTa, thoiGian, viTri, trangThai, maPT, maND);
            MessageBox.Show("Cập nhật yêu cầu cứu hộ thành công");
            initCuuHoDataGridView();
        }

        private void frmQuanLyYeuCauCuuHo_Load(object sender, EventArgs e)
        {
            initCuuHoDataGridView();

            cbTimKiem.SelectedIndex = 0;
            category.Add("Mã phương tiện", "MaPhuongTien");
            category.Add("Mã người dùng", "MaNguoiDung");
            category.Add("Mã cứu hộ", "MaCuuHo");
            category.Add("Trạng thái", "TrangThai");
        }

        private void dgvYeuCau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvYeuCau.CurrentRow.Index;
            tbMaCH.Text = dgvYeuCau.Rows[index].Cells[0].Value.ToString();
            rtbMoTa.Text = dgvYeuCau.Rows[index].Cells[1].Value.ToString();
            dtpThoiGian.Value = Convert.ToDateTime(dgvYeuCau.Rows[index].Cells[2].Value);
            tbViTri.Text = dgvYeuCau.Rows[index].Cells[3].Value.ToString();
            tbTrangThai.Text = dgvYeuCau.Rows[index].Cells[4].Value.ToString();
            tbMaPT.Text = dgvYeuCau.Rows[index].Cells[5].Value.ToString();
            tbMaND.Text = dgvYeuCau.Rows[index].Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCuuHo = tbMaCH.Text.Trim();

            if (maCuuHo == "")
            {
                MessageBox.Show("Vui lòng chọn yêu cầu cứu hộ để xóa");
                return;
            }

            handleYeuCauCuuHo.XoaYeuCauCuuHo(maCuuHo);
            MessageBox.Show("Xóa yêu cầu cứu hộ thành công");
            initCuuHoDataGridView();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaCH.Text = "";
            rtbMoTa.Text = "";
            dtpThoiGian.Value = DateTime.Now;
            tbViTri.Text = "";
            tbTrangThai.Text = "";
            tbMaPT.Text = "";
            tbMaND.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable yeuCauCuuHoData = new DataTable();
            string filteredField = category[cbTimKiem.Text.ToString()];
            yeuCauCuuHoData = handleYeuCauCuuHo.getYeuCauCuuHoFilteredData(filteredField, tbTimKiem.Text.ToString().Trim());
            dgvYeuCau.DataSource = yeuCauCuuHoData;
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiem.Text.ToString().Trim() == "")
            {
                initCuuHoDataGridView();
            }
        }
    }
}
