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
    public partial class Xuat_kho : Form
    {
        DataTable table;
        public Xuat_kho()
        {
            InitializeComponent();
        }

        public static string isbuton = "";

        private void Xuat_kho_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            Function.FillCombo("SELECT * FROM staffs", cbManv, "idStaffs", "idStaffs");
            cbManv.SelectedIndex = -1;
            Function.FillCombo("SELECT * FROM product", cbmasp, "idProduct", "idProduct");
            cbmasp.SelectedIndex = -1;
            Function.FillCombo("SELECT * FROM export", cbMaxuat, "idExport", "idExport");
            cbMaxuat.SelectedIndex = -1;
            Function.FillCombo("SELECT * FROM agents", cbDaily, "idAgents", "idAgents");
            cbDaily.SelectedIndex = -1;

            dateXuat.Text = DateTime.Today.ToString("dd/mm/yyyy");
            txtManxuat.Enabled = false;
            txtmactx.Enabled = false;
            cbManv.Enabled = false;
            cbDaily.Enabled = false;
            cbMaxuat.Enabled = false;
            cbmasp.Enabled = false;
            txtsl.Enabled = false;
            txtGia.Enabled = false;
        }

        private void LoadDataGridView()
        {
            string sql = "SELECT * FROM detailexport";
            table = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            chitietxuat.DataSource = table; //Nguồn dữ liệu            
            chitietxuat.Columns[0].HeaderText = "idDetailexport";
            chitietxuat.Columns[1].HeaderText = "idExport";
            chitietxuat.Columns[2].HeaderText = "idProduct";
            chitietxuat.Columns[3].HeaderText = "numberofExport";
            chitietxuat.Columns[4].HeaderText = "price";
        }

        private void chitietxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmactx.Text = chitietxuat.CurrentRow.Cells["idDetailexport"].Value.ToString();
            cbMaxuat.Text = chitietxuat.CurrentRow.Cells["idExport"].Value.ToString();
            cbmasp.Text = chitietxuat.CurrentRow.Cells["idProduct"].Value.ToString();
            txtsl.Text = chitietxuat.CurrentRow.Cells["numberofExport"].Value.ToString();
            txtGia.Text = chitietxuat.CurrentRow.Cells["price"].Value.ToString();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtmactx.Text = "";
            cbManv.Text = "";
            cbMaxuat.Text = "";
            txtsl.Text = "";
            txtGia.Text = "";
            txtManxuat.Enabled = true;
            txtmactx.Enabled = true;
            cbManv.Enabled = true;
            cbDaily.Enabled = true;
            cbMaxuat.Enabled = true;
            cbmasp.Enabled = true;
            txtsl.Enabled = true;
            txtGia.Enabled = true;
            dateXuat.Text = DateTime.Now.ToShortDateString();
            txtManxuat.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtManxuat.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManxuat.Focus();
                return;
            }

            if (cbManv.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbManv.Focus();
                return;
            }

            if (dateXuat.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập ngày xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateXuat.Focus();
                return;
            }

            if (cbDaily.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã đại lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbDaily.Focus();
                return;
            }
            String sql;
            sql = "INSERT INTO export(idExport, dateExport, idStaffs, idAgents) VALUES (N'" + txtManxuat.Text.Trim() + "',N'" +
                          Function.ConvertDateTime(dateXuat.Text.Trim()) + "','" + cbManv.SelectedValue + "','" + cbDaily.Text + "')";
            Function.RunSQL(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql;

            if (txtmactx.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã chi tiết xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmactx.Focus();
                return;
            }

            if (cbMaxuat.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaxuat.Focus();
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

            /*sl = Convert.ToDouble(Function.GetFieldValues(
                "SELECT number FROM detailimport WHERE idProduct = N'" + cbmasp.SelectedValue + "'"));
            if (Convert.ToDouble(txtsl.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsl.Text = "";
                txtsl.Focus();
                return;
            }*/

            /*double tong;
            tong = Convert.ToDouble(Function.GetFieldValues(
                "SELECT SUM(price) FROM detailexport"));
            txtTong.Text = tong.ToString();*/

            sql = "INSERT INTO detailexport(idDetailexport, idExport, idProduct, numberofExport, price) VALUES (N'" + txtmactx.Text.Trim() + "',N'" +
                    cbMaxuat.SelectedValue + "',N'" + cbmasp.SelectedValue + "','" + txtsl.Text.Trim() + "','" + txtGia.Text.Trim() + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String sql = "DELETE detailexport WHERE iddetailexport=N'" + txtmactx.Text + "'";
            Class.Function.RunSqlDel(sql);
            LoadDataGridView();
            txtmactx.Text = "";
            cbManv.Text = "";
            cbMaxuat.Text = "";
            txtsl.Text = "";
            txtGia.Text = "";
            dateXuat.Text = DateTime.Now.ToShortDateString();
        }
    }
}
