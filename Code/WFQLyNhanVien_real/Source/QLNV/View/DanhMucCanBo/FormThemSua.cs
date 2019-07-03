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
using QLNV.APIS;

namespace QLNV.View
{
    public partial class FormThemSua : Form
    {
        bool isUpdate = false;
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        CanBo updCanBo;
        public FormThemSua(CanBo obj)
        {
            InitializeComponent();
            if (obj == null)
            {
                this.Text = "Thêm Cán Bộ";
            }
            else
            {
                this.Text = "Sửa Cán Bộ";
                isUpdate = true;
                updCanBo = db.CanBo.SingleOrDefault(x => x.CanBoID == obj.CanBoID);
                if(updCanBo.ChucVu != null)
                {
                    txtChuVu.Text = updCanBo.ChucVu.ToString();
                }
                if(updCanBo.HoTen != null)
                {
                    txtHoTen.Text = updCanBo.HoTen.ToString();
                }

                
                if(updCanBo.NgaySinh != null)
                {
                    dtNgaySinh.Value = DateTime.Parse(updCanBo.NgaySinh.ToString());
                }
              
            }

        }
        private void FormThemSua_Load(object sender, EventArgs e)
        {
        
            cbxDonVi.DataSource = db.DonVi.ToList();
            cbxDonVi.DisplayMember = "TenDonVi";
            cbxDonVi.ValueMember = "DonViID";
            if (updCanBo != null)
            {
                //cbxDonVi.SelectedIndex = cbxDonVi.FindString(updCanBo.DonVi.TenDonVi);
            }
        }
        void UpdateCanBo()
        {
            updCanBo.ChucVu = txtChuVu.Text.ToString();
            updCanBo.DonViID = (int)cbxDonVi.SelectedValue;
            updCanBo.DonVi = db.DonVi.SingleOrDefault(x=>x.DonViID==updCanBo.DonViID);
            updCanBo.NgaySinh = DateTime.Parse(dtNgaySinh.Text.ToString());
            updCanBo.HoTen = txtHoTen.Text.ToString();
            db.SaveChanges();
        }
        void CreatCanBo()
        {
            CanBo canBo = new CanBo();
            canBo.ChucVu = txtChuVu.Text.ToString();
            canBo.DonViID = (int)cbxDonVi.SelectedValue;
            canBo.DonVi = null;
            canBo.NgaySinh = DateTime.Parse(dtNgaySinh.Text.ToString());
            canBo.HoTen = txtHoTen.Text.ToString();
            db.CanBo.Add(canBo);
            db.SaveChanges();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {

                CreatCanBo();
                Close();
                //this.Close();
                //FormThemSua FormThemSuaCanBo = new FormThemSua(null);
                //FormThemSuaCanBo.ShowDialog();
                FormQuanLyCanBo formQuanLyCanBo = new FormQuanLyCanBo();
                formQuanLyCanBo.Show();
            }
            else
            {
                UpdateCanBo();
                Close();
            }
        }

        private void txtDonVi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
