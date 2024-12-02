using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        public DataTable DanhSach(NhanVienDTO dto)
        {
            return DataProvider.GetData("select * FROM NhanVien WHERE HoTen LIKE N'%" + dto.TenSearch + "%'");
        }
        public DataTable NhanVienTheoMa(NhanVienDTO dto)
        {
            string sql = "select * FROM NhanVien WHERE MaNV = N'" + dto.MaNV + "'";
            return DataProvider.GetData(sql);
        }
        public DataTable DanhSachNhanVienCoboboxTinhLuong()
        {
            string Query = "SELECT 'ALL' as MaNV, N'---TẤT CẢ---' AS HoTen UNION ALL select MaNV,HoTen from NhanVien";
            return DataProvider.GetData(Query);
        }
        public DataTable DangNhap(NhanVienDTO dto)
        {
            return DataProvider.GetData("select * FROM NhanVien WHERE MaNV = N'" + dto.MaNV + "' AND Password = '" + dto.Password+"'");
        }
        public void Them(NhanVienDTO dto)
        {
            string strSQL = "INSERT INTO NhanVien(MaNV,HoTen,NgaySinh,GioiTinh,CCCD,Email,SDT,DiaChi,Password,MaCV,MaPB,NgayVaoLam,TrangThai,LuongCoBan)  VALUES ( '" + dto.MaNV + "',N'" + dto.HoTen + "','" + dto.NgaySinh + "',N'" + dto.GioiTinh + "','" + dto.CCCD + "','"+ dto.Email + "','"+dto.SDT + "',N'" + dto.DiaChi+ "','"+dto.Password+ "','"+dto.MaCV + "','" + dto.MaPB + "','" + dto.NgayVaoLam + "',N'" + dto.TrangThai + "',"+ dto.LuongCoBan + ")";
            DataProvider.RunQuery(strSQL);
        }
        public void Sua(NhanVienDTO dto)
        {
            string strSQL = "UPDATE NhanVien set HoTen = N'" + dto.HoTen + "',NgaySinh = '" + dto.NgaySinh + "',GioiTinh = N'" + dto.GioiTinh + "',CCCD = N'" + dto.CCCD + "' ,Email = '"+ dto.Email + "',SDT = '" + dto.SDT + "',DiaChi = N'" + dto.DiaChi+ "',Password = '" + dto.Password+ "',MaCV = '" + dto.MaCV + "',MaPB = '" + dto.MaPB + "',NgayVaoLam = '" + dto.NgayVaoLam + "',TrangThai = N'" + dto.TrangThai + "',LuongCoBan = "+dto.LuongCoBan + " where MaNV = '" + dto.MaNV + "'";
            DataProvider.RunQuery(strSQL);
        }
        public void Xoa(NhanVienDTO dto)
        {
            string strSQL = "DELETE NhanVien  where MaNV = '" + dto.MaNV + "'";
            DataProvider.RunQuery(strSQL);
        }
    }
}
