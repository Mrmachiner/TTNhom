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
    public partial class RandomNhanSu : Form
    {
        YeuCau yeuCau;
        List<CaTruc> lstCaTruc;
        public RandomNhanSu()
        {
            InitializeComponent();
           
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        List<CanBo> lstCBChon;
        public List<CanBo> RandomNhanSuPhuHop(int soLuong,int isle)
        {
            List<CanBo> data = db.CanBo.ToList();
            CanBo.FindCV(data, (DateTime)yeuCau.DotCongViec.NgayBatDau,(DateTime)yeuCau.DotCongViec.NgayKetThuc);
            List<CanBo>lstCanbo= data.OrderBy(x => x.CountCv).ToList();
            List<CanBo> cbPhuHop = new List<CanBo>();
            for (int i = 0; i < soLuong; i++)
            {
                if(lstCanbo[i].CountCv  < yeuCau.GioHan + isle)
                {
                    cbPhuHop.Add(lstCanbo[i]);
                }
            }
            return cbPhuHop;
        }
        private void RandomNhanSu_Load(object sender, EventArgs e)
        {
           
        }
        int[] chiaSLCongViec = new int[5]{0,0,0,0,0};
        List<string> strTxtBox = new List<string>();
        List<PhanCong> phanCongRandom(List<CanBo> lstCanBoPC,CaTruc caTruc)
        {
            List<PhanCong> phanCongs = new List<PhanCong>();
            foreach (var item in lstCanBoPC)
            {
                phanCongs.Add(new PhanCong()
                {
                    CaTrucID = caTruc.CaTrucID,
                    YeuCauID = yeuCau.YeuCauID,
                    CanBoID = item.CanBoID
                });
            }
            return phanCongs;
        }
        void RemovePhanCong()
        {
            db.PhanCong.RemoveRange(caTrucSelect.PhanCong);
            db.SaveChanges();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        void GetDataCaTruc()
        {
            cbxCaTruc.DataSource = null;
            cbxCaTruc.DataSource = yeuCau.CaTruc.ToList();
            cbxCaTruc.DisplayMember = "TenCa";
            cbxCaTruc.ValueMember = "CaTrucID";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            yeuCau = db.YeuCau.SingleOrDefault(x => x.NgayTruc.Value == dtNgayTruc.Value.Date);
            if(yeuCau == null)
            {
                if (MessageBox.Show("Yêu Cầu chưa được tạo. Bạn muốn tạo yêu cầu?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FormSuaYeuCau formSuaYeuCau = new FormSuaYeuCau(null);
                    formSuaYeuCau.ShowDialog();
                }
                return;
            }
            List<CaTruc> dataCatruc = db.CaTruc.Where(x => x.YeuCauID == yeuCau.YeuCauID).ToList();
            if (yeuCau != null)
            {
                lstCaTruc = dataCatruc;
                if (lstCaTruc.Count != 0)
                {
                    GetDataCaTruc();
                }
                else
                {
                    if (MessageBox.Show("Ngày này chưa có yêu cầu nào trong ngày. Bạn muốn tạo yêu cầu?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FormSuaYeuCau formSuaYeuCau = new FormSuaYeuCau(null);
                        formSuaYeuCau.ShowDialog();
                    }
                }
             
            }
            else
            {
                if (MessageBox.Show("Ngày này chưa có trong đợt. Bạn muốn tạo đợt?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TaoDotCongViet dotCongViet = new TaoDotCongViet();
                    dotCongViet.ShowDialog();
                }
            }

        }
        int CountCongViec()
        {
            int count = 0;
            DotCongViec dotCongViec = db.DotCongViec.SingleOrDefault(x => x.DotCongViecID == yeuCau.DotCongViecID);
            foreach (var item in dotCongViec.YeuCau)
            {
                count = count + item.PhanCong.Count;
            }
            return count;
        }
        CaTruc caTrucSelect;
        private void btnChon_Click(object sender, EventArgs e)
        {
            CaTruc caTruc = (CaTruc)cbxCaTruc.SelectedItem;
            caTrucSelect = caTruc;
            txtDen.Text = caTruc.KetThuc.Value.TimeOfDay.ToString();
            txtTu.Text = caTruc.BatDau.Value.TimeOfDay.ToString();
            txtNhanVien.Text = caTruc.NguoiCan.ToString();
            lstCBChon = new List<CanBo>();
            int SoCongViec = CountCongViec();
            dtGridNhanSu.DataSource = null;
            if (SoCongViec < caTruc.YeuCau.MucGioiHan)
            {
                lstCBChon = RandomNhanSuPhuHop((int)caTruc.NguoiCan, 0);
                dtGridNhanSu.DataSource = lstCBChon;
            }
            if (SoCongViec >= caTruc.YeuCau.MucGioiHan && SoCongViec <= caTruc.YeuCau.DotCongViec.LuongNguoiCan)
            {
                lstCBChon = RandomNhanSuPhuHop((int)caTruc.NguoiCan, 1);
                dtGridNhanSu.DataSource = lstCBChon;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (caTrucSelect.PhanCong.Count != 0)
            {
                RemovePhanCong();
            }
            List<PhanCong> phanCong = phanCongRandom(lstCBChon, caTrucSelect);
            db.PhanCong.AddRange(phanCong);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Phân Công Nhanh Thành Công");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Phân Công Random Xem Lại Thông Tin");
            }

        }
    }
}
