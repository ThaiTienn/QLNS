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
    public class KhaiBaoTPNVBLL
    {
        public DataTable DanhSach(KhaiBaoTPNVDTO dto)
        {
            KhaiBaoTPNVDAO dao = new KhaiBaoTPNVDAO();
            return dao.DanhSach(dto);
        }
        public void Them(KhaiBaoTPNVDTO dto)
        {
            KhaiBaoTPNVDAO dao = new KhaiBaoTPNVDAO();
            dao.Them(dto);
        }
        public void Sua(KhaiBaoTPNVDTO dto)
        {
            KhaiBaoTPNVDAO dao = new KhaiBaoTPNVDAO();
            dao.Sua(dto);
        }
        public void Xoa(KhaiBaoTPNVDTO dto)
        {
            KhaiBaoTPNVDAO dao = new KhaiBaoTPNVDAO();
            dao.Xoa(dto);
        }
    }
}
