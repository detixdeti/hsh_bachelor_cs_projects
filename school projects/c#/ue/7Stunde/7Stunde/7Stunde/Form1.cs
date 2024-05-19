using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7Stunde
{
    public partial class Form1 : Form
    {
        //Deklarieren und initalisieren
        double zahl1 = 0;
        double counter = 0;

        double start = 0;
        double end = 0;

        double Ausgwählte_Zahl;

        double Prozentwert = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAnzahl_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_Würfel_Click(object sender, EventArgs e)
        {
            //Alle startwerte zurücksetzten
            start = 0;
            txtLsg.Text = "";
            lbl_Sechs.Text = "";
            counter = 0;
            lbl_Prozent.Text = "";
            btn_Würfel.Text = "nochmal";

            //gesuchter Wert wird definiert 
            if(comb_Zahl.SelectedIndex == 0)
            {
                Ausgwählte_Zahl = 1;
            }
            else if(comb_Zahl.SelectedIndex == 1)
            {
                Ausgwählte_Zahl = 2;
            }
            else if(comb_Zahl.SelectedIndex == 2)
            {
                Ausgwählte_Zahl = 3;
            }
            else if(comb_Zahl.SelectedIndex == 3)
            {
                Ausgwählte_Zahl = 4;
            }
            else if(comb_Zahl.SelectedIndex == 4)
            {
                Ausgwählte_Zahl = 5;
            }
            else
            {
                Ausgwählte_Zahl = 6;
            }

            //Konventieren wird versucht sonst fehlermeldung
            try
            {
                end = Convert.ToInt16(txtAnzahl.Text);
            }
            catch
            {
                MessageBox.Show("Überprüfen Sie ihre Eingaben");
                return;
            }
            //Anzahl soll nicht größer als 17 sein da der balken nicht lang genug ist
            if(end >= 18)
            {
                MessageBox.Show("Sie können nur maximal 17 Zahlen eingeben.. Ihre arme Hand");
                return;
            }

            Random zufall = new Random();

            do
            {
                //Zahlen werden generiert
                zahl1 = zufall.Next(1, 7);
                start++;
                //Die ausgwählte zahl wird überprüft und gezählt und ausgeblendet wenn es nicht vorkommt
                if (zahl1 == Ausgwählte_Zahl)
                {
                    counter++;
                    lbl_Sechs.Text = "Sie haben " + counter + " mal die " + Ausgwählte_Zahl + " gewürfelt";

                    //Prozent wird ausgerechnet und ausgeblendet wenn es nicht vorkommt
                    Prozentwert = (counter / end) * 100;
                    Prozentwert = Math.Round(Prozentwert, 2);
                    lbl_Prozent.Text = Prozentwert + " % wurde die " + Ausgwählte_Zahl + " gewürfelt";
                }

                txtLsg.Text = txtLsg.Text + " " + zahl1;

            }
            while (start != end);
            
        }

        private void comb_Zahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Das Bild der würfelzahl wird daneben angezeigt
            if (comb_Zahl.SelectedIndex == 0)
            {
                pic_Würfel1.Visible = true;
                pic_Würfel2.Visible = false;
                pic_Würfel3.Visible = false;
                pic_Würfel4.Visible = false;
                pic_Würfel5.Visible = false;
                pic_Würfel6.Visible = false;

            }
            else if (comb_Zahl.SelectedIndex == 1)
            {
                pic_Würfel1.Visible = false;
                pic_Würfel2.Visible = true;
                pic_Würfel3.Visible = false;
                pic_Würfel4.Visible = false;
                pic_Würfel5.Visible = false;
                pic_Würfel6.Visible = false;
            }
            else if (comb_Zahl.SelectedIndex == 2)
            {
                pic_Würfel1.Visible = false;
                pic_Würfel2.Visible = false;
                pic_Würfel3.Visible = true;
                pic_Würfel4.Visible = false;
                pic_Würfel5.Visible = false;
                pic_Würfel6.Visible = false;
            }
            else if (comb_Zahl.SelectedIndex == 3)
            {
                pic_Würfel1.Visible = false;
                pic_Würfel2.Visible = false;
                pic_Würfel3.Visible = false;
                pic_Würfel4.Visible = true;
                pic_Würfel5.Visible = false;
                pic_Würfel6.Visible = false;
            }
            else if (comb_Zahl.SelectedIndex == 4)
            {
                pic_Würfel1.Visible = false;
                pic_Würfel2.Visible = false;
                pic_Würfel3.Visible = false;
                pic_Würfel4.Visible = false;
                pic_Würfel5.Visible = true;
                pic_Würfel6.Visible = false;
            }
            else if (comb_Zahl.SelectedIndex ==5)
            {
                pic_Würfel1.Visible = false;
                pic_Würfel2.Visible = false;
                pic_Würfel3.Visible = false;
                pic_Würfel4.Visible = false;
                pic_Würfel5.Visible = false;
                pic_Würfel6.Visible = true;
            }
        }

        private void lbl_Prozent_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gutefrage.net");
        }
    }
}
