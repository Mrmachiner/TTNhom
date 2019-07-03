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
    public partial class LichTrucf : Form
    {
        public LichTrucf(string tuNgay,string denNgay,string txtTimKiem)
        {
            InitializeComponent();
            string strconn = "Data Source=DESKTOP-ALHAQAN\\HOANGLE;Initial Catalog=QLPCNhanVien;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            DataSet ds = new DataSet();
            //string query = "select yc.NgayTruc NgàyTrực,ct.TenCa TênCa,ct.BatDau BắtĐầu " +
            //    "from YeuCau yc,CaTruc ct,CanBo cb " +
            //    "where yc.YeuCauID = ct.CaTrucID and cb.HoTen = N'" + txtTimKiem.Text.ToString() + "'and'" + "yc.NgayTruc BETWEEN '" + "'" +
            //    tuNgay.Value.ToString() + "'and'"
            //    + denNgay.Value.ToString() + "'";
            string query = "select yc.NgayTruc NgàyTrực,ct.TenCa TênCa,ct.BatDau BắtĐầu " +
                "from YeuCau yc , CaTruc ct , CanBo cb , PhanCong pc " +
                "where yc.YeuCauID = pc.YeuCauID and pc.CaTrucID = ct.CaTrucID and cb.CanBoID = pc.CanBoID and  yc.NgayTruc BETWEEN ' "
                + tuNgay
                + "'and'"
                + denNgay
                + "'and "
                + "cb.HoTen=N'"
                + txtTimKiem
                + "'"
                ;

            //"where yc.YeuCauID = ct.CaTrucID and cb.HoTen = N'txtTimKiem.text' and yc.NgayTruc BETWEEN '" +tuNgay.Value.ToString()+"'and'"+denNgay.Value.ToString()+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            dtGridLich.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LichTrucf_Load(object sender, EventArgs e)
        {
            
        }
    }
}
