
namespace cuoi_ki
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nhapkho = new System.Windows.Forms.ToolStripMenuItem();
            this.Xuat_kho = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.daily = new System.Windows.Forms.ToolStripMenuItem();
            this.Thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.Doanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.thoát = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SanPham,
            this.quảnLýKhoToolStripMenuItem,
            this.NhanVien,
            this.daily,
            this.Thongke,
            this.thoát});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SanPham
            // 
            this.SanPham.Name = "SanPham";
            this.SanPham.Size = new System.Drawing.Size(89, 26);
            this.SanPham.Text = "Sản phẩm";
            this.SanPham.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            this.quảnLýKhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nhapkho,
            this.Xuat_kho});
            this.quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            this.quảnLýKhoToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            // 
            // Nhapkho
            // 
            this.Nhapkho.Name = "Nhapkho";
            this.Nhapkho.Size = new System.Drawing.Size(156, 26);
            this.Nhapkho.Text = "Nhập kho";
            this.Nhapkho.Click += new System.EventHandler(this.nhậpKhoToolStripMenuItem_Click);
            // 
            // Xuat_kho
            // 
            this.Xuat_kho.Name = "Xuat_kho";
            this.Xuat_kho.Size = new System.Drawing.Size(156, 26);
            this.Xuat_kho.Text = "Xuất kho";
            this.Xuat_kho.Click += new System.EventHandler(this.xuấtKhoToolStripMenuItem_Click);
            // 
            // NhanVien
            // 
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Size = new System.Drawing.Size(89, 26);
            this.NhanVien.Text = "Nhân viên";
            this.NhanVien.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // daily
            // 
            this.daily.Name = "daily";
            this.daily.Size = new System.Drawing.Size(61, 26);
            this.daily.Text = "Đại lý";
            this.daily.Click += new System.EventHandler(this.đạiLýToolStripMenuItem_Click);
            // 
            // Thongke
            // 
            this.Thongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Doanhthu});
            this.Thongke.Name = "Thongke";
            this.Thongke.Size = new System.Drawing.Size(84, 26);
            this.Thongke.Text = "Thống kê";
            // 
            // Doanhthu
            // 
            this.Doanhthu.Name = "Doanhthu";
            this.Doanhthu.Size = new System.Drawing.Size(161, 26);
            this.Doanhthu.Text = "Doanh thu";
            this.Doanhthu.Click += new System.EventHandler(this.Doanhthu_Click);
            // 
            // thoát
            // 
            this.thoát.Name = "thoát";
            this.thoát.Size = new System.Drawing.Size(61, 26);
            this.thoát.Text = "Thoát";
            this.thoát.Click += new System.EventHandler(this.thoát_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 28);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(839, 606);
            this.pnlContent.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 634);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Kho hàng Pet shop ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SanPham;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Nhapkho;
        private System.Windows.Forms.ToolStripMenuItem Xuat_kho;
        private System.Windows.Forms.ToolStripMenuItem NhanVien;
        private System.Windows.Forms.ToolStripMenuItem daily;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem thoát;
        private System.Windows.Forms.ToolStripMenuItem Thongke;
        private System.Windows.Forms.ToolStripMenuItem Doanhthu;
    }
}

