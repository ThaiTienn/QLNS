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
    public partial class UC_PhuCapNhanVien : UserControl
    {
        public UC_PhuCapNhanVien()
        {
            InitializeComponent();
        }
        public static UC_PhuCapNhanVien ucPCNV = new UC_PhuCapNhanVien();
        KhaiBaoPCNVBLL bll = new KhaiBaoPCNVBLL();
        private bool luu;
        KhaiBaoPCNVDTO dto = new KhaiBaoPCNVDTO();
        private void LoadDTO()
        {
            dto.Id = txtId.Text;
            if (cboMaNV.Text == "")
            {
                dto.MaNV = "";
            }
            else
            {
                dto.MaNV = cboMaNV.SelectedValue.ToString();
            }
            if (cboMaPC.Text == "")
            {
                dto.MaPC = "";
            }
            else
            {
                dto.MaPC = cboMaPC.SelectedValue.ToString();
            }

            dto.Thang = txtThang.Text;
            dto.Nam = txtNam.Text;
            dto.TenSearch = txtMaNVSearch.Text;
        }
        private void UC_PhuCapNhanVien_Load(object sender, EventArgs e)
        {
            ComboboxPhuCap();
            ComboboxNhanVien();
            HienThiDanhSach();
            boolcontrols(true);
        }
        private void HienThiDanhSach()
        {
            LoadDTO();
            gridview.DataSource = bll.DanhSach(dto);
            gridview.Columns[0].HeaderText = "Id";
            gridview.Columns[1].HeaderText = "Mã NV";
            gridview.Columns[2].HeaderText = "Mã phụ cấp";
            gridview.Columns[3].HeaderText = "Tháng";
            gridview.Columns[4].HeaderText = "Năm";
            gridview.Columns[5].HeaderText = "Tiền phụ cấp";
            if (gridview.Rows.Count == 0)
            {
                txtId.Text = "";
                txtThang.Text = "";
                txtNam.Text = "";
            }
            else
            {
                var row = this.gridview.Rows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                cboMaNV.SelectedValue = row.Cells[1].Value.ToString();
                cboMaPC.Text = row.Cells[2].Value.ToString();
                txtThang.Text = row.Cells[3].Value.ToString();
                txtNam.Text = row.Cells[4].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtId.Text = "PCNV_" + DateTime.Now.ToString("yyyyMMddhhmmss");
            txtThang.Text = "";
            txtNam.Text = "";
            boolcontrols(false);
            luu = true;
            txtId.Focus();
        }
        private void ComboboxPhuCap()
        {
            PhuCapDTO dtopc = new PhuCapDTO();
            PhuCapBLL bllpc = new PhuCapBLL();
            DataTable dt = bllpc.DanhSach(dtopc);
            cboMaPC.DataSource = dt;
            cboMaPC.DisplayMember = "TenPC";
            cboMaPC.ValueMember = "MaPC";
        }

        private void ComboboxNhanVien()
        {
            NhanVienDTO dtonv = new NhanVienDTO();
            NhanVienBLL bllnv = new NhanVienBLL();
            DataTable dt = bllnv.DanhSach(dtonv);
            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";
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
            cboMaNV.Enabled = !iss;
            cboMaPC.Enabled = !iss;
            txtThang.Enabled = !iss;
            txtNam.Enabled = !iss;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            luu = false;
            txtId.Enabled = false;
            boolcontrols(false);
            txtId.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            try
            {
                DialogResult dr = MessageBox.Show("Có chắc chắn xóa khai báo này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        LoadDTO();
                        bll.Xoa(dto);
                        MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        HienThiDanhSach();
                        boolcontrols(true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa thất bại, dữ liệu khai báo này đã liên kết với khóa ngoại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                else
                    return;
            }
            catch (Exception)
            {
                MessageBox.Show("khai báo này đã phát sinh khóa ngoại ở table khác, nên không được xóa.");
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Mã khai báo không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }
            if (cboMaNV.Text == "")
            {
                MessageBox.Show("Nhân viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaNV.Focus();
                return;
            }
            if (cboMaPC.Text == "")
            {
                MessageBox.Show("Phụ cấp không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaPC.Focus();
                return;
            }
            if (txtThang.Text == "")
            {
                MessageBox.Show("Tháng không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThang.Focus();
                return;
            }
            if (txtNam.Text == "")
            {
                MessageBox.Show("Năm không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNam.Focus();
                return;
            }

            if (luu == true)
            {
                try
                {
                    LoadDTO();
                    bll.Them(dto);
                    MessageBox.Show("Thêm thành công.");
                    HienThiDanhSach();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã khai báo đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtId.Focus();
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
                    HienThiDanhSach();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã khai báo đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtId.Focus();
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNVSearch.Text = "";
            LoadDTO();
            HienThiDanhSach();
            boolcontrols(true);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNVSearch.Text = "";
            ComboboxNhanVien();
            LoadDTO();
            HienThiDanhSach();
            boolcontrols(true);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDTO();
            HienThiDanhSach();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                cboMaNV.SelectedValue = row.Cells[1].Value.ToString();
                cboMaPC.Text = row.Cells[2].Value.ToString();
                txtThang.Text = row.Cells[3].Value.ToString();
                txtNam.Text = row.Cells[4].Value.ToString();
            }
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
