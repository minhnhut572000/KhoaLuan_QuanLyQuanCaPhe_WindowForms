using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCaPhe.DAO
{
    public class ConnectDB
    {
        public static SqlConnection cnn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=dbQuanLyQuanCafeN10;Integrated Security=True");
    }
}
