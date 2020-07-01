using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
  public class DALstudyinfo
    {
        SqlConnection sql = new SqlConnection("server=.;database=aoteman1;uid=sa;pwd=123456");
       public DataTable getstudyinfo()
        {
            DataTable a = new DataTable();
            string adapter = "select *from 学习表";
            SqlDataAdapter sqlData = new SqlDataAdapter(adapter, sql);
            sqlData.Fill(a);
            return a;
        }
        /// <summary>
        /// 插入学习表中，任务名与奖励积分
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>true/false</returns>
        public bool insertstudyinfo(string a,string b)
        {
            sql.Open();
            int c = Convert.ToInt32(b);
            string command = "insert into 学习表 values " + "('" + a + "'," + "'" + c + "')";
            SqlCommand command1 = new SqlCommand(command, sql);
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

    }
}
