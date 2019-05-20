using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.APIS
{
    public class ValidateHelper
    {
        public static bool IsNumber(string intStr)
        {
            int so;
            return int.TryParse(intStr, out so);
        }
        public static DateTime FomatDateDef(DateTime data)
        {
            DateTime dateTime = new DateTime(day: data.Day, month: data.Month, year: data.Year, hour: 00, minute: 00, second: 00);
            return dateTime;
        }
        public static bool ToDate(DateTime tuNgay, DateTime denNgay)
        {
            int a= DateTime.Compare(tuNgay, denNgay) ;
            return DateTime.Compare(tuNgay, denNgay) > 0;
        }
        public static IEnumerable<DateTime> ListDate(DateTime tuNgay, DateTime denNgay)
        {
            while (tuNgay <= denNgay)
            {
                yield return tuNgay;
                tuNgay = tuNgay.AddDays(1);

            }
        }
    }
}
