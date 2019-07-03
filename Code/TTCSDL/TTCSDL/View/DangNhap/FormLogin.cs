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

namespace TTCSDL.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login.loginUser(txtTaiKhoan.Text, txtMatKhau.Text);
            {
                if (Login.isLoginSess==true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công!");
                    Close();
                }
                else
                {
                    MessageBox.Show(Login.ErrorLogin);
                }
            } 
        }
    }
}
