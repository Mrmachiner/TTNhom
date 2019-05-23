using QLNV.Helpers;
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
    public partial class DanhSachCanBo : Form
    {
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        List<CanBo> lstCanBo = new List<CanBo>();
        public DanhSachCanBo(CaTruc caTruc)
        {
            InitializeComponent();
            CaTruc data = db.CaTruc.SingleOrDefault(x => x.CaTrucID == caTruc.CaTrucID);
            foreach (var item in data.PhanCong)
            {
                lstCanBo.Add(item.CanBo);
            }
        }

        private void DanhSachCanBo_Load(object sender, EventArgs e)
        {
            dtDanhSanh.DataSource = lstCanBo;
            dtDanhSanh.Columns.Remove("CanBoID");
            dtDanhSanh.Columns.Remove("DonViID");
            dtDanhSanh.Columns.Remove("PhanCong");
            dtDanhSanh.Columns.Remove("DonVi");
            

        }

        private void dtDanhSanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
