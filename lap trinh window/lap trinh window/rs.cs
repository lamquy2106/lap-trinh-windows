using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace lap_trinh_window
{
    public class rs
    {
        public string rturn(string s)
        {
            string a;
            string str = @"Data Source=DESKTOP-SS34RAM\SQLEXPRESS3;Initial Catalog=QLDRLSV;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(str);
            
            SqlCommand cmd;
            try
            {
                sqlcon.Open();
                cmd = new SqlCommand (s, sqlcon);
                a = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                a = " ";
            }
            return a;
        }
    }
}
