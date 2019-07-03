using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCSDL.Helper;
using TTCSDL.View.Diem;

namespace TTCSDL.View
{
    public partial class FormDSDiem : Form
    {
        public FormDSDiem()
        {
            InitializeComponent();
        }
        QLThiCCEntities db = new QLThiCCEntities();
        genDataGrid g = new genDataGrid();

        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            cbxDot.DataSource = db.DotThi.ToList();
        }

        private void cbxDot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select	ts.IDThiSinh,dst.SBD,ts.Ho+' '+ts.Ten as N'Họ Tên',ts.NgaySinh as N'Ngày Sinh',ts.CMND," +
                "dstb.DiemTN as N'Điểm TN',dstb.KichThuocWord N'Kích Thước W',dstb.KichThuocExcel as N'Kích Thước E',dstb.KichThuocPpt as N'Kích Thước P'" +
                "from ThiSinh ts join DanhSachThi dst on ts.IDThiSinh = dst.IDThiSinh " +
                "join DanhSachThuBai dstb on dstb.IDThi = dst.IDThi " +
                "join DotThi dt on dt.IDDotThi = dst.IDDotThi and dt.IDDotThi = '" + cbxDot.SelectedItem.ToString() + "'";
            g.gen(query, dtGridNhapDiem);
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dtGridNhapDiem.DataSource, "Họ Tên", true);
            txtSBD.DataBindings.Clear();
            txtSBD.DataBindings.Add("Text", dtGridNhapDiem.DataSource, "SBD", true);
            dtNgaySinh.DataBindings.Clear();
            dtNgaySinh.DataBindings.Add("Value", dtGridNhapDiem.DataSource, "Ngày Sinh", true);
            txtDiemTN.DataBindings.Clear();
            txtDiemTN.DataBindings.Add("Text", dtGridNhapDiem.DataSource, "Điểm TN", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKTe.DataBindings.Clear();
            txtKTe.DataBindings.Add("Text", dtGridNhapDiem.DataSource, "Kích Thước E", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKTp.DataBindings.Clear();
            txtKTp.DataBindings.Add("Text", dtGridNhapDiem.DataSource, "Kích Thước P", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKTw.DataBindings.Clear();
            txtKTw.DataBindings.Add("Text", dtGridNhapDiem.DataSource, "Kích Thước W", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DanhSachThuBai dstb = new DanhSachThuBai();
            dstb.DiemTN = Convert.ToDouble(txtDiemTN.Text.ToString());
            dstb.KichThuocExcel = Convert.ToDouble(txtKTe.Text.ToString());
            dstb.KichThuocPpt = Convert.ToDouble(txtKTp.Text.ToString());
            dstb.KichThuocWord = Convert.ToDouble(txtKTw.Text.ToString());
            db.SaveChanges();
            MessageBox.Show("Lưu Thành Công!");
        }
    }
}
