using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DALmianinfo
    {
       public  SqlConnection sql = new SqlConnection("server=.;database=aoteman1;uid=sa;pwd=123456");
        DataTable maintable = new DataTable();
        public DataTable gettable()
        {         
            string getmaintable = "select *from 积分表";
            SqlDataAdapter adapter = new SqlDataAdapter(getmaintable,sql);
            adapter.Fill(maintable);          
            return maintable;
        }
        public bool addinfo(string a,string b)
        {
            sql.Open();
            int c = Convert.ToInt32(b);
            string command = "insert into 积分表 values "+"('"+a+"',"+"'"+c+"')";
            SqlCommand command1 = new SqlCommand(command,sql);
            try
            {
                command1.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                sql.Close();
            }
        }
        public bool decrease(string index)
        {
            sql.Open();
            string decrease_string = "delete from 积分表 where 奖品 ="+"'"+index+"'";
            SqlCommand decrease_command = new SqlCommand(decrease_string, sql);
            try
            {
                decrease_command.ExecuteNonQuery();
                return true;
            }
            catch

            {
                return false;
            }
            finally
            {
                sql.Close();
            }
        }
        
    }
}
