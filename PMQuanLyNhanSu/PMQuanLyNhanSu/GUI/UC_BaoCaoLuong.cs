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
    public partial class UC_BaoCaoLuong : UserControl
    {
        public UC_BaoCaoLuong()
        {
            InitializeComponent();
        }
        public static UC_BaoCaoLuong ucBaoCaoLuong = new UC_BaoCaoLuong();
        BaoCaoBLL bll = new BaoCaoBLL();
        private string ma_nv_search;
        private void UC_BaoCaoLuong_Load(object sender, EventArgs e)
        {
            txtThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
            if(frmDangNhap.role != "Nhân viên")
            {
                DanhSachNV();
            }    
        }
        private void DanhSachNV()
        {
            NhanVienBLL bll = new NhanVienBLL();
            DataTable dt = bll.DanhSachNhanVienCoboboxTinhLuong();
            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";
        }
        private void DuLieuBaoCao()
        {
            if(frmDangNhap.role == "Nhân viên")
            {
                ma_nv_search = frmDangNhap.id;
            }    
            else
            {
                ma_nv_search = cboMaNV.SelectedValue.ToString();
            }    
            gridview.DataSource = bll.BaoCaoLuong(ma_nv_search, txtThang.Text, txtNam.Text);
            gridview.Columns[0].HeaderText = "Tháng";
            gridview.Columns[1].HeaderText = "Năm";
            gridview.Columns[2].HeaderText = "Tên PB";
            gridview.Columns[3].HeaderText = "Tên CV";
            gridview.Columns[4].HeaderText = "Mã NV";
            gridview.Columns[5].HeaderText = "Họ tên";
            gridview.Columns[6].HeaderText = "Lương cơ bản";
            gridview.Columns[7].HeaderText = "Tiền phụ cấp";
            gridview.Columns[8].HeaderText = "Tiền thưởng";
            gridview.Columns[9].HeaderText = "Tiền phạt";
            gridview.Columns[10].HeaderText = "Thiếu giờ làm";
            gridview.Columns[11].HeaderText = "Tiền phạt làm thiếu giờ";
            gridview.Columns[12].HeaderText = "Tổng lương";

        }
        private void btnTim_Click(object sender, EventArgs e)
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
            if(frmDangNhap.role != "Nhân viên")
            {
                if (cboMaNV.Text == "")
                {
                    MessageBox.Show("Nhân viên không được trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboMaNV.Focus();
                    return;
                }
            }
            else
            {
                ma_nv_search = frmDangNhap.id;
            }    
            DuLieuBaoCao();
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

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                for (int i = 1; i < gridview.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = gridview.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < gridview.Rows.Count; i++)
                {
                    for (int j = 0; j < gridview.Columns.Count; j++)
                    {
                        if (gridview.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = gridview.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
            }
        }
    }
}
