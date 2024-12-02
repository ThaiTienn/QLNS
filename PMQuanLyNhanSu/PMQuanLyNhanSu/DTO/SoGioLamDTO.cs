using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SoGioLamDTO
    {
        public static string _Thang;
        public static string _Nam;
        public static string _SoGioLam;
        public static string _ThangSearch;
        public static string _NamSearch;

        public string Thang
        {
            get { return _Thang; }
            set { _Thang = value; }
        }
        public string Nam
        {
            get { return _Nam; }
            set { _Nam = value; }
        }
        public string SoGioLam
        {
            get { return _SoGioLam; }
            set { _SoGioLam = value; }
        }
        public string ThangSearch
        {
            get { return _ThangSearch; }
            set { _ThangSearch = value; }
        }
        public string NamSearch
        {
            get { return _NamSearch; }
            set { _NamSearch = value; }
        }
    }
}
