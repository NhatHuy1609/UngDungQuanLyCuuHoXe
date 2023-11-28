using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UngDungQuanLyCuuHoXe.Class.NguoiDung
{

    class YeuCauCuuHo
    {
        HandleXML handleXML = new HandleXML();

        public bool KiemTra(string MaCuuHo)
        {
            XmlTextReader reader = new XmlTextReader("YeuCauCuuHo.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/YeuCauCuuHo[MaCuuHo='" + MaCuuHo + "']");
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

        public void Them(string MoTaVanDe, string ViTri, string MaPhuongTien, string MaNguoiDung)
        {
            string trangThai = "Chờ xử lý";
            string thoiGian = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            string maCuuHo = AutoIncrementMaCuuHo();
            string noiDung = "<_x0027_YeuCauCuuHo_x0027_>" +
                "<MaCuuHo>" + maCuuHo + "</MaCuuHo>" +
                "<MoTaVanDe>" + MoTaVanDe + "</MoTaVanDe>" +
                "<ThoiGian>" + thoiGian + "</ThoiGian>" +
                "<ViTri>" + ViTri + "</ViTri>" +
                "<TrangThai>" + trangThai + "</TrangThai>" +
                "<MaPhuongTien>" + MaPhuongTien + "</MaPhuongTien>" +
                "<MaNguoiDung>" + MaNguoiDung + "</MaNguoiDung>" +
                "</_x0027_YeuCauCuuHo_x0027_>";
            handleXML.Them("YeuCauCuuHo.xml", noiDung);
        }

        private string AutoIncrementMaCuuHo()
        {
            string maCuuHoCuoi = GetLastNodeMaCuuHo("YeuCauCuuHo.xml");
            if (maCuuHoCuoi != null)
            {
                int soCuuHoCuoi = int.Parse(maCuuHoCuoi.Substring(2));
                soCuuHoCuoi++;

                string maCuuHoMoi = "CH" + soCuuHoCuoi.ToString("D3");

                return maCuuHoMoi;
            }
            else
            {
                return "CH000";
            }
        }

        private string GetLastNodeMaCuuHo(string path)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList nodeList = xmlDoc.SelectNodes("//_x0027_YeuCauCuuHo_x0027_");

            if (nodeList.Count > 0)
            {
                XmlNode lastNode = nodeList[nodeList.Count - 1];
                XmlNode maCuuHoNode = lastNode.SelectSingleNode("MaCuuHo");

                if (maCuuHoNode != null)
                {
                    return maCuuHoNode.InnerText;
                }
            }
            return null;
        }
    }
}
