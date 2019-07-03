using QLNV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV.View.TimKiem
{
    public partial class TimKiemNgay : Form
    {
        public TimKiemNgay()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        //List<YeuCau> QueryDateTime(DateTime since, DateTime toDate)
        //{
        //    List<YeuCau> lstYeuCau = new List<YeuCau>();
        //    string tungayStr = since.ToString("yyyy/M/d") + " 00:00:00 AM +07:00";
        //    string denNgayStr = toDate.ToString("yyyy/M/d") + " 00:00:00 AM +07:00";
        //    DateTime? tuNgay = DateTime.Parse(tungayStr);
        //    DateTime? denNgay = DateTime.Parse(denNgayStr);
        //    var query = db.YeuCau.AsQueryable();
        //    lstYeuCau = query.Where(x => x.NgayTruc >= tuNgay && x.NgayTruc <= denNgay).ToList();
        //    return lstYeuCau;
        //}
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //List<YeuCau> lstYeuCau = QueryDateTime(tuNgay.Value, denNgay.Value);
            //List<YeuCau> dataYeuCau = new List<YeuCau>();
            //foreach (var item in lstYeuCau)
            //{
            //    dataYeuCau.Add(db.YeuCau.SingleOrDefault(x => x.YeuCauID == item.YeuCauID));
            //}
            //foreach (var item in dataYeuCau)
            //{
            //    DateTime date = DateTime.Parse(item.NgayTruc.ToString());
            //    item.NgayTruc = DateTime.Parse(date.ToString("yyyy/M/d"));
            //}
            //dtGridThongKe.DataSource = dataYeuCau;
            string strconn = "Data Source=DESKTOP-ALHAQAN\\HOANGLE;Initial Catalog=QLPCNhanVien;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            DataSet ds = new DataSet();
            string query = "select yc.NgayTruc NgàyTrực,ct.BatDau BắtĐầu ,cb.HoTen HọTên " +
                "from YeuCau yc,CaTruc ct,CanBo cb,PhanCong pc " +
                "where yc.YeuCauID=pc.YeuCauID and pc.CaTrucID=ct.CaTrucID and cb.CanBoID=pc.CanBoID and  yc.NgayTruc BETWEEN ' "
                + tuNgay.Text.ToString()
                + "' and '"
                + denNgay.Text.ToString()
                + " ' ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            dtGridThongKe.DataSource = ds.Tables[0].DefaultView;
            con.Close();
            //dtGridThongKe.DataSource = null;
            //dtGridThongKe.Columns.Remove("NgàyTrực");
            //dtGridThongKe.Columns.Remove("BắtĐầu");
            //dtGridThongKe.Columns.Remove("HọTên");
            //dtGridThongKe.Columns.Remove("User");
            //dtGridThongKe.Columns[0].HeaderText = "Ngày Trực";
            //dtGridThongKe.Columns[1].HeaderText = "Bắt Đầu";
            //dtGridThongKe.Columns[2].HeaderText = "Họ Tên";
        }

        private void TimKiemNgay_Load(object sender, EventArgs e)
        {
            dtGridThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridThongKe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void ChiTiet(object sender, DataGridViewCellEventArgs e)
        {
            //int rowId = dtGridThongKe.SelectedCells[0].RowIndex;
            //var id = int.Parse(dtGridThongKe.Rows[rowId].Cells[0].Value.ToString());
            //YeuCau dataThongKe = db.YeuCau.SingleOrDefault(x => x.YeuCauID == id);
            //DanhSachCaTruc danhSachCanBo = new DanhSachCaTruc(dataThongKe);
            //danhSachCanBo.Show();
        }

        private void tuNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lable_Click(object sender, EventArgs e)
        {

        }

        private void denNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtGridThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
