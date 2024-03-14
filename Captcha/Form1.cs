using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] symbol1 = {"a","b","c","d","e","f","g" };
            string[] symbol2 = { "+", "-", "*", "/", "," };
            int symbol3;
            Random random = new Random();
            int sayi1, sayi2, sayi3;
            sayi1 = random.Next(symbol1.Length);
            sayi2 = random.Next(symbol2.Length);
            sayi3 = random.Next(0,10);
            label1.Text = symbol1[sayi1].ToString() +symbol2[sayi2].ToString() + sayi3.ToString();
           

        }
    }
}
