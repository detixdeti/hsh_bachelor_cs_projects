using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hausaufgabe_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Deklariere und initalisiere
        int n = 0;
        int counter = 0;
        int Summe = 0;
        int mittelwert = 0;
        private void btn_Rechnen_Click(object sender, EventArgs e)
        {
            //alles 0 setzten
            counter = 0;
            Summe = 0;
            mittelwert = 0;

            try
            {//n umwandeln
                n = Convert.ToInt16(txt_n.Text);
            }
            catch
            {
                //Fehleranzeige 
                MessageBox.Show("Überprüfen Sie ihr n");
                return;
            }

            do
            {
                //Rechenweg der Summe und des Mittelwerts
                counter++;

                Summe = Summe + counter ;

                mittelwert = Summe / counter;

            }
            while (counter != n);
            //Mittelwert und summe ausgeben
            txt_Summe.Text = Summe.ToString();
            txt_Mittelwert.Text = mittelwert.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //alles 0 setzten
            counter = 0;
            Summe = 0;
            mittelwert = 0;
            try
            {//n umwandeln
                n = Convert.ToInt16(txt_n.Text);
            }
            catch
            {
                //Fehleranzeige 
                MessageBox.Show("Überprüfen Sie ihre Eingaben");
                return;
            }

            //for 
            for (int i = 0; i < n; i++)
            {

                Summe = Summe + i + 1;

                mittelwert = Summe / n;

            }
            
            txt_Summe.Text = Summe.ToString();
            txt_Mittelwert.Text = mittelwert.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
            
        }

        private void btn_hilfe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gutefrage.net");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
