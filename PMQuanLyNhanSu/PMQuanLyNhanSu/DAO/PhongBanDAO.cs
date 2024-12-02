using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongBanDAO
    {
        public DataTable DanhSach(PhongBanDTO dto)
        {
            return DataProvider.GetData("select * FROM PhongBan WHERE TenPB LIKE N'%" + dto.TenSearch + "%'");
        }
        public void Them(PhongBanDTO dto)
        {
            string strSQL = "INSERT INTO PhongBan(MaPB,TenPB)  VALUES ( '" + dto.MaPB + "',N'" + dto.TenPB + "')";
            DataProvider.RunQuery(strSQL);
        }
        public void Sua(PhongBanDTO dto)
        {
            string strSQL = "UPDATE PhongBan set TenPB = N'" + dto.TenPB + "' where MaPB = '" + dto.MaPB + "'";
            DataProvider.RunQuery(strSQL);
        }
        public void Xoa(PhongBanDTO dto)
        {
            string strSQL = "DELETE PhongBan  where MaPB = '" + dto.MaPB + "'";
            DataProvider.RunQuery(strSQL);
        }
    }
}
