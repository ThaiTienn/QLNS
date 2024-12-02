using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public DataTable DanhSach(TaiKhoanDTO dto)
        {
            return DataProvider.GetData("select * FROM TaiKhoan WHERE TenTK LIKE N'%" + dto.TenSearch + "%'");
        }
        public DataTable DangNhap(TaiKhoanDTO dto)
        {
            return DataProvider.GetData("select * FROM TaiKhoan WHERE MaTK = N'" + dto.MaTK + "' AND MatKhau = '"+dto.MatKhau+"' ");
        }
        public void Them(TaiKhoanDTO dto)
        {
            string strSQL = "INSERT INTO TaiKhoan(MaTK,TenTK,MatKhau,DienThoai,DiaChi)  VALUES ( '" + dto.MaTK + "',N'" + dto.TenTK + "','" + dto.MatKhau + "','" + dto.DienThoai + "',N'"+ dto.DiaChi + "')";
            DataProvider.RunQuery(strSQL);
        }
        public void Sua(TaiKhoanDTO dto)
        {
            string strSQL = "UPDATE TaiKhoan set TenTK = N'" + dto.TenTK + "',MatKhau = '" + dto.MatKhau + "',DienThoai = '" + dto.DienThoai + "',DiaChi = N'"+dto.DiaChi + "' where MaTK = '" + dto.MaTK + "'";
            DataProvider.RunQuery(strSQL);
        }
        public void Xoa(TaiKhoanDTO dto)
        {
            string strSQL = "DELETE TaiKhoan  where MaTK = '" + dto.MaTK + "'";
            DataProvider.RunQuery(strSQL);
        }
    }
}
