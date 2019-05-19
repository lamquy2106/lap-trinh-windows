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
    public partial class fmain : Form
    {
        




        public void unlockcontrol()
        {
            txtdiemrl.ReadOnly = false;
            txtgioitinh.Enabled = true;
            txthoatdong.ReadOnly = false;
            txtmasv.ReadOnly = false;
            txtngaysinh.ReadOnly = false;
            txttensv.ReadOnly = false;
            txtlop.Enabled = true;

            btthem.Enabled = false;
            bthuy.Enabled = true;
            btluu.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void lockcontrol()
        {
            txtdiemrl.ReadOnly = true;
            txthoatdong.ReadOnly = true;
            txtmasv.ReadOnly = true;
            txtngaysinh.ReadOnly = true;
            txttensv.ReadOnly = true;

            txtgioitinh.Enabled = false;
            txtlop.Enabled =false;
            btthem.Enabled = true;
            bthuy.Enabled = false;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
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

        public fmain()
        {
            InitializeComponent();
        }

        private void fmain_Load(object sender, EventArgs e)
        {


            dtgsinhvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtlop.SelectedIndex = 0;
            txtgioitinh.SelectedIndex = 0;
            lockcontrol();
            

            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            unlockcontrol();

            txtmasv.Focus();
            
            txtdiemrl.Text = "";
            txthoatdong.Text = "";
            txtmasv.Text = "";
            txtngaysinh.Text = "";
            txttensv.Text = "";
            

            
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn hủy", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq==DialogResult.Yes)
            {
                txtdiemrl.Text = "";
                txthoatdong.Text = "";
                txtmasv.Text = "";
                txtngaysinh.Text = "";
                txttensv.Text = "";
            }

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void dtgsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgsinhvien.CurrentRow.Index;
            txtmasv.Text = dtgsinhvien.Rows[i].Cells[0].Value.ToString();
            txttensv.Text = dtgsinhvien.Rows[i].Cells[1].Value.ToString();
            txtlop.Text = dtgsinhvien.Rows[i].Cells[2].Value.ToString();
            txtngaysinh.Text = dtgsinhvien.Rows[i].Cells[3].Value.ToString();
            txtgioitinh.Text = dtgsinhvien.Rows[i].Cells[4].Value.ToString();
            txtdiemrl.Text = dtgsinhvien.Rows[i].Cells[5].Value.ToString();
            txthoatdong.Text = dtgsinhvien.Rows[i].Cells[6].Value.ToString();
            
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmasv.Text == "" || txttensv.Text== "" || txtngaysinh.Text == "" || txtgioitinh.Text == "" || txtdiemrl.Text == "" || txthoatdong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ dữ liệu vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    commmand = connection.CreateCommand();
                    commmand.CommandText = "insert into Sinhvien values('" + txtmasv.Text + "',N'" + txttensv.Text + "',N'" + txtlop.Text + "','" + txtngaysinh.Text + "',N'" + txtgioitinh.Text + "','" + txtdiemrl.Text + "',N'" + txthoatdong.Text + "')";
                    commmand.ExecuteNonQuery();

                    commmand.CommandText = "insert into Dangnhap values('" + txtmasv.Text + "','" + txtmasv.Text + "','user')";
                    commmand.ExecuteNonQuery();
                    loaddata();





                    txtdiemrl.Text = "";
                    txtgioitinh.Text = "";
                    txthoatdong.Text = "";
                    txtmasv.Text = "";
                    txtngaysinh.Text = "";
                    txttensv.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Mã sinh viên đã tồn tại");
            }

            
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq == DialogResult.Yes)
            {
                commmand = connection.CreateCommand();
                commmand.CommandText = "delete from Sinhvien where MaSV = '" + txtmasv.Text + "'";
                commmand.ExecuteNonQuery();

                commmand.CommandText = "delete from Dangnhap where Taikhoan  = '" + txtmasv.Text + "'";
                commmand.ExecuteNonQuery();
                loaddata();
            }
            
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            

            txtdiemrl.ReadOnly = false;
            txtgioitinh.Enabled = false;
            txthoatdong.ReadOnly = false;
            txtmasv.ReadOnly = true;
            txtngaysinh.ReadOnly = false;
            txttensv.ReadOnly = false;

            commmand = connection.CreateCommand();
            commmand.CommandText = "update Sinhvien set TenSV = N'" + txttensv.Text + "',Lop='"+txtlop.Text+"',Ngaysinh='" + txtngaysinh.Text + "',Gioitinh=N'" + txtgioitinh.Text + "',Diemrl='" + txtdiemrl.Text + "',Hoatdong = N'" + txthoatdong.Text + "' where MaSV = '"+txtmasv.Text+"'";
            commmand.ExecuteNonQuery();
            loaddata();

            txtdiemrl.Text = "";
            txtgioitinh.Text = "";
            txthoatdong.Text = "";
            txtmasv.Text = "";
            txtngaysinh.Text = "";
            txttensv.Text = "";
        }

        private void txtngaysinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            commmand = connection.CreateCommand();
            commmand.CommandText = "select * from Sinhvien Where TenSV like N'%"+txttim.Text+"%' OR MaSV like N'%"+txttim.Text+"%'";
            adapter.SelectCommand = commmand;
            table.Clear();
            adapter.Fill(table);
            dtgsinhvien.DataSource = table;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
