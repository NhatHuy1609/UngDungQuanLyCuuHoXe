using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyCuuHoXe.Class
{
    class ChuyenDoi
    {
        HandleXML handleXML = new HandleXML();

        public void ChuyenDoiSQLSangXML()
        {
            handleXML.TaoFileXML("NguoiDung");
            handleXML.TaoFileXML("PhuongTien");
            handleXML.TaoFileXML("YeuCauCuuHo");
        }

        void CapNhapTungBang(string tenBang)
        {
            string duongDan = @"" + tenBang + ".xml";
            DataTable table = handleXML.LayDuLieuXML(duongDan);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string sql = "insert into " + tenBang + " values(";
                for (int j = 0; j < table.Columns.Count - 1; j++)
                {

                    sql += "N'" + table.Rows[i][j].ToString().Trim() + "',";

                }
                sql += "N'" + table.Rows[i][table.Columns.Count - 1].ToString().Trim() + "'";
                sql += ")";
                //MessageBox.Show(sql);
                handleXML.InsertOrUpDateSQL(sql);
            }
        }

        private void CapNhatBangYeuCauCuuHo()
        {
            string duongDan = "YeuCauCuuHo.xml";
            DataTable table = handleXML.LayDuLieuXML(duongDan);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string sql = "INSERT INTO YeuCauCuuHo (MaCuuHo, MoTaVanDe, ThoiGian, ViTri, TrangThai, MaPhuongTien, MaNguoiDung)" + " values(";
                for (int j = 0; j < table.Columns.Count - 2; j++)
                {
                    if (j == 2)
                    {
                        DateTime dt = DateTimeOffset.Parse(table.Rows[i][j].ToString()).UtcDateTime;
                        string formattedThoiGian = dt.ToString("dd/MM/yyyy HH:mm:ss");
                        sql += $"CONVERT(datetime, '{formattedThoiGian}', 103),";
                    }
                    else
                    {
                        sql += "N'" + table.Rows[i][j].ToString().Trim() + "',";
                    }
                }
                sql += "N'" + table.Rows[i][table.Columns.Count - 2].ToString().Trim() + "'";
                sql += ")";
                //MessageBox.Show(sql);
                handleXML.InsertOrUpDateSQL(sql);
            }
        }

        public void CapNhapSQL()
        {
            //Xóa toàn bộ dữ liệu các bảng
            handleXML.InsertOrUpDateSQL("delete from YeuCauCuuHo");
            handleXML.InsertOrUpDateSQL("delete from PhuongTien");
            handleXML.InsertOrUpDateSQL("delete from NguoiDung");

            //Cập nhập toàn bộ dữ liệu các bảng
            CapNhapTungBang("NguoiDung");
            CapNhapTungBang("PhuongTien");
            CapNhatBangYeuCauCuuHo();
        }
    }
}
