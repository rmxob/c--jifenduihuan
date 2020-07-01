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
    public partial class studyinfo : Form
    {
        public static studyinfo studyinfo1 ;
        public studyinfo()
        {
            InitializeComponent();   
            studyinfo1 = this;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public BLLstudyinfo bllstudyinfo = new BLLstudyinfo();
        private void studyinfo_Load(object sender, EventArgs e)
        {
            int w = System.Windows.Forms.SystemInformation.WorkingArea.Width;
            int h = System.Windows.Forms.SystemInformation.WorkingArea.Height;
            this.Location = new Point(w / 2 - 370, h / 2 - 240);
            dataGridView1.DataSource = bllstudyinfo.getstudyinfo();
            BLLpersoninfo BLLpersoninfo = new BLLpersoninfo();
            label1.Text = "剩余积分 : " + BLLpersoninfo.getabel1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maininfo maininfo = new maininfo();
            this.Hide();
            maininfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        BLLpersoninfo BLLpersoninfo = new BLLpersoninfo();
        public int word;//完成任务奖励积分
        private void button3_Click(object sender, EventArgs e)
        {
           word=Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["奖励积分"].Value);
            runtime runtime = new runtime();
            runtime.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            if(a!=""&&b!="")
            {
              if(bllstudyinfo.insertstudyinfo(a, b))
                {
                    MessageBox.Show("添加成功");
                    dataGridView1.DataSource = bllstudyinfo.getstudyinfo();
                }
            }
            else
            {
                MessageBox.Show("输入不规范");
            }
           
        }
    }
}
