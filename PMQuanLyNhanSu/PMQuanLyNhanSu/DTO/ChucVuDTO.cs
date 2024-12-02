using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVuDTO
    {
        public static string _MaCV;
        public static string _TenCV;
        public static string _TenSearch;

        public string MaCV
        {
            get { return _MaCV; }
            set { _MaCV = value; }
        }
        public string TenCV
        {
            get { return _TenCV; }
            set { _TenCV = value; }
        }
        public string TenSearch
        {
            get { return _TenSearch; }
            set { _TenSearch = value; }
        }
    }
}
