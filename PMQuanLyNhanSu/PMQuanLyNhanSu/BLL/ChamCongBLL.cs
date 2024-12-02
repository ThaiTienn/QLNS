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
    public class ChamCongBLL
    {
        public DataTable HienThi(ChamCongDTO dto)
        {
            ChamCongDAO dao = new ChamCongDAO();
            return dao.HienThi(dto);
        }
        public void Checkin(ChamCongDTO dto)
        {
            ChamCongDAO dao = new ChamCongDAO();
            dao.Checkin(dto);
        }
        public void Checkout(ChamCongDTO dto)
        {
            ChamCongDAO dao = new ChamCongDAO();
            dao.Checkout(dto);
        }
    }
}
