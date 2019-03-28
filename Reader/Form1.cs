using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void read(string filename)
        {
            try
            {
                // 创建一个 StreamReader 的实例来读取文件 
                // using 语句也能关闭 StreamReader
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    string line1;

                    // 从文件读取并显示行，直到文件的末尾 
                    /*  while ((line = sr.ReadToEnd()) != null)
                      {
                          //Console.WriteLine(line);

                          //line1 +=  line;

                          textBox1.Text = line;
                      }*/
                    line = sr.ReadToEnd();

                    label1.Text = line;



                }
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            //Console.ReadKey();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                read(file);
            }

            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);

            label2.Text = label1.Text.Substring(0, 1);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void minusVitess_Click(object sender, EventArgs e)
        {
            timer1.Interval += 500;
        }

        private void addVitess_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 100)
            {


                timer1.Interval -= 100;
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
