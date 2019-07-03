using QLNV.APIS;
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
    public partial class TaoDotCongViet : Form
    {
        public TaoDotCongViet()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        List<YeuCau> TaoYeuCau(DateTime? tuNgay, DateTime? denNgay, int SoLuongCan, int id)
        {
            int SoNguoi = db.CanBo.ToList().Count;
            int GioiHan = SoLuongCan / SoNguoi;
            int LuongGioiHan = SoNguoi * GioiHan;
            List<DateTime> dateYeuCaus = ValidateHelper.ListDate((DateTime)tuNgay, (DateTime)denNgay).ToList();
            List<YeuCau> yeuCaus = new List<YeuCau>();
            foreach (var item in dateYeuCaus)
            {
                yeuCaus.Add(new YeuCau()
                {
                    DotCongViecID = id,
                    GioHan = GioiHan,
                    NgayTruc = item,
                    MucGioiHan = LuongGioiHan
                });
            }
            return yeuCaus;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DotCongViec dotCongViec = new DotCongViec();
            if (ValidateHelper.IsNumber(txtSoNgCan.Text.ToString()))
            {
                dotCongViec.LuongNguoiCan = int.Parse(txtSoNgCan.Text.ToString());
            }
            else
            {
                MessageBox.Show("Nhập Số!");
                return;
            }
            dotCongViec.NgayBatDau = ValidateHelper.FomatDateDef(dtTuNgay.Value);
            dotCongViec.NgayKetThuc = ValidateHelper.FomatDateDef(dtDenNgay.Value);
            if (ValidateHelper.ToDate((DateTime)dotCongViec.NgayBatDau, (DateTime)dotCongViec.NgayKetThuc))
            {
                MessageBox.Show("Ngày bắt đầu và Ngày kết thúc.Không Hợp Lý");
                return;
            }
            List<YeuCau> lstYeuCau = db.YeuCau.Where(x => x.NgayTruc >= dotCongViec.NgayBatDau && x.NgayTruc <= dotCongViec.NgayKetThuc).ToList();
            if (lstYeuCau.Count > 0)
            {
                MessageBox.Show("Trùng Đợt Yêu Cầu");
                return;
            }
            db.DotCongViec.Add(dotCongViec);
            List<YeuCau> yeuCaus = TaoYeuCau(dotCongViec.NgayBatDau, dotCongViec.NgayKetThuc, (int)dotCongViec.LuongNguoiCan, dotCongViec.DotCongViecID);
            db.YeuCau.AddRange(yeuCaus);
            db.SaveChanges();
            MessageBox.Show("Tạo đợt thành công");
            this.Close();
        }

        private void TaoDotCongViet_Load(object sender, EventArgs e)
        {

        }

        private void dtDenNgay_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}

