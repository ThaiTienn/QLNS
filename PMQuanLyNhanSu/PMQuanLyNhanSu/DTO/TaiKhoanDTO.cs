using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public static string _MaTK;
        public static string _TenTK;
        public static string _MatKhau;
        public static string _DienThoai;
        public static string _DiaChi;
        public static string _TenSearch;
        public string MaTK
        {
            get { return _MaTK; }
            set { _MaTK = value; }
        }
        public string TenTK
        {
            get { return _TenTK; }
            set { _TenTK = value; }
        }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string TenSearch
        {
            get { return _TenSearch; }
            set { _TenSearch = value; }
        }
    }
}
