using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace lap_trinh_window
{
    public partial class fsinhvien : Form
    {
        public fsinhvien()
        {
            InitializeComponent();
            
            dtgsinhvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtlop.SelectedIndex = 0;
            
            
        }
        SqlConnection connection;
        SqlCommand commmand;
        string str = @"Data Source=DESKTOP-SS34RAM\SQLEXPRESS3;Initial Catalog=QLDRLSV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            
            commmand = connection.CreateCommand();
            commmand.CommandText = "select * from Sinhvien";
            adapter.SelectCommand = commmand;
            table.Clear();
            adapter.Fill(table);
            dtgsinhvien.DataSource = table;
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            commmand = connection.CreateCommand();
            commmand.CommandText = "select * from Sinhvien Where TenSV like N'%" + txttim.Text + "%' OR MaSV like N'%" + txttim.Text + "%'";
            adapter.SelectCommand = commmand;
            table.Clear();
            adapter.Fill(table);
            dtgsinhvien.DataSource = table;
        }

        private void txtlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtlop.Text == "Tất cả")
            {
                connection = new SqlConnection(str);
                connection.Open();
                commmand = connection.CreateCommand();
                commmand.CommandText = "select * from Sinhvien";
                adapter.SelectCommand = commmand;
                table.Clear();
                adapter.Fill(table);
                dtgsinhvien.DataSource = table;
            }
            else
            {

                commmand = connection.CreateCommand();

                commmand.CommandText = "select * from Sinhvien Where Lop like N'%" + txtlop.Text + "%'";
                adapter.SelectCommand = commmand;
                table.Clear();
                adapter.Fill(table);
                dtgsinhvien.DataSource = table;
            }
        }

        private void fsinhvien_Load(object sender, EventArgs e)
        {
            txttim.Focus();
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
