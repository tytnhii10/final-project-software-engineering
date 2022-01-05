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
    public partial class NhanVien : Form
    {
        DataTable table;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtManv.Text = "";
            txtTennv.Text = "";
            txtManv.Focus();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM staffs";
            table = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            datanhanvien.DataSource = table; //Nguồn dữ liệu            
            datanhanvien.Columns[0].HeaderText = "idStaffs";
            datanhanvien.Columns[1].HeaderText = "nameStaffs";
        }

        private void datanhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManv.Text = datanhanvien.CurrentRow.Cells["idStaffs"].Value.ToString();
            txtTennv.Text = datanhanvien.CurrentRow.Cells["nameStaffs"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO staffs VALUES(N'" +
                txtManv.Text + "',N'" + txtTennv.Text + "')";
            Class.Function.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            txtManv.Text = "";
            txtTennv.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String sql = "DELETE staffs WHERE idstaffs=N'" + txtManv.Text + "'";
            Class.Function.RunSqlDel(sql);
            LoadDataGridView();
            txtManv.Text = "";
            txtTennv.Text = "";
        }
    }
}
