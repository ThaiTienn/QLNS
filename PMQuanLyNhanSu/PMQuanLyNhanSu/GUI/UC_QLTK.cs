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
    public partial class UC_QLTK : UserControl
    {
        public UC_QLTK()
        {
            InitializeComponent();
        }
        public static UC_QLTK ucQLTK = new UC_QLTK();
        TaiKhoanBLL bll = new TaiKhoanBLL();
        private bool luu;
        TaiKhoanDTO dto = new TaiKhoanDTO();
        private void LoadDTO ()
        {
            dto.MaTK = txtMaTK.Text;
            dto.TenTK = txtTenTK.Text;
            dto.MatKhau = txtMatKhau.Text;
            dto.DiaChi = txtDiaChi.Text;
            dto.DienThoai = txtDienThoai.Text;
            dto.TenSearch = txtTenTKSearch.Text;
        }
        private void UC_QLTK_Load(object sender, EventArgs e)
        {
            HienThiTaiKhoan();
            boolcontrols(true);
        }
        private void HienThiTaiKhoan()
        {
            LoadDTO();
            gridview.DataSource = bll.DanhSach(dto);
            gridview.Columns[0].HeaderText = "Mã TK";
            gridview.Columns[1].HeaderText = "Tên TK";
            gridview.Columns[2].HeaderText = "Mật khẩu";
            gridview.Columns[3].HeaderText = "Điện thoại";
            gridview.Columns[4].HeaderText = "Địa chỉ";
            if (gridview.Rows.Count == 0)
            {
                txtMaTK.Text = "";
                txtTenTK.Text = "";
                txtMatKhau.Text = "";
                txtDienThoai.Text = "";
                txtDiaChi.Text = "";
            }
            else
            {
                var row = this.gridview.Rows[0];
                txtMaTK.Text = row.Cells[0].Value.ToString().Trim();
                txtTenTK.Text = row.Cells[1].Value.ToString().Trim();
                txtMatKhau.Text = row.Cells[2].Value.ToString().Trim();
                txtDienThoai.Text = row.Cells[3].Value.ToString().Trim();
                txtDiaChi.Text = row.Cells[4].Value.ToString().Trim();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTK.Text = "";
            txtTenTK.Text = "";
            txtMatKhau.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            boolcontrols(false);
            luu = true;
            txtMaTK.Focus();
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
            txtMaTK.Enabled = !iss;
            txtTenTK.Enabled = !iss;
            txtMatKhau.Enabled = !iss;
            txtDiaChi.Enabled = !iss;
            txtDienThoai.Enabled = !iss;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            luu = false;
            txtMaTK.Enabled = false;
            boolcontrols(false);
            txtMaTK.Enabled = false;
            txtTenTK.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridview.Rows.Count == 0)
                {
                    return;
                }
                DialogResult dr = MessageBox.Show("Có chắc chắn xóa tài khoản này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    LoadDTO();
                    bll.Xoa(dto);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiTaiKhoan();
                    boolcontrols(true);
                }
                else
                    return;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi.");
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaTK.Text == "")
            {
                MessageBox.Show("Mã tài khoản không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTK.Focus();
                return;
            }
            if (txtTenTK.Text == "")
            {
                MessageBox.Show("Tên tài khoản không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTK.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }
            if (luu == true)
            {
                try
                {
                    LoadDTO();
                    bll.Them(dto);
                    MessageBox.Show("Thêm thành công.");
                    HienThiTaiKhoan();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã tài khoản đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaTK.Focus();
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
                    HienThiTaiKhoan();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã tài khoản đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaTK.Focus();
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenTKSearch.Text = "";
            LoadDTO();
            HienThiTaiKhoan();
            boolcontrols(true);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenTKSearch.Text = "";
            LoadDTO();
            HienThiTaiKhoan();
            boolcontrols(true);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDTO();
            HienThiTaiKhoan();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaTK.Text = row.Cells[0].Value.ToString().Trim();
                txtTenTK.Text = row.Cells[1].Value.ToString().Trim();
                txtMatKhau.Text = row.Cells[2].Value.ToString().Trim();
                txtDienThoai.Text = row.Cells[3].Value.ToString().Trim();
                txtDiaChi.Text = row.Cells[4].Value.ToString().Trim();
            }
        }
    }
}
