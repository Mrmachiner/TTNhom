using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//required for sql function sql
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.SqlClient;
using TTCSDL.Helper;

namespace TTCSDL.View
{
    public partial class DSThiSinh : Form
    {
        QLThiCCEntities db = new QLThiCCEntities();
        public DSThiSinh()
        {
            InitializeComponent();
        }
        string query = "select ts.IDThiSinh,ts.Ho as N'Họ',ts.Ten as N'Tên',ts.NgaySinh as N'Ngày Sinh',ts.CMND,nd.DoiTuong as N'Đối Tượng'," +
                            "dbo.TienOn(ts.IDThiSinh) as 'Tiền Ôn'," +
                            "dbo.TienThi(ts.IDThiSinh) as 'Tiền Thi'," +
                            "dbo.TienOn(ts.IDThiSinh) + dbo.TienThi(ts.IDThiSinh) as 'Tổng Tiền'," +
                            "ts.TrangThai as N'Trạng Thái'" +
                            "from ThiSinh ts join NoiDung nd on nd.IDNoiDung=ts.IDNoiDung ";
        genDataGrid g = new genDataGrid();
        private void DSThiSinh_Load(object sender, EventArgs e)
        {
            g.gen(query, dtGridDSThiSinh);
            //getDataGrid();
        }
        private void txtTimHo_TextChanged(object sender, EventArgs e)
        {
            string query = "select ts.IDThiSinh,ts.Ho as N'Họ',ts.Ten as N'Tên',ts.NgaySinh as N'Ngày Sinh',ts.CMND,nd.DoiTuong as N'Đối Tượng'," +
                            "dbo.TienOn(ts.IDThiSinh) as 'Tiền Ôn'," +
                            "dbo.TienThi(ts.IDThiSinh) as 'Tiền Thi'," +
                            "dbo.TienOn(ts.IDThiSinh) + dbo.TienThi(ts.IDThiSinh) as 'Tổng Tiền'," +
                            "ts.TrangThai as N'Trạng Thái'" +
                            "from ThiSinh ts join NoiDung nd on nd.IDNoiDung=ts.IDNoiDung and ts.Ho Like '%"+txtTimHo.Text.ToString()+"%'";
            g.gen(query, dtGridDSThiSinh);
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            
            string query = "select ts.IDThiSinh,ts.Ho as N'Họ',ts.Ten as N'Tên',ts.NgaySinh as N'Ngày Sinh',ts.CMND,nd.DoiTuong as N'Đối Tượng'," +
                            "dbo.TienOn(ts.IDThiSinh) as 'Tiền Ôn'," +
                            "dbo.TienThi(ts.IDThiSinh) as 'Tiền Thi'," +
                            "dbo.TienOn(ts.IDThiSinh) + dbo.TienThi(ts.IDThiSinh) as 'Tổng Tiền'," +
                            "ts.TrangThai as N'Trạng Thái'" +
                            "from ThiSinh ts join NoiDung nd on nd.IDNoiDung=ts.IDNoiDung and ts.Ten Like '%" + txtTimTen.Text.ToString() + "%'";
            g.gen(query, dtGridDSThiSinh);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tt;
            if (cbxTrangThai.SelectedItem.ToString() == "Đã Nộp") {
                tt = 1;
            }
            else tt = 0;
            
            string query = "select ts.IDThiSinh,ts.Ho as N'Họ',ts.Ten as N'Tên',ts.NgaySinh as N'Ngày Sinh',ts.CMND,nd.DoiTuong as N'Đối Tượng'," +
                            "dbo.TienOn(ts.IDThiSinh) as 'Tiền Ôn'," +
                            "dbo.TienThi(ts.IDThiSinh) as 'Tiền Thi'," +
                            "dbo.TienOn(ts.IDThiSinh) + dbo.TienThi(ts.IDThiSinh) as 'Tổng Tiền'," +
                            "ts.TrangThai as N'Trạng Thái'" +
                            "from ThiSinh ts join NoiDung nd on nd.IDNoiDung=ts.IDNoiDung and ts.TrangThai='" + tt + "'";
            g.gen(query, dtGridDSThiSinh);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTimHo.Text =" ";
            txtTimTen.Text = "";
            cbxTrangThai.Text = "";
            g.gen(query, dtGridDSThiSinh);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int rowID = dtGridDSThiSinh.SelectedCells[0].RowIndex;
            int id = int.Parse(dtGridDSThiSinh.Rows[rowID].Cells[0].Value.ToString());
            ThiSinh thiSinh = db.ThiSinh.SingleOrDefault(x => x.IDThiSinh == id);
            if (thiSinh != null)
            {
                //this.Close();
                DangKy dk = new DangKy(thiSinh);
                dk.ShowDialog();
                g.gen(query, dtGridDSThiSinh);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Có Chắc Muốn Xóa Không?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int rowID = dtGridDSThiSinh.SelectedCells[0].RowIndex;
                int id = int.Parse(dtGridDSThiSinh.Rows[rowID].Cells[0].Value.ToString());
                ThiSinh thiSinh = db.ThiSinh.SingleOrDefault(x => x.IDThiSinh == id);
                db.ThiSinh.Remove(thiSinh);
                try
                {
                    db.SaveChanges();
                }
                catch(Exception ex)
                {

                }
                g.gen(query, dtGridDSThiSinh);
            }
        }
    }
}
