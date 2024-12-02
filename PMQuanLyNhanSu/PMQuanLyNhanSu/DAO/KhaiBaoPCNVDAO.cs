using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhaiBaoPCNVDAO
    {
        public DataTable DanhSach(KhaiBaoPCNVDTO dto)
        {
            return DataProvider.GetData("select a.*,b.TienPC FROM KhaiBaoPCNV a INNER JOIN PhuCap b ON a.MaPC = b.MaPC WHERE MaNV LIKE '%" + dto.TenSearch + "%'");
        }
        public void Them(KhaiBaoPCNVDTO dto)
        {
            string strSQL = "INSERT INTO KhaiBaoPCNV(Id,MaPC,MaNV,Thang,Nam)  VALUES ( '"+dto.Id+"','" + dto.MaPC + "','" + dto.MaNV + "'," + dto.Thang + "," + dto.Nam + ")";
            DataProvider.RunQuery(strSQL);
        }
        public void Sua(KhaiBaoPCNVDTO dto)
        {
            string strSQL = "UPDATE KhaiBaoPCNV set MaNV = N'" + dto.MaNV + "',Thang = " + dto.Thang + ",Nam = " + dto.Nam + ",MaPC = '" + dto.MaPC + "' where Id = '"+dto.Id + "' ";
            DataProvider.RunQuery(strSQL);
        }
        public void Xoa(KhaiBaoPCNVDTO dto)
        {
            string strSQL = "DELETE KhaiBaoPCNV  where Id = '" + dto.Id + "'";
            DataProvider.RunQuery(strSQL);
        }
    }
}
