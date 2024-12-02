using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBanDTO
    {
        public static string _MaPB;
        public static string _TenPB;
        public static string _TenSearch;
        public string MaPB
        {
            get { return _MaPB; }
            set { _MaPB = value; }
        }
        public string TenPB
        {
            get { return _TenPB; }
            set { _TenPB = value; }
        }
        public string TenSearch
        {
            get { return _TenSearch; }
            set { _TenSearch = value; }
        }
    }
}
