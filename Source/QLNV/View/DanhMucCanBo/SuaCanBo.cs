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
    public partial class SuaCanBo : Form
    {
        public SuaCanBo()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtGridSuaCanBo.DataSource = db.CanBo.Where(x => x.HoTen.Contains(txtTimKiem.Text)).ToList();
        }

        private void SuaCanBo_Load(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.OrderByDescending(x => x.CanBoID).ToList();
        }

        private void txtChuVu_TextChanged(object sender, EventArgs e)
        {
            dtGridSuaCanBo.DataSource = db.CanBo.Where(x => x.ChucVu.Contains(txtChuVu.Text)).ToList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int rowId = dtGridSuaCanBo.SelectedCells[0].RowIndex;
            int id = int.Parse(dtGridSuaCanBo.Rows[rowId].Cells[0].Value.ToString());
            CanBo canBo = db.CanBo.SingleOrDefault(x => x.CanBoID == id);
            if (canBo != null)
            {
                this.Close();
                FormThemSua FormThemSuaCanBo = new FormThemSua(canBo);
                FormThemSuaCanBo.ShowDialog();
                FormQuanLyCanBo formQuanLyCanBo = new FormQuanLyCanBo();
                formQuanLyCanBo.Show();
            }
        }
    }
}
