using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.Stunde
{
    public partial class Form1 : Form
    {
        //deklarieren und initalisieren
        double A1_Preis = 0;
        double A2_Preis = 0;
        double A3_Preis = 0;
        double A4_Preis = 0;
        double A1_Anzahl = 0;
        double A2_Anzahl = 0;
        double A3_Anzahl = 0;
        double A4_Anzahl = 0;
        double Summe = 0;
        double Prozent = 0;
        double Mehrwertsteuern = 0.19;
        double Nettobetrag = 0;



        private void btnArtikel_Click(object sender, EventArgs e)
        {//Das einfügen der Atrikel wird hier durch visible eingestellt
            if (lblA3.Visible == true)
            {
                lblA4.Visible = true;
                txtAnzahl4.Visible = true;
                txtPreis4.Visible = true;
            }
            else if (lblA2.Visible == true)
            {
                lblA3.Visible = true;
                txtPreis3.Visible = true;
                txtAnzahl3.Visible = true;
            }
            else if (lblA1.Visible == true)
            {
                lblA2.Visible = true;
                txtAnzahl2.Visible = true;
                txtPreis2.Visible = true;
            }
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            //Prozentzahl vom Rabatt wird hier nachgefragt
            if (combProzent.SelectedIndex == 0)
            {
                Prozent = 0.95;
                lblProzent.Text = "Rabatt : 5 %";

            }
            else if (combProzent.SelectedIndex == 1)
            {
                Prozent = 0.90;
                lblProzent.Text = "Rabatt : 10% ";
            }
            else if (combProzent.SelectedIndex == 2)
            {
                Prozent = 0.85;
                lblProzent.Text = "Rabatt : 15 %";
            }
            else if ( combProzent.SelectedIndex == 3)
            {
                Prozent = 0.80;
                lblProzent.Text = "Rabatt : 20 %";
            }
            else
            {
                Prozent = 1;
                lblProzent.Text = "Rabatt : 0 %";
            }
            //Kommas in Punkte umgewandelt (nicht nötig da die Anzahl grade sein muss
            //txtAnzahl1.Text = txtAnzahl1.Text.Replace(",", ".");
            //txtAnzahl2.Text = txtAnzahl2.Text.Replace(",", ".");
            //txtAnzahl3.Text = txtAnzahl3.Text.Replace(",", ".");
            //txtAnzahl4.Text = txtAnzahl4.Text.Replace(",", ".");


            //Es wird geguckt ob alle Eingaben Konventiert werden können
            try
            {
                if (lblA4.Visible == true)
                {
                    A1_Anzahl = Convert.ToDouble(txtAnzahl1.Text);
                    A2_Anzahl = Convert.ToDouble(txtAnzahl2.Text);
                    A3_Anzahl = Convert.ToDouble(txtAnzahl3.Text);
                    A4_Anzahl = Convert.ToDouble(txtAnzahl4.Text);
                    //Es wird überprüft ob die Anzahl mindestens 1 ist und ob eine Comobox ausgewäglt worden ist
                    if (A1_Anzahl == 0 || A2_Anzahl == 0 || A3_Anzahl == 0 || A4_Anzahl == 0)
                    {
                        MessageBox.Show("Die Anzahl Ihres Produktes muss mindestens 1 sein.");
                        return;
                    }
                    if (lblA1.SelectedIndex == 0 || lblA1.SelectedIndex == 1 || lblA1.SelectedIndex == 2 || lblA1.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA2.SelectedIndex == 0 || lblA2.SelectedIndex == 1 || lblA2.SelectedIndex == 2 || lblA2.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA3.SelectedIndex == 0 || lblA3.SelectedIndex == 1 || lblA3.SelectedIndex == 2 || lblA3.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA4.SelectedIndex == 0 || lblA4.SelectedIndex == 1 || lblA4.SelectedIndex == 2 || lblA4.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }


                }
                else if (lblA3.Visible == true)
                {
                    A1_Anzahl = Convert.ToDouble(txtAnzahl1.Text);
                    A2_Anzahl = Convert.ToDouble(txtAnzahl2.Text);
                    A3_Anzahl = Convert.ToDouble(txtAnzahl3.Text);
                    if (A1_Anzahl == 0 || A2_Anzahl == 0 || A3_Anzahl == 0)
                    {
                        MessageBox.Show("Die Anzahl Ihres Produktes muss mindestens 1 sein.");
                        return;
                    }
                    if (lblA1.SelectedIndex == 0 || lblA1.SelectedIndex == 1 || lblA1.SelectedIndex == 2 || lblA1.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA2.SelectedIndex == 0 || lblA2.SelectedIndex == 1 || lblA2.SelectedIndex == 2 || lblA2.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA3.SelectedIndex == 0 || lblA3.SelectedIndex == 1 || lblA3.SelectedIndex == 2 || lblA3.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                }
                else if (lblA2.Visible == true)
                {
                    A1_Anzahl = Convert.ToDouble(txtAnzahl1.Text);
                    A2_Anzahl = Convert.ToDouble(txtAnzahl2.Text);
                    if (A1_Anzahl == 0 || A2_Anzahl == 0)
                    {
                        MessageBox.Show("Die Anzahl Ihres Produktes muss mindestens 1 sein.");
                        return;
                    }
                    if (lblA1.SelectedIndex == 0 || lblA1.SelectedIndex == 1 || lblA1.SelectedIndex == 2 || lblA1.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA2.SelectedIndex == 0 || lblA2.SelectedIndex == 1 || lblA2.SelectedIndex == 2 || lblA2.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                }
                else if (lblA1.Visible == true)
                {
                    A1_Anzahl = Convert.ToDouble(txtAnzahl1.Text);
                    if (A1_Anzahl == 0)
                    {
                        MessageBox.Show("Die Anzahl Ihres Produktes muss mindestens 1 sein.");
                        return;
                    }
                    if (lblA1.SelectedIndex == 0 || lblA1.SelectedIndex == 1 || lblA1.SelectedIndex == 2 || lblA1.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Bitte Überprüfen Sie Ihre Eingaben!");
                return;
            }

            //Berechnungen werden ausgeführt und alle geforderten Sachen werden ausgegeben 
            Summe = ((A1_Preis * A1_Anzahl) + (A2_Preis * A2_Anzahl) + (A3_Preis * A3_Anzahl) + (A4_Preis * A4_Anzahl)) * Prozent;
            lblPreis.Text = Summe.ToString("#0.00");

            double MwSt = Summe * Mehrwertsteuern;
            lblMwSt.Text = MwSt.ToString("#0.00");

            Nettobetrag = Summe - MwSt;
            lblNetto.Text = Nettobetrag.ToString("#0.00");

            double Rabatt = ((A1_Preis * A1_Anzahl) + (A2_Preis * A2_Anzahl) + (A3_Preis * A3_Anzahl) + (A4_Preis * A4_Anzahl)) - (((A1_Preis * A1_Anzahl) + (A2_Preis * A2_Anzahl) + (A3_Preis * A3_Anzahl) + (A4_Preis * A4_Anzahl)) * Prozent);
            lblProzent.Text = lblProzent.Text + "(" + Rabatt.ToString() +" Euro)";
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //Prozentzahl vom Rabatt wird hier nachgefragt
            switch (combProzent.SelectedIndex)
            {
                case 0:
                    Prozent = 0.95;
                    lblProzent.Text = "Rabatt : 5 %";
                    break;

                case 1:
                    Prozent = 0.90;
                    lblProzent.Text = "Rabatt : 10% ";
                    break;

                case 2:
                    Prozent = 0.85;
                    lblProzent.Text = "Rabatt : 15 %";
                    break;

                case 3:
                    Prozent = 0.80;
                    lblProzent.Text = "Rabatt : 20 %";
                    break;
                default:
                    Prozent = 1;
                    lblProzent.Text = "Rabatt : 0 %";
                    break;
            }

            //Kommas in Punkte umgewandelt (nicht nötig da die Anzahl grade sein muss
            //txtAnzahl1.Text = txtAnzahl1.Text.Replace(",", ".");
            //txtAnzahl2.Text = txtAnzahl2.Text.Replace(",", ".");
            //txtAnzahl3.Text = txtAnzahl3.Text.Replace(",", ".");
            //txtAnzahl4.Text = txtAnzahl4.Text.Replace(",", ".");


            //Es wird geguckt ob alle Eingaben Konventiert werden können
            try
            {
                if (lblA4.Visible == true)
                {
                    A1_Anzahl = Convert.ToDouble(txtAnzahl1.Text);
                    A2_Anzahl = Convert.ToDouble(txtAnzahl2.Text);
                    A3_Anzahl = Convert.ToDouble(txtAnzahl3.Text);
                    A4_Anzahl = Convert.ToDouble(txtAnzahl4.Text);
                    //Es wird überprüft ob die Anzahl mindestens 1 ist und ob eine Comobox ausgewäglt worden ist
                    if (A1_Anzahl == 0 || A2_Anzahl == 0 || A3_Anzahl == 0 || A4_Anzahl == 0)
                    {
                        MessageBox.Show("Die Anzahl Ihres Produktes muss mindestens 1 sein.");
                        return;
                    }
                    if (lblA1.SelectedIndex == 0 || lblA1.SelectedIndex == 1 || lblA1.SelectedIndex == 2 || lblA1.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA2.SelectedIndex == 0 || lblA2.SelectedIndex == 1 || lblA2.SelectedIndex == 2 || lblA2.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA3.SelectedIndex == 0 || lblA3.SelectedIndex == 1 || lblA3.SelectedIndex == 2 || lblA3.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA4.SelectedIndex == 0 || lblA4.SelectedIndex == 1 || lblA4.SelectedIndex == 2 || lblA4.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }


                }
                else if (lblA3.Visible == true)
                {
                    A1_Anzahl = Convert.ToDouble(txtAnzahl1.Text);
                    A2_Anzahl = Convert.ToDouble(txtAnzahl2.Text);
                    A3_Anzahl = Convert.ToDouble(txtAnzahl3.Text);
                    if (A1_Anzahl == 0 || A2_Anzahl == 0 || A3_Anzahl == 0)
                    {
                        MessageBox.Show("Die Anzahl Ihres Produktes muss mindestens 1 sein.");
                        return;
                    }
                    if (lblA1.SelectedIndex == 0 || lblA1.SelectedIndex == 1 || lblA1.SelectedIndex == 2 || lblA1.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA2.SelectedIndex == 0 || lblA2.SelectedIndex == 1 || lblA2.SelectedIndex == 2 || lblA2.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA3.SelectedIndex == 0 || lblA3.SelectedIndex == 1 || lblA3.SelectedIndex == 2 || lblA3.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                }
                else if (lblA2.Visible == true)
                {
                    A1_Anzahl = Convert.ToDouble(txtAnzahl1.Text);
                    A2_Anzahl = Convert.ToDouble(txtAnzahl2.Text);
                    if (A1_Anzahl == 0 || A2_Anzahl == 0)
                    {
                        MessageBox.Show("Die Anzahl Ihres Produktes muss mindestens 1 sein.");
                        return;
                    }
                    if (lblA1.SelectedIndex == 0 || lblA1.SelectedIndex == 1 || lblA1.SelectedIndex == 2 || lblA1.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                    if (lblA2.SelectedIndex == 0 || lblA2.SelectedIndex == 1 || lblA2.SelectedIndex == 2 || lblA2.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                }
                else if (lblA1.Visible == true)
                {
                    A1_Anzahl = Convert.ToDouble(txtAnzahl1.Text);
                    if (A1_Anzahl == 0)
                    {
                        MessageBox.Show("Die Anzahl Ihres Produktes muss mindestens 1 sein.");
                        return;
                    }
                    if (lblA1.SelectedIndex == 0 || lblA1.SelectedIndex == 1 || lblA1.SelectedIndex == 2 || lblA1.SelectedIndex == 3)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen ein Produkt auswählen");
                        return;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Bitte Überprüfen Sie Ihre Eingaben!");
                return;
            }

            //Berechnungen werden ausgeführt und alle geforderten Sachen werden ausgegeben 
            Summe = ((A1_Preis * A1_Anzahl) + (A2_Preis * A2_Anzahl) + (A3_Preis * A3_Anzahl) + (A4_Preis * A4_Anzahl)) * Prozent;
            lblPreis.Text =  Summe.ToString("#0.00") ;

            double MwSt = Summe * Mehrwertsteuern;
            lblMwSt.Text =  MwSt.ToString("#0.00");

            Nettobetrag = Summe - MwSt;
            lblNetto.Text = Nettobetrag.ToString("#0.00");

            double Rabatt = ((A1_Preis * A1_Anzahl) + (A2_Preis * A2_Anzahl) + (A3_Preis * A3_Anzahl) + (A4_Preis * A4_Anzahl)) - (((A1_Preis * A1_Anzahl) + (A2_Preis * A2_Anzahl) + (A3_Preis * A3_Anzahl) + (A4_Preis * A4_Anzahl)) * Prozent);
            lblProzent.Text = lblProzent.Text + "(" + Rabatt.ToString() + " Euro)";

        }

        

        private void lblA1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Produkte werden einen Preis hinzugefügt, jenachdem welches Produkt man gewählt hat
            if(lblA1.SelectedIndex == 0)
            {
                A1_Preis = 8;
                txtPreis1.Text = A1_Preis.ToString() + "$";
            }
            else if(lblA1.SelectedIndex == 1)
            {
                A1_Preis = 12;
                txtPreis1.Text = A1_Preis.ToString() + "$";
            }
            else if (lblA1.SelectedIndex == 2)
            {              
                A1_Preis = 199;
                txtPreis1.Text = A1_Preis.ToString() + "$";
            }
            else if (lblA1.SelectedIndex == 3)
            {
                A1_Preis = 599;
                txtPreis1.Text = A1_Preis.ToString() + "$";
            }
            else
            {
                A1_Preis = 0;
                txtPreis1.Text = A1_Preis.ToString() + "$";
            }
        }

        private void lblA2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Produkte werden einen Preis hinzugefügt, jenachdem welches Produkt man gewählt hat
            if (lblA2.SelectedIndex == 0)
            {
                A2_Preis = 8;
                txtPreis2.Text = A2_Preis.ToString() + "$";
            }
            else if (lblA2.SelectedIndex == 1)
            {
                A2_Preis = 12;
                txtPreis2.Text = A2_Preis.ToString() + "$";
            }
            else if (lblA2.SelectedIndex == 2)
            {
                A2_Preis = 199;
                txtPreis2.Text = A2_Preis.ToString() + "$";
            }
            else if (lblA2.SelectedIndex == 3)
            {
                A2_Preis = 599;
                txtPreis2.Text = A2_Preis.ToString() + "$";
            }
            else
            {
                A2_Preis = 0;
                txtPreis2.Text = A2_Preis.ToString() + "$";
            }
        }

        private void lblA3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Produkte werden einen Preis hinzugefügt, jenachdem welches Produkt man gewählt hat
            if (lblA3.SelectedIndex == 0)
            {
                A3_Preis = 8;
                txtPreis3.Text = A3_Preis.ToString() + "$";
            }
            else if (lblA3.SelectedIndex == 1)
            {
                A3_Preis = 12;
                txtPreis3.Text = A3_Preis.ToString() + "$";
            }
            else if (lblA3.SelectedIndex == 2)
            {
                A3_Preis = 199;
                txtPreis3.Text = A3_Preis.ToString() + "$";
            }
            else if (lblA3.SelectedIndex == 3)
            {
                A3_Preis = 599;
                txtPreis3.Text = A3_Preis.ToString() + "$";
            }
            else
            {
                A3_Preis = 0;
                txtPreis3.Text = A3_Preis.ToString() + "$";
            }
        }

        private void lblA4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Produkte werden einen Preis hinzugefügt, jenachdem welches Produkt man gewählt hat
            if (lblA4.SelectedIndex == 0)
            {
                A4_Preis = 8;
                txtPreis4.Text = A4_Preis.ToString() + "$";
            }
            else if (lblA4.SelectedIndex == 1)
            {
                A4_Preis = 12;
                txtPreis4.Text = A4_Preis.ToString() + "$";
            }
            else if (lblA4.SelectedIndex == 2)
            {
                A4_Preis = 199;
                txtPreis4.Text = A4_Preis.ToString() + "$";
            }
            else if (lblA4.SelectedIndex == 3)
            {
                A4_Preis = 599;
                txtPreis4.Text = A4_Preis.ToString() + "$";
            }
            else
            {
                A4_Preis = 0;
                txtPreis4.Text = A4_Preis.ToString() + "$";
            }
        }
        //app startet neu
        private void btnreset_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
        private void btnHilfe_MouseEnter(object sender, EventArgs e)
        {
            //Messgaebox wenn die Maus über dem i 
            MessageBox.Show("Als erstes Wählen Sie ihr Produkt aus (wenn Sie nähere Infos haben wollen klicken Sie auf den Button unten, da werden ihr mehrere Infos angegeben) \n " +
                "Der Preis wird automatisch angegeben und Sie müssen nun die Anzahl angeben.. 0 wird nicht akzeptiert \n" +
                "nun schauen sie ob dies ein Stammkunde ist und ob Sie Ihm Rabatte geben wollen, wenn ja wählen Sie den Rabatt aus. \n" +
                "nun wählen Sie ihre berechnungsart aus und Unten wird alles als Kassenbon ausgeworfen..)");
            btnHilfe.BackColor = Color.Blue;
        }
        //Farben ändern sich wenn man die Maus drauf hält
        private void btnHilfe_MouseLeave(object sender, EventArgs e)
        {
            btnHilfe.BackColor = Color.Gray;
        }       
        private void btnArtikel_MouseEnter(object sender, EventArgs e)
        {
            btnArtikel.BackColor = Color.Green;
        }

        private void btnArtikel_MouseLeave(object sender, EventArgs e)
        {
            btnArtikel.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 newform2 = new Form2();
            newform2.ShowDialog();



        }


        //___________________________________________________________
        private void grb_Rechner_Enter(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
