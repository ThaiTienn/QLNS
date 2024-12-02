using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChucVuDAO
    {
        public DataTable DanhSach(ChucVuDTO dto)
        {
            return DataProvider.GetData("select * FROM ChucVu WHERE TenCV LIKE N'%" + dto.TenSearch+ "%'");
        }
        public void Them(ChucVuDTO dto)
        {
            string strSQL = "INSERT INTO ChucVu(MaCV,TenCV)  VALUES ( '" + dto.MaCV + "',N'" + dto.TenCV + "')";
            DataProvider.RunQuery(strSQL);
        }
        public void Sua(ChucVuDTO dto)
        {
            string strSQL = "UPDATE ChucVu set TenCV = N'" + dto.TenCV + "' where MaCV = '" + dto.MaCV + "'";
            DataProvider.RunQuery(strSQL);
        }
        public void Xoa(ChucVuDTO dto)
        {
            string strSQL = "DELETE ChucVu  where MaCV = '" + dto.MaCV + "'";
            DataProvider.RunQuery(strSQL);
        }
        
    }
}
