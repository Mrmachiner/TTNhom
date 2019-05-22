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
    public partial class TimKiemCa : Form
    {
        public TimKiemCa()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(cbxChonCa.Items.ToString());
            string strconn = "Data Source=DESKTOP-ALHAQAN\\HOANGLE;Initial Catalog=QLPCNhanVien;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            DataSet ds = new DataSet();
            string query = "select yc.NgayTruc as 'Ngày Trực',cb.HoTen 'Cán Bộ' " +
                "from YeuCau yc,CaTruc ct,CanBo cb,PhanCong pc " +
                "where yc.YeuCauID=pc.YeuCauID and pc.CaTrucID=ct.CaTrucID and cb.CanBoID=pc.CanBoID and  yc.NgayTruc BETWEEN ' "
                + tuNgay.Text.ToString()
                + "'and'"
                + denNgay.Text.ToString()
                + "'and "
                + "ct.TenCa=N'"
                + cbxChonCa.SelectedValue.ToString()
                + "'"
                ;

            //"where yc.YeuCauID = ct.CaTrucID and cb.HoTen = N'txtTimKiem.text' and yc.NgayTruc BETWEEN '" +tuNgay.Value.ToString()+"'and'"+denNgay.Value.ToString()+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            dtGridTimCa.DataSource = ds.Tables[0].DefaultView;
            con.Close();
            
        }

        private void dtGridTimCa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<CaTruc> TaoCaTrucMacDinh(/*DateTime dateTime*/)
        {
            List<CaTruc> lstCaTruc = new List<CaTruc>();
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 1",
                //BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 7, 0, 0),
                //KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 9, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 2",
                //KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 11, 30, 0),
                //BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 9, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 3",
                //BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 11, 30, 0),
                //KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 15, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 4",
                //BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 15, 30, 0),
                //KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 18, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 5",
                //BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 18, 30, 0),
                //KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 20, 30, 0)
            });

            return lstCaTruc;
        }
        private void TimKiemCa_Load(object sender, EventArgs e)
        {
            dtGridTimCa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridTimCa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            cbxChonCa.DataSource = TaoCaTrucMacDinh();
            cbxChonCa.DisplayMember = "TenCa";
            cbxChonCa.ValueMember = "TenCa";
        }
    }
}
