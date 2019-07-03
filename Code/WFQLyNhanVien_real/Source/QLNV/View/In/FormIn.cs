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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLNV.View.In
{
    public partial class FormIn : Form
    {
        public FormIn()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string strconn = "Data Source=DESKTOP-ALHAQAN\\HOANGLE;Initial Catalog=QLPCNhanVien;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            DataSet ds = new DataSet();
            string query = "select yc.YeuCauID 'Yêu Cầu ID',yc.NgayTruc 'Ngày Trực',ct.TenCa 'Tên Ca' ,cb.HoTen 'Họ Tên' " +
                "from YeuCau yc,CaTruc ct,CanBo cb,PhanCong pc " +
                "where yc.YeuCauID=pc.YeuCauID and pc.CaTrucID=ct.CaTrucID and cb.CanBoID=pc.CanBoID and  yc.NgayTruc BETWEEN ' "
                + tuNgay.Text.ToString()
                + "' and '"
                + denNgay.Text.ToString()
                + " ' ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            //dtGridThongKe.DataSource = ds.Tables[0].Columns[1];
            dtGridThongKe.DataSource = ds.Tables[0].DefaultView;
            con.Close();
            
        }
        private void export2excel(DataGridView g,string duongDan,string tenTep)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for(int i = 0; i < g.Rows.Count; i++)
            {
                for(int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            MessageBox.Show("Đã in vào ổ D:\\"+txtTenFile.Text.ToString());
        }
        DateTime dt = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenFile.Text == "")
            {
                MessageBox.Show("Không Được Để Trống");
            }
            else
            {
                export2excel(dtGridThongKe, "D:\\", txtTenFile.Text.ToString() + dt.ToString("dd-MM-yyyy"));
            }
        }
    }

}
