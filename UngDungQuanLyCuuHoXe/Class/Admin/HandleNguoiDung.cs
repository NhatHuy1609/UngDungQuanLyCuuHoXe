using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UngDungQuanLyCuuHoXe.Class.Admin
{
    public class HandleNguoiDung
    {
        HandleXML handleXML = new HandleXML();

        public DataTable getNguoiDungFilteredData(string filterField, string filterValue)
        {
            DataTable data = new DataTable();
            data = handleXML.LayDuLieuXML("NguoiDung.xml");

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

        public void ThemNguoiDung(string mand, string tendn, string matkhau, string hoten, string diachi, string sodt, string email)
        {
            string noiDung = "<_x0027_NguoiDung_x0027_>" +
                        "<MaNguoiDung>" + mand + "</MaNguoiDung>" +
                        "<TenDangNhap>" + tendn + "</TenDangNhap>" +
                        "<MatKhau>" + matkhau + "</MatKhau>" +
                        "<HoTen>" + hoten + "</HoTen>" +
                        "<DiaChi>" + diachi + "</DiaChi>" +
                        "<SoDienThoai>" + sodt + "</SoDienThoai>" +
                        "<Email>" + email + "</Email>" +
                        "<MaQuyen>" + 1 + "</MaQuyen>" +
                        "</_x0027_NguoiDung_x0027_>";
            handleXML.Them("NguoiDung.xml", noiDung);
        }

        public void CapNhatNguoiDung(string mand, string tendn, string matkhau, string hoten, string diachi, string sodt, string email)
        {
            string noiDung = "<_x0027_NguoiDung_x0027_>" +
                        "<MaNguoiDung>" + mand + "</MaNguoiDung>" +
                        "<TenDangNhap>" + tendn + "</TenDangNhap>" +
                        "<MatKhau>" + matkhau + "</MatKhau>" +
                        "<HoTen>" + hoten + "</HoTen>" +
                        "<DiaChi>" + diachi + "</DiaChi>" +
                        "<SoDienThoai>" + sodt + "</SoDienThoai>" +
                        "<Email>" + email + "</Email>" +
                        "<MaQuyen>" + 1 + "</MaQuyen>" +
                        "</_x0027_NguoiDung_x0027_>";
            handleXML.Sua("NguoiDung.xml", "_x0027_NguoiDung_x0027_", "MaNguoiDung", mand, noiDung);
        }

        public void XoaNguoiDung(string mand)
        {
            handleXML.Xoa("NguoiDung.xml", "_x0027_NguoiDung_x0027_", "MaNguoiDung", mand);
        }

        public bool KiemTra(string fieldKiemTra, string fieldGiaTriKiemTra)
        {
            XmlTextReader reader = new XmlTextReader("NguoiDung.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_NguoiDung_x0027_[" + fieldKiemTra + "='" + fieldGiaTriKiemTra + "']");
            reader.Close();
            if (node != null)
                return true;
            else
                return false;
        }
    }
}
