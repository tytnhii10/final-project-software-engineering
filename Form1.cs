using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms;

namespace cuoi_ki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddForm(Form s)
        {
            this.pnlContent.Controls.Clear();
            s.TopLevel = false;
            s.AutoScroll = true;
            s.FormBorderStyle = FormBorderStyle.None;
            s.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(s);
            s.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham s = new SanPham();
            AddForm(s);
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xuatkho x = new Xuatkho();
            AddForm(x);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            AddForm(nv);
        }

        private void đạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daily dl = new daily();
            AddForm(dl);
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapKho nhap = new NhapKho();
            AddForm(nhap);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
        }
        private void thoát_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect();
            Application.Exit();
        }

    }
}
