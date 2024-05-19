namespace Würfel_Volumen_und_Oberfläche
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Viereck = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Würfel_a = new System.Windows.Forms.TextBox();
            this.btn_Berechnen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Volumen = new System.Windows.Forms.Label();
            this.lbl_Oberflache = new System.Windows.Forms.Label();
            this.rad_Würfel = new System.Windows.Forms.RadioButton();
            this.rad_Rechteck = new System.Windows.Forms.RadioButton();
            this.txt_Rechteck_a = new System.Windows.Forms.TextBox();
            this.lbl_Rechteck = new System.Windows.Forms.Label();
            this.txt_Rechteck_b = new System.Windows.Forms.TextBox();
            this.txt_Rechteck_c = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nochmal = new System.Windows.Forms.Button();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Viereck
            // 
            this.lbl_Viereck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Viereck.Location = new System.Drawing.Point(25, 197);
            this.lbl_Viereck.Name = "lbl_Viereck";
            this.lbl_Viereck.Size = new System.Drawing.Size(137, 32);
            this.lbl_Viereck.TabIndex = 1;
            this.lbl_Viereck.Text = "Kantenlänge";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volumen";
            // 
            // txt_Würfel_a
            // 
            this.txt_Würfel_a.Location = new System.Drawing.Point(226, 203);
            this.txt_Würfel_a.Name = "txt_Würfel_a";
            this.txt_Würfel_a.Size = new System.Drawing.Size(83, 20);
            this.txt_Würfel_a.TabIndex = 3;
            this.txt_Würfel_a.Text = "a";
            // 
            // btn_Berechnen
            // 
            this.btn_Berechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Berechnen.Location = new System.Drawing.Point(225, 405);
            this.btn_Berechnen.Name = "btn_Berechnen";
            this.btn_Berechnen.Size = new System.Drawing.Size(241, 44);
            this.btn_Berechnen.TabIndex = 5;
            this.btn_Berechnen.Text = "Berechnen";
            this.btn_Berechnen.UseVisualStyleBackColor = true;
            this.btn_Berechnen.Click += new System.EventHandler(this.btn_Berechnen_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "O-Fläche";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.Move += new System.EventHandler(this.label4_Move);
            // 
            // lbl_Volumen
            // 
            this.lbl_Volumen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Volumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Volumen.Location = new System.Drawing.Point(225, 302);
            this.lbl_Volumen.Name = "lbl_Volumen";
            this.lbl_Volumen.Size = new System.Drawing.Size(462, 25);
            this.lbl_Volumen.TabIndex = 7;
            // 
            // lbl_Oberflache
            // 
            this.lbl_Oberflache.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Oberflache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Oberflache.Location = new System.Drawing.Point(225, 358);
            this.lbl_Oberflache.Name = "lbl_Oberflache";
            this.lbl_Oberflache.Size = new System.Drawing.Size(462, 25);
            this.lbl_Oberflache.TabIndex = 8;
            // 
            // rad_Würfel
            // 
            this.rad_Würfel.AutoSize = true;
            this.rad_Würfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Würfel.Location = new System.Drawing.Point(525, 195);
            this.rad_Würfel.Name = "rad_Würfel";
            this.rad_Würfel.Size = new System.Drawing.Size(82, 28);
            this.rad_Würfel.TabIndex = 9;
            this.rad_Würfel.TabStop = true;
            this.rad_Würfel.Text = "Würfel";
            this.rad_Würfel.UseVisualStyleBackColor = true;
            this.rad_Würfel.CheckedChanged += new System.EventHandler(this.rad_Würfel_CheckedChanged);
            // 
            // rad_Rechteck
            // 
            this.rad_Rechteck.AutoSize = true;
            this.rad_Rechteck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Rechteck.Location = new System.Drawing.Point(525, 245);
            this.rad_Rechteck.Name = "rad_Rechteck";
            this.rad_Rechteck.Size = new System.Drawing.Size(107, 28);
            this.rad_Rechteck.TabIndex = 10;
            this.rad_Rechteck.TabStop = true;
            this.rad_Rechteck.Text = "Rechteck";
            this.rad_Rechteck.UseVisualStyleBackColor = true;
            this.rad_Rechteck.CheckedChanged += new System.EventHandler(this.rad_Rechteck_CheckedChanged);
            // 
            // txt_Rechteck_a
            // 
            this.txt_Rechteck_a.Location = new System.Drawing.Point(228, 247);
            this.txt_Rechteck_a.Name = "txt_Rechteck_a";
            this.txt_Rechteck_a.Size = new System.Drawing.Size(83, 20);
            this.txt_Rechteck_a.TabIndex = 12;
            this.txt_Rechteck_a.Text = "a";
            // 
            // lbl_Rechteck
            // 
            this.lbl_Rechteck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rechteck.Location = new System.Drawing.Point(27, 241);
            this.lbl_Rechteck.Name = "lbl_Rechteck";
            this.lbl_Rechteck.Size = new System.Drawing.Size(137, 32);
            this.lbl_Rechteck.TabIndex = 11;
            this.lbl_Rechteck.Text = "Kantenlänge";
            // 
            // txt_Rechteck_b
            // 
            this.txt_Rechteck_b.Location = new System.Drawing.Point(327, 247);
            this.txt_Rechteck_b.Name = "txt_Rechteck_b";
            this.txt_Rechteck_b.Size = new System.Drawing.Size(83, 20);
            this.txt_Rechteck_b.TabIndex = 13;
            this.txt_Rechteck_b.Text = "b";
            // 
            // txt_Rechteck_c
            // 
            this.txt_Rechteck_c.Location = new System.Drawing.Point(426, 247);
            this.txt_Rechteck_c.Name = "txt_Rechteck_c";
            this.txt_Rechteck_c.Size = new System.Drawing.Size(83, 20);
            this.txt_Rechteck_c.TabIndex = 14;
            this.txt_Rechteck_c.Text = "c";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 88);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lushaj, Würfel\r\nBitte wählen Sie die Kantenlänge(n),\r\nDas Volumen und das Berechn" +
    "en wird mit dem klicken\r\nauf Button Berechnen errechnet.\r\n";
            // 
            // btn_nochmal
            // 
            this.btn_nochmal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nochmal.Location = new System.Drawing.Point(472, 405);
            this.btn_nochmal.Name = "btn_nochmal";
            this.btn_nochmal.Size = new System.Drawing.Size(215, 44);
            this.btn_nochmal.TabIndex = 16;
            this.btn_nochmal.Text = "Nochmal";
            this.btn_nochmal.UseVisualStyleBackColor = true;
            this.btn_nochmal.Visible = false;
            this.btn_nochmal.Click += new System.EventHandler(this.btn_nochmal_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_exit.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.Location = new System.Drawing.Point(713, 9);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(19, 17);
            this.lbl_exit.TabIndex = 17;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(741, 469);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.btn_nochmal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Rechteck_c);
            this.Controls.Add(this.txt_Rechteck_b);
            this.Controls.Add(this.txt_Rechteck_a);
            this.Controls.Add(this.lbl_Rechteck);
            this.Controls.Add(this.rad_Rechteck);
            this.Controls.Add(this.rad_Würfel);
            this.Controls.Add(this.lbl_Oberflache);
            this.Controls.Add(this.lbl_Volumen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Berechnen);
            this.Controls.Add(this.txt_Würfel_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Viereck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Würfel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Viereck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Würfel_a;
        private System.Windows.Forms.Button btn_Berechnen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Volumen;
        private System.Windows.Forms.Label lbl_Oberflache;
        private System.Windows.Forms.RadioButton rad_Würfel;
        private System.Windows.Forms.RadioButton rad_Rechteck;
        private System.Windows.Forms.TextBox txt_Rechteck_a;
        private System.Windows.Forms.Label lbl_Rechteck;
        private System.Windows.Forms.TextBox txt_Rechteck_b;
        private System.Windows.Forms.TextBox txt_Rechteck_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nochmal;
        private System.Windows.Forms.Label lbl_exit;
    }
}

