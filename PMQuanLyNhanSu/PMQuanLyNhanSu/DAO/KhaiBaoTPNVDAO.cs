using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhaiBaoTPNVDAO
    {
        public DataTable DanhSach(KhaiBaoTPNVDTO dto)
        {
            return DataProvider.GetData("select * FROM KhaiBaoTPNV WHERE MaNV LIKE N'%" + dto.TenSearch + "%'");
        }
        public void Them(KhaiBaoTPNVDTO dto)
        {
            string strSQL = "INSERT INTO KhaiBaoTPNV(Id,MaThuongPhat,MaNV,Thang,Nam,SoTien,LyDo)  VALUES ( '" + dto.Id + "',N'" + dto.MaThuongPhat + "','" + dto.MaNV + "'," + dto.Thang + "," + dto.Nam + ","+dto.SoTien + ",N'"+dto.LyDo+"')";
            DataProvider.RunQuery(strSQL);
        }
        public void Sua(KhaiBaoTPNVDTO dto)
        {
            string strSQL = "UPDATE KhaiBaoTPNV set MaNV = N'" + dto.MaNV + "',Thang = " + dto.Thang + ",Nam = " + dto.Nam + ",MaThuongPhat = N'" + dto.MaThuongPhat + "',LyDo = N'"+dto.LyDo + "',SoTien = "+dto.SoTien+" where Id = '" + dto.Id + "' ";
            DataProvider.RunQuery(strSQL);
        }
        public void Xoa(KhaiBaoTPNVDTO dto)
        {
            string strSQL = "DELETE KhaiBaoTPNV  where Id = '" + dto.Id + "'";
            DataProvider.RunQuery(strSQL);
        }
    }
}
