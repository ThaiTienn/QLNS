namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblUser = new System.Windows.Forms.Label();
            this.TabHienThi = new System.Windows.Forms.TabControl();
            this.ctxtmenuTabHienThi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDongTrang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDongTrangAll = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcChứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcPhụCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khaiBáoThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốGiờLàmCủaThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụCấpChoNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thưởngphạtChoNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngTínhLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchChấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.ctxtmenuTabHienThi.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(519, 662);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 17);
            this.lblUser.TabIndex = 146;
            this.lblUser.Text = "_______";
            // 
            // TabHienThi
            // 
            this.TabHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabHienThi.ContextMenuStrip = this.ctxtmenuTabHienThi;
            this.TabHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TabHienThi.Location = new System.Drawing.Point(0, 34);
            this.TabHienThi.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.TabHienThi.Name = "TabHienThi";
            this.TabHienThi.SelectedIndex = 0;
            this.TabHienThi.Size = new System.Drawing.Size(1067, 623);
            this.TabHienThi.TabIndex = 142;
            // 
            // ctxtmenuTabHienThi
            // 
            this.ctxtmenuTabHienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtmenuTabHienThi.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.ctxtmenuTabHienThi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDongTrang,
            this.menuItemDongTrangAll});
            this.ctxtmenuTabHienThi.Name = "ctxtmenuTabHienThi";
            this.ctxtmenuTabHienThi.Size = new System.Drawing.Size(230, 56);
            // 
            // menuItemDongTrang
            // 
            this.menuItemDongTrang.Name = "menuItemDongTrang";
            this.menuItemDongTrang.Size = new System.Drawing.Size(229, 26);
            this.menuItemDongTrang.Text = "Đóng trang hiện tại";
            this.menuItemDongTrang.Click += new System.EventHandler(this.menuItemDongTrang_Click);
            // 
            // menuItemDongTrangAll
            // 
            this.menuItemDongTrangAll.Name = "menuItemDongTrangAll";
            this.menuItemDongTrangAll.Size = new System.Drawing.Size(229, 26);
            this.menuItemDongTrangAll.Text = "Đóng tất cả";
            this.menuItemDongTrangAll.Click += new System.EventHandler(this.menuItemDongTrangAll_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(836, 662);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 17);
            this.lblDate.TabIndex = 144;
            this.lblDate.Text = "_______";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.khaiBáoThôngTinToolStripMenuItem,
            this.chấmCôngTínhLươngToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 147;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hệThốngToolStripMenuItem.Image")));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcPhòngBanToolStripMenuItem,
            this.danhMụcChứcVụToolStripMenuItem,
            this.danhMụcNhânViênToolStripMenuItem,
            this.danhMụcPhụCấpToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhMụcToolStripMenuItem.Image")));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // danhMụcPhòngBanToolStripMenuItem
            // 
            this.danhMụcPhòngBanToolStripMenuItem.Name = "danhMụcPhòngBanToolStripMenuItem";
            this.danhMụcPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.danhMụcPhòngBanToolStripMenuItem.Text = "Danh mục phòng ban";
            this.danhMụcPhòngBanToolStripMenuItem.Click += new System.EventHandler(this.danhMụcPhòngBanToolStripMenuItem_Click);
            // 
            // danhMụcChứcVụToolStripMenuItem
            // 
            this.danhMụcChứcVụToolStripMenuItem.Name = "danhMụcChứcVụToolStripMenuItem";
            this.danhMụcChứcVụToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.danhMụcChứcVụToolStripMenuItem.Text = "Danh mục chức vụ";
            this.danhMụcChứcVụToolStripMenuItem.Click += new System.EventHandler(this.danhMụcChứcVụToolStripMenuItem_Click);
            // 
            // danhMụcNhânViênToolStripMenuItem
            // 
            this.danhMụcNhânViênToolStripMenuItem.Name = "danhMụcNhânViênToolStripMenuItem";
            this.danhMụcNhânViênToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.danhMụcNhânViênToolStripMenuItem.Text = "Danh mục nhân viên";
            this.danhMụcNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhMụcNhânViênToolStripMenuItem_Click);
            // 
            // danhMụcPhụCấpToolStripMenuItem
            // 
            this.danhMụcPhụCấpToolStripMenuItem.Name = "danhMụcPhụCấpToolStripMenuItem";
            this.danhMụcPhụCấpToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.danhMụcPhụCấpToolStripMenuItem.Text = "Danh mục phụ cấp";
            this.danhMụcPhụCấpToolStripMenuItem.Click += new System.EventHandler(this.danhMụcPhụCấpToolStripMenuItem_Click);
            // 
            // khaiBáoThôngTinToolStripMenuItem
            // 
            this.khaiBáoThôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sốGiờLàmCủaThángToolStripMenuItem,
            this.phụCấpChoNhânViênToolStripMenuItem,
            this.thưởngphạtChoNhânViênToolStripMenuItem});
            this.khaiBáoThôngTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khaiBáoThôngTinToolStripMenuItem.Image")));
            this.khaiBáoThôngTinToolStripMenuItem.Name = "khaiBáoThôngTinToolStripMenuItem";
            this.khaiBáoThôngTinToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.khaiBáoThôngTinToolStripMenuItem.Text = "Khai báo thông tin";
            // 
            // sốGiờLàmCủaThángToolStripMenuItem
            // 
            this.sốGiờLàmCủaThángToolStripMenuItem.Name = "sốGiờLàmCủaThángToolStripMenuItem";
            this.sốGiờLàmCủaThángToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.sốGiờLàmCủaThángToolStripMenuItem.Text = "Số giờ làm của tháng";
            this.sốGiờLàmCủaThángToolStripMenuItem.Click += new System.EventHandler(this.sốGiờLàmCủaThángToolStripMenuItem_Click);
            // 
            // phụCấpChoNhânViênToolStripMenuItem
            // 
            this.phụCấpChoNhânViênToolStripMenuItem.Name = "phụCấpChoNhânViênToolStripMenuItem";
            this.phụCấpChoNhânViênToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.phụCấpChoNhânViênToolStripMenuItem.Text = "Phụ cấp cho nhân viên";
            this.phụCấpChoNhânViênToolStripMenuItem.Click += new System.EventHandler(this.phụCấpChoNhânViênToolStripMenuItem_Click);
            // 
            // thưởngphạtChoNhânViênToolStripMenuItem
            // 
            this.thưởngphạtChoNhânViênToolStripMenuItem.Name = "thưởngphạtChoNhânViênToolStripMenuItem";
            this.thưởngphạtChoNhânViênToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.thưởngphạtChoNhânViênToolStripMenuItem.Text = "Thưởng/phạt cho nhân viên";
            this.thưởngphạtChoNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thưởngphạtChoNhânViênToolStripMenuItem_Click);
            // 
            // chấmCôngTínhLươngToolStripMenuItem
            // 
            this.chấmCôngTínhLươngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chấmCôngToolStripMenuItem,
            this.tínhLươngToolStripMenuItem});
            this.chấmCôngTínhLươngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chấmCôngTínhLươngToolStripMenuItem.Image")));
            this.chấmCôngTínhLươngToolStripMenuItem.Name = "chấmCôngTínhLươngToolStripMenuItem";
            this.chấmCôngTínhLươngToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.chấmCôngTínhLươngToolStripMenuItem.Text = "Chấm công - Tính lương";
            // 
            // chấmCôngToolStripMenuItem
            // 
            this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            this.chấmCôngToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.chấmCôngToolStripMenuItem.Text = "Chấm công";
            this.chấmCôngToolStripMenuItem.Click += new System.EventHandler(this.chấmCôngToolStripMenuItem_Click);
            // 
            // tínhLươngToolStripMenuItem
            // 
            this.tínhLươngToolStripMenuItem.Name = "tínhLươngToolStripMenuItem";
            this.tínhLươngToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.tínhLươngToolStripMenuItem.Text = "Tính lương";
            this.tínhLươngToolStripMenuItem.Click += new System.EventHandler(this.tínhLươngToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchChấmCôngToolStripMenuItem,
            this.danhSáchNhânViênToolStripMenuItem,
            this.báoCáoLươngToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("báoCáoToolStripMenuItem.Image")));
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.báoCáoToolStripMenuItem.Text = " Báo cáo";
            // 
            // danhSáchChấmCôngToolStripMenuItem
            // 
            this.danhSáchChấmCôngToolStripMenuItem.Name = "danhSáchChấmCôngToolStripMenuItem";
            this.danhSáchChấmCôngToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.danhSáchChấmCôngToolStripMenuItem.Text = "Danh sách chấm công";
            this.danhSáchChấmCôngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchChấmCôngToolStripMenuItem_Click);
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // báoCáoLươngToolStripMenuItem
            // 
            this.báoCáoLươngToolStripMenuItem.Name = "báoCáoLươngToolStripMenuItem";
            this.báoCáoLươngToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.báoCáoLươngToolStripMenuItem.Text = "Báo cáo lương";
            this.báoCáoLươngToolStripMenuItem.Click += new System.EventHandler(this.báoCáoLươngToolStripMenuItem_Click);
            // 
            // lblRight
            // 
            this.lblRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRight.AutoSize = true;
            this.lblRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRight.Location = new System.Drawing.Point(819, 655);
            this.lblRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(54, 18);
            this.lblRight.TabIndex = 143;
            this.lblRight.Text = "lblRight";
            // 
            // lblLeft
            // 
            this.lblLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLeft.AutoSize = true;
            this.lblLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeft.Location = new System.Drawing.Point(501, 655);
            this.lblLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(44, 18);
            this.lblLeft.TabIndex = 145;
            this.lblLeft.Tag = "001";
            this.lblLeft.Text = "lblLeft";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 687);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.TabHienThi);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý nhân sự";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ctxtmenuTabHienThi.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TabControl TabHienThi;
        internal System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.Label lblRight;
        internal System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcChứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcPhụCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khaiBáoThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốGiờLàmCủaThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phụCấpChoNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thưởngphạtChoNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngTínhLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoLươngToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxtmenuTabHienThi;
        private System.Windows.Forms.ToolStripMenuItem menuItemDongTrang;
        private System.Windows.Forms.ToolStripMenuItem menuItemDongTrangAll;
        private System.Windows.Forms.ToolStripMenuItem danhSáchChấmCôngToolStripMenuItem;
    }
}