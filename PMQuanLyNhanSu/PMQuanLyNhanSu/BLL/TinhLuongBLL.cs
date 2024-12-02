using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TinhLuongBLL
    {
        public void TinhLuong(string MaNV, string Thang, string Nam)
        {
            TinhLuongDAO dao = new TinhLuongDAO();
            dao.TinhLuong(MaNV,Thang,Nam);
        }
    }
}
