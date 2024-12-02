using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SoGioLamDAO
    {
        public DataTable DanhSach(SoGioLamDTO dto)
        {
            return DataProvider.GetData("select * FROM SoGioLam WHERE Thang LIKE '%" + dto.ThangSearch+"%' AND Nam LIKE '%"+dto.NamSearch+"%'");
        }
        public void Them(SoGioLamDTO dto)
        {
            string strSQL = "INSERT INTO SoGioLam(Thang,Nam,SoGioLam)  VALUES ( " + dto.Thang + "," + dto.Nam + ","+dto.SoGioLam + ")";
            DataProvider.RunQuery(strSQL);
        }
        public void Sua(SoGioLamDTO dto)
        {
            string strSQL = "UPDATE SoGioLam set SoGioLam = " + dto.SoGioLam + " where Thang = " + dto.Thang + " AND Nam = "+dto.Nam + "";
            DataProvider.RunQuery(strSQL);
        }
        public void Xoa(SoGioLamDTO dto)
        {
            string strSQL = "DELETE SoGioLam  where Thang = " + dto.Thang + " AND Nam = " + dto.Nam + "";
            DataProvider.RunQuery(strSQL);
        }
    }
}
