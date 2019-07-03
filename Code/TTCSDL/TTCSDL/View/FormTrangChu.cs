using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCSDL.View.DanhSach;
using TTCSDL.Helper;

namespace TTCSDL.View
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xuấtFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                dSThuBàiThiToolStripMenuItem.Enabled = true;
                dSHộiĐôngThoeĐợtToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui Lòng Đăng Nhập Quyền Admin");
            }
        }

        private void danhSáchThiSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSThiSinh ds = new DSThiSinh();
            ds.Show();
        }

        private void đăngKýDựThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy(null);
            dk.Show();
        }

        private void thêmGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                thêmGiáoViênToolStripMenuItem.Enabled = true;
                QuanLyDiemToolStripMenuItem.Enabled = true;
                FormThemGiaoVien f = new FormThemGiaoVien(null);
                f.Show();
            }
            else
            {
                MessageBox.Show("Vui Lòng Đăng Nhập Quyền Admin");
            }

        }

        private void tạoHộiĐôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dSHộiĐôngThoeĐợtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dSDựThiTheoĐợtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDSThi ds = new FormDSThi();
            ds.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
        }

        private void dSThuBàiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýHộiĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                DSCanBoToolStripMenuItem.Enabled = true;
                thêmGiáoViênToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui Lòng Đăng Nhập Quyền Admin");
            }
        }
        void load()
        {
            QuanLyDiemToolStripMenuItem.Enabled = true;
        }
        private void FormTrangChu_Load(object sender, EventArgs e)
        {
        }

        private void QuanLyDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                nhậpĐiểmToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui Lòng Đăng Nhập Quyền Admin");
            }
        }
    }
}
