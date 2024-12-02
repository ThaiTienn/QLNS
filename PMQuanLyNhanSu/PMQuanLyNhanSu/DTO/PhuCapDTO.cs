using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhuCapDTO
    {
        public static string _MaPC;
        public static string _TenPC;
        public static string _TienPC;
        public static string _NgayHieuLuc;
        public static string _TenSearch;
        public string MaPC
        {
            get { return _MaPC; }
            set { _MaPC = value; }
        }
        public string TenPC
        {
            get { return _TenPC; }
            set { _TenPC = value; }
        }
        public string TienPC
        {
            get { return _TienPC; }
            set { _TienPC = value; }
        }
        public string NgayHieuLuc
        {
            get { return _NgayHieuLuc; }
            set { _NgayHieuLuc = value; }
        }
        public string TenSearch
        {
            get { return _TenSearch; }
            set { _TenSearch = value; }
        }
    }
}
