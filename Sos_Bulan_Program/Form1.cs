using System;
using System.Windows.Forms;

namespace Sos_Bulan_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, sayac;
        string b, c;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            b = "";
            sayac = 0;

            for (int i = 0; i < 20; i++)
            {
                a = rnd.Next(1, 3);
                if (a == 1) b += "S";
                if (a == 2) b += "O";
            }
            textBox1.Text = b;
            for (int x = 0; x <= 20; x++)
            {
                if (x <= 17)
                {
                    c = b.Substring(x, 3);
                    if (c == "SOS") sayac++;
                }
            }
            label1.Text = sayac.ToString();
        }
    }
}
