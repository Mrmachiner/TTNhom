using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace TTCSDL.Helper
{
    class genDataGrid
    {
        public void gen(string query, DataGridView g)
        {
            string strcon = "Data Source=DESKTOP-ALHAQAN\\HOANGLE;Initial Catalog=QLThiCC;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            g.DataSource = dtbl;
            con.Close();
        }
    }
}
