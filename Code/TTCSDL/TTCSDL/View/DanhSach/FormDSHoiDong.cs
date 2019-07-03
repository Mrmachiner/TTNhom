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
using TTCSDL.Helper;

namespace TTCSDL.View.DanhSach
{
    public partial class FormDSHoiDong : Form
    {
        QLThiCCEntities db = new QLThiCCEntities();
        public FormDSHoiDong()
        {
            InitializeComponent();
        }

        private void DSHoiDong_Load(object sender, EventArgs e)
        {
            cbxDot.DataSource = db.DotThi.ToList();

        }
        DateTime dt = DateTime.Now;
        private void btnIn_Click(object sender, EventArgs e)
        {
            
            if (txtTenFile.Text == "")
            {
                MessageBox.Show("Không Được Để Trống");
            }
            else
            {
                exportExcel ex = new exportExcel();
                ex.exportexcel(dtGridHoiDong, "D:\\", txtTenFile.Text.ToString() + dt.ToString("dd-MM-yyyy"));
            }
        }

        private void cbxDot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select gv.Ho as N'Họ',gv.Ten as N'Tên',gv.DonVi as N'Đơn Vị',gv.CapBac as N'Cấp Bậc',nv.TenNhiemVu as N'Tên Nhiệm Vụ'" +
                "from GiaoVien gv join HoiDong hd on gv.IDGiaoVien=hd.IDGiaoVien " +
                "join NhiemVu nv on nv.IDNhiemVu=hd.IDNhiemVu " +
                "join DotThi dt on dt.IDDotThi=hd.IDDotThi and dt.IDDotThi='" + cbxDot.SelectedValue.ToString() + "'";
            genDataGrid g = new genDataGrid();
            g.gen(query, dtGridHoiDong);
        }
    }
}
