using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCSDL
{
    public partial class DangKy : Form
    {
        QLThiCCEntities db = new QLThiCCEntities();
        ThiSinh ts = new ThiSinh();
        ThiSinh upDateTS = new ThiSinh();
        bool check = false;
        public DangKy(ThiSinh obj)
        {
            InitializeComponent();
            if (obj == null)
            {
                this.Text = "Đăng Ký";
            }
            else
            {
                checkBoxNopTien.Visible = true;
                check = true;
                this.Text = "Sửa Thông Tin Thí Sinh";
                upDateTS = db.ThiSinh.SingleOrDefault(x => x.IDThiSinh == obj.IDThiSinh);
                if (upDateTS.TrangThai == true)
                {
                    checkBoxNopTien.Checked = true;
                }
                else checkBoxNopTien.Checked = false;
                if (upDateTS.Email != null)
                {
                    txtMail.Text = upDateTS.Email.ToString();
                }
                if (upDateTS.Ho != null)
                {
                    txtHo.Text = upDateTS.Ho.ToString();
                }
                if (upDateTS.Ten != null)
                {
                    txtTen.Text = upDateTS.Ten.ToString();
                }
                if (upDateTS.NgaySinh != null)
                {
                    dTimeNgaySinh.Value = DateTime.Parse(upDateTS.NgaySinh.ToString());
                }
                if (upDateTS.CMND != null)
                {
                    txtCMT.Text = upDateTS.CMND.ToString();
                }
                if (upDateTS.SDT != null)
                {
                    txtSDT.Text = upDateTS.SDT.ToString();
                }
                if (upDateTS.GioiTinh == true)
                {
                    RabtnNam.Checked = true;
                    RabtnNu.Checked = false;
                }
                else
                {
                    RabtnNu.Checked = true;
                    RabtnNam.Checked = false;
                }
                if (upDateTS.IDNhuCau == 1)
                {
                    RabtnOnThi.Checked = true;
                    RabtnThi.Checked = false;
                }
                else
                {
                    RabtnThi.Checked = true;
                    RabtnOnThi.Checked = false;
                }
                if (upDateTS.IDNoiDung == 1)
                {
                    RabtnKhong.Checked = true;
                    RabtnNangCao.Checked = true;
                }
                else if (upDateTS.IDNoiDung == 2)
                {
                    RabtnKhong.Checked = true;
                    RabtnCoBan.Checked = true;
                }
                else if (upDateTS.IDNoiDung == 3)
                {
                    RabtnCo.Checked = true;
                    RabtnNangCao.Checked = true;
                }
                else if (upDateTS.IDNoiDung == 4)
                {
                    RabtnCo.Checked = true;
                    RabtnCoBan.Checked = true;
                }
            } 
        }
        bool GioiTinhTS(ThiSinh ts)
        {
            if (RabtnNam.Checked == true)
            {
                ts.GioiTinh = true;
                return true;
            }
            else if (RabtnNu.Checked == true)
            {
                ts.GioiTinh = true;
                return true;
            }
            return false;
        }
        bool NhuCauTS(ThiSinh ts)
        {
            if (RabtnOnThi.Checked == true)
            {
                ts.IDNhuCau = 1;
                return true;
            }
            else 
            {
                ts.IDNhuCau = 2;
                return true;
            }
            return false;
        }
        bool NoiDungTS(ThiSinh ts)
        {
            if(RabtnKhong.Checked==true && RabtnNangCao.Checked == true)
            {
                ts.IDNoiDung = 1;
                return true;
            }
            else if (RabtnKhong.Checked == true && RabtnCoBan.Checked == true)
            {
                ts.IDNoiDung = 2;
                return true;
            }
            else if (RabtnCo.Checked == true && RabtnNangCao.Checked == true)
            {
                ts.IDNoiDung = 3;
                return true;
            }
            else if(RabtnCo.Checked==true && RabtnCoBan.Checked == true)
            {
                ts.IDNoiDung = 4;
                return true;
            }
            return false;
        }
        void ADDThiSinh()
        {
            ts.Email = txtMail.Text.ToString();
            ts.Ho = txtHo.Text.ToString();
            ts.Ten = txtTen.Text.ToString();
            ts.CMND = txtCMT.Text.ToString();
            ts.SDT = txtSDT.Text.ToString();
            ts.NgaySinh = DateTime.Parse(dTimeNgaySinh.Text.ToString());
            GioiTinhTS(ts);
            NhuCauTS(ts);
            NoiDungTS(ts);
            db.ThiSinh.Add(ts);
            db.SaveChanges();
        }
        void UpdateThiSinh()
        {
            if (checkBoxNopTien.Checked == true) upDateTS.TrangThai = true;
            else upDateTS.TrangThai = false;
            upDateTS.Email = txtMail.Text.ToString();
            upDateTS.Ho = txtHo.Text.ToString();
            upDateTS.Ten = txtTen.Text.ToString();
            upDateTS.CMND = txtCMT.Text.ToString();
            upDateTS.SDT = txtSDT.Text.ToString();
            upDateTS.NgaySinh = DateTime.Parse(dTimeNgaySinh.Text.ToString());
            GioiTinhTS(upDateTS);
            NhuCauTS(upDateTS);
            NoiDungTS(upDateTS);
            db.SaveChanges();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (GioiTinhTS(ts) == false || NhuCauTS(ts) == false || NoiDungTS(ts) == false|| txtMail.Text==""||txtHo.Text==""
                ||txtTen.Text==""||txtCMT.Text==""||txtSDT.Text=="")
            {
                MessageBox.Show("Không Được Để Trống Thông Tin");
                Focus();
            }
            else if(!check)
            {
                ADDThiSinh();
                MessageBox.Show("Đăng Ký Thành Công!");
                Close();
            }
            else if (check)
            {
                UpdateThiSinh();
                MessageBox.Show("Sửa Thông Tin Thành Công!");
                Close();
            }
            
            
        }

    }
}
