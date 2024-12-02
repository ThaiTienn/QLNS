using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhuCapDAO
    {
        public DataTable DanhSach(PhuCapDTO dto)
        {
            return DataProvider.GetData("select * FROM PhuCap WHERE TenPC LIKE N'%" + dto.TenSearch + "%'");
        }
        public void Them(PhuCapDTO dto)
        {
            string strSQL = "INSERT INTO PhuCap(MaPC,TenPC,TienPC,NgayHieuLuc)  VALUES ( '" + dto.MaPC + "',N'" + dto.TenPC + "',"+dto.TienPC+",'"+dto.NgayHieuLuc+"')";
            DataProvider.RunQuery(strSQL);
        }
        public void Sua(PhuCapDTO dto)
        {
            string strSQL = "UPDATE PhuCap set TenPC = N'" + dto.TenPC + "',TienPC = "+ dto.TienPC + ",NgayHieuLuc = '"+dto.NgayHieuLuc + "' where MaPC = '" + dto.MaPC + "'";
            DataProvider.RunQuery(strSQL);
        }
        public void Xoa(PhuCapDTO dto)
        {
            string strSQL = "DELETE PhuCap  where MaPC = '" + dto.MaPC + "'";
            DataProvider.RunQuery(strSQL);
        }
    }
}
