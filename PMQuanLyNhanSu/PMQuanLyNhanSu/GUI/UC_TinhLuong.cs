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
    public partial class UC_TinhLuong : UserControl
    {
        public UC_TinhLuong()
        {
            InitializeComponent();
        }
        public static UC_TinhLuong ucTinhLuong = new UC_TinhLuong();
        TinhLuongBLL bll = new TinhLuongBLL();
        private void UC_TinhLuong_Load(object sender, EventArgs e)
        {
            txtThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
            DanhSachNV();
        }
        private void DanhSachNV()
        {
            NhanVienBLL bll = new NhanVienBLL();
            DataTable dt = bll.DanhSachNhanVienCoboboxTinhLuong();
            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";
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
            if (cboMaNV.Text == "")
            {
                MessageBox.Show("Nhân viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaNV.Focus();
                return;
            }
            if (cboMaNV.SelectedValue.ToString() == "ALL")
            {
                NhanVienBLL bllnv = new NhanVienBLL();
                NhanVienDTO dtonv = new NhanVienDTO();
                DataTable dt = new DataTable();
                dt = bllnv.DanhSach(dtonv);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        bll.TinhLuong(dt.Rows[i][0].ToString(),txtThang.Text, txtNam.Text);
                    }
                }
            }
            else
            {
                bll.TinhLuong(cboMaNV.SelectedValue.ToString(),txtThang.Text, txtNam.Text);
            }
            MessageBox.Show("Tính lương thành công, qua chức năng báo cáo lương để lọc kết quả");
        }
    }
}
