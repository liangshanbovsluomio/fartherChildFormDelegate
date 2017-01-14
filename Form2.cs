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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public delegate void Words(string a);
        public Words words;
        
        private void button1_Click(object sender, EventArgs e)
        {
            words(textChild.Text);
            this.Close();
        }

        private void textChild_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
