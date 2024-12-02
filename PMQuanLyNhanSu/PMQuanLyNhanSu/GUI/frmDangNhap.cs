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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        TaiKhoanBLL bLLtk = new TaiKhoanBLL();
        NhanVienBLL bLLnv = new NhanVienBLL();
        public static string role;
        public static string id;
        public static string name;
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            DanhSachQuyen();
        }
        private void DanhSachQuyen()
        {
            DataTable dataTable = new DataTable();
            cboQuyen.Items.Clear();
            dataTable.Columns.Add("MaQuyen", typeof(string));
            dataTable.Columns.Add("TenQuyen", typeof(string));
            dataTable.Rows.Add("Quản trị viên", "Quản trị viên");
            dataTable.Rows.Add("Nhân viên", "Nhân viên");
            cboQuyen.DataSource = dataTable;
            cboQuyen.DisplayMember = "TenQuyen";
            cboQuyen.ValueMember = "MaQuyen";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Mã đăng nhập không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtid.Focus();
                return;
            }
            if (txtpass.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Focus();
                return;
            }
            if(cboQuyen.Text == "Nhân viên")
            {
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                NhanVienDTO dto = new NhanVienDTO();
                dto.MaNV = txtid.Text;
                dto.Password = txtpass.Text;
                dt = bLLnv.DangNhap(dto);
                dt2 = bLLnv.NhanVienTheoMa(dto);
                if (dt.Rows.Count > 0)
                {
                    role = cboQuyen.Text;
                    id = txtid.Text;
                    name = dt2.Rows[0][1].ToString();
                    frmMain frm = new frmMain();
                    frm.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Không đúng tên người dùng hoặc mật khẩu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtid.Focus();
                }
            }    
            else
            {
                DataTable dt = new DataTable();
                TaiKhoanDTO dto = new TaiKhoanDTO();
                dto.MaTK = txtid.Text;
                dto.MatKhau = txtpass.Text;
                dt = bLLtk.DangNhap(dto);
                if (dt.Rows.Count > 0)
                {
                    role = cboQuyen.Text;
                    id = txtid.Text;
                    frmMain frm = new frmMain();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không đúng tên người dùng hoặc mật khẩu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtid.Focus();
                }
            }    
        }
    }
}
