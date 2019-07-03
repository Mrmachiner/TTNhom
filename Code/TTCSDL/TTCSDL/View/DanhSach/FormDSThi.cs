using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCSDL.Helper;

namespace TTCSDL.View.DanhSach
{
    public partial class FormDSThi : Form
    {
        QLThiCCEntities db = new QLThiCCEntities();
        public FormDSThi()
        {
            InitializeComponent();
        }
        genDataGrid g = new genDataGrid();
        private void DSThi_Load(object sender, EventArgs e)
        {

            cbxDot.DataSource = db.DotThi.ToList();
        }
        DateTime dt = DateTime.Now;
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txtTenFile.Text == "")
            {
                MessageBox.Show("Không Được Để Trống");
            }
            else
            {
                exportExcel ex = new exportExcel();
                ex.exportexcel(dtGridThi, "D:\\", txtTenFile.Text.ToString() + dt.ToString("dd-MM-yyyy"));
            }
        }

        private void cbxDot_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "select ds.SBD,ts.Ho+ts.Ten as HoTen,ts.NgaySinh,ts.CMND,ds.GhiChu " +
                    "from DanhSachThi ds join ThiSinh ts on ts.IDThiSinh = ds.IDThiSinh " +
                    "join DotThi dt on dt.IDDotThi = ds.IDDotThi and ds.IDDotThi = '" + cbxDot.SelectedValue.ToString() + "'";
            g.gen(query, dtGridThi);
        }
    }
}
