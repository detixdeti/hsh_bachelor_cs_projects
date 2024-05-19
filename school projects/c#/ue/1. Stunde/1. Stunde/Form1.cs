using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Stunde
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Keep going brother!";
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            button1.Visible = true;
            button2.Visible = true;
            label1.Visible = true;
            button3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Antwort_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Gib dein bestes, auch wenn es nicht gut aussieht!";
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            button3.Visible = true;
        }
    }
}
