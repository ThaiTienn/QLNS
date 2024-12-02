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
    public partial class UC_QLCV : UserControl
    {
        public UC_QLCV()
        {
            InitializeComponent();
        }
        public static UC_QLCV ucQLCV = new UC_QLCV();
        ChucVuBLL bll = new ChucVuBLL();
        private bool luu;
        ChucVuDTO dto = new ChucVuDTO();
        private void LoadDTO()
        {
            dto.MaCV = txtMaCV.Text;
            dto.TenCV = txtTenCV.Text;
            dto.TenSearch = txtTenSearch.Text;
        }
        private void UC_QLCV_Load(object sender, EventArgs e)
        {
            HienThiCV();
            boolcontrols(true);
        }
        private void HienThiCV()
        {
            LoadDTO();
            gridview.DataSource = bll.DanhSach(dto);
            gridview.Columns[0].HeaderText = "Mã CV";
            gridview.Columns[1].HeaderText = "Tên CV";
            if (gridview.Rows.Count == 0)
            {
                txtMaCV.Text = "";
                txtTenCV.Text = "";
            }
            else
            {
                var row = this.gridview.Rows[0];
                txtMaCV.Text = row.Cells[0].Value.ToString();
                txtTenCV.Text = row.Cells[1].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            boolcontrols(false);
            luu = true;
            txtMaCV.Focus();
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
            txtMaCV.Enabled = !iss;
            txtTenCV.Enabled = !iss;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            luu = false;
            txtMaCV.Enabled = false;
            boolcontrols(false);
            txtMaCV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa chức vụ này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    LoadDTO();
                    bll.Xoa(dto);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiCV();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại, dữ liệu chức vụ này đã liên kết với khóa ngoại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
                
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Mã chức vụ không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaCV.Focus();
                return;
            }
            if (txtTenCV.Text == "")
            {
                MessageBox.Show("Tên chức vụ không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenCV.Focus();
                return;
            }
            if (luu == true)
            {
                try
                {
                    LoadDTO();
                    bll.Them(dto);
                    MessageBox.Show("Thêm thành công.");
                    HienThiCV();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã chức vụ đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaCV.Focus();
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
                    HienThiCV();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã chức vụ đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaCV.Focus();
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenSearch.Text = "";
            LoadDTO();
            HienThiCV();
            boolcontrols(true);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSearch.Text = "";
            LoadDTO();
            HienThiCV();
            boolcontrols(true);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDTO();
            HienThiCV();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaCV.Text = row.Cells[0].Value.ToString();
                txtTenCV.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
