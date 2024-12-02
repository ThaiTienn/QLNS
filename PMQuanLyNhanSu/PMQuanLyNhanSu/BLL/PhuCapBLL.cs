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
    public class PhuCapBLL
    {
        public DataTable DanhSach(PhuCapDTO dto)
        {
            PhuCapDAO dao = new PhuCapDAO();
            return dao.DanhSach(dto);
        }
        public void Them(PhuCapDTO dto)
        {
            PhuCapDAO dao = new PhuCapDAO();
            dao.Them(dto);
        }
        public void Sua(PhuCapDTO dto)
        {
            PhuCapDAO dao = new PhuCapDAO();
            dao.Sua(dto);
        }
        public void Xoa(PhuCapDTO dto)
        {
            PhuCapDAO dao = new PhuCapDAO();
            dao.Xoa(dto);
        }
    }
}
