using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayısalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e) //BAŞLAT butonuna bastığında
        {
            Random rdm = new Random(); //Random sınıfından rdm  nesnesi türettik
            int s1, s2, s3, s4; //int türünde değişkenler tanımladık
            s1 = rdm.Next(1, 11); //rnd nesnesinde Next metodunu kullanarak 1 ile 11 arasında sayılar üretiyoruz
            s2 = rdm.Next(1, 11);
            s3 = rdm.Next(1, 11);
            s4 = rdm.Next(1, 11);

            label1.Text = s1.ToString(); //label1 e yazdırıyoruz
            label3.Text = s2.ToString();
            label4.Text = s3.ToString();
            label6.Text = s4.ToString();

            //sayı1
            if(textBox1.Text==label1.Text) // eğer textBox daki değer label deki değere eşit ise
            {
                textBox1.BackColor = Color.Green; //textBox ın arka plan nergini yeşil yap
            }
            else
            {
                textBox1.BackColor = Color.Red; //değilse textbox ın arka plan rengini kırmızı yap
            }

            //sayı2
            if (textBox2.Text == label3.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            //sayı3
            if (textBox3.Text == label4.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            //sayı4
            if (textBox4.Text == label6.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e) //Temizle butonuna bastığında
        {
            label1.Text = "0"; //label1 in metnini 0 yap
            label3.Text = "0";
            label4.Text = "0";
            label6.Text = "0";

            textBox1.Text = ""; //textBox ın değerini sıfırla
            textBox1.BackColor = Color.White; //textBox ın arka plan rengini begaz yap

            textBox2.Text = "";
            textBox2.BackColor = Color.White;

            textBox3.Text = "";
            textBox3.BackColor = Color.White;

            textBox4.Text = "";
            textBox4.BackColor = Color.White;



        }
    }
}
