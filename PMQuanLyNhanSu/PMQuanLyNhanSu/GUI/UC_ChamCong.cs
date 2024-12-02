using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_ChamCong : UserControl
    {
        public UC_ChamCong()
        {
            InitializeComponent();
        }
        public static UC_ChamCong ucChamCong = new UC_ChamCong();
        ChamCongBLL bll = new ChamCongBLL();
        ChamCongDTO dto = new ChamCongDTO();
        private void LoadDTO()
        {
            dto.MaChamCong = "MCC_" + DateTime.Now.ToString("yyyyMMddhhmmss");
            dto.MaNV = frmDangNhap.id;
            dto.NgayChamCong = DateTime.Now.ToString("yyyyMMdd");
            dto.GioVao = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            dto.GioRa = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }
        private void UC_ChamCong_Load(object sender, EventArgs e)
        {
            HienThiChamCongNV();
        }
        private void HienThiChamCongNV()
        {
            LoadDTO();
            gridview.DataSource = bll.HienThi(dto);
            gridview.Columns[0].HeaderText = "Mã chấm công";
            gridview.Columns[1].HeaderText = "Mã nhân viên";
            gridview.Columns[2].HeaderText = "Ngày chấm công";
            gridview.Columns[3].HeaderText = "Giờ vào";
            gridview.Columns[4].HeaderText = "Giờ ra";
            gridview.Columns[5].HeaderText = "Số giờ làm";
            if(gridview.Rows.Count > 0)
            {
                btnCheckin.Enabled = false;
            }    
        }
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            LoadDTO();
            bll.Checkin(dto);
            MessageBox.Show("Check In thành công");
            HienThiChamCongNV();
            btnCheckin.Enabled = false;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(gridview.Rows.Count == 0)
            {
                MessageBox.Show("Checkin trước khi checkout");
                return;
            }
            LoadDTO();
            dto.MaChamCong = gridview.Rows[gridview.CurrentCell.RowIndex].Cells[0].Value.ToString();
            bll.Checkout(dto);
            MessageBox.Show("Check Out thành công");
            HienThiChamCongNV();
        }
    }
}
