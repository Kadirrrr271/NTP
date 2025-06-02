using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kadirin_NTP_bahcesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[6];
        int[] not= new int[6];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
         if(index<isimler.Length)
            {
                isimler[index] = textBox1.Text;
                not[index] = int.Parse(textBox2.Text);
                index++;
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0; i< isimler.Length;i++)
            {
                if(isimler[i]!=null)
                {
                    listBox1.Items.Add(isimler[i] + ">" + not[i]);
                }
            }
        }
    }
}
