using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollDice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random rnd = new Random();
        int Sayi1, Sayi2;
        int sayac = 1;
        bool hileVarmi = false;


        private void btnSalla_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            hileVarmi = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hileVarmi)
            {
                lblSayi1.Text = "6";
                lblSayi2.Text = "6";

            }
            else
            {
                Sayi1 = rnd.Next(1, 7);
                Sayi2 = rnd.Next(1, 7);
                lblSayi1.Text = Sayi1.ToString();
                lblSayi2.Text = Sayi2.ToString();
                
            }
            sayac++;
            if (sayac > 20)
            {
                timer1.Stop();
                sayac = 1;
                hileVarmi = false;
            }
        }
    }
}
