using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaoCaoBLL
    {
        public DataTable BaoCaoLuong(string MaNV, string Thang, string Nam)
        {
            BaoCaoDAO dao = new BaoCaoDAO();
            return dao.BaoCaoLuong(MaNV, Thang, Nam);
        }
        public DataTable BaoCaoNhanVien(string NhanVien, string PhongBan, string ChucVu)
        {
            BaoCaoDAO dao = new BaoCaoDAO();
            return dao.BaoCaoNhanVien(NhanVien, PhongBan, ChucVu);
        }
        public DataTable BaoCaoChamCong(string MaNV, string Thang, string Nam)
        {
            BaoCaoDAO dao = new BaoCaoDAO();
            return dao.BaoCaoChamCong(MaNV, Thang, Nam);
        }
    }
}
