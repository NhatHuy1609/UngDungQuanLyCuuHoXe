using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UngDungQuanLyCuuHoXe.Class;
using UngDungQuanLyCuuHoXe.Class.NguoiDung;

namespace UngDungQuanLyCuuHoXe.GUI.NguoiDung
{
    public partial class frmYeuCauCuuHo : Form
    {
        HandleXML handleXML = new HandleXML();
        PhuongTien phuongtien = new PhuongTien();
        YeuCauCuuHo yeuCauCuuHo = new YeuCauCuuHo();
        string MaPhuongTien, LoaiPhuongTien, TenPhuongTien, BienSoXe, MaNguoiDung, ViTri, MoTaVanDe;

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
            MaPhuongTien = lbMaPhuongTien.Text;
            LoaiPhuongTien = tbLoaiPhuongTien.Text;
            TenPhuongTien = tbTenPhuongTien.Text;
            BienSoXe = tbBienSoXe.Text;
            MaNguoiDung = lbMaNguoiDung.Text;
            ViTri = tbViTri.Text;
            MoTaVanDe = tbMoTaVanDe.Text;
        }



        public void hienThiPhuongTien()
        {
            DataTable dt = new DataTable();
            dt = handleXML.LayDuLieuXML("PhuongTien.xml");

            DataView dv = new DataView(dt);
            dv.RowFilter = $"MaNguoiDung = '{lbMaNguoiDung.Text}'";

            if (dv.Count == 0)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                dgvPhuongTien.DataSource = dv.ToTable();

                //Hide the "MaNguoiDung" column after setting the DataSource
                dgvPhuongTien.Columns["MaNguoiDung"].Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("PhuongTien.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaPhuongTien";
            reader.Close();

            // Filter DataView based on MaNguoiDung
            dv.RowFilter = $"MaNguoiDung = '{lbMaNguoiDung.Text}'";
            int index = dv.Find(tbSearch.Text);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                tbSearch.Text = "";
                tbSearch.Focus();

            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã phương tiện");
                dt.Columns.Add("Loại phương tiện");
                dt.Columns.Add("Tên phương tiệnh");
                dt.Columns.Add("Biển số xe");


                object[] list = { dv[index]["MaPhuongTien"], dv[index]["LoaiPhuongTien"], dv[index]["TenPhuongTien"], dv[index]["BienSo"]};
                dt.Rows.Add(list);
                dgvPhuongTien.DataSource = dt;
                tbSearch.Text = "";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            hienThiPhuongTien();
        }

        private void frmYeuCauCuuHo_Load(object sender, EventArgs e)
        {
            hienThiPhuongTien();
        }



        private void dgvPhuongTien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvPhuongTien.CurrentRow.Index;
            lbMaPhuongTien.Text = dgvPhuongTien.Rows[d].Cells[0].Value.ToString();
            tbLoaiPhuongTien.Text = dgvPhuongTien.Rows[d].Cells[1].Value.ToString();
            tbTenPhuongTien.Text = dgvPhuongTien.Rows[d].Cells[2].Value.ToString();
            tbBienSoXe.Text = dgvPhuongTien.Rows[d].Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbMaPhuongTien.Text = "";
            tbLoaiPhuongTien.Text = "";
            tbTenPhuongTien.Text = "";
            tbBienSoXe.Text = "";
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
                phuongtien.Them(tbLoaiPhuongTien.Text, tbTenPhuongTien.Text, tbBienSoXe.Text, lbMaNguoiDung.Text);
                MessageBox.Show("Đã thêm!");
                hienThiPhuongTien();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            phuongtien.Sua(lbMaPhuongTien.Text, tbLoaiPhuongTien.Text, tbTenPhuongTien.Text, tbBienSoXe.Text, lbMaNguoiDung.Text);
            MessageBox.Show("Cập nhật thành công@");
            hienThiPhuongTien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!lbMaPhuongTien.Text.Equals(""))
            {
                phuongtien.Xoa(lbMaPhuongTien.Text);
                MessageBox.Show("Đã xóa!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương tiện để xóa");
            }
            hienThiPhuongTien();
        }

        private void btnYeuCau_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            if (ViTri == "" || MoTaVanDe == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                phuongtien.Them(tbLoaiPhuongTien.Text, tbTenPhuongTien.Text, tbBienSoXe.Text, lbMaNguoiDung.Text);
                yeuCauCuuHo.Them(tbMoTaVanDe.Text, tbViTri.Text, tbBienSoXe.Text, lbMaNguoiDung.Text);
                MessageBox.Show("Đã gửi yêu cầu!");
            }
        }

        private string AutoIncrementMaPhuongTien()
        {
            string maPhuongTienCuoi = GetLastNodeMaPhuongTien("PhuongTien.xml");
            if (maPhuongTienCuoi != null)
            {
                int soPhuongTienCuoi = int.Parse(maPhuongTienCuoi.Substring(2));
                soPhuongTienCuoi++;

                string maPhuongTienMoi = "PT" + soPhuongTienCuoi.ToString("D3");

                return maPhuongTienMoi;
            }
            else
            {
                return "PT000";
            }
        }

        private string GetLastNodeMaPhuongTien(string path)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList nodeList = xmlDoc.SelectNodes("//_x0027_PhuongTien_x0027_");

            if (nodeList.Count > 0)
            {
                XmlNode lastNode = nodeList[nodeList.Count - 1];
                XmlNode maPhuongTienNode = lastNode.SelectSingleNode("MaPhuongTien");

                if (maPhuongTienNode != null)
                {
                    return maPhuongTienNode.InnerText;
                }
            }
            return null;
        }
    }
}
