using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.APIS;
using QLNV.Model;
using QLNV.View;

namespace QLNV
{
    public partial class FormQuanLyYeuCau : Form
    {
        
        public FormQuanLyYeuCau()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        QLPCNhanVienEntities1 db =new QLPCNhanVienEntities1();
        private void FormQuanLyYeuCau_Load(object sender, EventArgs e)
        {
            getDataGrid();
            //gridYeuCau.Columns.Remove("CaTrucID");
            //gridYeuCau.Columns.Remove("BatDau");
            //gridYeuCau.Columns.Remove("KetThuc");
            //gridYeuCau.Columns.Remove("PhanCong");
        }
        YeuCauAPIS yeuCauAPIS = new YeuCauAPIS();
        void getDataGrid()
        {
            List<CaTruc> lstYeuCau = db.CaTruc.OrderByDescending(x=>x.CaTrucID).ToList();
            
            gridYeuCau.DataSource = lstYeuCau;
            gridYeuCau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridYeuCau.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
       
        void CreateYeuCau()
        {
            FormSuaYeuCau formSuaYeuCau = new FormSuaYeuCau(null);
            formSuaYeuCau.ShowDialog();
        }
        private void BtnTaoCa_Click(object sender, EventArgs e)
        {
            CreateYeuCau();
            gridYeuCau.DataSource = null;
            getDataGrid();
        }

        private void gridYeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = this.gridYeuCau.Rows[e.RowIndex];
            //int i= int.Parse(row.Cells["YeuCauID"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

        private  void btnSua_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            getDataGrid();
        }

        private void dtTimKiem_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gridYeuCau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yeuCauBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //TaoDotCongViet taoDotCongViet = new TaoDotCongViet();
            //taoDotCongViet.Show();
        }
    }
}
