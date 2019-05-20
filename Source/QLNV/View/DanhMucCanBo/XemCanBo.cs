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
    public partial class XemCanBo : Form
    {
        public XemCanBo()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        private void XemCanBo_Load(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.OrderByDescending(x => x.CanBoID).ToList();
        }
      
        void getDataGrid()
        {
            List<CanBo> canBos = db.CanBo.OrderByDescending(x => x.CanBoID).ToList();
            canBoBindingSource.DataSource = db.CanBo.OrderByDescending(x => x.CanBoID).ToList();
            dtGridXemCanBo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridXemCanBo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtGridXemCanBo.DataSource = db.CanBo.Where(x => x.HoTen.Contains(txtTimKiem.Text)).ToList();
        }

        private void txtChuVu_TextChanged(object sender, EventArgs e)
        {
            dtGridXemCanBo.DataSource = db.CanBo.Where(x => x.ChucVu.Contains(txtChuVu.Text)).ToList();
        }

        private void txtDonVi_TextAlignChanged(object sender, EventArgs e)
        {
            //dtGridXemCanBo.DataSource = db.CanBo.Where(x => x.DonVi.TenDonVi.Contains(txtChuVu.Text)).ToList();
        }

        private void txtDonVi_TextChanged(object sender, EventArgs e)
        {
            dtGridXemCanBo.DataSource = db.CanBo.Where(x => x.DonVi.TenDonVi.Contains(txtDonVi.Text)).ToList();
        }
    }
}
