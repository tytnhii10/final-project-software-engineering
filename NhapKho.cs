using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using cuoi_ki.Class;
using System.Windows.Forms;
namespace cuoi_ki
{
    public partial class NhapKho : Form
    {
        DataTable table;
        public NhapKho()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbManv.Text = "";
            cbManhap.Text = "";
            txtsl.Text = "";
            txtGia.Text = "";
            dateNhap.Text = DateTime.Now.ToShortDateString();
            txtMannhap.Enabled = true;
            cbManv.Enabled = true;
            cbManv.Enabled = true;
            dateNhap.Enabled = true;
            cbmasp.Enabled = true;
            txtsl.Enabled = true;
            txtGia.Enabled = true;
            txtMannhap.Focus();
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            Function.FillCombo("SELECT * FROM staffs", cbManv, "idStaffs", "idStaffs");
            cbManv.SelectedIndex = -1;
            Function.FillCombo("SELECT * FROM product", cbmasp, "idProduct", "idProduct");
            cbmasp.SelectedIndex = -1;
            Function.FillCombo("SELECT * FROM import", cbManhap, "idimport", "idimport");
            cbManhap.SelectedIndex = -1;
            dateNhap.Text = DateTime.Today.ToString("dd/mm/yyyy");

            txtMannhap.Enabled = false;
            cbManv.Enabled = false;
            cbManv.Enabled = false;
            dateNhap.Enabled = false;
            cbmasp.Enabled = false;
            txtsl.Enabled = false;
            txtGia.Enabled = false;
        }

        private void LoadDataGridView()
        {
            string sql = "SELECT * FROM detailimport";
            table = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            chitietnhap.DataSource = table; //Nguồn dữ liệu        
            chitietnhap.Columns[0].HeaderText = "idImport";
            chitietnhap.Columns[1].HeaderText = "idProduct";
            chitietnhap.Columns[2].HeaderText = "number";
            chitietnhap.Columns[3].HeaderText = "price";
        }

        private void chitietnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbManhap.Text = chitietnhap.CurrentRow.Cells["idImport"].Value.ToString();
            cbmasp.Text = chitietnhap.CurrentRow.Cells["idProduct"].Value.ToString();
            txtsl.Text = chitietnhap.CurrentRow.Cells["number"].Value.ToString();
            txtGia.Text = chitietnhap.CurrentRow.Cells["price"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbManhap.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbManhap.Focus();
                return;
            }

            if (cbmasp.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmasp.Focus();
                return;
            }

            if (txtsl.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập số lượng xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsl.Focus();
                return;
            }

            if (txtGia.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return;
            }


            String sql = "INSERT INTO detailimport(idImport, idProduct, number, price) VALUES (N'" +
                    cbManhap.SelectedValue + "',N'" + cbmasp.SelectedValue + "','" + txtsl.Text.Trim() + "','" + txtGia.Text.Trim() + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String sql;
            if (txtMannhap.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMannhap.Focus();
                return;
            }

            if (cbManv.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbManv.Focus();
                return;
            }

            if (dateNhap.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNhap.Focus();
                return;
            }

            sql = "INSERT INTO import(idImport, idStaffs, dateImport) VALUES (N'" + txtMannhap.Text.Trim() + "',N'" +
                          cbManv.SelectedValue + "','" + Function.ConvertDateTime(dateNhap.Text.Trim()) + "')";
            Function.RunSQL(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String sql = "DELETE detailimport WHERE idImport=N'" + txtMannhap.Text + "'";
            Class.Function.RunSqlDel(sql);
            LoadDataGridView();
            cbManv.Text = "";
            cbManhap.Text = "";
            txtsl.Text = "";
            txtGia.Text = "";
            dateNhap.Text = DateTime.Now.ToShortDateString();
        }
    }
}
