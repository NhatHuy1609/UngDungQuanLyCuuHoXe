using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UngDungQuanLyCuuHoXe.Class.NguoiDung
{
    class MatKhau
    {
        public bool DoiMatKhau(string maNguoiDung, string matKhauMoi)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(Application.StartupPath + "\\NguoiDung.xml");
            XmlNode node1 = doc1.SelectSingleNode("NewDataSet/_x0027_NguoiDung_x0027_[MaNguoiDung = '" + maNguoiDung + "']");
            if (node1 != null)
            {
                node1.ChildNodes[2].InnerText = matKhauMoi;
                doc1.Save(Application.StartupPath + "\\NguoiDung.xml");
                return true;
            }

            return false;
        }
    }
}
