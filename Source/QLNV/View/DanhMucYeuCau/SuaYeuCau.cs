using QLNV.APIS;
using QLNV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV.View.DanhMucYeuCau
{
    public partial class SuaYeuCau : Form
    {
        public SuaYeuCau()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tungayStr = dtTimKiem.Value.ToString("yyyy/M/d") + " 00:00:00 AM +07:00";
            DateTime dateTime = DateTime.Parse(tungayStr);
            List<YeuCau> yeuCau = db.YeuCau.Where(x => x.NgayTruc == dateTime).ToList();
            List<CaTruc> dataCaTruc = new List<CaTruc>();
            foreach (var item in yeuCau)
            {
                dataCaTruc.AddRange(item.CaTruc);
            }
            gridYeuCau.DataSource = null;
            gridYeuCau.DataSource = dataCaTruc;
        }
        YeuCauAPIS yeuCauAPIS = new YeuCauAPIS();
        void getDataGrid()
        {
            List<CaTruc> lstYeuCau = db.CaTruc.OrderByDescending(x => x.CaTrucID).ToList();

            gridYeuCau.DataSource = lstYeuCau;
            gridYeuCau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridYeuCau.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void SuaYeuCau_Load(object sender, EventArgs e)
        {
            getDataGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int rowId = gridYeuCau.SelectedCells[0].RowIndex;

            int id = int.Parse(gridYeuCau.Rows[rowId].Cells[0].Value.ToString());
            //int Ngay = int.Parse(gridYeuCau.Rows[rowId].Cells[2].Value.ToString());
            //MessageBox.Show(Ngay.ToString());
            CaTruc caTruc = db.CaTruc.SingleOrDefault(x => x.CaTrucID == id);
            //CaTruc caTrucNgay = db.CaTruc.SingleOrDefault(x => x.BatDau.ToString() == Ngay.ToString());

            if (caTruc != null)
            {
                this.Close();
                FormQuanLyYeuCau formQuanLyYeuCau = new FormQuanLyYeuCau();
                FormSuaYeuCau formSuaYeuCau = new FormSuaYeuCau(caTruc);
                formSuaYeuCau.ShowDialog();
                formQuanLyYeuCau.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getDataGrid();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
