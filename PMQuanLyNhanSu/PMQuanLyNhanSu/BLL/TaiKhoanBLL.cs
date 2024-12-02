using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        public DataTable DanhSach(TaiKhoanDTO dto)
        {
            TaiKhoanDAO dao = new TaiKhoanDAO();
            return dao.DanhSach(dto);
        }
        public DataTable DangNhap(TaiKhoanDTO dto)
        {
            TaiKhoanDAO dao = new TaiKhoanDAO();
            return dao.DangNhap(dto);
        }
        public DataTable DangNhapAdmin(TaiKhoanDTO dto)
        {
            TaiKhoanDAO dao = new TaiKhoanDAO();
            return dao.DangNhap(dto);
        }
        public DataTable DangNhapNhanVien(NhanVienDTO dto)
        {
            NhanVienDAO dao = new NhanVienDAO();
            return dao.DangNhap(dto);
        }
        public void Them(TaiKhoanDTO dto)
        {
            TaiKhoanDAO dao = new TaiKhoanDAO();
            dao.Them(dto);
        }
        public void Sua(TaiKhoanDTO dto)
        {
            TaiKhoanDAO dao = new TaiKhoanDAO();
            dao.Sua(dto);
        }
        public void Xoa(TaiKhoanDTO dto)
        {
            TaiKhoanDAO dao = new TaiKhoanDAO();
            dao.Xoa(dto);
        }
    }
}
