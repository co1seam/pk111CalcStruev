using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StruevCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            var a = (Button)sender;
            if (a.Text ==",")
            {
                if (textBox1.Text.IndexOf(",") == -1)
                {
                    textBox1.Text += a.Text;
                }
            }
            else
            {
                textBox1.Text += a.Text;

            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            button6.Text = "X\u00B2";
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (x.Length == 2 && x[0] == '0' && x[1] != ',')
            {
                x = x.Substring(1, 1);
                textBox1.Text = x;
            }
            if(textBox1.Text.Length>24)
            {
                string txt = textBox1.Text;
                textBox1.Text = txt.Substring(0, 24);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            textBox1.Text = txt.Substring(0, textBox1.Text.Length-1);
            if (textBox1.Text.Length<1)
            {
                textBox1.Text = "0";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {//стереть все
            textBox1.Text = "0";
        }

        private void button27_Click(object sender, EventArgs e)
        {//расчет обратного числа
            float x = float.Parse(textBox1.Text);
            if (x!=0)
            {
                x = 1 / x;
                textBox1.Text = x.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            x = x * x;
            textBox1.Text = x.ToString();
        }
    }
}
