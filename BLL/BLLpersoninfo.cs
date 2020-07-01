using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLpersoninfo
    {
        DALpersoninfo dALpersoninfo = new DALpersoninfo();
        public int getabel1()
        {
            return dALpersoninfo.getinfolabel();
        }
        public bool loseword(int word)
        {
            return dALpersoninfo.loseword(word);
        }
        public bool addword(int word)
        {
            return dALpersoninfo.addword(word);
        }
        public bool writetime(int nowtime)
        {
            return dALpersoninfo.writetime(nowtime);
        }
        public int readtime()//读取计时时间用来判断时间
        {
            return dALpersoninfo.readtime();
        }
    }
}
