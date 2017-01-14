using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 利用委托将子窗体关闭时文本传入父窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.words = new Form2.Words(GetWords);
            //或者简写成 child.words = GetWords;
            child.Show();

        }
        public void GetWords(string str)
        {
            textMain.Text = str;
        }
    }
}
