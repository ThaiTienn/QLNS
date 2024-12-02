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
    public partial class UC_ThuongPhatNhanVien : UserControl
    {
        public UC_ThuongPhatNhanVien()
        {
            InitializeComponent();
        }
        public static UC_ThuongPhatNhanVien ucTPNV = new UC_ThuongPhatNhanVien();
        KhaiBaoTPNVBLL bll = new KhaiBaoTPNVBLL();
        private bool luu;
        KhaiBaoTPNVDTO dto = new KhaiBaoTPNVDTO();
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
            if (cboMaThuongPhat.Text == "")
            {
                dto.MaThuongPhat = "";
            }
            else
            {
                dto.MaThuongPhat = cboMaThuongPhat.SelectedValue.ToString();
            }
            
            dto.Thang = txtThang.Text;
            dto.Nam = txtNam.Text;
            dto.SoTien = txtSoTien.Text;
            dto.LyDo = txtLyDo.Text;
            dto.TenSearch = txtMaNVSearch.Text;
        }
        private void UC_ThuongPhatNhanVien_Load(object sender, EventArgs e)
        {
            ComboboxThuongPhat();
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
            gridview.Columns[2].HeaderText = "Mã thưởng phạt";
            gridview.Columns[3].HeaderText = "Tháng";
            gridview.Columns[4].HeaderText = "Năm";
            gridview.Columns[5].HeaderText = "Số tiền";
            gridview.Columns[6].HeaderText = "Lý do";
            if (gridview.Rows.Count == 0)
            {
                txtId.Text = "";
                txtThang.Text = "";
                txtNam.Text = "";
                txtSoTien.Text = "";
                txtLyDo.Text = "";
            }
            else
            {
                var row = this.gridview.Rows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                cboMaNV.SelectedValue = row.Cells[1].Value.ToString();
                cboMaThuongPhat.Text = row.Cells[2].Value.ToString();
                txtThang.Text = row.Cells[3].Value.ToString();
                txtNam.Text = row.Cells[4].Value.ToString();
                txtSoTien.Text = row.Cells[5].Value.ToString();
                txtLyDo.Text = row.Cells[6].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtId.Text = "TPNV_"+ DateTime.Now.ToString("yyyyMMddhhmmss");
            txtThang.Text = "";
            txtNam.Text = "";
            txtSoTien.Text = "";
            txtLyDo.Text = "";
            boolcontrols(false);
            luu = true;
            txtId.Focus();
        }
        private void ComboboxThuongPhat()
        {
            DataTable dataTable = new DataTable();
            cboMaThuongPhat.Items.Clear();
            dataTable.Columns.Add("Ma", typeof(string));
            dataTable.Columns.Add("Ten", typeof(string));
            dataTable.Rows.Add("Thưởng", "Thưởng");
            dataTable.Rows.Add("Phạt", "Phạt");
            cboMaThuongPhat.DataSource = dataTable;
            cboMaThuongPhat.DisplayMember = "Ten";
            cboMaThuongPhat.ValueMember = "Ma";
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
            cboMaThuongPhat.Enabled = !iss;
            txtThang.Enabled = !iss;
            txtNam.Enabled = !iss;
            txtSoTien.Enabled = !iss;
            txtLyDo.Enabled = !iss;
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
                cboMaThuongPhat.Text = row.Cells[2].Value.ToString();
                txtThang.Text = row.Cells[3].Value.ToString();
                txtNam.Text = row.Cells[4].Value.ToString();
                txtSoTien.Text = row.Cells[5].Value.ToString();
                txtLyDo.Text = row.Cells[6].Value.ToString();
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

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
