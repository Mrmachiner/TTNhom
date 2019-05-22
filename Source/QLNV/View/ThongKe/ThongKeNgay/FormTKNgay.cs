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
    public partial class FormTKNgay : Form
    {
        public FormTKNgay()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        List<CaTruc> QueryDateTime(DateTime since, DateTime toDate)
        {
            List<CaTruc> lstYeuCau = new List<CaTruc>();
            string tungayStr = since.ToString("yyyy/M/d") + " 00:00:00 AM +07:00";
            string denNgayStr = toDate.ToString("yyyy/M/d") + " 00:00:00 AM +07:00";
            DateTime? tuNgay = DateTime.Parse(tungayStr);
            DateTime? denNgay = DateTime.Parse(denNgayStr);
            var query = db.CaTruc.AsQueryable();
            lstYeuCau = query.Where(x => x.BatDau >= tuNgay && x.BatDau <= denNgay).ToList();
            return lstYeuCau;
        }
        private void FormTKNgay_Load(object sender, EventArgs e)
        {

            GetDataYeuCau(new List<CaTruc>() {
                new CaTruc(){}
            });
            GetData();
            dtGridThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridThongKe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtDanhSanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtDanhSanh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
       
        List<CanBo> lstCanBoTk;
        void ThongKeNgay(List<CaTruc> yeuCaus)
        {
            int LuongViec = 0;
            lstCanBoTk = new List<CanBo>();
            foreach (var yeuCau in yeuCaus)
            {
                foreach (var phanCong in yeuCau.PhanCong)
                {
                    LuongViec++;
                    if (lstCanBoTk.FindIndex(x => x.CanBoID == phanCong.CanBoID) < 0)
                    {
                        lstCanBoTk.Add(phanCong.CanBo);
                    }
             
                }
            }
            txtSLNguoi.Text = lstCanBoTk.Count.ToString();
            txtSLViec.Text = LuongViec.ToString();
        }
        void GetData()
        {
            List<CanBo> dataCanBo = new List<CanBo>();
            if(lstCanBoTk != null)
            {
                foreach (var item in lstCanBoTk)
                {
                    dataCanBo.Add(db.CanBo.SingleOrDefault(x => x.CanBoID == item.CanBoID));
                }
            }
            if (dataCanBo.Count == 0)
            {
                dataCanBo.Add(new CanBo());
            }
            dtDanhSanh.DataSource = dataCanBo;
            dtDanhSanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtDanhSanh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtDanhSanh.Columns.Remove("MaCanBo");
            dtDanhSanh.Columns.Remove("DonViID");
            dtDanhSanh.Columns.Remove("PhanCong");
            dtDanhSanh.Columns.Remove("DonVi");
            dtDanhSanh.Columns.Remove("CountCv");

        }
        //List<YeuCau> dataYeuCau;
        List<CaTruc> dataYeuCau;
        void GetDataYeuCau(List<CaTruc> lstYeuCau)
        {
            //dataYeuCau = new List<YeuCau>();
             dataYeuCau = new List<CaTruc>();
            if (lstCanBoTk != null)
            {
               
                foreach (var item in lstYeuCau)
                {
                    dataYeuCau.Add(db.CaTruc.SingleOrDefault(x => x.CaTrucID == item.CaTrucID));
                }
                foreach (var item in dataYeuCau)
                {
                    DateTime date = DateTime.Parse(item.BatDau.ToString());
                    item.BatDau = DateTime.Parse(date.ToString("yyyy/M/d"));
                }
            }
            if(dataYeuCau.Count == 0)
            {
                dataYeuCau.Add(new CaTruc());
            }
            dtGridThongKe.DataSource = dataYeuCau;
            dtGridThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridThongKe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //dtGridThongKe.Columns.Remove("YeuCauID");
            //dtGridThongKe.Columns.Remove("IDAdmin");
            //dtGridThongKe.Columns.Remove("CaTruc");
            //dtGridThongKe.Columns.Remove("PhanCong");
            //dtGridThongKe.Columns.Remove("User");
           
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            List<CaTruc> lstYeuCau = QueryDateTime(tuNgay.Value, denNgay.Value);
            ThongKeNgay(lstYeuCau);
            GetData();
            GetData();
            GetDataYeuCau(lstYeuCau);
            GetDataYeuCau(lstYeuCau);
        }

        private void ChiTiet(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtDanhSanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGridThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
