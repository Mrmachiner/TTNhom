using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCSDL.Helper
{
    class Login
    {
        static QLThiCCEntities db = new QLThiCCEntities();
        public static bool isLoginSess = false;
        public static string ErrorLogin;
        public static void loginUser(string taiKhoan,string matKhau)
        {
            User user = db.User.SingleOrDefault(x => x.TaiKhoan == taiKhoan && x.MatKhau == matKhau);
            if(user == null)
            {
                isLoginSess = false;
                ErrorLogin = "Tài Khoản Hoặc Mật Khẩu Không Đúng!";
                return;
            }
            else
            {
                isLoginSess = true;
                return;
            }
        }
    }
}
