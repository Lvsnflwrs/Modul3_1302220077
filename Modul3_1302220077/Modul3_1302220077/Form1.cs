using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Modul3_1302220077
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = button1.Text;
            int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = button2.Text;
            int.Parse(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = button5.Text;
            int.Parse(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = button4.Text;
            int.Parse(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = button3.Text;
            int.Parse(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = button6.Text;
            int.Parse(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = button7.Text;
            int.Parse(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = button8.Text;
            int.Parse(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = button9.Text;
            int.Parse(textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = button11.Text;
            int.Parse(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);
            textBox1.Text = (num1 + num2).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
