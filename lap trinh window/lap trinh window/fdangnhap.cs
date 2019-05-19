using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap_trinh_window
{
    public partial class fdangnhap : Form
    {
        public string taikhoan;
        public string matkhau;
        public static string quyenhan = string.Empty;
        public fdangnhap()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SS34RAM\SQLEXPRESS3;Initial Catalog=QLDRLSV;Integrated Security=True");

        private void fdangnhap_Load(object sender, EventArgs e)
        {

        }
        rs m = new rs();
        private void btdangnhap_Click(object sender, EventArgs e)
        {
            
            String query = "SELECT * FROM Dangnhap WHERE Taikhoan = '" + txttaikhoan.Text + "' AND Matkhau = '" + txtmatkhau.Text + "' ";
            taikhoan = txttaikhoan.Text;
            matkhau = txtmatkhau.Text;
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                
                quyenhan=m.rturn("select Quyenhan from Dangnhap where Taikhoan='" + taikhoan + "'");
                
                if(quyenhan =="admin")
                {
                fmain f = new fmain();
                this.Hide();
                MessageBox.Show("Đăng nhập thành công");
                f.ShowDialog();
                    this.Show();
                    
                }
                else
                {
                    fsinhvien m = new fsinhvien();
                    this.Hide();
                    m.ShowDialog();
                    this.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính sát");

            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
