using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TinhLuongDAO
    {
        public void TinhLuong(string MaNV,string Thang,string Nam)
        {
            string strSQL = "EXEC pr_TinhLuong '"+ MaNV + "',"+Thang+","+Nam+"";
            DataProvider.RunQuery(strSQL);
        }
    }
}
