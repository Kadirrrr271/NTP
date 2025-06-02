using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dowhile3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                i++;
                if (i % 2 == 0)//Değerin 2 ile bölümünden kalanına bakarı
            }
            {
                continue;
            }
            MessageBox.Show("" + i);
          }  While(in<= 15);
        }
    }
}
