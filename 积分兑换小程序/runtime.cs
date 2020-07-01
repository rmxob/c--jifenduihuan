using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace 积分兑换小程序
{
    public partial class runtime : Form
    {
        public runtime()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
       
        }
        public string nowtime;
        public int nowhour;
        BLLpersoninfo personinfo = new BLLpersoninfo();
        private void runtime_Load(object sender, EventArgs e)
        {
            #region 规定窗体位置
            int w = System.Windows.Forms.SystemInformation.WorkingArea.Width;
            int h = System.Windows.Forms.SystemInformation.WorkingArea.Height;
            this.Location = new Point(w / 2 - 370, h / 2 - 240);
            #endregion
            nowtime = DateTime.Now.ToShortTimeString().ToString();
            label1.Text = "现在的时间是: " + nowtime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           nowhour=DateTime.Now.Hour;
        
            try
            {
              if( personinfo.writetime(nowhour))
               MessageBox.Show("开始计时", "写入时间成功");
              else
                {
                    MessageBox.Show("sql语句失败");
                }
            }
            catch
            {
                MessageBox.Show("写入时间失败");
            }
           
        }
        public int after_time;
        private void button2_Click(object sender, EventArgs e)
        {
            after_time = DateTime.Now.Hour;       
            if (after_time >= personinfo.readtime() + 2)
            {

                if (personinfo.addword(studyinfo.studyinfo1.word))
                {
                    MessageBox.Show("完成成功,获得积分:" + studyinfo.studyinfo1.word);
                }
                else
                {
                    MessageBox.Show("代码执行出错");
                }
            }
            else
            {
                MessageBox.Show("时间还不足哦");
            }
        }
    }
}
