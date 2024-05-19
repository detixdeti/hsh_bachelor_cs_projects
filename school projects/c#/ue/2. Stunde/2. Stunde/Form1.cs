using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Stunde
{
    public partial class Form1 : Form
    {
        //Deklarieren der Zahlen und des Randoms
        int zahl1 = 0, zahl2 = 0, ergebniss = 0;
        Random rdn = new Random();

        private void lbl_zahl2_Click(object sender, EventArgs e)
        {
            //Die Zahl 2 wird auf ein Random gesetzt zwischen 1-100
            zahl2 = rdn.Next(1, 101);
            //Der Text des Labels wird auf die Zahl angepasst
            lbl_zahl2.Text = "Zahl 2 = " + zahl2.ToString();
        }

        private void btn_zahl_Click(object sender, EventArgs e)
        {
            //Die Zahl 1 und 2 wird auf ein Random gesetzt zwischen 1-100
            zahl2 = rdn.Next(1, 101);
            zahl1 = rdn.Next(1, 101);
            //Der Text des Labels wird auf die Zahl angepasst
            lbl_zahl2.Text = "Zahl 2 = " + zahl2.ToString();
            lbl_zahl1.Text = "Zahl 1 = " + zahl1.ToString();
        }
        private void lbl_zahl1_Click(object sender, EventArgs e)
        {
            //Die Zahl 1 wird auf ein Random gesetzt zwischen 1-100
            zahl1 = rdn.Next(1, 101);
            //Der Text des Labels wird auf die Zahl angepasst
            lbl_zahl1.Text = "Zahl 1 = " + zahl1.ToString();
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            //Zahl 1 wird minus der Zahl 2 genommen und als int Ergebniss gespeichert
            ergebniss = zahl1 - zahl2;
            //Das ERgebniss wird durch den ToString als Zahl in dem Labeltextfeld angegeben
            lbl_Ergebniss.Text = "Ergebnis = " + ergebniss.ToString();
            Art.Text = "-"; //zwischen den Zahlen steht ein "-"
        }

        private void btn_addieren_Click(object sender, EventArgs e)
        {
            //mit addieren meinte ich geteilt !!!!! und int wird als double umgeändert
            //Zahl 1 wird geteilt durch der Zahl 2 und als int Ergebniss gespeichert
            double ergebniss = (double) zahl1 / zahl2;
            ergebniss = zahl1 / zahl2;
            //Das ERgebniss wird durch den ToString als Zahl in dem Labeltextfeld angegeben
            lbl_Ergebniss.Text = "Ergebnis = " + ergebniss.ToString();
            Art.Text = "/"; //zwischen den Zahlen steht ein "/"
        }

        private void btn_multiplizieren_Click(object sender, EventArgs e)
        {
            //Zahl 1 wird mal der Zahl 2 genommen und als int Ergebniss gespeichert
            ergebniss = zahl1 * zahl2;
            //Das ERgebniss wird durch den ToString als Zahl in dem Labeltextfeld angegeben
            lbl_Ergebniss.Text = "Ergebnis = " + ergebniss.ToString();
            Art.Text = "*"; //zwischen den Zahlen steht ein "*"
        }

        private void reset_Click(object sender, EventArgs e)
        {
            lbl_Ergebniss.Text = "Ergebniss";
            lbl_zahl1.Text = "Zahl 1";
            lbl_zahl2.Text = "Zahl 2";
            ergebniss = 0;
            zahl1 = 0;
            zahl2 = 0;
            Art.Visible = false;
            
        }

        private void Art_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            //Zahl 1 wird plus der Zahl 2 genommen und als int Ergebniss gespeichert
            ergebniss = zahl1 + zahl2;
            //Das ERgebniss wird durch den ToString als Zahl in dem Labeltextfeld angegeben
            lbl_Ergebniss.Text = "Ergebnis = " + ergebniss.ToString();
            Art.Text = "+"; //zwischen den Zahlen steht ein "+"
        }

        public Form1()
        {
            InitializeComponent();

            
        }

       
    }
}
