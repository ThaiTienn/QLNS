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
    public partial class UC_SoGioLam : UserControl
    {
        public UC_SoGioLam()
        {
            InitializeComponent();
        }
        public static UC_SoGioLam ucSoGioLam = new UC_SoGioLam();
        SoGioLamBLL bll = new SoGioLamBLL();
        private bool luu;
        SoGioLamDTO dto = new SoGioLamDTO();
        private void LoadDTO()
        {
            dto.Thang = txtThang.Text;
            dto.Nam = txtNam.Text;
            dto.SoGioLam = txtSoGioLam.Text;
            dto.ThangSearch = txtThangSearch.Text;
            dto.NamSearch = txtNamSearch.Text;
        }
        private void UC_SoGioLam_Load(object sender, EventArgs e)
        {
            HienThiSoGioLam();
            boolcontrols(true);
        }
        private void HienThiSoGioLam()
        {
            LoadDTO();
            gridview.DataSource = bll.DanhSach(dto);
            gridview.Columns[0].HeaderText = "Tháng";
            gridview.Columns[1].HeaderText = "Năm";
            gridview.Columns[2].HeaderText = "Số giờ làm";
            if (gridview.Rows.Count == 0)
            {
                txtThang.Text = "";
                txtNam.Text = "";
                txtSoGioLam.Text = "";
            }
            else
            {
                var row = this.gridview.Rows[0];
                txtThang.Text = row.Cells[0].Value.ToString();
                txtNam.Text = row.Cells[1].Value.ToString();
                txtSoGioLam.Text = row.Cells[2].Value.ToString();
            }
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
            txtThang.Enabled = !iss;
            txtNam.Enabled = !iss;
            txtSoGioLam.Enabled = !iss;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtThang.Text = "";
            txtNam.Text = "";
            txtSoGioLam.Text = "";
            boolcontrols(false);
            luu = true;
            txtThang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            luu = false;
            txtThang.Enabled = false;
            boolcontrols(false);
            txtThang.Enabled = false;
            txtNam.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa số giờ làm này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LoadDTO();
                bll.Xoa(dto);
                MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                HienThiSoGioLam();
                boolcontrols(true);
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
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
            if (txtSoGioLam.Text == "")
            {
                MessageBox.Show("Số giờ làm không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoGioLam.Focus();
                return;
            }
            if (luu == true)
            {
                try
                {
                    LoadDTO();
                    bll.Them(dto);
                    MessageBox.Show("Thêm thành công.");
                    HienThiSoGioLam();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã số giờ làm đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtThang.Focus();
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
                    HienThiSoGioLam();
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã số giờ làm đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtThang.Focus();
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtThangSearch.Text = "";
            txtNamSearch.Text = "";
            LoadDTO();
            HienThiSoGioLam();
            boolcontrols(true);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtThangSearch.Text = "";
            txtNamSearch.Text = "";
            LoadDTO();
            HienThiSoGioLam();
            boolcontrols(true);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDTO();
            HienThiSoGioLam();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtThang.Text = row.Cells[0].Value.ToString();
                txtNam.Text = row.Cells[1].Value.ToString();
                txtSoGioLam.Text = row.Cells[2].Value.ToString();
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

        private void txtSoGioLam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtThangSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNamSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
