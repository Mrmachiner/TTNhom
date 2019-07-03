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
    public partial class XoaYeuCau : Form
    {
        public XoaYeuCau()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        YeuCauAPIS yeuCauAPIS = new YeuCauAPIS();
        void getDataGrid()
        {
            List<CaTruc> lstYeuCau = db.CaTruc.OrderByDescending(x => x.CaTrucID).ToList();

            gridYeuCau.DataSource = lstYeuCau;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            getDataGrid();
        }

        private void XoaYeuCau_Load(object sender, EventArgs e)
        {
            getDataGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Chac Muon Xoa Khong?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowId = gridYeuCau.SelectedCells[0].RowIndex;
                int id = int.Parse(gridYeuCau.Rows[rowId].Cells[0].Value.ToString());
                //MessageBox.Show("{0}", id.ToString());
                CaTruc caTruc = db.CaTruc.SingleOrDefault(x => x.CaTrucID == id);
                db.PhanCong.RemoveRange(caTruc.PhanCong);
                //YeuCau yeuCau = db.YeuCau.SingleOrDefault(x => x.YeuCauID == id);
                //db.DotCongViec.Remove(yeuCau.DotCongViecID);
                //db.PhanCong.RemoveRange(yeuCau.PhanCong);
                //db.CaTruc.RemoveRange(yeuCau.CaTruc);
                //db.DotCongViec.RemoveRange(yeuCau.DotCongViec);
                db.CaTruc.Remove(caTruc);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                gridYeuCau.DataSource = null;
                getDataGrid();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

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
    }
}
