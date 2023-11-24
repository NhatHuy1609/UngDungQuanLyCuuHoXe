using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UngDungQuanLyCuuHoXe.Class.NguoiDung
{
    class PhuongTien
    {
        HandleXML handleXML = new HandleXML();

        public bool KiemTra(string MaPhuongTien)
        {
            XmlTextReader reader = new XmlTextReader("PhuongTien.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/PhuongTien[MaPhuongTien='" + MaPhuongTien + "']");
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

        public void Them(string MaPhuongTien, string LoaiPhuongTien, string TenPhuongTien, string BienSoXe, string MaNguoiDung)
        {
            string noiDung = "<_x0027_PhuongTien_x0027_>" +
                "<MaPhuongTien>" + MaPhuongTien + "</MaPhuongTien>" +
                "<LoaiPhuongTien>" + LoaiPhuongTien + "</LoaiPhuongTien>" +
                "<TenPhuongTien>" + TenPhuongTien + "</TenPhuongTien>" +
                "<BienSo>" + BienSoXe + "</BienSo>" +
                "<MaNguoiDung>" + MaNguoiDung + "</MaNguoiDung>" +
                "</_x0027_PhuongTien_x0027_>";
            handleXML.Them("PhuongTien.xml", noiDung);
        }

        public void Sua(string MaPhuongTien, string LoaiPhuongTien, string TenPhuongTien, string BienSoXe, string MaNguoiDung)
        {
            string noiDung = "<_x0027_PhuongTien_x0027_>" +
                "<MaPhuongTien>" + MaPhuongTien + "</MaPhuongTien>" +
                "<LoaiPhuongTien>" + LoaiPhuongTien + "</LoaiPhuongTien>" +
                "<TenPhuongTien>" + TenPhuongTien + "</TenPhuongTien>" +
                "<BienSo>" + BienSoXe + "</BienSo>" +
                "<MaNguoiDung>" + MaNguoiDung + "</MaNguoiDung>" +
                "</_x0027_PhuongTien_x0027_>";

            handleXML.Sua("PhuongTien.xml", "_x0027_PhuongTien_x0027_", "MaPhuongTien", MaPhuongTien, noiDung);
        }

        public void Xoa(string MaPhuongTien)
        {
            handleXML.Xoa("PhuongTien.xml", "_x0027_PhuongTien_x0027_", "MaPhuongTien", MaPhuongTien);
        }
    }
}
