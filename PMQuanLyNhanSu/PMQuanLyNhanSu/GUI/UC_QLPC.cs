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
    public partial class UC_QLPC : UserControl
    {
        public UC_QLPC()
        {
            InitializeComponent();
        }
        public static UC_QLPC ucQLPC = new UC_QLPC();
        PhuCapBLL bll = new PhuCapBLL();
        private bool luu;
        PhuCapDTO dto = new PhuCapDTO();
        private void LoadDTO()
        {
            dto.MaPC = txtMaPC.Text;
            dto.TenPC = txtTenPC.Text;
            dto.TienPC = txtTienPC.Text;
            dto.NgayHieuLuc =dtNgayHieuLuc.Value.ToString("yyyyMMdd");
            dto.TenSearch = txtTenSearch.Text;
        }
        private void UC_QLPC_Load(object sender, EventArgs e)
        {
            HienThiPC();
            boolcontrols(true);
        }
        private void HienThiPC()
        {
            LoadDTO();
            gridview.DataSource = bll.DanhSach(dto);
            gridview.Columns[0].HeaderText = "Mã PC";
            gridview.Columns[1].HeaderText = "Tên PC";
            if (gridview.Rows.Count == 0)
            {
                txtMaPC.Text = "";
                txtTenPC.Text = "";
                txtTienPC.Text = "";
            }
            else
            {
                var row = this.gridview.Rows[0];
                txtMaPC.Text = row.Cells[0].Value.ToString();
                txtTenPC.Text = row.Cells[1].Value.ToString();
                txtTienPC.Text = row.Cells[2].Value.ToString();
                dtNgayHieuLuc.Text = row.Cells[3].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaPC.Text = "";
            txtTenPC.Text = "";
            txtTienPC.Text = "";
            boolcontrols(false);
            luu = true;
            txtMaPC.Focus();
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
            txtMaPC.Enabled = !iss;
            txtTenPC.Enabled = !iss;
            txtTienPC.Enabled = !iss;
            dtNgayHieuLuc.Enabled = !iss;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            luu = false;
            txtMaPC.Enabled = false;
            boolcontrols(false);
            txtMaPC.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa phụ cấp này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    LoadDTO();
                    bll.Xoa(dto);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiPC();
                    boolcontrols(true);
                }
                catch (Exception)
                {

                     MessageBox.Show("Xóa thất bại, dữ liệu phụ cấp này đã liên kết với khóa ngoại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPC.Text == "")
            {
                MessageBox.Show("Mã phụ cấp không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPC.Focus();
                return;
            }
            if (txtTenPC.Text == "")
            {
                MessageBox.Show("Tên phụ cấp không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenPC.Focus();
                return;
            }
            if (txtTienPC.Text == "")
            {
                MessageBox.Show("Tiền phụ cấp không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTienPC.Focus();
                return;
            }
            if (luu == true)
            {
                try
                {
                    LoadDTO();
                    bll.Them(dto);
                    MessageBox.Show("Thêm thành công.");
                    HienThiPC();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã phụ cấp đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPC.Focus();
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
                    HienThiPC();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã phụ cấp đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPC.Focus();
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenSearch.Text = "";
            LoadDTO();
            HienThiPC();
            boolcontrols(true);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSearch.Text = "";
            LoadDTO();
            HienThiPC();
            boolcontrols(true);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDTO();
            HienThiPC();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaPC.Text = row.Cells[0].Value.ToString();
                txtTenPC.Text = row.Cells[1].Value.ToString();
                txtTienPC.Text = row.Cells[2].Value.ToString();
                dtNgayHieuLuc.Text = row.Cells[3].Value.ToString();
            }
        }

        private void txtTienPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
