/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					   2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:Proje1
**				ÖĞRENCİ ADI............:ZEYNEP DUVARCI
**				ÖĞRENCİ NUMARASI.......:B201210082
**              DERSİN ALINDIĞI GRUP...:1. ÖĞRETİM A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MeyveOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 60;

        Random rnd = new Random();

        List<Image> images = new List<Image>
        {Properties.Resources.Portakal, 
            Properties.Resources.Greyfurt,
            Properties.Resources.Limon,
            Properties.Resources.Mandalina,
            Properties.Resources.Elma,
            Properties.Resources.Armut,
            Properties.Resources.Kivi,
            Properties.Resources.Çilek
        };

        int secim ;
        int t_agirlik=0;
        int a_vit=0;
        int c_vit = 0;

        Narenciye narenciye = new Narenciye();
        KatıMeyve katıMeyve = new KatıMeyve();


        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Zamanlayıcı : 01:00";
            button2.Enabled = true;
            button3.Enabled = true;
            richTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            timer1.Start();
            button1.Hide();

            secim = rnd.Next(1, images.Count);
            pictureBox9.Image = images[secim];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label2.Text = "Zamanlayıcı : 00:" + sayac;

            //1 dakika dolduysa çalışır
            if (sayac == 0)
            {
                timer1.Stop();
                label2.Text = " Süreniz Doldu ";
                button2.Enabled = false;
                button3.Enabled = false;

                button1.Text = "YENİ OYUN";
                button1.Show();
                sayac = 60;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   //Katı meyve sıkacağı

            //image listesindeki değeri 4 le 8 arasındaysa çalışır
            //görselle makina uyumunu kontrol eder
            if(secim>=4|secim<8)
            {
                //image listesindeki değerine göre meyvenin uygun değerlerini yazdırır
                switch(secim)
                {
                    case 4:

                        richTextBox1.Text += katıMeyve.Bilgi(0);
                        t_agirlik = t_agirlik + katıMeyve.Agirlik(0);
                        textBox3.Text = Convert.ToString(t_agirlik);
                        a_vit = a_vit + katıMeyve.Avitamini(0);
                        textBox1.Text = Convert.ToString(a_vit);
                        c_vit = c_vit + katıMeyve.Cvitamini(0);
                        textBox2.Text = Convert.ToString(c_vit);
                        
                        secim = rnd.Next(0, images.Count);
                        pictureBox9.Image = images[secim];
                        break;
                    case 5:

                        richTextBox1.Text += katıMeyve.Bilgi(1);
                        t_agirlik = t_agirlik + katıMeyve.Agirlik(1);
                        textBox3.Text = Convert.ToString(t_agirlik);
                        a_vit = a_vit + katıMeyve.Avitamini(1);
                        textBox1.Text = Convert.ToString(a_vit);
                        c_vit = c_vit + katıMeyve.Cvitamini(1);
                        textBox2.Text = Convert.ToString(c_vit);
                        
                        secim = rnd.Next(0, images.Count);
                        pictureBox9.Image = images[secim];
                        break;
                    case 6:

                        richTextBox1.Text += katıMeyve.Bilgi(2);
                        t_agirlik = t_agirlik + katıMeyve.Agirlik(2);
                        textBox3.Text = Convert.ToString(t_agirlik);
                        a_vit = a_vit + katıMeyve.Avitamini(2);
                        textBox1.Text = Convert.ToString(a_vit);
                        c_vit = c_vit + katıMeyve.Cvitamini(2);
                        textBox2.Text = Convert.ToString(c_vit);
                       
                        secim = rnd.Next(0, images.Count);
                        pictureBox9.Image = images[secim];
                        break;
                    case 7:

                        richTextBox1.Text += katıMeyve.Bilgi(3); 
                        t_agirlik = t_agirlik + katıMeyve.Agirlik(3);
                        textBox3.Text = Convert.ToString(t_agirlik);
                        a_vit = a_vit + katıMeyve.Avitamini(3);
                        textBox1.Text = Convert.ToString(a_vit);
                        c_vit = c_vit + katıMeyve.Cvitamini(3);
                        textBox2.Text = Convert.ToString(c_vit);
                         
                        secim = rnd.Next(0, images.Count);
                        pictureBox9.Image = images[secim];
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   //narenciye sıkacağı

            //image listesindeki değeri 0 le 4 arasındaysa çalışır
            //görselle makina uyumunu kontrol eder

            if (secim >= 0 | secim < 4)
            {
                //image listesindeki değerine göre meyvenin uygun değerlerini yazdırır

                switch (secim)
                {
                    case 0:

                        richTextBox1.Text += narenciye.Bilgi(0);
                        t_agirlik = t_agirlik + narenciye.Agirlik(0);
                        textBox3.Text = Convert.ToString(t_agirlik);
                        a_vit = a_vit + narenciye.Avitamini(0);
                        textBox1.Text = Convert.ToString(a_vit);
                        c_vit = c_vit + narenciye.Cvitamini(0);
                        textBox2.Text = Convert.ToString(c_vit);
                        
                        secim = rnd.Next(0, images.Count);
                        pictureBox9.Image = images[secim];
                        break;
                    case 1:

                        richTextBox1.Text += narenciye.Bilgi(1); 
                        t_agirlik = t_agirlik + narenciye.Agirlik(1);
                        textBox3.Text = Convert.ToString(t_agirlik);
                        a_vit = a_vit + narenciye.Avitamini(1);
                        textBox1.Text = Convert.ToString(a_vit);
                        c_vit = c_vit + narenciye.Cvitamini(1);
                        textBox2.Text = Convert.ToString(c_vit);
                        
                        secim = rnd.Next(0, images.Count);
                        pictureBox9.Image = images[secim];
                        break;
                    case 2:

                        richTextBox1.Text += narenciye.Bilgi(2); 
                        t_agirlik = t_agirlik + narenciye.Agirlik(2);
                        textBox3.Text = Convert.ToString(t_agirlik);
                        a_vit = a_vit + narenciye.Avitamini(2);
                        textBox1.Text = Convert.ToString(a_vit);
                        c_vit = c_vit + narenciye.Cvitamini(2);
                        textBox2.Text = Convert.ToString(c_vit);
                        
                        secim = rnd.Next(0, images.Count);
                        pictureBox9.Image = images[secim];
                        break;
                    case 3:

                        richTextBox1.Text += narenciye.Bilgi(3);
                        t_agirlik = t_agirlik + narenciye.Agirlik(3);
                        textBox3.Text = Convert.ToString(t_agirlik);
                        a_vit = a_vit + narenciye.Avitamini(3);
                        textBox1.Text = Convert.ToString(a_vit);
                        c_vit = c_vit + narenciye.Cvitamini(3);
                        textBox2.Text = Convert.ToString(c_vit);
                        
                        secim = rnd.Next(0, images.Count);
                        pictureBox9.Image = images[secim];
                        break;
                }
            }

        }

       
    }
}
