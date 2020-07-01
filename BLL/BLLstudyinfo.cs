using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
  public  class BLLstudyinfo
    {
        DALstudyinfo studyinfo = new DALstudyinfo();
        public DataTable getstudyinfo()
        {
            return studyinfo.getstudyinfo();
        }
        public bool insertstudyinfo(string a,string b)
        {
            return studyinfo.insertstudyinfo(a, b);

        }
    }
}
