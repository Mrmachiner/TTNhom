using QLNV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.Helpers
{
    class Login
    {
        static QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        public static bool isLoginSess= false;
        public static string ErrorLogin;
        public static void LoginUser(string taiKhoan, string matKhau)
        {
            User user= db.User.SingleOrDefault(x => x.TaiKhoan == taiKhoan && x.MatKhau == matKhau);
            if(user == null)
            {
                isLoginSess = false;
                ErrorLogin = "Không tìm thấy tài khoản hoặc mật khẩu";
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
