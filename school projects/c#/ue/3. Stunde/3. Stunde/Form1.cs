using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Stunde
{
    public partial class Form1 : Form
    {
        //Deklariere hier die Objekte und initalisiere Sie
       
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRechne_Click(object sender, EventArgs e)
        {
            double Zahla = 0;
            double Zahlb = 0;
            //Punkte werden durch ein Komma ersetzt bei den beiden Textfelder
            txtZahla.Text = txtZahla.Text.Replace(".", ",");
            txtZahlb.Text = txtZahlb.Text.Replace(".", ",");
            //Die Textfelder werden in Double's konventiert
            //Wenn man eine Buchstaben oder sonstiges eingibt wird eine Fehleranzeige kommen 
            try
            {
                 Zahla = Convert.ToDouble(txtZahla.Text);
                 Zahlb = Convert.ToDouble(txtZahlb.Text);

            }
            catch
            {
                MessageBox.Show("Bitte gültige Zahlen eingeben");
            }
            

            //checken ob Plus ausgewählt ist
            //Ergebnis wird ausgerechnet und ausgegeben im Textfeld
            if (radplus.Checked == true)
            {
                double Ergebniss = Zahla + Zahlb;
                lblErgebniss.Text = "Die Summe von " + txtZahla.Text + " und " + txtZahlb.Text + " ist =" + Ergebniss.ToString("");
                lblArt.Text = "+";
            }
            //checken ob Minus ausgewählt ist 
            //Ergebnis wird ausgerechnet und ausgegeben im Textfeld
            else if (radminus.Checked == true)
            {
                double Ergebniss = Zahla - Zahlb;
                lblErgebniss.Text = "Die Differenz von " + txtZahla.Text + " und " + txtZahlb.Text + " ist =" + Ergebniss.ToString("");
                lblArt.Text = "-";
            }
            //checken ob Div ausgewählt ist 
            //Ergebnis wird ausgerechnet und ausgegeben im Textfeld
            else if (raddiv.Checked == true)
            {
                double Ergebniss = Zahla / Zahlb;
                lblErgebniss.Text = "Der Quotient von " + txtZahla.Text + " und " + txtZahlb.Text + " ist =" + Ergebniss.ToString("#0.00");
                lblArt.Text = "/";
            }
            //checken ob Mal ausgewählt ist //else ist nichts
            //Ergebnis wird ausgerechnet und ausgegeben im Textfeld
            else if (radmal.Checked == true)
            {
                double Ergebniss = Zahla * Zahlb;
                lblErgebniss.Text = "Das Produkt von " + txtZahla.Text + " und " + txtZahlb.Text + " ist =" + Ergebniss.ToString("");
                lblArt.Text = "*";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)

        {
            //Alles wird auf den standart Wert zurückgesetzt
            radmal.Checked = false;
            radminus.Checked = false;
            radplus.Checked = false;
            raddiv.Checked = false;
            txtZahla.Text = "";
            txtZahlb.Text = "";
            lblArt.Text = "";
            lblErgebniss.Text = "";
        }
    }
}
