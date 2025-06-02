using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_boyutlu_dizilerde_kullanılan_özellikler_ve_metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //dizi tanımlaması
           int[] sayilar = { 5, 8, 16, 18, 6 };

            //Length:Dizi uzunluğu
            int lenght = sayilar.Length;
            label1.Text = "dizi uzunluğu" + lenght;

            //Rank: Dizi boyutu
            int rank = sayilar.Rank;
            label2.Text = "dizi boyutu" + rank;

            //max: Dizideki en büyük değer
            int max = sayilar.Max();
            label3.Text = "dizideki en büyük değer" + max;

            //Min:dizideki en küçük değer
            int min = sayilar.Min();
            label4.Text = "dizideki en küçük değer" + min;

            //sum: dizideki elemanları toplaması
            int sum = sayilar.Sum();
            label5.Text = "Dizideki toplam sıralama" + sum;

            //Average:Dizideki elemanların ortalaması
            double average = sayilar.Average();
            label6.Text = "Dizideki toplam sıralama" + average;



            //first: dizinin ilk elemeanı
            int first = sayilar.First();
            label7.Text = "Dizinin ilk elemanı" + first;

            //Last: dizinin son elemanı
            int Last = sayilar.Last();
            label8.Text = "dizinin son elemanı" + Last;
        }
    }
}
