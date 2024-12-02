using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhaiBaoTPNVDTO
    {
        public static string _MaNV;
        public static string _Id;
        public static string _MaThuongPhat;
        public static string _Thang;
        public static string _Nam;
        public static string _SoTien;
        public static string _LyDo;
        public static string _TenSearch;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string MaThuongPhat
        {
            get { return _MaThuongPhat; }
            set { _MaThuongPhat = value; }
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
        public string SoTien
        {
            get { return _SoTien; }
            set { _SoTien = value; }
        }
        public string LyDo
        {
            get { return _LyDo; }
            set { _LyDo = value; }
        }
        public string TenSearch
        {
            get { return _TenSearch; }
            set { _TenSearch = value; }
        }
    }
}
