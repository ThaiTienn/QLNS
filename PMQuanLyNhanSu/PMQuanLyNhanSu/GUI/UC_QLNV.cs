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
    public partial class UC_QLNV : UserControl
    {
        public UC_QLNV()
        {
            InitializeComponent();
        }
        public static UC_QLNV ucQLNV = new UC_QLNV();
        NhanVienBLL bll = new NhanVienBLL();
        private bool luu;
        NhanVienDTO dto = new NhanVienDTO();
        private void LoadDTO()
        {
            dto.MaNV = txtMaNV.Text;
            dto.HoTen = txtHoTen.Text;
            dto.NgaySinh = dtNgaySinh.Value.ToString("yyyyMMdd");
            dto.GioiTinh = cboGioiTinh.Text;
            dto.CCCD = txtCCCD.Text;
            dto.Email = txtEmail.Text;
            dto.SDT = txtSDT.Text;
            dto.DiaChi = txtDiaChi.Text;
            dto.Password = txtPassword.Text;
            if(cboMaCV.Text == "")
            {
                dto.MaCV = "";
            }   
            else
            {
                dto.MaCV = cboMaCV.SelectedValue.ToString();
            }
            if (cboMaPB.Text == "")
            {
                dto.MaPB = "";
            }
            else
            {
                dto.MaPB = cboMaPB.SelectedValue.ToString();
            }
            dto.NgayVaoLam = dtNgayVaoLam.Value.ToString("yyyyMMdd");
            dto.TrangThai = cboTrangThai.Text;
            dto.LuongCoBan = txtLuongCoBan.Text;
            dto.TenSearch = txtTenNVSearch.Text;
        }
        private void UC_QLNV_Load(object sender, EventArgs e)
        {   
            DanhSachGioiTinh();
            DanhSachPhongBan();
            DanhSachTrangThaiNV();
            DanhSachChucVu();
            boolcontrols(true);
            HienThiNhanVien();
        }
        private void HienThiNhanVien()
        {
            LoadDTO();
            gridview.DataSource = bll.DanhSach(dto);
            gridview.Columns[0].HeaderText = "Mã NV";
            gridview.Columns[1].HeaderText = "Tên NV";
            gridview.Columns[2].HeaderText = "Ngày sinh";
            gridview.Columns[3].HeaderText = "Giới tính";
            gridview.Columns[4].HeaderText = "CCCD";
            gridview.Columns[5].HeaderText = "Email";
            gridview.Columns[6].HeaderText = "SĐT";
            gridview.Columns[7].HeaderText = "Địa chỉ";
            gridview.Columns[8].HeaderText = "Mật khẩu";
            gridview.Columns[9].HeaderText = "Chức vụ";
            gridview.Columns[10].HeaderText = "Phòng ban";
            gridview.Columns[11].HeaderText = "Ngày vào làm";
            gridview.Columns[12].HeaderText = "Trạng thái";
            gridview.Columns[13].HeaderText = "Lương cơ bản";
            if (gridview.Rows.Count == 0)
            {
                txtMaNV.Text = "";
                txtHoTen.Text = "";
                txtCCCD.Text = "";
                txtEmail.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                txtPassword.Text = "";
                txtLuongCoBan.Text = "";
            }
            else
            {
                var row = this.gridview.Rows[0];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtNgaySinh.Text = row.Cells[2].Value.ToString();
                cboGioiTinh.Text = row.Cells[3].Value.ToString();
                txtCCCD.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
                txtDiaChi.Text = row.Cells[7].Value.ToString();
                txtPassword.Text = row.Cells[8].Value.ToString();
                cboMaCV.SelectedValue = row.Cells[9].Value.ToString();
                cboMaPB.SelectedValue = row.Cells[10].Value.ToString();
                dtNgayVaoLam.Text = row.Cells[11].Value.ToString();
                cboTrangThai.Text = row.Cells[12].Value.ToString();
                txtLuongCoBan.Text = row.Cells[13].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtCCCD.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtPassword.Text = "";
            txtLuongCoBan.Text = "";
            boolcontrols(false);
            luu = true;
            txtMaNV.Focus();    
        }
        private void DanhSachGioiTinh()
        {
            DataTable dataTable = new DataTable();
            cboGioiTinh.Items.Clear();
            dataTable.Columns.Add("GioiTinh", typeof(string));
            dataTable.Columns.Add("TenGioiTinh", typeof(string));
            dataTable.Rows.Add("Nam", "Nam");
            dataTable.Rows.Add("Nữ", "Nữ");
            cboGioiTinh.DataSource = dataTable;
            cboGioiTinh.DisplayMember = "TenGioiTinh";
            cboGioiTinh.ValueMember = "GioiTinh";
        }
        private void DanhSachTrangThaiNV()
        {
            DataTable dataTable = new DataTable();
            cboTrangThai.Items.Clear();
            dataTable.Columns.Add("MaTrangThai", typeof(string));
            dataTable.Columns.Add("TenTrangThai", typeof(string));
            dataTable.Rows.Add("1", "Đang làm việc");
            dataTable.Rows.Add("0", "Nghỉ việc");
            cboTrangThai.DataSource = dataTable;
            cboTrangThai.DisplayMember = "TenTrangThai";
            cboTrangThai.ValueMember = "MaTrangThai";
        }
        private void DanhSachPhongBan()
        {
            PhongBanDTO dtopb = new PhongBanDTO();
            PhongBanBLL bllpb = new PhongBanBLL();
            DataTable dt = bllpb.DanhSach(dtopb);
            cboMaPB.DataSource = dt;
            cboMaPB.DisplayMember = "TenPB";
            cboMaPB.ValueMember = "MaPB";
        }
        private void DanhSachChucVu()
        {
            ChucVuDTO dtocv= new ChucVuDTO();
            ChucVuBLL bllcv = new ChucVuBLL();
            DataTable dt = bllcv.DanhSach(dtocv);
            cboMaCV.DataSource = dt;
            cboMaCV.DisplayMember = "TenCV";
            cboMaCV.ValueMember = "MaCV";
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
            txtMaNV.Enabled = !iss;
            txtHoTen.Enabled = !iss;
            dtNgaySinh.Enabled = !iss;
            cboGioiTinh.Enabled = !iss;
            txtCCCD.Enabled = !iss;
            txtEmail.Enabled = !iss;
            txtSDT.Enabled = !iss;
            txtDiaChi.Enabled = !iss;
            txtPassword.Enabled = !iss;
            cboMaCV.Enabled = !iss;
            cboMaPB.Enabled = !iss;
            cboTrangThai.Enabled = !iss;
            txtLuongCoBan.Enabled = !iss;
            dtNgayVaoLam.Enabled = !iss;
            if (frmDangNhap.role == "Nhân viên")
            {
                btnLamMoi.Visible = false;
                btnThem.Visible = false;
                btnXoa.Visible = false;
                btnTim.Visible = false;
                txtTenNVSearch.Visible = false;
                label6.Visible = false;
                txtTenNVSearch.Text = frmDangNhap.name;
                txtMaNV.Enabled = false;
                txtHoTen.Enabled = false;
                dtNgaySinh.Enabled = false;
                cboGioiTinh.Enabled = false;
                txtCCCD.Enabled = false;
                txtEmail.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
                txtPassword.Enabled = true;
                cboMaCV.Enabled = false;
                cboMaPB.Enabled = false;
                cboTrangThai.Enabled = false;
                txtLuongCoBan.Enabled = false;
                dtNgayVaoLam.Enabled = false;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            luu = false;
            txtMaNV.Enabled = false;
            boolcontrols(false);
            txtMaNV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            try
            {
                DialogResult dr = MessageBox.Show("Có chắc chắn xóa nhân viên này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        LoadDTO();
                        bll.Xoa(dto);
                        MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        HienThiNhanVien();
                        boolcontrols(true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa thất bại, dữ liệu nhân viên này đã liên kết với khóa ngoại ở bảng khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                else
                    return;
            }
            catch (Exception)
            {
                MessageBox.Show("Nhân viên này đã phát sinh khóa ngoại ở table khác, nên không được xóa.");
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }
            if (txtCCCD.Text == "")
            {
                MessageBox.Show("CCCD không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCCCD.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("SDT không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (cboMaCV.Text == "")
            {
                MessageBox.Show("Chức vụ không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaCV.Focus();
                return;
            }
            if (cboMaPB.Text == "")
            {
                MessageBox.Show("Phòng ban không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaPB.Focus();
                return;
            }
            if (txtLuongCoBan.Text == "")
            {
                MessageBox.Show("Lương cơ bản không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuongCoBan.Focus();
                return;
            }
            if (luu == true)
            {
                try
                {
                    LoadDTO();
                    bll.Them(dto);
                    MessageBox.Show("Thêm thành công.");
                    HienThiNhanVien();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
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
                    HienThiNhanVien();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenNVSearch.Text = "";
            boolcontrols(true);
            HienThiNhanVien();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenNVSearch.Text = "";
            DanhSachPhongBan();
            DanhSachChucVu();
            LoadDTO();
            HienThiNhanVien();
            boolcontrols(true);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDTO();
            HienThiNhanVien();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtNgaySinh.Text = row.Cells[2].Value.ToString();
                cboGioiTinh.Text = row.Cells[3].Value.ToString();
                txtCCCD.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
                txtDiaChi.Text = row.Cells[7].Value.ToString();
                txtPassword.Text = row.Cells[8].Value.ToString();
                cboMaCV.SelectedValue = row.Cells[9].Value.ToString();
                cboMaPB.SelectedValue = row.Cells[10].Value.ToString();
                dtNgayVaoLam.Text = row.Cells[11].Value.ToString();
                cboTrangThai.Text = row.Cells[12].Value.ToString();
                txtLuongCoBan.Text = row.Cells[13].Value.ToString();
            }
        }

        private void txtLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
