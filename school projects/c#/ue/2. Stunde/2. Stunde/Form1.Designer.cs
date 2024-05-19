namespace _2.Stunde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_addieren = new System.Windows.Forms.Button();
            this.btn_multiplizieren = new System.Windows.Forms.Button();
            this.headline = new System.Windows.Forms.Label();
            this.lbl_zahl1 = new System.Windows.Forms.Label();
            this.lbl_zahl2 = new System.Windows.Forms.Label();
            this.lbl_Ergebniss = new System.Windows.Forms.Label();
            this.btn_zahl = new System.Windows.Forms.Button();
            this.Hilfe = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.Art = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Plus
            // 
            this.btn_Plus.Location = new System.Drawing.Point(26, 282);
            this.btn_Plus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(100, 28);
            this.btn_Plus.TabIndex = 0;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Minus
            // 
            this.btn_Minus.Location = new System.Drawing.Point(134, 282);
            this.btn_Minus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(100, 28);
            this.btn_Minus.TabIndex = 1;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_addieren
            // 
            this.btn_addieren.Location = new System.Drawing.Point(242, 282);
            this.btn_addieren.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addieren.Name = "btn_addieren";
            this.btn_addieren.Size = new System.Drawing.Size(100, 28);
            this.btn_addieren.TabIndex = 2;
            this.btn_addieren.Text = "/";
            this.btn_addieren.UseVisualStyleBackColor = true;
            this.btn_addieren.Click += new System.EventHandler(this.btn_addieren_Click);
            // 
            // btn_multiplizieren
            // 
            this.btn_multiplizieren.Location = new System.Drawing.Point(351, 282);
            this.btn_multiplizieren.Margin = new System.Windows.Forms.Padding(4);
            this.btn_multiplizieren.Name = "btn_multiplizieren";
            this.btn_multiplizieren.Size = new System.Drawing.Size(100, 28);
            this.btn_multiplizieren.TabIndex = 3;
            this.btn_multiplizieren.Text = "*";
            this.btn_multiplizieren.UseVisualStyleBackColor = true;
            this.btn_multiplizieren.Click += new System.EventHandler(this.btn_multiplizieren_Click);
            // 
            // headline
            // 
            this.headline.AutoSize = true;
            this.headline.BackColor = System.Drawing.Color.Transparent;
            this.headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.headline.Location = new System.Drawing.Point(26, 69);
            this.headline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headline.Name = "headline";
            this.headline.Size = new System.Drawing.Size(409, 29);
            this.headline.TabIndex = 4;
            this.headline.Text = "Wählen Sie die Art der Berechnung";
            // 
            // lbl_zahl1
            // 
            this.lbl_zahl1.AutoSize = true;
            this.lbl_zahl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_zahl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zahl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_zahl1.Location = new System.Drawing.Point(85, 204);
            this.lbl_zahl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_zahl1.Name = "lbl_zahl1";
            this.lbl_zahl1.Size = new System.Drawing.Size(83, 29);
            this.lbl_zahl1.TabIndex = 5;
            this.lbl_zahl1.Text = "Zahl 1";
            this.lbl_zahl1.Click += new System.EventHandler(this.lbl_zahl1_Click);
            // 
            // lbl_zahl2
            // 
            this.lbl_zahl2.AutoSize = true;
            this.lbl_zahl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_zahl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zahl2.ForeColor = System.Drawing.Color.Snow;
            this.lbl_zahl2.Location = new System.Drawing.Point(289, 204);
            this.lbl_zahl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_zahl2.Name = "lbl_zahl2";
            this.lbl_zahl2.Size = new System.Drawing.Size(83, 29);
            this.lbl_zahl2.TabIndex = 6;
            this.lbl_zahl2.Text = "Zahl 2";
            this.lbl_zahl2.Click += new System.EventHandler(this.lbl_zahl2_Click);
            // 
            // lbl_Ergebniss
            // 
            this.lbl_Ergebniss.AutoSize = true;
            this.lbl_Ergebniss.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ergebniss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ergebniss.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Ergebniss.Location = new System.Drawing.Point(175, 397);
            this.lbl_Ergebniss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ergebniss.Name = "lbl_Ergebniss";
            this.lbl_Ergebniss.Size = new System.Drawing.Size(113, 29);
            this.lbl_Ergebniss.TabIndex = 7;
            this.lbl_Ergebniss.Text = "Ergebnis";
            // 
            // btn_zahl
            // 
            this.btn_zahl.Location = new System.Drawing.Point(151, 144);
            this.btn_zahl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_zahl.Name = "btn_zahl";
            this.btn_zahl.Size = new System.Drawing.Size(160, 31);
            this.btn_zahl.TabIndex = 8;
            this.btn_zahl.Text = "Random Zahlen";
            this.btn_zahl.UseVisualStyleBackColor = true;
            this.btn_zahl.Click += new System.EventHandler(this.btn_zahl_Click);
            // 
            // Hilfe
            // 
            this.Hilfe.Location = new System.Drawing.Point(26, 458);
            this.Hilfe.Name = "Hilfe";
            this.Hilfe.Size = new System.Drawing.Size(425, 125);
            this.Hilfe.TabIndex = 9;
            this.Hilfe.Text = resources.GetString("Hilfe.Text");
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(388, 612);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 10;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Art
            // 
            this.Art.AutoSize = true;
            this.Art.BackColor = System.Drawing.Color.Transparent;
            this.Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Art.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Art.Location = new System.Drawing.Point(238, 212);
            this.Art.Name = "Art";
            this.Art.Size = new System.Drawing.Size(0, 20);
            this.Art.TabIndex = 11;
            this.Art.Click += new System.EventHandler(this.Art_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2.Stunde.Properties.Resources.Foto_Hintergrund_Schatten_1;
            this.ClientSize = new System.Drawing.Size(475, 647);
            this.Controls.Add(this.Art);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Hilfe);
            this.Controls.Add(this.btn_zahl);
            this.Controls.Add(this.lbl_Ergebniss);
            this.Controls.Add(this.lbl_zahl2);
            this.Controls.Add(this.lbl_zahl1);
            this.Controls.Add(this.headline);
            this.Controls.Add(this.btn_multiplizieren);
            this.Controls.Add(this.btn_addieren);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Plus);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_addieren;
        private System.Windows.Forms.Button btn_multiplizieren;
        private System.Windows.Forms.Label headline;
        private System.Windows.Forms.Label lbl_zahl1;
        private System.Windows.Forms.Label lbl_zahl2;
        private System.Windows.Forms.Label lbl_Ergebniss;
        private System.Windows.Forms.Button btn_zahl;
        private System.Windows.Forms.Label Hilfe;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label Art;
    }
}

