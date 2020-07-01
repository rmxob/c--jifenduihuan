using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BLL
{
    public class BLLmianinfo
    {
        DALmianinfo Maininfo = new DALmianinfo();
        public DataTable bllgettable()
        {
            return Maininfo.gettable();
        }
       public bool updatainfo(string a,string b)
        {
            return Maininfo.addinfo(a, b);
        }
        public bool decrease(string index)
        {
            return Maininfo.decrease(index);
        }

    }
}
