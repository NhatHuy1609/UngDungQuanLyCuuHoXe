using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UngDungQuanLyCuuHoXe.Class.Admin
{
    class HandleYeuCauCuuHo
    {
        HandleXML handleXML = new HandleXML();

        public DataTable getYeuCauCuuHoFilteredData(string filterField, string filterValue)
        {
            DataTable data = new DataTable();
            data = handleXML.LayDuLieuXML("YeuCauCuuHo.xml");

            // Filter the rows where filterField = filterValue
            DataRow[] filteredRows = data.Select($"{filterField} = '{filterValue}'");

            // Create a new DataTable to store the filtered data
            DataTable filteredDataTable = data.Clone();

            // Import the filtered rows into the new DataTable
            foreach (DataRow row in filteredRows)
            {
                filteredDataTable.ImportRow(row);
            }

            return filteredDataTable;
        }

        public void ThemYeuCauCuuHo(string mach, string mota, string thoigian, string vitri, string trangthai, string mapt, string mand)
        {
            string noiDung = "<_x0027_YeuCauCuuHo_x0027_>" +
                        "<MaCuuHo>" + mach + "</MaCuuHo>" +
                        "<MoTaVanDe>" + mota + "</MoTaVanDe>" +
                        "<ThoiGian>" + thoigian + "</ThoiGian>" +
                        "<ViTri>" + vitri + "</ViTri>" +
                        "<TrangThai>" + trangthai + "</TrangThai>" +
                        "<MaPhuongTien>" + mapt + "</MaPhuongTien>" +
                        "<MaNguoiDung>" + mand + "</MaNguoiDung>" +
                        "</_x0027_YeuCauCuuHo_x0027_>";
            handleXML.Them("YeuCauCuuHo.xml", noiDung);
        }

        public void CapNhatYeuCauCuuHo(string mach, string mota, string thoigian, string vitri, string trangthai, string mapt, string mand)
        {
            string noiDung = "<MaCuuHo>" + mapt + "</MaCuuHo>" +
                        "<MoTaVanDe>" + mota + "</MoTaVanDe>" +
                        "<ThoiGian>" + thoigian + "</ThoiGian>" +
                        "<ViTri>" + vitri + "</ViTri>" +
                        "<TrangThai>" + trangthai + "</TrangThai>" +
                        "<MaPhuongTien>" + mapt + "</MaPhuongTien>" +
                        "<MaNguoiDung>" + mand + "</MaNguoiDung>";


            handleXML.Sua("YeuCauCuuHo.xml", "_x0027_YeuCauCuuHo_x0027_", "MaCuuHo", mach, noiDung);
        }

        public void XoaYeuCauCuuHo(string mach)
        {
            handleXML.Xoa("YeuCauCuuHo.xml", "_x0027_YeuCauCuuHo_x0027_", "MaCuuHo", mach);
        }

        public bool KiemTra(string fieldKiemTra, string fieldGiaTriKiemTra)
        {
            XmlTextReader reader = new XmlTextReader("YeuCauCuuHo.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_YeuCauCuuHo_x0027_[" + fieldKiemTra + "='" + fieldGiaTriKiemTra + "']");
            reader.Close();
            if (node != null)
                return true;
            else
                return false;
        }
    }
}
