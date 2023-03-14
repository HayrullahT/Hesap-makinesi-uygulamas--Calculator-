using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        İslemler aa = new İslemler();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
label2.Text = aa.Toplama(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
       
            }
            catch (Exception)
            {

                MessageBox.Show("Muhtemelen sayı girmediniz!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
label2.Text = aa.Cıkarma(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Muhtemelen sayı girmediniz!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
label2.Text = aa.Carpma(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
            
            }
            catch (Exception)
            {

                MessageBox.Show("Muhtemelen sayı girmediniz!");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = aa.Bolme(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Muhtemelen sayı girmediniz!");
               
            }    
        }
    }
}
