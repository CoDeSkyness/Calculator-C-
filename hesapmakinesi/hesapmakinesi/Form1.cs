﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int sayi1;

            int sayi2; 

            int toplam;

            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);

            toplam = sayi1 + sayi2;

            label4.Text = toplam.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sayi1, sayi2, cikma;


            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);

            cikma = sayi1 - sayi2;


            label4.Text = cikma.ToString();



        }

        private void button4_Click(object sender, EventArgs e)
        {



            int sayi1, sayi2, bolum;


            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);

            bolum = sayi1 / sayi2;


            label4.Text = bolum.ToString();





        }

        private void button3_Click(object sender, EventArgs e)
        {




            int sayi1, sayi2, carpma;


            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);

            carpma = sayi1 * sayi2;


            label4.Text = carpma.ToString();










        }
    }
}
