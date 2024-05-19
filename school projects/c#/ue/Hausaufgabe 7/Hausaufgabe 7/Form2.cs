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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //deklariere und initalisiere

        double Anfangswert = 0;
        int Laufzeit = 0;
        double Zinssatz = 0;
        int counter = 0;
        double anfang = 0;

        private void btn_Berechnen_Click(object sender, EventArgs e)
        {
            Kapital_je_Jahr.Items.Clear();
            counter = 0;
            //Prozentzeichen wird entfernt von der Usereingabe
            txt_Zinssatz.Text = txt_Zinssatz.Text.Replace("%", "");
            txt_Zinssatz.Text = txt_Zinssatz.Text.Replace(" ", "");

            //Alle Usereingaben werden umgewandelt + Fehlermeldung
            try
            {
                Anfangswert = Convert.ToDouble(txt_Anfangskapital.Text);
                Laufzeit = Convert.ToInt16(txt_Laufzeit.Text);
                Zinssatz = Convert.ToDouble(txt_Zinssatz.Text);
            }
            catch
            {
                MessageBox.Show("Kontrollieren Sie Ihre Eingaben da ist ein Fehler vorhanden. Wenn Sie hilfe brauchen wie Sie dies Eingeben drücken Sie auf Hilfe");
                return;
            }
            anfang = Anfangswert;

            for (int i = 0; i != Laufzeit; i++)
            {
                counter++;

                Anfangswert = Anfangswert * (1 + Zinssatz / 100);
                Anfangswert = Math.Round(Anfangswert, 2);
                txt_Endbetrag.Text = Anfangswert.ToString();
                Kapital_je_Jahr.Items.Add("Jahr "+ counter + ".     " + Anfangswert + " €");
            }


            txt_inklZ.Text = "Das erzielte Endkapital inkl. Zinsen beträgt:	" + Anfangswert.ToString() + " Euro";

            txt_zinsen.Text = "Zinsen gesamt: " +(Anfangswert - anfang) + " Euro";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
