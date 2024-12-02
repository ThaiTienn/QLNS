using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamCongDTO
    {
        public static string _MaNV;
        public static string _MaChamCong;
        public static string _NgayChamCong;
        public static string _GioVao;
        public static string _GioRa;
        public static string _SoGioLam;
        public static string _MaNVSearch;
        public static string _NgayChamCongSearch;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        public string MaChamCong
        {
            get { return _MaChamCong; }
            set { _MaChamCong = value; }
        }
        public string NgayChamCong
        {
            get { return _NgayChamCong; }
            set { _NgayChamCong = value; }
        }
        public string GioVao
        {
            get { return _GioVao; }
            set { _GioVao = value; }
        }
        public string GioRa
        {
            get { return _GioRa; }
            set { _GioRa = value; }
        }
        public string SoGioLam
        {
            get { return _SoGioLam; }
            set { _SoGioLam = value; }
        }
        public string MaNVSearch
        {
            get { return _MaNVSearch; }
            set { _MaNVSearch = value; }
        }
        public string NgayChamCongSearch
        {
            get { return _NgayChamCongSearch; }
            set { _NgayChamCongSearch = value; }
        }
    }
}
