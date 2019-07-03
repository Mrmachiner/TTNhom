using QLNV.Helpers;
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
using QLNV.View;
using QLNV.View.DanhMucYeuCau;
using QLNV.View.TimKiem;
using QLNV.View.DanhMucCanBo;
using QLNV.View.In;

namespace QLNV
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        private void quảnLýYêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyYeuCau f = new FormQuanLyYeuCau();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyCanBo f = new FormQuanLyCanBo();
            f.MdiParent = this;
            f.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.MdiParent = this;
            f.Show();
            
        }

        public void FormTrangChu_Load(object sender, EventArgs e)
        {
            
        }
        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                tKTheoCaToolStripMenuItem.Enabled = true;
                tKTheoNgàyToolStripMenuItem.Enabled = true;
                tKTheoCánBộToolStripMenuItem.Enabled = true;
            }
        }
        private void tKTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTKNgay f = new FormTKNgay();
            f.Show();
        }

        private void tKTheoCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTKCanBo f = new FormTKCanBo();
            f.Show();
        }

        private void tKTheoCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTKCa f = new FormTKCa();
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.isLoginSess = false;
            tKTheoCaToolStripMenuItem.Enabled = false;
            tKTheoNgàyToolStripMenuItem.Enabled = false;
            tKTheoCánBộToolStripMenuItem.Enabled = false;            
            FormDangNhap fdn = new FormDangNhap();
            fdn.Close();
            FormQuanLyYeuCau fQlyc = new FormQuanLyYeuCau();
            fQlyc.Close();
            FormQuanLyCanBo fQlcb = new FormQuanLyCanBo();
            fQlcb.Close();
            FormTKCa fTkc = new FormTKCa();
            fTkc.Close();
            FormTKCanBo fTkcb = new FormTKCanBo();
            fTkc.Close();
            FormTKNgay fTkn = new FormTKNgay();
            Close();
        }

        private void phaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                phânCôngToolStripMenuItem.Enabled = true;
                phânCôngNhanhToolStripMenuItem.Enabled = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                //FormQuanLyYeuCau formQuanLyYeuCau = new FormQuanLyYeuCau();
                //formQuanLyYeuCau.Show();
                xemCácYêuCầuToolStripMenuItem.Enabled = true;
                sửaYêuCầuToolStripMenuItem.Enabled = true;
                xoáYêuCầuToolStripMenuItem.Enabled = true;
                toolStripMenuItem1.Enabled = true;
            }
            
        }

        private void QLCanBotoolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void phânCôngNhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNhanSu randomNhanSu = new RandomNhanSu();
            randomNhanSu.Show();
        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChonCa formChonCa = new FormChonCa();
            formChonCa.Show();
        }

        private void sửaThôngTinCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemCácYêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyYeuCau yeuCau = new FormQuanLyYeuCau();
            yeuCau.Show();
        }

        private void thêmCácYêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FormSuaYeuCau formThemSua = new FormSuaYeuCau(null);
            formThemSua.Show();
        }

        private void sửaYêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaYeuCau suaYeuCau = new SuaYeuCau();
            suaYeuCau.Show();
        }

        private void xoáYêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaYeuCau xoaYeuCau = new XoaYeuCau();
            xoaYeuCau.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                xemQuảnLýYêuCầuToolStripMenuItem.Enabled = true;
                thêmQuảnLýYêuCầuToolStripMenuItem.Enabled = true;
                sửaYêuCầuToolStripMenuItem1.Enabled = true;
                xoáYêuCầuToolStripMenuItem1.Enabled = true;
            }
        }

        private void xemQuảnLýYêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyYeuCau formQuanLyYeuCau = new FormQuanLyYeuCau();
            formQuanLyYeuCau.Show();
        }

        private void thêmQuảnLýYêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSuaYeuCau formSuaYeuCau = new FormSuaYeuCau(null);
            formSuaYeuCau.Show();
        }

        private void sửaYêuCầuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SuaYeuCau suaYeuCau = new SuaYeuCau();
            suaYeuCau.Show();
        }

        private void xoáYêuCầuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XoaYeuCau xoaYeuCau = new XoaYeuCau();
            xoaYeuCau.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RandomNhanSu randomNhanSu = new RandomNhanSu();
            randomNhanSu.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormChonCa formChonCa = new FormChonCa();
            formChonCa.Show();
        }

        private void thêmCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemSua f = new FormThemSua(null);
            f.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                randomTlMenu.Enabled = true;
                tlPhanCong.Enabled = true;
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FormTKNgay formTKNgay = new FormTKNgay();
            formTKNgay.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FormTKCanBo formTKCanBo = new FormTKCanBo();
            formTKCanBo.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FormTKCa formTKCa = new FormTKCa();
            formTKCa.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                toolStripMenuItem9.Enabled = true;
                toolStripMenuItem10.Enabled = true;
                toolStripMenuItem8.Enabled = true;
            }
        }

        private void tìmKiếmCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimCanBo timCanBo = new TimCanBo();
            timCanBo.Show();
        }

        private void tìmKiếmTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                tìmKiếmCánBộToolStripMenuItem.Enabled = true;
                tìmKiếmTheoNgàyToolStripMenuItem1.Enabled = true;
                tìmKiếmTheoCaToolStripMenuItem.Enabled = true;
            }
        }

        private void tìmKiếmTheoNgàyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiemNgay timKiem = new TimKiemNgay();
            timKiem.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                //FormQuanLyCanBo formQuanLyCanBo = new FormQuanLyCanBo();
                //formQuanLyCanBo.Show();
                xemCánBộToolStripMenuItem.Enabled = true;
                thêmCánBộToolStripMenuItem.Enabled = true;
                suaCBtoolSrip.Enabled = true;
                xoáCánBộToolStripMenuItem.Enabled = true;
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Login.isLoginSess = false;
            tKTheoCaToolStripMenuItem.Enabled = false;
            tKTheoNgàyToolStripMenuItem.Enabled = false;
            tKTheoCánBộToolStripMenuItem.Enabled = false;
            FormDangNhap fdn = new FormDangNhap();
            fdn.Close();
            FormQuanLyYeuCau fQlyc = new FormQuanLyYeuCau();
            fQlyc.Close();
            FormQuanLyCanBo fQlcb = new FormQuanLyCanBo();
            fQlcb.Close();
            FormTKCa fTkc = new FormTKCa();
            fTkc.Close();
            FormTKCanBo fTkcb = new FormTKCanBo();
            fTkc.Close();
            FormTKNgay fTkn = new FormTKNgay();
            Close();
        }

        private void xemCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemCanBo fXCB = new XemCanBo();
            fXCB.Show();
        }

        private void xoáCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaCanBo fCB = new XoaCanBo();
            fCB.Show();
        }

        private void suaCBtoolSrip_Click(object sender, EventArgs e)
        {
            SuaCanBo fSCB = new SuaCanBo();
            fSCB.Show();
        }

        private void tìmKiếmTheoCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemCa fTC = new TimKiemCa();
            fTC.Show();
        }

        private void quarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                frmQuanLyDot f = new frmQuanLyDot();
                f.Show();
            }
        }

        private void kQPhânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                FormIn f = new FormIn();
                f.Show();
            }
        }
    }
}
