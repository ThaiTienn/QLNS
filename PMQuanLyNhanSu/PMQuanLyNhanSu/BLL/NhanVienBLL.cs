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
    public class NhanVienBLL
    {
        public DataTable DanhSach(NhanVienDTO dto)
        {
            NhanVienDAO dao = new NhanVienDAO();
            return dao.DanhSach(dto);
        }
        public DataTable NhanVienTheoMa(NhanVienDTO dto)
        {
            NhanVienDAO dao = new NhanVienDAO();
            return dao.NhanVienTheoMa(dto);
        }
        public DataTable DanhSachNhanVienCoboboxTinhLuong()
        {
            NhanVienDAO dao = new NhanVienDAO();
            return dao.DanhSachNhanVienCoboboxTinhLuong();
        }
        public DataTable DangNhap(NhanVienDTO dto)
        {
            NhanVienDAO dao = new NhanVienDAO();
            return dao.DangNhap(dto);
        }
        public void Them(NhanVienDTO dto)
        {
            NhanVienDAO dao = new NhanVienDAO();
            dao.Them(dto);
        }
        public void Sua(NhanVienDTO dto)
        {
            NhanVienDAO dao = new NhanVienDAO();
            dao.Sua(dto);
        }
        public void Xoa(NhanVienDTO dto)
        {
            NhanVienDAO dao = new NhanVienDAO();
            dao.Xoa(dto);
        }
    }
}
