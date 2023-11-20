using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungQuanLyCuuHoXe.Class;
using UngDungQuanLyCuuHoXe.GUI;

namespace UngDungQuanLyCuuHoXe
{
    public partial class TrangChu : Form
    {
        HandleXML handleXML = new HandleXML();

        public TrangChu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            handleXML.TaoFileXML("Quyen");
            handleXML.TaoFileXML("NguoiDung");
            handleXML.TaoFileXML("PhuongTien");
            handleXML.TaoFileXML("YeuCauCuuHo");
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
