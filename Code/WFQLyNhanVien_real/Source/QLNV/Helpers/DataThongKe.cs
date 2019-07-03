using QLNV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.Helpers
{
    public class DataThongKe
    {
        public DateTime NgayTruc { get; set; }
        public TimeSpan GioTrucBatDau { get; set; }
        public TimeSpan GioTrucKetThuc { get; set; }
    }
    public class DataThongKeCa
    {
        public DateTime NgayTruc { get; set; }
        public int SoNguoi { get; set; }
    }
}
