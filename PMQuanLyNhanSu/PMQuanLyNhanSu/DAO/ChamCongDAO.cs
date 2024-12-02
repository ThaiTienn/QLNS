using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChamCongDAO
    {
        public DataTable HienThi(ChamCongDTO dto)
        {
            string Query = "select * from ChamCong WHERE MaNV = N'" + dto.MaNV + "' AND MONTH(NgayChamCong) = '" + DateTime.Now.Month + "' AND YEAR(NgayChamCong) = '" + DateTime.Now.Year + "' AND NgayChamCong = '"+DateTime.Now.ToString("yyyyMMdd")+"' ";
            return DataProvider.GetData(Query);
        }
    
        public void Checkin(ChamCongDTO dto)
        {
            string Query = "INSERT INTO ChamCong(MaChamCong,MaNV,NgayChamCong,GioVao,GioRa,SoGioLam)  VALUES ('" + dto.MaChamCong + "', '" + dto.MaNV + "','" + dto.NgayChamCong + "','" + dto.GioVao + "',NULL,0)";
            DataProvider.RunQuery(Query);
        }
        public void Checkout(ChamCongDTO dto)
        {
            string strSQL = "UPDATE ChamCong SET GioRa = '" + dto.GioRa + "' WHERE MaChamCong = '" + dto.MaChamCong + "' ";
            DataProvider.RunQuery(strSQL);

            string strSQL2 = "UPDATE ChamCong SET SoGioLam = (DATEDIFF(HOUR, GioVao, GioRa)) WHERE MaChamCong = '" + dto.MaChamCong + "' ";
            DataProvider.RunQuery(strSQL2);
        }
    }
}
