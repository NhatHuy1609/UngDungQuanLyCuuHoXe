using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UngDungQuanLyCuuHoXe.Class
{
    class HandleXML
    {
        //string conn = @"data source=desktop-0tdnqcq\sqlexpress;initial catalog=dbquanlycuuhoxe;integrated security=true";
        string conn = @"Data Source=NHATHUY16903\SQLEXPRESS;Initial Catalog=dbQUANLYCUUHOXE;Persist Security Info=True;User ID=pvnhathuy;Password=Nhathuy160903";

        public void TaoFileXML(string tenBang)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = "SELECT * FROM " + tenBang;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable("'" + tenBang + "'");
            adapter.Fill(table);
            table.WriteXml(Application.StartupPath + "\\" + tenBang + ".xml", XmlWriteMode.WriteSchema);
        }

        public DataTable LayDuLieuXML(string file)
        {

            DataTable dt = new DataTable();
            string FilePath = Application.StartupPath + "\\" + file;
            if (File.Exists(FilePath))
            {
                FileStream fsReadXML = new FileStream(FilePath, FileMode.Open);
                dt.ReadXml(fsReadXML);
                fsReadXML.Close();
            }
            else
            {
                MessageBox.Show("File XML '" + file + "' không tồn tại");
            }

            return dt;
        }

        // Muốn lấy giá trị của truongB tại duongDan thỏa mãn giá trị truongA == giaTriA
        public string LayGiaTri(string duongDan, string truongA, string giaTriA, string truongB)
        {
            string giatriB = "";
            DataTable dt = new DataTable();
            dt = LayDuLieuXML(duongDan);
            int soDongNhanVien = dt.Rows.Count;
            for (int i = 0; i < soDongNhanVien; i++)
            {
                if (dt.Rows[i][truongA].ToString().Trim().Equals(giaTriA))
                {
                    giatriB = dt.Rows[i][truongB].ToString();
                    return giatriB;
                }
            }
            return giatriB;
        }

        public void Them(string duongDan, string noiDung)
        {
            XmlTextReader reader = new XmlTextReader(duongDan);

            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();

            XmlDocumentFragment docFrag = doc.CreateDocumentFragment();
            docFrag.InnerXml = noiDung;

            //get the current node
            XmlNode currNode = doc.DocumentElement;

            //insert the docFragment after the last child of current node
            currNode.InsertAfter(docFrag, currNode.LastChild);

            doc.Save(duongDan);
        }

        public void Sua(string duongDan, string tenFile, string suaTheoTruong, string giaTriTruong, string noiDung)
        {

            XmlTextReader reader = new XmlTextReader(duongDan);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode oldHang;
            XmlElement root = doc.DocumentElement;
            oldHang = root.SelectSingleNode("/NewDataSet/" + tenFile + "[" + suaTheoTruong + "='" + giaTriTruong + "']");
            XmlElement newhang = doc.CreateElement(tenFile);
            newhang.InnerXml = noiDung;
            root.ReplaceChild(newhang, oldHang);
            doc.Save(duongDan);
        }

        public void Xoa(string duongDan, string tenFileXML, string xoaTheoTruong, string giaTriTruong)
        {
            string fileName = Application.StartupPath + "\\" + duongDan;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode nodeCu = doc.SelectSingleNode("NewDataSet/" + tenFileXML + "[" + xoaTheoTruong + "='" + giaTriTruong + "']");
            doc.DocumentElement.RemoveChild(nodeCu);
            doc.Save(fileName);
        }

        public void InsertOrUpDateSQL(string sql)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
