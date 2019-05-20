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

namespace QLNV.View
{
    public partial class frmQuanLyDot : Form
    {
        public frmQuanLyDot()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        private void frmQuanLyDot_Load(object sender, EventArgs e)
        {
            
            dotCongViecBindingSource.DataSource = db.DotCongViec.OrderByDescending(x => x.DotCongViecID).ToList();
            dtGridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        void GetData()
        {
            dotCongViecBindingSource.DataSource = db.DotCongViec.OrderByDescending(x => x.DotCongViecID).ToList();
            dtGridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //TaoDotCongViet frm = new TaoDotCongViet();
            //frm.ShowDialog();
            //GetData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Chac Muon Xoa Khong?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowId = dtGridData.SelectedCells[0].RowIndex;
                int id = int.Parse(dtGridData.Rows[rowId].Cells[0].Value.ToString());
                DotCongViec dotCongViec = db.DotCongViec.SingleOrDefault(x => x.DotCongViecID == id);
                foreach (var item in dotCongViec.YeuCau)
                {
                    db.PhanCong.RemoveRange(item.PhanCong);
                    db.CaTruc.RemoveRange(item.CaTruc);
                }
                db.YeuCau.RemoveRange(dotCongViec.YeuCau);
                db.DotCongViec.Remove(dotCongViec);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
            GetData();
        }

        private void dtGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
