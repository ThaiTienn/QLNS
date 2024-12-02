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
    public class ChucVuBLL
    {
        public DataTable DanhSach(ChucVuDTO dto)
        {
            ChucVuDAO dao = new ChucVuDAO();
            return dao.DanhSach(dto);
        }
        public void Them(ChucVuDTO dto)
        {
            ChucVuDAO dao = new ChucVuDAO();
            dao.Them(dto);
        }
        public void Sua(ChucVuDTO dto)
        {
            ChucVuDAO dao = new ChucVuDAO();
            dao.Sua(dto);
        }
        public void Xoa(ChucVuDTO dto)
        {
            ChucVuDAO dao = new ChucVuDAO();
            dao.Xoa(dto);
        }
    }
}
