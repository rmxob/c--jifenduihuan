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
    public partial class maininfo : Form
    {
        public maininfo()
        {
            InitializeComponent();
        }
        BLLmianinfo BLLmianinfo = new BLLmianinfo();
        BLLpersoninfo BLLpersoninfo = new BLLpersoninfo();
        public int word;//获取剩余的积分值
        public int indexword;//获取索引（选择）的物品积分值
        private void maininfo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLmianinfo.bllgettable();
            label1.Text = "剩余积分 : " + BLLpersoninfo.getabel1();
            word = BLLpersoninfo.getabel1();
         int w = System.Windows.Forms.SystemInformation.WorkingArea.Width;
         int h = System.Windows.Forms.SystemInformation.WorkingArea.Height;
         this.Location = new Point(w / 2 - 370, h / 2 - 240);
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            indexword = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["所需积分"].Value);//获取索引积分值
            if(word>=indexword)
            {
                if(BLLpersoninfo.loseword(indexword))
                {
                  MessageBox.Show("兑换成功,积分减少 : "+indexword);
                  label1.Text = "剩余积分 : " + BLLpersoninfo.getabel1();
                }
               
                else
                {
                    MessageBox.Show("减少失败");
                }
            }
            else
            {
                MessageBox.Show("积分不足");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addinfo addinfo1 = new addinfo();
            addinfo1.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string delete_index;
        private void button3_Click(object sender, EventArgs e)
        {
            delete_index = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["奖品"].Value);

            if(BLLmianinfo.decrease(delete_index))
            {
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = BLLmianinfo.bllgettable();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studyinfo studyinfo = new studyinfo();
            studyinfo.Show();
            Hide();
          
        }

        private void maininfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void maininfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
