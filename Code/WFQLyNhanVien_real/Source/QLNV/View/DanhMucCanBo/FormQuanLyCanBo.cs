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
using QLNV.APIS;
using QLNV.View;
using System.Data.Entity.Infrastructure;
using System.Collections.ObjectModel;

namespace QLNV
{
    public partial class FormQuanLyCanBo : Form
    {
        public FormQuanLyCanBo()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void FormQuanLyCanBo_Load(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.OrderByDescending(x => x.CanBoID).ToList();
        }

        private  void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSua formThemSua = new FormThemSua(null);
            formThemSua.ShowDialog();
            getDataGrid();
        }
        void getDataGrid()
        {
            List<CanBo> canBos = db.CanBo.OrderByDescending(x => x.CanBoID).ToList();
            canBoBindingSource.DataSource = db.CanBo.OrderByDescending(x=>x.CanBoID).ToList();
            dtGridQLCanBo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridQLCanBo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
          
                int rowId = dtGridQLCanBo.SelectedCells[0].RowIndex;
                int id = int.Parse(dtGridQLCanBo.Rows[rowId].Cells[0].Value.ToString());
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Chac Muon Xoa Khong?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowId= dtGridQLCanBo.SelectedCells[0].RowIndex;
                int id = int.Parse(dtGridQLCanBo.Rows[rowId].Cells[0].Value.ToString());
                CanBo canBo=db.CanBo.SingleOrDefault(x => x.CanBoID == id);
                db.PhanCong.RemoveRange(canBo.PhanCong);
                db.CanBo.Remove(canBo);
                try
                {
                    db.SaveChanges();
                }catch(Exception ex)
                {

                }
            }
            getDataGrid();
        }

        private void btnLuu_Click(object sender, EventArgs e)   
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void txtDonVi_TextChanged(object sender, EventArgs e)
        {
            //dtGridQLCanBo.DataSource = db.CanBo.Where(x => x.DonVi.Contains(txtDonVi.Text)).ToList();
        }

        private void txtChuVu_TextChanged(object sender, EventArgs e)
        {
            dtGridQLCanBo.DataSource = db.CanBo.Where(x => x.ChucVu.Contains(txtChuVu.Text)).ToList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtGridQLCanBo.DataSource = db.CanBo.Where(x => x.HoTen.Contains(txtTimKiem.Text)).ToList();
        }

        private void dtGridQLCanBo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
