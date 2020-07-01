using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
  public class DALpersoninfo
    {
        public SqlConnection sql = new SqlConnection("server=.;database=aoteman1;uid=sa;pwd=123456");
        public int lable1;
        public int getinfolabel()
        {
            sql.Open();
            string sqlcnn = "select 拥有积分 from 个人信息表 where 姓名=" + "'欧小布'";
            SqlCommand command = new SqlCommand(sqlcnn, sql);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                lable1 = reader.GetInt32(reader.GetOrdinal("拥有积分"));
            }
            reader.Close();
            sql.Close();
            return lable1;
        }
        public bool loseword(int word)
        {
            sql.Open();
            string loseword_string = "update 个人信息表 set 拥有积分-="+word;
            SqlCommand loseword_command = new SqlCommand(loseword_string, sql);
            try
            {
                loseword_command.ExecuteNonQuery();
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
        /// <summary>
        /// 完成任务增加积分
        /// </summary>
        /// <param name="word">读取的任务积分</param>
        /// <returns></returns>
        public bool addword(int word)
        {
            sql.Open();
            string addword_string = "update 个人信息表 set 拥有积分+=" + word;
            SqlCommand addword_command = new SqlCommand(addword_string, sql);
            try
            {
                addword_command.ExecuteNonQuery();
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
        /// <summary>
        /// 把获取得当时时间写入数据库
        /// </summary>
        /// <param name="nowtime">当时时间</param>
        /// <returns></returns>
        public bool writetime(int nowtime)
        {
            string write_string = "update 个人信息表 set 计时时间="+nowtime;
            sql.Open();
            SqlCommand write_command = new SqlCommand(write_string,sql);
            try
            {
                write_command.ExecuteNonQuery();
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
        public int gettime;
        /// <summary>
        /// 获取写入的计时时间
        /// </summary>
        /// <returns></returns>
        public int readtime()
        {
            sql.Open();
            string readtime_string = "select 计时时间 from 个人信息表 where 姓名='欧小布'";
            SqlCommand readtime_command = new SqlCommand(readtime_string,sql);
            SqlDataReader readtime_reader = readtime_command.ExecuteReader();
            while(readtime_reader.Read())
            {
                gettime = readtime_reader.GetInt32(readtime_reader.GetOrdinal("计时时间"));
            }
            readtime_reader.Close();
            sql.Close();
            return gettime;

        }
        }
}
