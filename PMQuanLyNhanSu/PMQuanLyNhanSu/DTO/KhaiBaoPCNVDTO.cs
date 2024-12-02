using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhaiBaoPCNVDTO
    {
        public static string _Id;
        public static string _MaPC;
        public static string _MaNV;
        public static string _Thang;
        public static string _Nam;
        public static string _TenSearch;
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string MaPC
        {
            get { return _MaPC; }
            set { _MaPC = value; }
        }
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
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
        public string TenSearch
        {
            get { return _TenSearch; }
            set { _TenSearch = value; }
        }
    }
}
