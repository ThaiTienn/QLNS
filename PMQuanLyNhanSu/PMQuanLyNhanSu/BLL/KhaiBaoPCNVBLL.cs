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
    public class KhaiBaoPCNVBLL
    {
        public DataTable DanhSach(KhaiBaoPCNVDTO dto)
        {
            KhaiBaoPCNVDAO dao = new KhaiBaoPCNVDAO();
            return dao.DanhSach(dto);
        }
        public void Them(KhaiBaoPCNVDTO dto)
        {
            KhaiBaoPCNVDAO dao = new KhaiBaoPCNVDAO();
            dao.Them(dto);
        }
        public void Sua(KhaiBaoPCNVDTO dto)
        {
            KhaiBaoPCNVDAO dao = new KhaiBaoPCNVDAO();
            dao.Sua(dto);
        }
        public void Xoa(KhaiBaoPCNVDTO dto)
        {
            KhaiBaoPCNVDAO dao = new KhaiBaoPCNVDAO();
            dao.Xoa(dto);
        }
    }
}
