using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.Model;

namespace QLNV.View.DanhMucCanBo
{
    public partial class XoaCanBo : Form
    {
        public XoaCanBo()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        void getDataGrid()
        {
            List<CanBo> canBos = db.CanBo.OrderByDescending(x => x.CanBoID).ToList();
            canBoBindingSource.DataSource = db.CanBo.OrderByDescending(x => x.CanBoID).ToList();
            dtGridXoaCanBo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridXoaCanBo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtGridXoaCanBo.DataSource = db.CanBo.Where(x => x.HoTen.Contains(txtTimKiem.Text)).ToList();
        }

        private void txtChuVu_TextChanged(object sender, EventArgs e)
        {
            dtGridXoaCanBo.DataSource = db.CanBo.Where(x => x.ChucVu.Contains(txtChuVu.Text)).ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Chac Muon Xoa Khong?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowId = dtGridXoaCanBo.SelectedCells[0].RowIndex;
                int id = int.Parse(dtGridXoaCanBo.Rows[rowId].Cells[0].Value.ToString());
                CanBo canBo = db.CanBo.SingleOrDefault(x => x.CanBoID == id);
                db.CanBo.Remove(canBo);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
            getDataGrid();
        }

        private void XoaCanBo_Load(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.OrderByDescending(x => x.CanBoID).ToList();
        }
    }
}
