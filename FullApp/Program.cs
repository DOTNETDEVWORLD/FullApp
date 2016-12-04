

using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tt = ConfigurationManager.ConnectionStrings;
            var cs = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cs;
            conn.Open();
        }
    }
}
