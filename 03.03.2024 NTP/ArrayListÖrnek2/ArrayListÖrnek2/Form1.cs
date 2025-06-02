using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListÖrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList liste2 = new ArrayList();
            liste2.Add("elma");
            liste2.Add("Armut");
            liste2.Add("çilek");

            liste2.Remove("Armut");
            foreach (var eleman in liste2)
            {
                listBox1.Items.Add(eleman);
            }
            label1.Text = liste2.Count.ToString();

        }
    }
}
