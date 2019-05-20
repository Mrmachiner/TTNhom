using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.Model;
using QLNV.Helpers;
using QLNV.APIS;

namespace QLNV.View
{
    public partial class FormSuaYeuCau : Form
    {
        bool succsef ;
        bool isUpdate = false;
        CaTruc updYeuCau;
        int GioiHan= 0;
        int MucGioiHan = 0;
        public FormSuaYeuCau(CaTruc obj)
        {
            InitializeComponent();
            if(obj== null)
            {
                succsef = false;
                this.Text = "Thêm Yêu Cầu";
            }
            else
            {
                succsef = false;
                this.Text = "Sửa Yêu Cầu";
                isUpdate = true;
                updYeuCau = db.CaTruc.SingleOrDefault(x => x.CaTrucID == obj.CaTrucID);
                dtNgayNhap.Value = DateTime.Parse(updYeuCau.BatDau.ToString());
                txtSoNguoiLam.Text = updYeuCau.NguoiCan.ToString();
                //dtNgayNhap = (DateTime)ngay;
            }
        }
        CaTruc TaoCaTrucMacDinh(DateTime dateTime,string tenCa)
        {
            List<CaTruc> lstCaTruc = new List<CaTruc>();
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 1",
                BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 7, 0, 0),
                KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 9, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 2",
                KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 11, 30, 0),
                BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 9, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 3",
                BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 11, 30, 0),
                KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 15, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 4",
                BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 15, 30, 0),
                KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 18, 30, 0)
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 5",
                BatDau = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 18, 30, 0),
                KetThuc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 20, 30, 0)
            });
            CaTruc caTruc = lstCaTruc.Find(x => x.TenCa == tenCa);
            return caTruc;
        }
        private void FormSuaYeuCau_Load(object sender, EventArgs e)
        {
            string[] tenCa = new string[5]{ "Ca 1","Ca 2","Ca 3","Ca 4","Ca 5"};
            cbxChonCa.DataSource = tenCa;
            if(updYeuCau != null)
            {
                cbxChonCa.SelectedItem = updYeuCau.TenCa;
            }
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        bool CkeckValue(DateTime ngayTruc)
        {
            List<YeuCau> lstYeuCau = null;
            lstYeuCau=db.YeuCau.Where(x => x.NgayTruc.Value == ngayTruc.Date).ToList();
            if(lstYeuCau.Count == 0)
            {
                return true;
            }
            return false;
        }
        bool CkeckSoLuongCa(YeuCau yeuCau,CaTruc caTruc)
        {
           
            DotCongViec dotCongViec = db.DotCongViec.SingleOrDefault(x => x.DotCongViecID == yeuCau.DotCongViecID);
            int ckeckCount = 0;
            if(caTruc.CaTrucID == 0)
            {
                foreach (var item in dotCongViec.YeuCau)
                {
                    foreach (var caTrucCount in item.CaTruc)
                    {
                        ckeckCount = ckeckCount + (int)caTrucCount.NguoiCan;
                    }
                }
            }
            else
            {
                int CountNCan = (int)db.CaTruc.SingleOrDefault(x => x.CaTrucID == caTruc.CaTrucID).NguoiCan;
                foreach (var item in dotCongViec.YeuCau)
                {
                    foreach (var caTrucCount in item.CaTruc)
                    {
                        ckeckCount = ckeckCount + (int)caTrucCount.NguoiCan;
                    }
                }
                ckeckCount = ckeckCount - CountNCan;

            }

            ckeckCount = ckeckCount + (int)caTruc.NguoiCan;
            if (ckeckCount > yeuCau.DotCongViec.LuongNguoiCan)
            {
                MessageBox.Show("Số lượng người quá nhiều so với đợt.");
                return false;
            }
            else if (ckeckCount > yeuCau.DotCongViec.LuongNguoiCan)
            {
                MessageBox.Show("So Lượng Người Đã Đủ Tạo Đợt Mới.");
                return false;
            }
            return true;
        }
        void SaveYeuCauNew()
        {
            DateTime NgayCaTruc = ValidateHelper.FomatDateDef(dtNgayNhap.Value);
            YeuCau yeuCau = db.YeuCau.SingleOrDefault(x => x.NgayTruc == NgayCaTruc);
           
            CaTruc caTrucTao = TaoCaTrucMacDinh(NgayCaTruc, cbxChonCa.SelectedValue.ToString());
            List<CaTruc> CkeckCatruc = db.CaTruc.Where(x => x.TenCa == caTrucTao.TenCa && x.BatDau == caTrucTao.BatDau && x.KetThuc == caTrucTao.KetThuc).ToList();
            if (CkeckCatruc.Count != 0)
            {
                MessageBox.Show("Ca Trực Này Đã Tồn Tại");
                return;
            }
            if (yeuCau != null)
            {
                GioiHan = (int)yeuCau.DotCongViec.LuongNguoiCan / db.CanBo.ToList().Count;
                MucGioiHan = GioiHan * db.CanBo.ToList().Count;
                CaTruc caTruc = TaoCaTrucMacDinh(NgayCaTruc, cbxChonCa.SelectedValue.ToString());
                caTruc.YeuCauID = yeuCau.YeuCauID;
                caTruc.YeuCau = yeuCau;
                if (ValidateHelper.IsNumber(txtSoNguoiLam.Text.ToString()))
                {
                    caTruc.NguoiCan = int.Parse(txtSoNguoiLam.Text.ToString());
                }
                else
                {
                    MessageBox.Show("Hãy Nhập Số Vào Số Lượng Người Cần");
                    return;
                }
                if (CkeckSoLuongCa(yeuCau, caTruc))
                {
                    db.CaTruc.Add(caTruc);
                    succsef = true;
                }
                db.SaveChanges();
            }
            else
            {
                if (MessageBox.Show("Chưa có đợt cho ngày này. Bạn có muốn tạo đợt ?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TaoDotCongViet f = new TaoDotCongViet();
                    f.ShowDialog();
                }
            }
        }
        void UpdateYeuCau()
        {
            DateTime NgayCaTruc = ValidateHelper.FomatDateDef(dtNgayNhap.Value);
            YeuCau yeuCau = db.YeuCau.SingleOrDefault(x => x.NgayTruc == NgayCaTruc);
            if (yeuCau != null)
            {
                CaTruc caTruc = TaoCaTrucMacDinh(NgayCaTruc, cbxChonCa.SelectedValue.ToString());
                List<CaTruc> CkeckCatruc = db.CaTruc.Where(x => x.TenCa == caTruc.TenCa && x.BatDau == caTruc.BatDau && x.KetThuc == caTruc.KetThuc).ToList();
                if(CkeckCatruc != null && updYeuCau.YeuCau.NgayTruc.Value.Date != NgayCaTruc.Date)
                {
                    MessageBox.Show("Ca Trực Này Đã Tồn Tại");
                    return;
                }
                caTruc.YeuCauID = yeuCau.YeuCauID;
                caTruc.YeuCau = yeuCau;
                caTruc.CaTrucID = updYeuCau.CaTrucID;
                if (ValidateHelper.IsNumber(txtSoNguoiLam.Text.ToString()))
                {
                    caTruc.NguoiCan = int.Parse(txtSoNguoiLam.Text.ToString());
                }
                else
                {
                    MessageBox.Show("Hãy Nhập Số Vào Số Lượng Người Cần");
                    return;
                }
                if (CkeckSoLuongCa(yeuCau, caTruc))
                {
                    db.PhanCong.RemoveRange(updYeuCau.PhanCong);
                    updYeuCau.NguoiCan = caTruc.NguoiCan;
                    updYeuCau.BatDau = caTruc.BatDau;
                    updYeuCau.KetThuc = caTruc.KetThuc;
                    updYeuCau.TenCa = caTruc.TenCa;
                    updYeuCau.YeuCau = caTruc.YeuCau;
                    updYeuCau.YeuCauID = caTruc.YeuCauID;
                    db.SaveChanges();
                    succsef = true;
                }
               
            }
            else
            {
                if (MessageBox.Show("Chưa có đợt cho ngày này. Bạn có muốn tạo đợt ?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TaoDotCongViet f = new TaoDotCongViet();
                    f.ShowDialog();

                }
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                
                SaveYeuCauNew();
                if (succsef)
                {
                    this.Close();
                }
                
            }
            else
            {
                UpdateYeuCau();
                if (succsef)
                {
                    this.Close();
                }
            }
        }

        private void dtNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
