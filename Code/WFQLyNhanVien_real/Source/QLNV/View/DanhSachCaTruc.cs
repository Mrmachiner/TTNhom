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
    public partial class DanhSachCaTruc : Form
    {
        List<CaTruc> defCaTruc = new List<CaTruc>();
        public DanhSachCaTruc(YeuCau yeuCau)
        {
            InitializeComponent();
            defCaTruc = yeuCau.CaTruc.ToList();
        }

        private void DanhSachCaTruc_Load(object sender, EventArgs e)
        {
            cbxCaTruc.DataSource = defCaTruc;
            cbxCaTruc.DisplayMember = "TenCa";
            cbxCaTruc.ValueMember = "CaTrucID";
            dtDanhSanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtDanhSanh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
            int id = int.Parse(cbxCaTruc.SelectedValue.ToString());
            CaTruc caTruc = db.CaTruc.SingleOrDefault(x => x.CaTrucID == id);
            List<CanBo> lstCanBo = new List<CanBo>();
            txtGioKetThuc.Text = ((DateTime)caTruc.KetThuc).TimeOfDay.ToString();
            txtGioBatDau.Text = ((DateTime)caTruc.BatDau).TimeOfDay.ToString();
            txtNgayTruc.Text = ((DateTime)caTruc.BatDau).ToString("yyyy/M/d");
            txtSoNguoi.Text = caTruc.PhanCong.Count.ToString();
            foreach (var item in caTruc.PhanCong)
            {
                lstCanBo.Add(item.CanBo);
            }
            dtDanhSanh.DataSource = lstCanBo;
            dtDanhSanh.Columns.Remove("CanBoID");
            dtDanhSanh.Columns.Remove("DonViID");
            dtDanhSanh.Columns.Remove("PhanCong");
            dtDanhSanh.Columns.Remove("DonVi");
        }
    }
}
