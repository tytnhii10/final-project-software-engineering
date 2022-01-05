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
    public partial class Nhapkho : Form
    {
        DataTable table;
        public Nhapkho()
        {
            InitializeComponent();
        }

        private void Nhapkho_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            Function.FillCombo("SELECT * FROM staffs", cbManv, "idStaffs", "idStaffs");
            cbManv.SelectedIndex = -1;
            Function.FillCombo("SELECT * FROM product", cbmasp, "idProduct", "idProduct");
            cbmasp.SelectedIndex = -1;
            Function.FillCombo("SELECT * FROM import", cbManhap, "idimport", "idimport");
            cbManhap.SelectedIndex = -1;
            dateNhap.Text = DateTime.Today.ToString("dd/mm/yyyy");
        }

        private void LoadDataGridView()
        {
            string sql = "SELECT * FROM detailimport";
            table = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            chitietnhap.DataSource = table; //Nguồn dữ liệu            
            chitietnhap.Columns[0].HeaderText = "iddetailimport";
            chitietnhap.Columns[1].HeaderText = "idImport";
            chitietnhap.Columns[2].HeaderText = "idProduct";
            chitietnhap.Columns[3].HeaderText = "number";
            chitietnhap.Columns[4].HeaderText = "price";
        }

        private void chitietnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmactn.Text = chitietnhap.CurrentRow.Cells["iddetailimport"].Value.ToString();
            cbManhap.Text = chitietnhap.CurrentRow.Cells["idImport"].Value.ToString();
            cbmasp.Text = chitietnhap.CurrentRow.Cells["idProduct"].Value.ToString();
            txtsl.Text = chitietnhap.CurrentRow.Cells["number"].Value.ToString();
            txtGia.Text = chitietnhap.CurrentRow.Cells["price"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtmactn.Text = "";
            cbManv.Text = "";
            cbManhap.Text = "";
            txtsl.Text = "";
            txtGia.Text = "";
            dateNhap.Text = DateTime.Now.ToShortDateString();
            txtMannhap.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO detailimport(iddetailimport, idImport, idProduct, number, price) VALUES (N'" + txtmactn.Text.Trim() + "',N'" +
                    cbManhap.SelectedValue + "',N'" + cbmasp.SelectedValue + "','" + txtsl.Text.Trim() + "','" + txtGia.Text.Trim() + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String sql;
            sql = "INSERT INTO import(idImport, idStaffs, dateImport) VALUES (N'" + txtMannhap.Text.Trim() + "',N'" +
                          cbManv.SelectedValue + "','" + Function.ConvertDateTime(dateNhap.Text.Trim()) + "')";
            Function.RunSQL(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String sql = "DELETE detailimport WHERE iddetailimport=N'" + txtmactn.Text + "'";
            Class.Function.RunSqlDel(sql);
            LoadDataGridView();
            txtmactn.Text = "";
            cbManv.Text = "";
            cbManhap.Text = "";
            txtsl.Text = "";
            txtGia.Text = "";
            dateNhap.Text = DateTime.Now.ToShortDateString();
        }
    }
}
