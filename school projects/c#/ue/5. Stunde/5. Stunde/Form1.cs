using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Stunde
{
    public partial class Form1 : Form
    {
        //Deklariere und initalisiere 
        double a = 0;
        double b = 0;
        double gamma = 0;
        double c = 0;
        double gammaDEG = 0;

        double alpha = 0;
        double beta = 0;

        int grenzwert = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //Kosinussatz !!!!
        private void button1_Click(object sender, EventArgs e)
        {
            //in die nächste Groupbox mit einem Hinweis
            groupBox2.Visible = true;
            MessageBox.Show("Wenn Sie nun ihre Maus auf das Bild halten, wird Ihnen der Vorgang nochmal näher erläutert!");

        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            //Die Grenzwerte für die Nachkommastellen werden hier angeben
            if (comboBox1.SelectedIndex == 0)
            {
                grenzwert = 1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                grenzwert = 3;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                grenzwert = 4;
            }
            else
            {
                grenzwert = 2;
            }



            //Kommas werden durch Punkte ersetzt
            txtA.Text = txtA.Text.Replace(".", ",");
            txtB.Text = txtB.Text.Replace(".", ",");
            txtGamma.Text = txtGamma.Text.Replace(".", ",");

            //Convert Wenn es nicht geht = Fehlermeldung und Return 
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                gamma = Convert.ToDouble(txtGamma.Text);



                a = Math.Round(a, grenzwert);
                b = Math.Round(b, grenzwert);
                gammaDEG = Math.Round(gammaDEG, grenzwert);
            }
            catch
            {
                //Fehlermeldung und Programm geht nicht weiter
                MessageBox.Show("Bitte überprüfen Sie Ihre eingaben, ihre Eingaben sind momentan nicht gültig");
                return;
            }
            if (gamma > 180)
            {
                MessageBox.Show("Gamma soll unter 180 Grad sein! Ach Herr Steinke");
                return;
            }
            gammaDEG = gamma * ((Math.PI / 180)); //Hier wird nochmal RAD in DEG umgewandelt

            //c Wird ausgerechnet 
            c = Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)) - ((2 * a * b) * Math.Cos(gammaDEG)));
            c = Math.Round(c, grenzwert); //nachkommestelle

            //c wird in einem satz ausgegeben 
            txtlc.Text = "c = " + c.ToString() + " = √(" + a + "² +" + b + "² - 2 * " + a + " * " + b + " * cos⁡(" + gamma + ")";

            //Alpha ausrechen α = arccos( (b² + c² - a²) / 2bc )

            alpha = (Math.Acos((Math.Pow(b, 2)) + (Math.Pow(c, 2)) - (Math.Pow(a, 2)) / (2 * a * b)));
            alpha = alpha * (180 / Math.PI); //Hier wird nochmal DEG in RAD  umgewandelt
            alpha = Math.Round(alpha, grenzwert); //nachkommestelle
            txtlalpha.Text = "α = " + alpha.ToString() + " = arccos( (b² + c² - a²) / 2bc )";


            //Beta ausrechen β = arccos( (a² + c² - b²) / 2ac )

            beta = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c));
            beta = beta * (180 / Math.PI); //Hier wird nochmal RAD in DEG  umgewandelt
            beta = Math.Round(beta, grenzwert); //nachkommestelle
            txtlbeta.Text = "β = " + beta.ToString() + " = arccos( (a² + c² - b²) / 2ac )";
        }

        private void btnca_Click(object sender, EventArgs e)
        {
            txtA.Text = "";  //Die Textfelder werden geleert
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtB.Text = ""; //Die Textfelder werden geleert
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtGamma.Text = ""; //Die Textfelder werden geleert
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtA.Text = "";  //Die Textfelder werden geleert
            txtB.Text = "";
            txtGamma.Text = "";
            comboBox1.SelectedIndex = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Link öffnen
            System.Diagnostics.Process.Start("https://www.change.org/p/european-parliament-stop-the-censorship-machinery-save-the-internet?utm_source=share_petition&utm_medium=copylink&utm_campaign=share_petition");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hilfanzeige wird ausgezeigt
            MessageBox.Show("Klick auf Start -> \n  gibt die Seiten a und b an in der Einheit m -> \n " +
                "gib Gamma an -> \n klicke auf Berechnen und es wird dir dein gesuchter Wert ausgegeben in dem Fall c. \n " +
                "Klicke auf löschen und alle Werte werden gelöscht und du hast die neue möglichkeit alles einzugeben. " +
                "(Dies geht auch einzelnt wenn du auf C klickts \n Bitte wähle noch deine Nachkommastelle \n " +
                "Ich wünsche Ihnen viel Spaß mit ihrem Mathe Rechner!");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Ereignisseeee !!!!!!!! AB jetzt !!!_____________________________________________________________

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            //Das Ereignisse wenn man die Maus über das Bild bewegt!    
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            //Das Ereignisse wenn man die Maus über das Bild bewegt!     
            pictureBox4.Visible = false;
        }
        private void btnPatention_MouseEnter(object sender, EventArgs e)
        {
            //Wenn der User über den Button geht wird er Grün
            btnPatention.BackColor = Color.Green;
        }

        private void btnPatention_MouseLeave(object sender, EventArgs e)
        {
            //Wenn der User von den Button geht wird er Silber
            btnPatention.BackColor = Color.Silver;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //Wenn der User über den Button geht wird er Blau
            button2.BackColor = Color.Blue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            //Wenn der User von den Button geht wird er Silber
            button2.BackColor = Color.Silver;
        }
        private void btnBerechnen_MouseEnter(object sender, EventArgs e)
        {
            lblc_2.Visible = true;
            //Die Grenzwerte für die Nachkommastellen werden hier angeben
            if (comboBox1.SelectedIndex == 0)
            {
                grenzwert = 1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                grenzwert = 3;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                grenzwert = 4;
            }
            else
            {
                grenzwert = 2;
            }

            //Kommas werden durch Punkte ersetzt
            txtA.Text = txtA.Text.Replace(".", ",");
            txtB.Text = txtB.Text.Replace(".", ",");
            txtGamma.Text = txtGamma.Text.Replace(".", ",");

            //Convert Wenn es nicht geht = Fehlermeldung und Return 
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                gamma = Convert.ToDouble(txtGamma.Text);

                gammaDEG = gamma * ((Math.PI / 180)); //Hier wird nochmal RAD in DEG umgewandelt

                a = Math.Round(a, grenzwert);
                b = Math.Round(b, grenzwert);
                gammaDEG = Math.Round(gammaDEG, grenzwert);

                //c Wird ausgerechnet 
                c = Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)) - ((2 * a * b) * Math.Cos(gammaDEG)));
                c = Math.Round(c, grenzwert); //nachkommestelle

                lblc_2.Text = "c = " + c.ToString();
            }
            catch
            {

            }
        }

        private void btnBerechnen_MouseLeave(object sender, EventArgs e)
        {
            lblc_2.Visible = false;
        }
        //Rechtwinklinge Dreiecke bzw Satz des Pythagoras!!!!!!!!!!!!!!________________________________

        private void button6_Click_2(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }
        //Deklariere erneut!!!

        double RWD_Seite_1 = 0;
        double RWD_Seite_2 = 0;

        double RWD_Lösung = 0;

        int RWD_Grenzwert = 0;


        private void btnH_Berechnen_Click(object sender, EventArgs e)
        {
            //Grenzwert wird hinzugefügt  bzw Nachkommastelle
            if (comboBox_RWD_Grenzwert.SelectedIndex == 0)
            {
                RWD_Grenzwert = 1;
            }
            else if (comboBox_RWD_Grenzwert.SelectedIndex == 2)
            {
                RWD_Grenzwert = 3;
            }
            else
            {
                RWD_Grenzwert = 2;
            }

            //Punkt wird durch komma ersetzt
            txt_RWD_Seite1.Text = txt_RWD_Seite1.Text.Replace(".", ",");
            txt_RWD_Seite2.Text = txt_RWD_Seite2.Text.Replace(".", ",");
            //Konventiert in die Zahl
            try
            {
                RWD_Seite_1 = Convert.ToDouble(txt_RWD_Seite1.Text);
                RWD_Seite_2 = Convert.ToDouble(txt_RWD_Seite2.Text);
            }
            catch
            {
                MessageBox.Show("Bitte Überprüfen Sie ihre Eingaben, das System sagt sie haben ein Fehler!");
                return;
            }
            if (comboBox_Seite_2.SelectedIndex == 0)
            {

            }
            else if (comboBox_Seite_2.SelectedIndex == 1)
            {

            }
            else
            {
                MessageBox.Show("Sie müssen für die Seite 2 eine Variable in der Combobox auswählen");
                return;
            }
            //Richtiger Rechen Act
            if (comboBox_Seite_2.SelectedIndex == 1)
            {
                //Überprüft wird ob c größer als die andere Variable ist und es wird drauf hingewiesen
                if (RWD_Seite_1 > RWD_Seite_2)
                {
                    MessageBox.Show("Die Seite a ist größer oder gleich wie die Seite c. Dies ist nicht möglich überarbeiten Sie nochmal Ihre Eingaben");
                    return;
                }
                // c wird ausgerechnet
                RWD_Lösung = Math.Sqrt(Math.Pow(RWD_Seite_2, 2) - Math.Pow(RWD_Seite_1, 2));
                RWD_Lösung = Math.Round(RWD_Lösung, RWD_Grenzwert);
            }
            else if (comboBox_Seite_2.SelectedIndex == 0)
            {
                //b Wird ausgerechnet
                RWD_Lösung = Math.Sqrt(Math.Pow(RWD_Seite_1, 2) + Math.Pow(RWD_Seite_2, 2));
                RWD_Lösung = Math.Round(RWD_Lösung, RWD_Grenzwert);
            }

            txt_RWD_Lösung.Text = "Die Seite die Sie suchen beeinhaltet " + RWD_Lösung + " Längeneinheiten";
        }

        private void btn_1_C_Click(object sender, EventArgs e)
        {
            txt_RWD_Seite1.Text = "";
        }

        private void btn_2_c_Click(object sender, EventArgs e)
        {
            txt_RWD_Seite2.Text = "";
        }

        private void btnH_Berechnen_MouseEnter(object sender, EventArgs e)
        {
            btnH_Berechnen.BackColor = Color.Green;
        }

        private void btnH_Berechnen_MouseLeave(object sender, EventArgs e)
        {
            btnH_Berechnen.BackColor = Color.Silver;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //__________________________________________________________________
        private void btnPatention_Enter(object sender, EventArgs e)
        {
        }
        private void btnPatention_Leave(object sender, EventArgs e)
        {
        }
        private void button2_Enter(object sender, EventArgs e)
        {
        }
        private void button2_Leave(object sender, EventArgs e)
        {
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
        }
        private void lblAlpha_Click(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void lblB_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox2_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
        }
        private void txtlbeta_TextChanged(object sender, EventArgs e)
        {
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
