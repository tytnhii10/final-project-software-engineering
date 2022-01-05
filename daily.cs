using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuoi_ki
{
    public partial class daily : Form
    {
        DataTable table;
        public daily()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMadl.Text = "";
            txtTendl.Text = "";
            sdt.Text = "";
            diachi.Text = "";
            txtMadl.Focus();
        }

        private void daily_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM agents";
            table = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            datadaily.DataSource = table; //Nguồn dữ liệu            
            datadaily.Columns[0].HeaderText = "idAgents";
            datadaily.Columns[1].HeaderText = "nameAgents";
            datadaily.Columns[2].HeaderText = "address";
            datadaily.Columns[3].HeaderText = "phone";
        }

        private void datadaily_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMadl.Text = datadaily.CurrentRow.Cells["idAgents"].Value.ToString();
            txtTendl.Text = datadaily.CurrentRow.Cells["nameAgents"].Value.ToString();
            sdt.Text = datadaily.CurrentRow.Cells["phone"].Value.ToString();
            diachi.Text = datadaily.CurrentRow.Cells["address"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO agents VALUES(N'" +
                txtMadl.Text + "',N'" + txtTendl.Text + "',N'" + diachi.Text + "',N'" + sdt.Text + "')";
            Class.Function.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            txtMadl.Text = "";
            txtTendl.Text = "";
            sdt.Text = "";
            diachi.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String sql = "DELETE agents WHERE idAgents=N'" + txtMadl.Text + "'";
            Class.Function.RunSqlDel(sql);
            LoadDataGridView();
            txtMadl.Text = "";
            txtTendl.Text = "";
            sdt.Text = "";
            diachi.Text = "";
        }
    }
}
