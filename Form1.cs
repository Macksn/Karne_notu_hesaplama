using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace karne_notu_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y1, y2, p1, p2, ort, sonuc;
            y1 = Convert.ToInt16(textBox1.Text); 
            y2 = Convert.ToInt16(textBox2.Text);
            p1 = Convert.ToInt16(textBox3.Text);
            p2 = Convert.ToInt16(textBox4.Text);
           
            ort = (y1 + y2 + p1 + p2) / 4;
            textBox5.Text = ort.ToString();
            if (ort >= 50)
            {
                textBox6.Text = "geçtiniz";
            }
            else
            {
                textBox6.Text = "kaldınız";
            
            }
           

        }
    }
}
