using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaoCaoDAO
    {
        public DataTable BaoCaoLuong(string MaNV, string Thang, string Nam)
        {
            string strSQL = "EXEC pr_BaoCaoLuong '" + MaNV + "'," + Thang + "," + Nam + "";
            return DataProvider.GetData(strSQL);
        }
        public DataTable BaoCaoNhanVien(string PhongBan, string ChucVu, string NhanVien)
        {
            string strSQL = "SELECT b.TenPB,c.TenCV,a.* FROM NhanVien a INNER JOIN PhongBan b ON a.MaPB = b.MaPB INNER JOIN ChucVu c ON a.MaCV = c.MaCV WHERE a.HoTen LIKE N'%"+NhanVien+ "%' AND TenPB like N'%"+PhongBan+ "%' AND TenCV LIKE N'%"+ChucVu+"%'";
            return DataProvider.GetData(strSQL);
        }
        public DataTable BaoCaoChamCong(string MaNV, string Thang, string Nam)
        {
            if(MaNV == "ALL")
            {
                string strSQL = "SELECT * FROM ChamCong WHERE MONTH(NgayChamCong) = " + Thang + " AND YEAR(NgayChamCong) = " + Nam + "";
                return DataProvider.GetData(strSQL);
            }    
            else
            {
                string strSQL = "SELECT * FROM ChamCong WHERE MaNV = N'" + MaNV + "' AND MONTH(NgayChamCong) = " + Thang + " AND YEAR(NgayChamCong) = " + Nam + "";
                return DataProvider.GetData(strSQL);
            }    
        }
    }
}
