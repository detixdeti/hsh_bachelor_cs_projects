using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Stunde
{
    public partial class Form1 : Form
    {

        //Deklariere und initalisiere 
        double ZahlA = 0;
        double ZahlB = 0;
        double SollErgebnis = 0;
        double IstErgebnis = 0;
        int schwierigkeitsgrad;
        int Aufgaben;
        int count = 0;
        double countture = 0;
        double countfalse = 0;


        public Form1()
        {
            InitializeComponent();
        }
        
        private void bntStart_Click(object sender, EventArgs e)
        {
            
            //Schwiergikeitsgrad wird ausgewählt. Damit wählt man die Zahlen aus
            if (comboBox2.SelectedIndex == 0)
            {
                schwierigkeitsgrad = 10;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                schwierigkeitsgrad = 50;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                schwierigkeitsgrad = 100;
            }

            //Aufgaben auswählen 

            if(comboBox1.SelectedIndex == 0)
            {
                Aufgaben = 2;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Aufgaben = 4;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Aufgaben = 8;
            }

            //Berechnungsart wird ausgewählt und als Operator unten angezeigt
            if (radplus.Checked == true)
            {
                lblOperator.Text = "+";
            }
            else if (radminus.Checked == true)
            {
                lblOperator.Text = "-";
            }
            else if (radmal.Checked == true)
            {
                lblOperator.Text = "*";
            }
            else if (raddiv.Checked == true)
            {
                raddiv.Text = "/";
            }

            //Die Ersten einstellungen werden von der Zweiten Groupbox "überlagert" man sieht 
            //die alten Einstellungen nicht mehr un der Rechenmodus fängt an
            groupBox2.Enabled = true;
            groupBox2.Visible = true;

            //Prüfen wird als Button erstmal ausgeschaltet damit es keine Error gibt

            btnPrüfen.Enabled = false;
            btnZufall.Enabled = true;

        }

        private void btnZufall_Click(object sender, EventArgs e)
        {

            //erstellt neuen Zufallsgenerator
            Random zufall = new Random();
            //Bereich für Zufallsgenerator
            ZahlA = zufall.Next(0, schwierigkeitsgrad);
            //Zufallszahl wird in lblZahl ausgegeben
            lblZahlA.Text = ZahlA.ToString(); 
            ZahlB = zufall.Next(0, schwierigkeitsgrad);
            lblZahlB.Text = ZahlB.ToString();

            //Man kann keine anderen Zufallszahlen auswählen und muss mit den ersten Ausgegeben rechnen
            btnZufall.Enabled = false;

            //Count wird für ein Label gebraucht um sie Anzahl der Aufgaben und der erledigten auszugeben
            count++;
            lblCoun.Text = "Aufgabe " + count + " von " + Aufgaben;

            //Textfeld wird geleert
            txtSollErgebnis.Text = "";
            lblIstErgebnis.Text = "";
            lblFT.Text = "";
            lblFT.BackColor = Color.Transparent;
            lblIstErgebnis.Text = "";

            //Prüfen wird wieder enable
            btnPrüfen.Enabled = true;

            if (radplus.Checked == true)
            {
                
                lblOperator.Text = "+";

            }
            else if (radminus.Checked == true)
            {
                
                lblOperator.Text = "-";
            }
            else if (radmal.Checked == true)
            {
                
                lblOperator.Text = "*";
            }
            else if (raddiv.Checked == true)
            {
                
                lblOperator.Text = "/";
            }
        }

        private void btnPrüfen_Click(object sender, EventArgs e)
        {
            //Punkte werden durch ein Komma ersetzt bei den beiden Textfelder
            txtSollErgebnis.Text = txtSollErgebnis.Text.Replace(".", ",");
            //Die Zahlen im Textfeld werden zu einem Double Conventiert
            //Fehleranzeige wenn es nicht gültig ist.
            try
            {
                SollErgebnis = Convert.ToDouble(txtSollErgebnis.Text);

            }
            catch
            {
                MessageBox.Show("Bitte gültige Zahlen eingeben");
                // Mit dem Befehl wird die aufgabe nicht gezählt wenn da ausversehen ein buchstabe eingefügt worden ist
                return;
            }

           

            //Man kann wieder Zahlen generieren  und Prüfen wir ausgeschaltet

            btnZufall.Enabled = true;
            btnPrüfen.Enabled = false;

            //Es wird gerechnet und als IstErgebnis ausgeworfen
            if (radplus.Checked == true)
            {
                IstErgebnis = ZahlA + ZahlB ;
                lblOperator.Text = "+";

            }
            else if (radminus.Checked == true)
            {
                IstErgebnis = ZahlA - ZahlB;
                lblOperator.Text = "-";
            }
            else if (radmal.Checked == true)
            {
                IstErgebnis = ZahlA * ZahlB;
                lblOperator.Text = "*";
            }
            else if (raddiv.Checked == true)
            {
                IstErgebnis = ZahlA / ZahlB;
                lblOperator.Text = "/";
                Math.Round(IstErgebnis, 2);
            }

           
            //Das Ist Ergebniss wird mit dem von User eingetippten SollErgebnis verglichen 
            if (SollErgebnis == IstErgebnis)
            {
                //Wenn es richtig ist wird countTrue gezählt
                countture += 1;
                //Ein Tetfeld wird unter dem Ist Ergebnis erscheinen und zeigen ob es richtig oder falsch war
                lblFT.Text = "Richtig!";
                lblFT.BackColor = Color.Green;

                
            }
            else
            {
                countfalse += 1;
                lblFT.Text = "Falsch!";
                lblFT.BackColor = Color.Red;

                //Ist Ergebnis wird angezeigt
                lblIstErgebnis.Text = "Das Richtige Ergebnis wäre = " + IstErgebnis.ToString("#0.00");

            }


            //Treffer und Fehleranzeige wird aktualisiert 
            lblF.Text = "Du hast " + countfalse + " Falsch(e)";
            lblT.Text = "Du hast " + countture + " Richtig(e)" ;

            
            //Wenn die Aufgaben erledigt worden sind ist nurnoch der reset Button verfügbar

            if (count == Aufgaben)
            {
                btnZufall.Enabled = false;
                btnPrüfen.Enabled = false;

                //Wenn die Aufgabenzahl erreicht worden ist kommt eine Meldung wo gesagt wird gehe auf reset
                MessageBox.Show(" Du hast die Aufgaben alle erledigt. Klicke auf reset um wieder am Anfang zu gelanden.");

            }

            //Ein Prozentwert der richtigen Ergebnisse wird ausgerechnet
            double prozent = (countture / (countture + countfalse)) * 100;
            lblProzentsatz.Text = "Prozentsatz = " + prozent.ToString("#0.00") + " %";



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
          

            Application.Restart();
        }

        private void lblBerechnungsart_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Wenn der User bzw. das Kind hilfe braucht drückt er auf Hilfe und diese Nachricht erscheint ihm !
            MessageBox.Show("Als erstes wählst du eine Rechenart aus(plus, minus oder so),\n " +
                "dass machst du indem du auf den auf den Button drauf klickst. \n" +
                "Nun wählst du aus wie viele Aufgaben du haben willst mit dennen du dich testen willst.\n" +
                "Wenn du das gemacht hast wählst du nun ein Schwierigkeitsgrad aus.\n " +
                "Leicht = Zahlen von 0-9. // \n" +
                "Mittel = Zahlen von 10-49 // \n" +
                "Schwer = Zahlen von 50-99 // \n" +
                " Wenn du auf Start klickst wirst du auf eine ander Seite hingeleitet, dort musst \n" +
                " du zuerst zwei Zufallszahlen generieren, dass machst du indem du auf Zufallszahlen \n " +
                "generieren drückst. Dann musst du nurnoch dein Ergebnis eintragen und es Prüfen. \n " +
                "Unten wird es dir statistisch ausgeworfen");
        }
    }
}
