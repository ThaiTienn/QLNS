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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LabelHeight(lblLeft, 32);
            LabelHeight(lblRight, 32);
            lblUser.Text = "Người sử dụng" + " : " + frmDangNhap.id;
            lblDate.Text = "Ngày làm việc" + " : " + DateTime.Now.ToString("dd/MM/yyyy");
            if(frmDangNhap.role == "Nhân viên")
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                danhMụcPhòngBanToolStripMenuItem.Enabled = false;
                danhMụcChứcVụToolStripMenuItem.Enabled = false;
                danhMụcPhụCấpToolStripMenuItem.Enabled = false;
                sốGiờLàmCủaThángToolStripMenuItem.Enabled = false;
                phụCấpChoNhânViênToolStripMenuItem.Enabled = false;
                thưởngphạtChoNhânViênToolStripMenuItem.Enabled = false;
                tínhLươngToolStripMenuItem.Enabled = false;
                danhSáchNhânViênToolStripMenuItem.Enabled = false;
            } 
            else
            {
                chấmCôngToolStripMenuItem.Enabled = false;
            }    
        }
        public static void LabelHeight(Label label, int size)
        {
            label.AutoSize = false;
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Width = 1;
            label.Height = size;
        }
        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            for (int i = 0; i < TabHienThi.TabPages.Count; i++)
            {
                if (TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThi.Size;
            tab.Text = tenTab;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        public void DongAllTab()
        {
            while (TabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_QLTK.ucQLTK, 4, "QUẢN LÝ TÀI KHOẢN");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void danhMụcPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_QLPB.ucQLPB, 4, "DANH MỤC PHÒNG BAN");
        }

        private void danhMụcChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_QLCV.ucQLCV, 4, "DANH MỤC CHỨC VỤ");
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_QLNV.ucQLNV, 4, "DANH MỤC NHÂN VIÊN");
        }

        private void danhMụcPhụCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_QLPC.ucQLPC, 4, "DANH MỤC PHỤ CẤP");
        }

        private void menuItemDongTrang_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void menuItemDongTrangAll_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void sốGiờLàmCủaThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_SoGioLam.ucSoGioLam, 4, "KHAI BÁO SỐ GIỜ LÀM");
        }

        private void thưởngphạtChoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_ThuongPhatNhanVien.ucTPNV, 4, "KHAI BÁO THƯỞNG/PHẠT NHÂN VIÊN");
        }

        private void phụCấpChoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_PhuCapNhanVien.ucPCNV, 4, "KHAI BÁO PHỤ CẤP NHÂN VIÊN");
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_ChamCong.ucChamCong, 4, "CHẤM CÔNG");
        }

        private void tínhLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_TinhLuong.ucTinhLuong, 4, "TÍNH LƯƠNG");
        }

        private void báoCáoLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_BaoCaoLuong.ucBaoCaoLuong, 4, "BÁO CÁO LƯƠNG");
        }

        private void danhSáchChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_BaoCaoChamCong.ucBaoCaoChamCong, 4, "BÁO CÁO CHẤM CÔNG");
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UC_BaoCaoNhanVien.ucBaoCaoNhanVien, 4, "DANH SÁCH NHÂN VIÊN");
        }

       
    }
}
