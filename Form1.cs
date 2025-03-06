using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUGAS_modul3
{
    public partial class Form1 : Form
    {
        int num;
        int total;

        public Form1()
        {
            InitializeComponent();
        }

        private void textbox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            num = num * 10 + 1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            num = num * 10 + 1;
        }
        

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            num = num * 10 + 3;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            num = num * 10 + 1;
        }
    

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            num = num * 10 + 1;

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            num = num * 10 + 1;
        }
    

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            num = num * 10 + 7;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            num = num * 10 + 8;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            num = num * 10 + 9;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            total = 

            
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            num = num * 10;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "=";
        }


        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
