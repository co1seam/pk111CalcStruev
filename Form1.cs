﻿using System;
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
        public double fnum;
        public double snum;
        public string deystvie = "";
        public bool clear = false;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void Deystvie(int _counter, Button button, double _fnum, double _snum)
        {
            if (counter == 1)
            {
                //fnum = double.Parse(textBox1.Text);
                string deystvie = button.Text;
                textBox2.Text = fnum.ToString() + deystvie;//Перенести в другой метод
            }
            if (counter > 1)
            {
                //snum = double.Parse(textBox1.Text);
                textBox1.Text = Sum(_fnum, _snum, deystvie).ToString();
                fnum = Sum(fnum, snum, deystvie);
            }
        }
        public double Sum(double _fnum, double _snum, string _deystvie)
        {
            double res;
            switch (_deystvie)
            {
                case "+":
                    res = _fnum + _snum;
                    break;
                case "-":
                    res = _fnum - _snum;
                    break;
                case "*":
                    res = _fnum * _snum;
                    break;
                case "/":
                    res = _fnum / _snum;
                    break;
                default:
                    res = double.NaN;
                    break;
            }
            return res;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {//переписать по нормальному
            //кнопки с цифрами
            if (clear)
            {
                textBox1.Clear();
                clear = false;
            }
            var a = (Button)sender;
            if (a.Text == ",")
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
        {//делить числа
            fnum = double.Parse(textBox1.Text);
            deystvie = "/";
            clear = true;
            textBox2.Text = fnum.ToString() + deystvie;
            counter++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (x.Length == 2 && x[0] == '0' && x[1] != ',')
            {
                x = x.Substring(1, 1);
                textBox1.Text = x;
            }
            if (textBox1.Text.Length > 24)
            {
                string txt = textBox1.Text;
                textBox1.Text = txt.Substring(0, 24);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {//
            string txt = textBox1.Text;
            textBox1.Text = txt.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text.Length < 1)
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
            if (x != 0)
            {
                x = 1 / x;
                textBox1.Text = x.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {//квадрат числа
            float x = float.Parse(textBox1.Text);
            x = x * x;
            textBox1.Text = x.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {//смена знака
            float x = float.Parse(textBox1.Text);
            if (x != 0)
            {
                x *= -1;
                textBox1.Text = x.ToString();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double x = float.Parse(textBox1.Text);
            if (x > 0)
            {//квадратный корень
                x = Math.Sqrt(x);
                textBox1.Text = x.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {//сложение чисел
            counter++;
            clear = true;
            Deystvie(counter, (Button)sender, double.Parse(textBox1.Text), );
            /*
            if (counter == 1)
            {

                fnum = double.Parse(textBox1.Text);
                deystvie = "+";
                clear = true;
                textBox2.Text = fnum.ToString() + deystvie;
            }
            if (counter > 1)
            {
                snum = double.Parse(textBox1.Text);
                textBox1.Text = Sum(fnum, snum, deystvie).ToString();
                fnum = Sum(fnum, snum, deystvie);
                clear = true;

            }
            */
        }
        private void button25_Click(object sender, EventArgs e)
        {//равно
            counter = 0;
            snum = double.Parse(textBox1.Text);
            double res;
            res = Sum(fnum, snum, deystvie);

            textBox1.Text = res.ToString();
            snum = double.NaN;
            fnum = double.NaN;
            deystvie = "";
            clear = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {//вычитание чисел
            fnum = double.Parse(textBox1.Text);
            deystvie = "-";
            clear = true;
            textBox2.Text = fnum.ToString() + deystvie;
            counter++;
        }

        private void button9_Click(object sender, EventArgs e)
        {//умножение чисел
            fnum = double.Parse(textBox1.Text);
            deystvie = "*";
            clear = true;
            textBox2.Text = fnum.ToString() + deystvie;
            counter++;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
