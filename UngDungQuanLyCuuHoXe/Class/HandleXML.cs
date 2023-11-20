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
    }
}
