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
    public partial class UC_QLPB : UserControl
    {
        public UC_QLPB()
        {
            InitializeComponent();
        }
        public static UC_QLPB ucQLPB = new UC_QLPB();
        PhongBanBLL bll = new PhongBanBLL();
        private bool luu;
        PhongBanDTO dto = new PhongBanDTO();
        private void LoadDTO()
        {
            dto.MaPB = txtMaPB.Text;
            dto.TenPB = txtTenPB.Text;
            dto.TenSearch = txtTenSearch.Text;
        }
        private void UC_QLPB_Load(object sender, EventArgs e)
        {
            HienThiPB();
            boolcontrols(true);
        }
        private void HienThiPB()
        {
            LoadDTO();
            gridview.DataSource = bll.DanhSach(dto);
            gridview.Columns[0].HeaderText = "Mã PB";
            gridview.Columns[1].HeaderText = "Tên PB";
            if (gridview.Rows.Count == 0)
            {
                txtMaPB.Text = "";
                txtTenPB.Text = "";
            }
            else
            {
                var row = this.gridview.Rows[0];
                txtMaPB.Text = row.Cells[0].Value.ToString();
                txtTenPB.Text = row.Cells[1].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
            boolcontrols(false);
            luu = true;
            txtMaPB.Focus();
        }
        private void boolcontrols(bool iss)
        {
            btnThem.Enabled = iss;
            btnSua.Enabled = iss;
            btnXoa.Enabled = iss;
            btnLuu.Enabled = !iss;
            btnHuy.Enabled = !iss;
            btnLamMoi.Enabled = iss;
            btnTim.Enabled = iss;
            txtMaPB.Enabled = !iss;
            txtTenPB.Enabled = !iss;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            luu = false;
            txtMaPB.Enabled = false;
            boolcontrols(false);
            txtMaPB.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa phòng ban này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    LoadDTO();
                    bll.Xoa(dto);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiPB();
                    boolcontrols(true);
                }
                catch (Exception)
                {

                    MessageBox.Show("Xóa thất bại, dữ liệu phòng ban này đã liên kết với khóa ngoại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text == "")
            {
                MessageBox.Show("Mã phòng ban không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPB.Focus();
                return;
            }
            if (txtTenPB.Text == "")
            {
                MessageBox.Show("Tên phòng ban không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenPB.Focus();
                return;
            }
            if (luu == true)
            {
                try
                {
                    LoadDTO();
                    bll.Them(dto);
                    MessageBox.Show("Thêm thành công.");
                    HienThiPB();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã phòng ban đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPB.Focus();
                    return;
                }
            }
            else
            {
                try
                {
                    LoadDTO();
                    bll.Sua(dto);
                    MessageBox.Show("Sửa thành công.");
                    HienThiPB();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã phòng ban đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPB.Focus();
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenSearch.Text = "";
            LoadDTO();
            HienThiPB();
            boolcontrols(true);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSearch.Text = "";
            LoadDTO();
            HienThiPB();
            boolcontrols(true);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDTO();
            HienThiPB();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaPB.Text = row.Cells[0].Value.ToString();
                txtTenPB.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
