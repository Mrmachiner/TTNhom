using QLNV.Helpers;
using QLNV.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV.View
{
    public partial class FormTKCa : Form
    {
        public FormTKCa()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public Collection<DataThongKeCa> GetDateView(List<CaTruc> lstCaTruc)
        {
            Collection<DataThongKeCa> Data = new Collection<DataThongKeCa>();
            foreach (var item in lstCaTruc)
            {
                Data.Add(new DataThongKeCa()
                {
                    NgayTruc = DateTime.Parse(item.YeuCau.NgayTruc.ToString()),
                    SoNguoi = item.PhanCong.Count,
                });
            }
            return Data;
        }
        List<CaTruc> lstCaTruc;
        Collection<DataThongKeCa> data;
        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            lstCaTruc = QueryDateTime(tuNgay.Value,denNgay.Value,cbxCaTruc.Text);
            txtSoLuong.Text = lstCaTruc.Count.ToString();
            CaTruc caTruc = DefCaTruc.Find(x => x.TenCa.Equals(cbxCaTruc.Text));
            txtKetThuc.Text = ((DateTime)caTruc.KetThuc).ToString("hh:mm");
            txtGioBatDau.Text = ((DateTime)caTruc.BatDau).ToString("hh:mm");
            data = GetDateView(lstCaTruc);
            DataTable dt = ConvertData.ToDataTable<DataThongKeCa>(data);
            dtGridThongKe.DataSource = dt;
        }
        List<CaTruc> QueryDateTime(DateTime since, DateTime toDate,string tenCa)
        {
            List<CaTruc> lstCaTruc = new List<CaTruc>();
            string tungayStr = since.ToString("yyyy/M/d") + " 00:00:00 AM +07:00";
            string denNgayStr = toDate.ToString("yyyy/M/d") + " 00:00:00 AM +07:00";
            DateTime? tuNgay = DateTime.Parse(tungayStr);
            DateTime? denNgay = DateTime.Parse(denNgayStr);
            //string query = string.Format("SELECT * from YeuCau where NgayTruc between '{0}' and '{1}'", Tungay, DenNgay);
            var query = db.CaTruc.AsQueryable();
            lstCaTruc = query.Where(x => x.YeuCau.NgayTruc >= tuNgay && x.YeuCau.NgayTruc <= denNgay && x.TenCa.Equals(tenCa) && x.PhanCong.Count !=0).ToList();
            return lstCaTruc;
        }
        static List<CaTruc> TaoCaTrucMacDinh(DateTime dateTime)
        {
            List<CaTruc> lstCaTruc = new List<CaTruc>();
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 1",
                BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 7, 0, 0),
                KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 9, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 2",
                KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 11, 30, 0),
                BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 9, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 3",
                BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 11, 30, 0),
                KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 15, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 4",
                BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 15, 30, 0),
                KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 18, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 5",
                BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 18, 30, 0),
                KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 20, 30, 0)
            });

            return lstCaTruc;
        }
        List<CaTruc> DefCaTruc = TaoCaTrucMacDinh(DateTime.Now);
        private void FormTKCa_Load(object sender, EventArgs e)
        {
            dtGridThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridThongKe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            cbxCaTruc.DataSource = DefCaTruc;
            cbxCaTruc.DisplayMember = "TenCa";
            cbxCaTruc.ValueMember = "TenCa";
        }

        private void dtGridThongKe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowId = dtGridThongKe.SelectedCells[0].RowIndex;
            DateTime ngayTruc = DateTime.Parse(dtGridThongKe.Rows[rowId].Cells[0].Value.ToString());
            CaTruc dataThongKeCa = lstCaTruc.ToList().Find(x => x.YeuCau.NgayTruc == ngayTruc);
            if(dataThongKeCa.PhanCong.Count == 0)
            {
                MessageBox.Show("Ca Này không có người làm");
            }
            DanhSachCanBo danhSachCanBo = new DanhSachCanBo(dataThongKeCa);
            danhSachCanBo.Show();
        }

        private void cbxCaTruc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtGridThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
