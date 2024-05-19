using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Würfel_Volumen_und_Oberfläche
{
    public partial class Form1 : Form
    {

        double Würfel_a = 0;
        double Rechteck_a = 0;
        double Rechteck_b = 0;
        double Rechteck_c = 0;

        double Volumen = 0;
        double Oberflache = 0;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void rad_Würfel_CheckedChanged(object sender, EventArgs e)
        {
            //Die Rechteck Sachen werden unsichtbar"
            lbl_Rechteck.Visible = false;
            txt_Rechteck_a.Visible = false;
            txt_Rechteck_b.Visible = false;
            txt_Rechteck_c.Visible = false;

            lbl_Viereck.Visible = true;
            txt_Würfel_a.Visible = true;

            txt_Würfel_a.Text = "";
            txt_Rechteck_a.Text = "";
            txt_Rechteck_b.Text = "";
            txt_Rechteck_c.Text = "";

            lbl_Volumen.Text = "";
            lbl_Oberflache.Text = "";

        }

        private void rad_Rechteck_CheckedChanged(object sender, EventArgs e)
        {
            //Viereck sachen werden unsichtbar
            lbl_Viereck.Visible = false;
            txt_Würfel_a.Visible = false;

            lbl_Rechteck.Visible = true;
            txt_Rechteck_a.Visible = true;
            txt_Rechteck_b.Visible = true;
            txt_Rechteck_c.Visible = true;

            txt_Würfel_a.Text = "";
            txt_Rechteck_a.Text = "";
            txt_Rechteck_b.Text = "";
            txt_Rechteck_c.Text = "";

            lbl_Volumen.Text = "";
            lbl_Oberflache.Text = "";
        }

        private void btn_Berechnen_Click(object sender, EventArgs e)
        {
            if(rad_Würfel.Checked == true)
            {
                txt_Würfel_a.Text = txt_Würfel_a.Text.Replace(".", ",");

                try
                {
                    Würfel_a = Convert.ToDouble(txt_Würfel_a.Text);
                }
                catch
                {
                    MessageBox.Show("Überprüfen Sie Ihre Eingaben.");
                    return;
                }

                Volumen = Würfel_a * Würfel_a * Würfel_a;
                Volumen = Math.Round(Volumen, 2);
                lbl_Volumen.Text = Würfel_a.ToString() + " * " + Würfel_a.ToString() + " * " + Würfel_a.ToString() + " = " + Volumen.ToString() + "m*m*m";

                Oberflache = (Würfel_a * Würfel_a) * 6;
                Oberflache = Math.Round(Oberflache, 2);
                lbl_Oberflache.Text = "( " + Würfel_a.ToString() + " * " + Würfel_a.ToString() + " ) * 6 = " + Oberflache.ToString() + " m*m";

                

               
            }
            else if(rad_Rechteck.Enabled == true)
            {
                txt_Rechteck_a.Text = txt_Rechteck_a.Text.Replace(".", ",");
                txt_Rechteck_b.Text = txt_Rechteck_b.Text.Replace(".", ",");
                txt_Rechteck_c.Text = txt_Rechteck_c.Text.Replace(".", ",");

                try
                {
                    Rechteck_a = Convert.ToDouble(txt_Rechteck_a.Text);
                    Rechteck_b = Convert.ToDouble(txt_Rechteck_b.Text);
                    Rechteck_c = Convert.ToDouble(txt_Rechteck_c.Text);
                }
                catch
                {
                    MessageBox.Show("Bitte überprüfen Sie ihr Eingaben");
                    return;
                }

                Volumen = Rechteck_a * Rechteck_b * Rechteck_c;
                Volumen = Math.Round(Volumen, 2);
                lbl_Volumen.Text = Rechteck_a.ToString() + " * " + Rechteck_b.ToString() + " * " + Rechteck_c.ToString() + " = " + Volumen.ToString() + " m*m*m";

                Oberflache = (2 * (Rechteck_a * Rechteck_b)) + (2 * (Rechteck_a * Rechteck_c)) + (2 * (Rechteck_b * Rechteck_c));
                Oberflache = Math.Round(Oberflache, 2);
                lbl_Oberflache.Text = "2 * (" + Rechteck_a.ToString() + " * " + Rechteck_b.ToString() + ") + 2 * (" + Rechteck_a.ToString() + " * " + Rechteck_c.ToString() + ") + 2 * (" + Rechteck_b.ToString() + " * " + Rechteck_c.ToString() + ") = " + Oberflache.ToString() + " m*m";
                // A=2ab+2ac+2bc
            }
            else
            {
                MessageBox.Show("Wählen Sie zuerst aus ob Sie ein Quader oder ein Würfel ausrechnen wollen!");
            }

            //Alle eingaben werden gespeert bis man nochmal drückt!
            txt_Würfel_a.Enabled = false;
            txt_Rechteck_a.Enabled = false;
            txt_Rechteck_b.Enabled = false;
            txt_Rechteck_c.Enabled = false;
            rad_Rechteck.Enabled = false;
            rad_Würfel.Enabled = false;

            btn_nochmal.Visible = true;
            btn_Berechnen.Visible = false;
        }

        private void btn_nochmal_Click(object sender, EventArgs e)
        {
            txt_Würfel_a.Text = "";
            txt_Rechteck_a.Text = "";
            txt_Rechteck_b.Text = "";
            txt_Rechteck_c.Text = "";

            lbl_Volumen.Text = "";
            lbl_Oberflache.Text = "";

            btn_Berechnen.Visible = true;
            btn_nochmal.Visible = false;

            txt_Würfel_a.Enabled = true;
            txt_Rechteck_a.Enabled = true;
            txt_Rechteck_b.Enabled = true;
            txt_Rechteck_c.Enabled = true;
            rad_Rechteck.Enabled = true;
            rad_Würfel.Enabled = true;

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Quelle Mathematiker!!Sie haben gesagt es muss nicht stimmen was hier steht hauptsache ich weiß wie das geht !!!!");
        }

        private void label4_Move(object sender, EventArgs e)
        {
            
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_min_Click(object sender, EventArgs e)
        {
            
        }
    }
}