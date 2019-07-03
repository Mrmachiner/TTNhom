using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCSDL.View.Diem
{
    public partial class ThemSuaDiem : Form
    {
        QLThiCCEntities db = new QLThiCCEntities();
        ThiSinh upTS = new ThiSinh();
        public ThemSuaDiem(ThiSinh obj)
        {
            InitializeComponent();
            //upTS = db.ThiSinh.SingleOrDefault(x => x.IDThiSinh == obj.IDThiSinh);
            upTS = db.ThiSinh.SingleOrDefault(x => x.IDThiSinh == obj.IDThiSinh);
            txtHoTen.Text = upTS.Ho + " " + upTS.Ten;
            dateNS.Value = upTS.NgaySinh.Value;
        }
        
    }
}
