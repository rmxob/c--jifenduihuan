using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    class sqlcnn
    {
        public SqlConnection sql = new SqlConnection("server=.;database=aoteman1;uid=sa;pwd=123456");
   
    }
}
