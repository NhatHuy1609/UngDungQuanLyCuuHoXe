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
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_NguoiDung_x0027_[TenDangNhap='" + TenDangNhap + "']");
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

        public void Them(string TenDangNhap, string MatKhau, string HoTen, string DiaChi, string SDT, string Email, int MaQuyen)
        {
            string maNguoiDung = AutoIncrementMaNguoiDung();
            string noiDung = "<_x0027_NguoiDung_x0027_>" +
                "<MaNguoiDung>" + maNguoiDung + "</MaNguoiDung>" +
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

        private string AutoIncrementMaNguoiDung()
        {
            string maNguoiDungCuoi = GetLastNodeMaNguoiDung("NguoiDung.xml");
            if (maNguoiDungCuoi != null)
            {
                int soNguoiDungCuoi = int.Parse(maNguoiDungCuoi.Substring(2));
                soNguoiDungCuoi++;

                string maNguoiDungMoi = "ND" + soNguoiDungCuoi.ToString("D3");

                return maNguoiDungMoi;
            }
            else
            {
                return "ND000";
            }
        }

        private string GetLastNodeMaNguoiDung(string path)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList nodeList = xmlDoc.SelectNodes("//_x0027_NguoiDung_x0027_");

            if (nodeList.Count > 0)
            {
                XmlNode lastNode = nodeList[nodeList.Count - 1];
                XmlNode maNguoiDungNode = lastNode.SelectSingleNode("MaNguoiDung");

                if (maNguoiDungNode != null)
                {
                    return maNguoiDungNode.InnerText;
                }
            }
            return null;
        }
    }
}
