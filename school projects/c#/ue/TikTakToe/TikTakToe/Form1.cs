using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTakToe
{
    public partial class TikTakToe : Form
    {

        bool s1 = true ;
        bool s2 = false;

        string cross = "X";
        string circle = "O";

        string Spieler_1;
        string Spieler_2;

        int cross_s =0;
        int circle_s = 0;

        public TikTakToe()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn1_1.Enabled = true;
            btn1_2.Enabled = true;
            btn1_3.Enabled = true;
            btn2_1.Enabled = true;
            btn2_2.Enabled = true;
            btn2_3.Enabled = true;
            btn3_1.Enabled = true;
            btn3_2.Enabled = true;
            btn3_3.Enabled = true;
            btn_start.Enabled = false;
            btn_start.Visible = false;
            txt_s1.Enabled = false;
            txt_s2.Enabled = false;

            try
            {
                Spieler_1 = txt_s1.Text;
                Spieler_2 = txt_s2.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Überprüfen Sie ihre Eingabe");
                return;
            }



        }

        private void btn1_1_Click(object sender, EventArgs e)
        {
            if (s1 == true)
            {
                btn1_1.Text = cross;
                s1 = false;
                s2 = true;
            }
            else if(s2 == true)
            {
                btn1_1.Text = circle;
                s1 = true;
                s2 = false;
            }
            btn1_1.Enabled = false;


            if ((btn1_1.Text == cross && btn1_2.Text == cross && btn1_3.Text == cross) ||
               (btn2_1.Text == cross && btn2_2.Text == cross && btn2_3.Text == cross) ||
               (btn3_1.Text == cross && btn3_2.Text == cross && btn3_3.Text == cross) ||
               (btn1_1.Text == cross && btn2_1.Text == cross && btn3_1.Text == cross) ||
               (btn1_2.Text == cross && btn2_2.Text == cross && btn3_2.Text == cross) ||
               (btn1_3.Text == cross && btn2_3.Text == cross && btn3_3.Text == cross) ||
               (btn1_1.Text == cross && btn2_2.Text == cross && btn3_3.Text == cross) ||
               (btn1_3.Text == cross && btn2_2.Text == cross && btn3_1.Text == cross))
            {
                cross_s = cross_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lblX.Text = "Spieler (X) " + Spieler_1 + " | " + cross_s;
                picb_cross.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 1 hat gewonnen! Herzlichen Glückwunsch " + Spieler_1 + " !";
                MessageBox.Show("Spieler 1 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_1 + "! Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");
                s1 = true;
                s2 = false;
            }
            else if ((btn1_1.Text == circle && btn1_2.Text == circle && btn1_3.Text == circle) ||
               (btn2_1.Text == circle && btn2_2.Text == circle && btn2_3.Text == circle) ||
               (btn3_1.Text == circle && btn3_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_1.Text == circle && btn3_1.Text == circle) ||
               (btn1_2.Text == circle && btn2_2.Text == circle && btn3_2.Text == circle) ||
               (btn1_3.Text == circle && btn2_3.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_3.Text == circle && btn2_2.Text == circle && btn3_1.Text == circle))
            {
                circle_s = circle_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lbl_O.Text = "Spieler (O) " + Spieler_2 + " | " + circle_s;
                picb_circle.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 2 hat gewonnen! Herzlichen Glückwunsch " + Spieler_2 + " !";
                MessageBox.Show("Spieler 2 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_2 + "!  Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");

            }
            else if ((btn1_1.Enabled == false && btn1_2.Enabled == false && btn1_3.Enabled == false && btn2_1.Enabled == false && btn2_2.Enabled == false && btn2_3.Enabled == false && btn3_1.Enabled == false && btn3_2.Enabled == false && btn3_3.Enabled == false))
            {
                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                picb_cc.Location = new Point(25, 48);
                lbl_gewinner.Text = "Neue Runde neues Glück Spieler 1 " + Spieler_1 + " und Spieler 2 " + Spieler_2 + " Viel Erfolg!";
            }

        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            if (s1 == true)
            {
                btn1_2.Text = cross;
                s1 = false;
                s2 = true;
            }
            else if (s2 == true)
            {
                btn1_2.Text = circle;
                s1 = true;
                s2 = false;
            }
            btn1_2.Enabled = false;

            if ((btn1_1.Text == cross && btn1_2.Text == cross && btn1_3.Text == cross) ||
              (btn2_1.Text == cross && btn2_2.Text == cross && btn2_3.Text == cross) ||
              (btn3_1.Text == cross && btn3_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_1.Text == cross && btn3_1.Text == cross) ||
              (btn1_2.Text == cross && btn2_2.Text == cross && btn3_2.Text == cross) ||
              (btn1_3.Text == cross && btn2_3.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_3.Text == cross && btn2_2.Text == cross && btn3_1.Text == cross))
            {
                cross_s = cross_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lblX.Text = "Spieler (X) " + Spieler_1 + " | " + cross_s;
                picb_cross.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 1 hat gewonnen! Herzlichen Glückwunsch " + Spieler_1 + " !";
                MessageBox.Show("Spieler 1 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_1 + "! Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");
                s1 = true;
                s2 = false;
            }
            else if ((btn1_1.Text == circle && btn1_2.Text == circle && btn1_3.Text == circle) ||
               (btn2_1.Text == circle && btn2_2.Text == circle && btn2_3.Text == circle) ||
               (btn3_1.Text == circle && btn3_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_1.Text == circle && btn3_1.Text == circle) ||
               (btn1_2.Text == circle && btn2_2.Text == circle && btn3_2.Text == circle) ||
               (btn1_3.Text == circle && btn2_3.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_3.Text == circle && btn2_2.Text == circle && btn3_1.Text == circle))
            {
                circle_s = circle_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lbl_O.Text = "Spieler (O) " + Spieler_2 + " | " + circle_s;
                picb_circle.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 2 hat gewonnen! Herzlichen Glückwunsch " + Spieler_2 + " !";
                MessageBox.Show("Spieler 2 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_2 + "!  Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");

            }
            else if ((btn1_1.Enabled == false && btn1_2.Enabled == false && btn1_3.Enabled == false && btn2_1.Enabled == false && btn2_2.Enabled == false && btn2_3.Enabled == false && btn3_1.Enabled == false && btn3_2.Enabled == false && btn3_3.Enabled == false))
            {
                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                picb_cc.Location = new Point(25, 48);
                lbl_gewinner.Text = "Neue Runde neues Glück Spieler 1 " + Spieler_1 + " und Spieler 2 " + Spieler_2 + " Viel Erfolg!";
            }

        }

        private void btn1_3_Click(object sender, EventArgs e)
        {
            if (s1 == true)
            {
                btn1_3.Text = cross;
                s1 = false;
                s2 = true;
            }
            else if (s2 == true)
            {
                btn1_3.Text = circle;
                s1 = true;
                s2 = false;
            }
            btn1_3.Enabled = false;

            

        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            if (s1 == true)
            {
                btn2_1.Text = cross;
                s1 = false;
                s2 = true;
            }
            else if (s2 == true)
            {
                btn2_1.Text = circle;
                s1 = true;
                s2 = false;
            }
            btn2_1.Enabled = false;

            if ((btn1_1.Text == cross && btn1_2.Text == cross && btn1_3.Text == cross) ||
              (btn2_1.Text == cross && btn2_2.Text == cross && btn2_3.Text == cross) ||
              (btn3_1.Text == cross && btn3_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_1.Text == cross && btn3_1.Text == cross) ||
              (btn1_2.Text == cross && btn2_2.Text == cross && btn3_2.Text == cross) ||
              (btn1_3.Text == cross && btn2_3.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_3.Text == cross && btn2_2.Text == cross && btn3_1.Text == cross))
            {
                cross_s = cross_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lblX.Text = "Spieler (X) "  + " | " + cross_s;
                picb_cross.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 1 hat gewonnen! Herzlichen Glückwunsch " + Spieler_1 + " !";
                MessageBox.Show("Spieler 1 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_1 + "! Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");
                s1 = true;
                s2 = false;
            }
            else if ((btn1_1.Text == circle && btn1_2.Text == circle && btn1_3.Text == circle) ||
               (btn2_1.Text == circle && btn2_2.Text == circle && btn2_3.Text == circle) ||
               (btn3_1.Text == circle && btn3_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_1.Text == circle && btn3_1.Text == circle) ||
               (btn1_2.Text == circle && btn2_2.Text == circle && btn3_2.Text == circle) ||
               (btn1_3.Text == circle && btn2_3.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_3.Text == circle && btn2_2.Text == circle && btn3_1.Text == circle))
            {
                circle_s = circle_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lbl_O.Text = "Spieler (O) " + " | " + circle_s;
                picb_circle.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 2 hat gewonnen! Herzlichen Glückwunsch " + Spieler_2 + " !";
                MessageBox.Show("Spieler 2 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_2 + "!  Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");

            }
            else if ((btn1_1.Enabled == false && btn1_2.Enabled == false && btn1_3.Enabled == false && btn2_1.Enabled == false && btn2_2.Enabled == false && btn2_3.Enabled == false && btn3_1.Enabled == false && btn3_2.Enabled == false && btn3_3.Enabled == false))
            {
                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                picb_cc.Location = new Point(25, 48);
                lbl_gewinner.Text = "Neue Runde neues Glück Spieler 1 " + Spieler_1 + " und Spieler 2 " + Spieler_2 + " Viel Erfolg!";
            }

        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            if (s1 == true)
            {
                btn2_2.Text = cross;
                s1 = false;
                s2 = true;
            }
            else if (s2 == true)
            {
                btn2_2.Text = circle;
                s1 = true;
                s2 = false;
            }
            btn2_2.Enabled = false;


            if ((btn1_1.Text == cross && btn1_2.Text == cross && btn1_3.Text == cross) ||
              (btn2_1.Text == cross && btn2_2.Text == cross && btn2_3.Text == cross) ||
              (btn3_1.Text == cross && btn3_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_1.Text == cross && btn3_1.Text == cross) ||
              (btn1_2.Text == cross && btn2_2.Text == cross && btn3_2.Text == cross) ||
              (btn1_3.Text == cross && btn2_3.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_3.Text == cross && btn2_2.Text == cross && btn3_1.Text == cross))
            {
                cross_s = cross_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lblX.Text = "Spieler (X) " + " | " + cross_s;
                picb_cross.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 1 hat gewonnen! Herzlichen Glückwunsch " + Spieler_1 + " !";
                MessageBox.Show("Spieler 1 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_1 + "! Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");
                s1 = true;
                s2 = false;
            }
            else if ((btn1_1.Text == circle && btn1_2.Text == circle && btn1_3.Text == circle) ||
               (btn2_1.Text == circle && btn2_2.Text == circle && btn2_3.Text == circle) ||
               (btn3_1.Text == circle && btn3_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_1.Text == circle && btn3_1.Text == circle) ||
               (btn1_2.Text == circle && btn2_2.Text == circle && btn3_2.Text == circle) ||
               (btn1_3.Text == circle && btn2_3.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_3.Text == circle && btn2_2.Text == circle && btn3_1.Text == circle))
            {
                circle_s = circle_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lbl_O.Text = "Spieler (O) " + " | " + circle_s;
                picb_circle.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 2 hat gewonnen! Herzlichen Glückwunsch " + Spieler_2 + " !";
                MessageBox.Show("Spieler 2 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_2 + "!  Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");

            }
            else if ((btn1_1.Enabled == false && btn1_2.Enabled == false && btn1_3.Enabled == false && btn2_1.Enabled == false && btn2_2.Enabled == false && btn2_3.Enabled == false && btn3_1.Enabled == false && btn3_2.Enabled == false && btn3_3.Enabled == false))
            {
                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                picb_cc.Location = new Point(25, 48);
                lbl_gewinner.Text = "Neue Runde neues Glück Spieler 1 " + Spieler_1 + " und Spieler 2 " + Spieler_2 + " Viel Erfolg!";
            }
        }

        private void btn2_3_Click(object sender, EventArgs e)
        {
            if (s1 == true)
            {
                btn2_3.Text = cross;
                s1 = false;
                s2 = true;
            }
            else if (s2 == true)
            {
                btn2_3.Text = circle;
                s1 = true;
                s2 = false;
            }
            btn2_3.Enabled = false;

            if ((btn1_1.Text == cross && btn1_2.Text == cross && btn1_3.Text == cross) ||
              (btn2_1.Text == cross && btn2_2.Text == cross && btn2_3.Text == cross) ||
              (btn3_1.Text == cross && btn3_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_1.Text == cross && btn3_1.Text == cross) ||
              (btn1_2.Text == cross && btn2_2.Text == cross && btn3_2.Text == cross) ||
              (btn1_3.Text == cross && btn2_3.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_3.Text == cross && btn2_2.Text == cross && btn3_1.Text == cross))
            {
                cross_s = cross_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lblX.Text = "Spieler (X) "  + " | " + cross_s;
                picb_cross.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 1 hat gewonnen! Herzlichen Glückwunsch " + Spieler_1 + " !";
                MessageBox.Show("Spieler 1 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_1 + "! Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");
                s1 = true;
                s2 = false;
            }
            else if ((btn1_1.Text == circle && btn1_2.Text == circle && btn1_3.Text == circle) ||
               (btn2_1.Text == circle && btn2_2.Text == circle && btn2_3.Text == circle) ||
               (btn3_1.Text == circle && btn3_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_1.Text == circle && btn3_1.Text == circle) ||
               (btn1_2.Text == circle && btn2_2.Text == circle && btn3_2.Text == circle) ||
               (btn1_3.Text == circle && btn2_3.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_3.Text == circle && btn2_2.Text == circle && btn3_1.Text == circle))
            {
                circle_s = circle_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lbl_O.Text = "Spieler (O) "  + " | " + circle_s;
                picb_circle.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 2 hat gewonnen! Herzlichen Glückwunsch " + Spieler_2 + " !";
                MessageBox.Show("Spieler 2 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_2 + "!  Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");

            }
            else if ((btn1_1.Enabled == false && btn1_2.Enabled == false && btn1_3.Enabled == false && btn2_1.Enabled == false && btn2_2.Enabled == false && btn2_3.Enabled == false && btn3_1.Enabled == false && btn3_2.Enabled == false && btn3_3.Enabled == false))
            {
                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                picb_cc.Location = new Point(25, 48);
                lbl_gewinner.Text = "Neue Runde neues Glück Spieler 1 " + Spieler_1 + " und Spieler 2 " + Spieler_2 + " Viel Erfolg!";
            }

        }

        private void btn3_1_Click(object sender, EventArgs e)
        {
            if (s1 == true)
            {
                btn3_1.Text = cross;
                s1 = false;
                s2 = true;
            }
            else if (s2 == true)
            {
                btn3_1.Text = circle;
                s1 = true;
                s2 = false;
            }
            btn3_1.Enabled = false;

            if ((btn1_1.Text == cross && btn1_2.Text == cross && btn1_3.Text == cross) ||
              (btn2_1.Text == cross && btn2_2.Text == cross && btn2_3.Text == cross) ||
              (btn3_1.Text == cross && btn3_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_1.Text == cross && btn3_1.Text == cross) ||
              (btn1_2.Text == cross && btn2_2.Text == cross && btn3_2.Text == cross) ||
              (btn1_3.Text == cross && btn2_3.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_3.Text == cross && btn2_2.Text == cross && btn3_1.Text == cross))
            {
                cross_s = cross_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lblX.Text = "Spieler (X) "  + " | " + cross_s;
                picb_cross.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 1 hat gewonnen! Herzlichen Glückwunsch " + Spieler_1 + " !";
                MessageBox.Show("Spieler 1 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_1 + "! Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");
                s1 = true;
                s2 = false;
            }
            else if ((btn1_1.Text == circle && btn1_2.Text == circle && btn1_3.Text == circle) ||
               (btn2_1.Text == circle && btn2_2.Text == circle && btn2_3.Text == circle) ||
               (btn3_1.Text == circle && btn3_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_1.Text == circle && btn3_1.Text == circle) ||
               (btn1_2.Text == circle && btn2_2.Text == circle && btn3_2.Text == circle) ||
               (btn1_3.Text == circle && btn2_3.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_3.Text == circle && btn2_2.Text == circle && btn3_1.Text == circle))
            {
                circle_s = circle_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lbl_O.Text = "Spieler (O) "  + " | " + circle_s;
                picb_circle.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 2 hat gewonnen! Herzlichen Glückwunsch " + Spieler_2 + " !";
                MessageBox.Show("Spieler 2 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_2 + "!  Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");

            }
            else if ((btn1_1.Enabled == false && btn1_2.Enabled == false && btn1_3.Enabled == false && btn2_1.Enabled == false && btn2_2.Enabled == false && btn2_3.Enabled == false && btn3_1.Enabled == false && btn3_2.Enabled == false && btn3_3.Enabled == false))
            {
                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                picb_cc.Location = new Point(25, 48);
                lbl_gewinner.Text = "Neue Runde neues Glück Spieler 1 " + Spieler_1 + " und Spieler 2 " + Spieler_2 + " Viel Erfolg!";
            }

        }

        private void btn3_2_Click(object sender, EventArgs e)
        {
            if (s1 == true)
            {
                btn3_2.Text = cross;
                s1 = false;
                s2 = true;
            }
            else if (s2 == true)
            {
                btn3_2.Text = circle;
                s1 = true;
                s2 = false;
            }
            btn3_2.Enabled = false;

            if ((btn1_1.Text == cross && btn1_2.Text == cross && btn1_3.Text == cross) ||
              (btn2_1.Text == cross && btn2_2.Text == cross && btn2_3.Text == cross) ||
              (btn3_1.Text == cross && btn3_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_1.Text == cross && btn3_1.Text == cross) ||
              (btn1_2.Text == cross && btn2_2.Text == cross && btn3_2.Text == cross) ||
              (btn1_3.Text == cross && btn2_3.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_3.Text == cross && btn2_2.Text == cross && btn3_1.Text == cross))
            {
                cross_s = cross_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lblX.Text = "Spieler (X) "  + " | " + cross_s;
                picb_cross.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 1 hat gewonnen! Herzlichen Glückwunsch " + Spieler_1 + " !";
                MessageBox.Show("Spieler 1 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_1 + "! Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");
                s1 = true;
                s2 = false;
            }
            else if ((btn1_1.Text == circle && btn1_2.Text == circle && btn1_3.Text == circle) ||
               (btn2_1.Text == circle && btn2_2.Text == circle && btn2_3.Text == circle) ||
               (btn3_1.Text == circle && btn3_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_1.Text == circle && btn3_1.Text == circle) ||
               (btn1_2.Text == circle && btn2_2.Text == circle && btn3_2.Text == circle) ||
               (btn1_3.Text == circle && btn2_3.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_3.Text == circle && btn2_2.Text == circle && btn3_1.Text == circle))
            {
                circle_s = circle_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lbl_O.Text = "Spieler (O) "  + " | " + circle_s;
                picb_circle.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 2 hat gewonnen! Herzlichen Glückwunsch " + Spieler_2 + " !";
                MessageBox.Show("Spieler 2 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_2 + "!  Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");

            }
            else if ((btn1_1.Enabled == false && btn1_2.Enabled == false && btn1_3.Enabled == false && btn2_1.Enabled == false && btn2_2.Enabled == false && btn2_3.Enabled == false && btn3_1.Enabled == false && btn3_2.Enabled == false && btn3_3.Enabled == false))
            {
                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                picb_cc.Location = new Point(25, 48);
                lbl_gewinner.Text = "Neue Runde neues Glück Spieler 1 " + Spieler_1 + " und Spieler 2 " + Spieler_2 + " Viel Erfolg!";
            }

        }

        private void btn3_3_Click(object sender, EventArgs e)
        {
            if (s1 == true)
            {
                btn3_3.Text = cross;
                s1 = false;
                s2 = true;
            }
            else if (s2 == true)
            {
                btn3_3.Text = circle;
                s1 = true;
                s2 = false;
            }
            btn3_3.Enabled = false;

            if ((btn1_1.Text == cross && btn1_2.Text == cross && btn1_3.Text == cross) ||
              (btn2_1.Text == cross && btn2_2.Text == cross && btn2_3.Text == cross) ||
              (btn3_1.Text == cross && btn3_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_1.Text == cross && btn3_1.Text == cross) ||
              (btn1_2.Text == cross && btn2_2.Text == cross && btn3_2.Text == cross) ||
              (btn1_3.Text == cross && btn2_3.Text == cross && btn3_3.Text == cross) ||
              (btn1_1.Text == cross && btn2_2.Text == cross && btn3_3.Text == cross) ||
              (btn1_3.Text == cross && btn2_2.Text == cross && btn3_1.Text == cross))
            {
                cross_s = cross_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lblX.Text = "Spieler (X) " + " | " + cross_s;
                picb_cross.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 1 hat gewonnen! Herzlichen Glückwunsch " + Spieler_1 + " !";
                MessageBox.Show("Spieler 1 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_1 + "! Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");
                s1 = true;
                s2 = false;
            }
            else if ((btn1_1.Text == circle && btn1_2.Text == circle && btn1_3.Text == circle) ||
               (btn2_1.Text == circle && btn2_2.Text == circle && btn2_3.Text == circle) ||
               (btn3_1.Text == circle && btn3_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_1.Text == circle && btn3_1.Text == circle) ||
               (btn1_2.Text == circle && btn2_2.Text == circle && btn3_2.Text == circle) ||
               (btn1_3.Text == circle && btn2_3.Text == circle && btn3_3.Text == circle) ||
               (btn1_1.Text == circle && btn2_2.Text == circle && btn3_3.Text == circle) ||
               (btn1_3.Text == circle && btn2_2.Text == circle && btn3_1.Text == circle))
            {
                circle_s = circle_s + 1;

                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                lbl_O.Text = "Spieler (O) "  + " | " + circle_s;
                picb_circle.Location = new Point(25, 48);

                lbl_gewinner.Text = "Spieler 2 hat gewonnen! Herzlichen Glückwunsch " + Spieler_2 + " !";
                MessageBox.Show("Spieler 2 hat gewonnen!! Herzlichen Glückwunsch " + Spieler_2 + "!  Drücken Sie nun bitte auf das Bild wenn sie weiterspielen wollen, bei einer neuen Runde bitte auf Neustarten klicken!!");

            }
            else if ((btn1_1.Enabled == false && btn1_2.Enabled == false && btn1_3.Enabled == false && btn2_1.Enabled == false && btn2_2.Enabled == false && btn2_3.Enabled == false && btn3_1.Enabled == false && btn3_2.Enabled == false && btn3_3.Enabled == false))
            {
                btn1_1.Enabled = true;
                btn1_2.Enabled = true;
                btn1_3.Enabled = true;
                btn2_1.Enabled = true;
                btn2_2.Enabled = true;
                btn2_3.Enabled = true;
                btn3_1.Enabled = true;
                btn3_2.Enabled = true;
                btn3_3.Enabled = true;
                btn1_1.Text = "";
                btn1_2.Text = "";
                btn1_3.Text = "";
                btn2_1.Text = "";
                btn2_2.Text = "";
                btn2_3.Text = "";
                btn3_1.Text = "";
                btn3_2.Text = "";
                btn3_3.Text = "";

                btn_neustart.Visible = true;
                btn_neustart.Enabled = true;
                picb_cc.Location = new Point(25, 48);
                lbl_gewinner.Text = "Neue Runde neues Glück Spieler 1 " + Spieler_1 + " und Spieler 2 " + Spieler_2 + " Viel Erfolg!";
            }

        }

        private void picb_cc_MouseClick(object sender, MouseEventArgs e)
        {
            picb_cc.Location = new Point(448, 48);
            btn_neustart.Visible = false;
            btn_neustart.Enabled = false;
        }

        private void picb_circle_MouseClick(object sender, MouseEventArgs e)
        {
            picb_circle.Location = new Point(448, 48);
            btn_neustart.Visible = false;
            btn_neustart.Enabled = false;
        }

        private void picb_cross_MouseClick(object sender, MouseEventArgs e)
        {
            picb_cross.Location = new Point(448, 48);
            btn_neustart.Visible = false;
            btn_neustart.Enabled = false;
        }



        private void btn_neustart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void lbl_O_Click(object sender, EventArgs e)
        {

        }
        private void lbl_gewinner_Click(object sender, EventArgs e)
        {

        }

        private void TikTakToe_Load(object sender, EventArgs e)
        {

        }
    }
}
