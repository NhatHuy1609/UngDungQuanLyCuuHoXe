using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyCuuHoXe.Class
{
    class HandleXML
    {
        string conn = @"Data Source=DESKTOP-0TDNQCQ\SQLEXPRESS;Initial Catalog=dbQUANLYCUUHOXE;Integrated Security=True";

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
    }
}
