using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "字数：" + textBox1.Text.Length.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "字数：" + textBox1.Text.Length.ToString();
        }
    }
}
