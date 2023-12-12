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
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_PhuongTien_x0027_[MaPhuongTien='" + MaPhuongTien + "']");
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

        public void Them(string LoaiPhuongTien, string TenPhuongTien, string BienSoXe, string MaNguoiDung)
        {
            string MaPhuongTien = AutoIncrementMaPhuongTien();
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
