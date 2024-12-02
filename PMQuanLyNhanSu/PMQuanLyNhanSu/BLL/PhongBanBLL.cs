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
    public class PhongBanBLL
    {
        public DataTable DanhSach(PhongBanDTO dto)
        {
            PhongBanDAO dao = new PhongBanDAO();
            return dao.DanhSach(dto);
        }
        public void Them(PhongBanDTO dto)
        {
            PhongBanDAO dao = new PhongBanDAO();
            dao.Them(dto);
        }
        public void Sua(PhongBanDTO dto)
        {
            PhongBanDAO dao = new PhongBanDAO();
            dao.Sua(dto);
        }
        public void Xoa(PhongBanDTO dto)
        {
            PhongBanDAO dao = new PhongBanDAO();
            dao.Xoa(dto);
        }
    }
}
