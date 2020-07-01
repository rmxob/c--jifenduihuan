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
    public partial class addinfo : Form
    {
        public addinfo()
        {
            InitializeComponent();
        }
        BLLmianinfo BLLmianinfo = new BLLmianinfo();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string award_name = textBox1.Text;
            string award = textBox2.Text;
            
           if( BLLmianinfo.updatainfo(award_name, award))
            {
                MessageBox.Show("添加成功");
            }
           else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maininfo a = new maininfo();
            a.Show();
            this.Close();
        }

        private void addinfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            maininfo a = new maininfo();
            a.Show();
        }

        private void addinfo_Load(object sender, EventArgs e)
        {
            int w = System.Windows.Forms.SystemInformation.WorkingArea.Width;
            int h = System.Windows.Forms.SystemInformation.WorkingArea.Height;
            this.Location = new Point(w / 2 - 370, h / 2 - 240);
        }
    }
}
