using BLL;
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
    public partial class UC_BaoCaoNhanVien : UserControl
    {
        public UC_BaoCaoNhanVien()
        {
            InitializeComponent();
        }
        public static UC_BaoCaoNhanVien ucBaoCaoNhanVien = new UC_BaoCaoNhanVien();
        BaoCaoBLL bll = new BaoCaoBLL();
        private void UC_BaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            
        }
        private void DuLieuBaoCao()
        {
            gridview.DataSource = bll.BaoCaoNhanVien(txtPhongBan.Text, txtChucVu.Text, txtNhanVien.Text);
            gridview.Columns[0].HeaderText = "Tên PB";
            gridview.Columns[1].HeaderText = "Tên Chức vụ";
            gridview.Columns[2].HeaderText = "Mã NV";
            gridview.Columns[3].HeaderText = "Tên NV";
            gridview.Columns[4].HeaderText = "Ngày sinh";
            gridview.Columns[5].HeaderText = "Giới tính";
            gridview.Columns[6].HeaderText = "CCCD";
            gridview.Columns[7].HeaderText = "Email";
            gridview.Columns[8].HeaderText = "SĐT";
            gridview.Columns[9].HeaderText = "Địa chỉ";
            gridview.Columns[10].HeaderText = "Mật khẩu";
            gridview.Columns[11].HeaderText = "Chức vụ";
            gridview.Columns[12].HeaderText = "Phòng ban";
            gridview.Columns[13].HeaderText = "Ngày vào làm";
            gridview.Columns[14].HeaderText = "Trạng thái";
            gridview.Columns[15].HeaderText = "Lương cơ bản";

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

        private void btnTim_Click(object sender, EventArgs e)
        {
            DuLieuBaoCao();
        }
    }
}
