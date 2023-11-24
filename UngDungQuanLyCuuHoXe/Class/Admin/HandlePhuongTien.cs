using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UngDungQuanLyCuuHoXe.Class.Admin
{
    class HandlePhuongTien
    {
        HandleXML handleXML = new HandleXML();

        public DataTable getPhuongTienFilteredData(string filterField, string filterValue)
        {
            DataTable data = new DataTable();
            data = handleXML.LayDuLieuXML("PhuongTien.xml");

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

        public void ThemPhuongTien(string mapt, string loai, string ten, string bienso, string mand)
        {
            string noiDung = "<_x0027_PhuongTien_x0027_>" +
                        "<MaPhuongTien>" + mapt + "</MaPhuongTien>" +
                        "<LoaiPhuongTien>" + loai + "</LoaiPhuongTien>" +
                        "<TenPhuongTien>" + ten + "</TenPhuongTien>" +
                        "<BienSo>" + bienso + "</BienSo>" +
                        "<MaNguoiDung>" + mand + "</MaNguoiDung>" +
                        "</_x0027_PhuongTien_x0027_>";
            handleXML.Them("PhuongTien.xml", noiDung);
        }

        public void CapNhatPhuongTien(string mapt, string loai, string ten, string bienso, string mand)
        {
            string noiDung = "<MaPhuongTien>" + mapt + "</MaPhuongTien>" +
                        "<LoaiPhuongTien>" + loai + "</LoaiPhuongTien>" +
                        "<TenPhuongTien>" + ten + "</TenPhuongTien>" +
                        "<BienSo>" + bienso + "</BienSo>" +
                        "<MaNguoiDung>" + mand + "</MaNguoiDung>";


            handleXML.Sua("PhuongTien.xml", "_x0027_PhuongTien_x0027_", "MaPhuongTien", mapt, noiDung);
        }

        public void XoaPhuongTien(string mapt)
        {
            handleXML.Xoa("PhuongTien.xml", "_x0027_PhuongTien_x0027_", "MaPhuongTien", mapt);
        }

        public bool KiemTra(string fieldKiemTra, string fieldGiaTriKiemTra)
        {
            XmlTextReader reader = new XmlTextReader("PhuongTien.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_PhuongTien_x0027_[" + fieldKiemTra + "='" + fieldGiaTriKiemTra + "']");
            reader.Close();
            if (node != null)
                return true;
            else
                return false;
        }
    }
}
