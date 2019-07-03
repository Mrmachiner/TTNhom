using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.Helpers;
using QLNV.Model;
using QLNV.View.TimKiem;

namespace QLNV.View
{
    public partial class TimCanBo : Form
    {
        public TimCanBo()
        {
            InitializeComponent();
        }
        private void txtDonVi_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtChuVu_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //dtGridTimCB.DataSource = db.CanBo.Where(x => x.HoTen.Contains(txtTimKiem.Text)).ToList();
        }

        private void TimCanBo_Load(object sender, EventArgs e)
        {
            lstCanBo = db.CanBo.ToList();
            cbxCanBo.DataSource = lstCanBo;
            cbxCanBo.DisplayMember = "HoTen";
            cbxCanBo.ValueMember = "CanBoID";
            dtGridThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridThongKe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
        List<CanBo> lstCanBo = new List<CanBo>();
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        string QueryDateTime(DateTime since, DateTime toDate)
        {
            string Tungay = since.ToString("yyyy/M/d") + " 00:00:00 AM +07:00";
            string DenNgay = toDate.ToString("yyyy/M/d") + " 00:00:00 AM +07:00";
            string query = string.Format("SELECT * from YeuCau where NgayTruc between '{0}' and '{1}'", Tungay, DenNgay);
            return query;
        }
        List<PhanCong> FindListPhanCong(List<YeuCau> dataYeuCau, int canBoID)
        {
            List<PhanCong> lstFindCB = new List<PhanCong>();
            foreach (var yeuCau in dataYeuCau)
            {
                lstFindCB.AddRange(yeuCau.PhanCong.ToList().FindAll(x => x.CanBoID == canBoID));
            }
            return lstFindCB;
        }
        public TimeSpan FomatDate(DateTime dateTime)
        {

            TimeSpan time = new TimeSpan(dateTime.Hour, dateTime.Minute, 0);
            return time;
        }
        public Collection<DataThongKe> GetDateView(List<PhanCong> lstPhanCong)
        {
            Collection<DataThongKe> Data = new Collection<DataThongKe>();
            foreach (var item in lstPhanCong)
            {
                Data.Add(new DataThongKe()
                {
                    GioTrucBatDau = FomatDate((DateTime)item.CaTruc.BatDau),
                    GioTrucKetThuc = FomatDate((DateTime)item.CaTruc.KetThuc),
                    NgayTruc = DateTime.Parse(item.YeuCau.NgayTruc.ToString())
                });
            }
            return Data;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string query = QueryDateTime(tuNgay.Value, denNgay.Value);
            List<YeuCau> lstYeuCau = db.YeuCau.SqlQuery(query).ToList();
            int idCanBo = int.Parse(cbxCanBo.SelectedValue.ToString());
            CanBo canBo = db.CanBo.SingleOrDefault(x => x.CanBoID == idCanBo);
            List<PhanCong> lstPhanTK = FindListPhanCong(lstYeuCau, idCanBo);
            //txtSoLuong.Text = lstPhanTK.Count.ToString();
            //txtChucVu.Text = canBo.ChucVu;
            //txtMaCanBo.Text = canBo.MaCanBo;
            //dtNgaySinh.Value = DateTime.Parse(canBo.NgaySinh.ToString());
            Collection<DataThongKe> dataView = GetDateView(lstPhanTK);
            DataTable dt = ConvertData.ToDataTable<DataThongKe>(dataView);
            dtGridThongKe.DataSource = dt;
            dtGridThongKe.Columns.Remove("GioTrucKetThuc");
        }

        private void dtGridThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
