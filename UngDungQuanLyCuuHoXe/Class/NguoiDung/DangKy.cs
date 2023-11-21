using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UngDungQuanLyCuuHoXe.Class.NguoiDung
{
    class DangKy
    {
        HandleXML handleXML = new HandleXML();

        public bool KiemTra(string TenDangNhap)
        {
            XmlTextReader reader = new XmlTextReader("NguoiDung.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/NguoiDung[TenDangNhap='" + TenDangNhap + "']");
            reader.Close();
            if (node != null)
            {
                return true;
            }
            else
            {
                return false;

            }

        }

        public void Them(string MaNguoiDung, string TenDangNhap, string MatKhau, string HoTen, string DiaChi, string SDT, string Email, int MaQuyen)
        {
            string noiDung = "<_x0027_NguoiDung_x0027_>" +
                "<MaNguoiDung>" + MaNguoiDung + "</MaNguoiDung>" +
                "<TenDangNhap>"  + TenDangNhap + "</TenDangNhap>" +
                "<MatKhau>"  + MatKhau + "</MatKhau>" +
                "<HoTen>"  +HoTen + "</HoTen>" +
                "<DiaChi>"  +DiaChi + "</DiaChi>" +
                "<SoDienThoai>"  +SDT + "</SoDienThoai>" +
                "<Email>"  +Email + "</Email>" +
                "<MaQuyen>"  +MaQuyen + "</MaQuyen>" +
                "</_x0027_NguoiDung_x0027_>";
            handleXML.Them("NguoiDung.xml", noiDung);
        }
    }
}
