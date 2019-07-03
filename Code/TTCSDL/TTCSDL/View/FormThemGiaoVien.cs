using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCSDL.View
{
    public partial class FormThemGiaoVien : Form
    {
        QLThiCCEntities db = new QLThiCCEntities();
        GiaoVien upDateGV = new GiaoVien();
        public FormThemGiaoVien(GiaoVien Obj)
        {
            InitializeComponent();
            if (Obj == null)
            {
                this.Text = "Thêm Giao Viên";
            }
            else
            {
                this.Text = "Sửa Thông Tin Giáo Viên";
                upDateGV = db.GiaoVien.SingleOrDefault(x => x.IDGiaoVien == Obj.IDGiaoVien);
                if (upDateGV.Ho != null)
                {
                    txtHo.Text = upDateGV.Ho.ToString();
                }
                if (upDateGV.Ten != null)
                {
                    txtTen.Text = upDateGV.Ten.ToString();
                }
                if (upDateGV.DonVi != null)
                {
                    txtDonVi.Text = upDateGV.DonVi.ToString();
                }
                if (upDateGV.CapBac != null)
                {
                    txtDonVi.Text = upDateGV.CapBac.ToString();
                }
            }
        }
        GiaoVien gv = new GiaoVien();
        NhiemVu nv = new NhiemVu();
        HoiDong hd = new HoiDong();
        void AddGiaoVien()
        {
            gv.Ho = txtHo.Text.ToString();
            gv.Ten = txtTen.Text.ToString();
            gv.DonVi = txtDonVi.Text.ToString();
            nv.TenNhiemVu= cbxNhiemVu.SelectedItem.ToString();
            gv.CapBac = txtCapBac.Text.ToString();
            hd.IDGiaoVien = gv.IDGiaoVien;
            hd.IDNhiemVu=nv.IDNhiemVu;
            db.GiaoVien.Add(gv);
            db.NhiemVu.Add(nv);
            db.HoiDong.Add(hd);
            db.SaveChanges();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            AddGiaoVien();
            MessageBox.Show("Thêm Giáo Viên Thành Công");
            Close();
        }
    }
}
