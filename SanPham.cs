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
    public partial class SanPham : Form
    {
        DataTable table;
        public SanPham()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMasp.Text = "";
            txtTensp.Text = "";
            txtMasp.Focus();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM product";
            table = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            datasanpham.DataSource = table; //Nguồn dữ liệu            
            datasanpham.Columns[0].HeaderText = "idProduct";
            datasanpham.Columns[1].HeaderText = "nameProduct";
        }

        private void datasanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasp.Text = datasanpham.CurrentRow.Cells["idProduct"].Value.ToString();
            txtTensp.Text = datasanpham.CurrentRow.Cells["nameProduct"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO product VALUES(N'" +
                txtMasp.Text + "',N'" + txtTensp.Text + "')";
            Class.Function.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            txtMasp.Text = "";
            txtTensp.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String sql = "DELETE product WHERE idproduct=N'" + txtMasp.Text + "'";
            Class.Function.RunSqlDel(sql);
            LoadDataGridView();
            txtMasp.Text = "";
            txtTensp.Text = "";
        }

    }
}
