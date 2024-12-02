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
    public class SoGioLamBLL
    {
        public DataTable DanhSach(SoGioLamDTO dto)
        {
            SoGioLamDAO dao = new SoGioLamDAO();
            return dao.DanhSach(dto);
        }
        public void Them(SoGioLamDTO dto)
        {
            SoGioLamDAO dao = new SoGioLamDAO();
            dao.Them(dto);
        }
        public void Sua(SoGioLamDTO dto)
        {
            SoGioLamDAO dao = new SoGioLamDAO();
            dao.Sua(dto);
        }
        public void Xoa(SoGioLamDTO dto)
        {
            SoGioLamDAO dao = new SoGioLamDAO();
            dao.Xoa(dto);
        }
    }
}
