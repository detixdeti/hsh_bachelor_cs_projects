namespace _4.Stunde
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCoun = new System.Windows.Forms.Label();
            this.btnZufall = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrüfen = new System.Windows.Forms.Button();
            this.lblProzentsatz = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblFT = new System.Windows.Forms.Label();
            this.lblIstErgebnis = new System.Windows.Forms.Label();
            this.txtSollErgebnis = new System.Windows.Forms.TextBox();
            this.lblgleich = new System.Windows.Forms.Label();
            this.lblZahlB = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblZahlA = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBerechnungsart = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radmal = new System.Windows.Forms.RadioButton();
            this.raddiv = new System.Windows.Forms.RadioButton();
            this.radminus = new System.Windows.Forms.RadioButton();
            this.radplus = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblCoun);
            this.groupBox2.Controls.Add(this.btnZufall);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnPrüfen);
            this.groupBox2.Controls.Add(this.lblProzentsatz);
            this.groupBox2.Controls.Add(this.lblF);
            this.groupBox2.Controls.Add(this.lblT);
            this.groupBox2.Controls.Add(this.lblFT);
            this.groupBox2.Controls.Add(this.lblIstErgebnis);
            this.groupBox2.Controls.Add(this.txtSollErgebnis);
            this.groupBox2.Controls.Add(this.lblgleich);
            this.groupBox2.Controls.Add(this.lblZahlB);
            this.groupBox2.Controls.Add(this.lblOperator);
            this.groupBox2.Controls.Add(this.lblZahlA);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(153, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(787, 446);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblCoun
            // 
            this.lblCoun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoun.Location = new System.Drawing.Point(147, 38);
            this.lblCoun.Name = "lblCoun";
            this.lblCoun.Size = new System.Drawing.Size(437, 39);
            this.lblCoun.TabIndex = 13;
            this.lblCoun.Text = "Drücke hier um Zufallszahlen zu Generieren";
            this.lblCoun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZufall
            // 
            this.btnZufall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZufall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZufall.Location = new System.Drawing.Point(305, 92);
            this.btnZufall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZufall.Name = "btnZufall";
            this.btnZufall.Size = new System.Drawing.Size(141, 34);
            this.btnZufall.TabIndex = 12;
            this.btnZufall.Text = "Generiere";
            this.btnZufall.UseVisualStyleBackColor = true;
            this.btnZufall.Click += new System.EventHandler(this.btnZufall_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(733, 412);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrüfen
            // 
            this.btnPrüfen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrüfen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrüfen.Location = new System.Drawing.Point(469, 149);
            this.btnPrüfen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrüfen.Name = "btnPrüfen";
            this.btnPrüfen.Size = new System.Drawing.Size(91, 27);
            this.btnPrüfen.TabIndex = 11;
            this.btnPrüfen.Text = "Prüfen";
            this.btnPrüfen.UseVisualStyleBackColor = true;
            this.btnPrüfen.Click += new System.EventHandler(this.btnPrüfen_Click);
            // 
            // lblProzentsatz
            // 
            this.lblProzentsatz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProzentsatz.Location = new System.Drawing.Point(248, 238);
            this.lblProzentsatz.Name = "lblProzentsatz";
            this.lblProzentsatz.Size = new System.Drawing.Size(284, 33);
            this.lblProzentsatz.TabIndex = 9;
            this.lblProzentsatz.Text = "Prozentsatz";
            this.lblProzentsatz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(31, 263);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(167, 20);
            this.lblF.TabIndex = 8;
            this.lblF.Text = "Du hast 0 Falsche(e)";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(31, 214);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(160, 20);
            this.lblT.TabIndex = 7;
            this.lblT.Text = "Du hast 0 Richtig(e)";
            // 
            // lblFT
            // 
            this.lblFT.BackColor = System.Drawing.Color.Transparent;
            this.lblFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFT.Location = new System.Drawing.Point(552, 206);
            this.lblFT.Name = "lblFT";
            this.lblFT.Size = new System.Drawing.Size(168, 30);
            this.lblFT.TabIndex = 6;
            this.lblFT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIstErgebnis
            // 
            this.lblIstErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIstErgebnis.Location = new System.Drawing.Point(564, 102);
            this.lblIstErgebnis.Name = "lblIstErgebnis";
            this.lblIstErgebnis.Size = new System.Drawing.Size(168, 71);
            this.lblIstErgebnis.TabIndex = 5;
            this.lblIstErgebnis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtSollErgebnis
            // 
            this.txtSollErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSollErgebnis.Location = new System.Drawing.Point(305, 148);
            this.txtSollErgebnis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSollErgebnis.Name = "txtSollErgebnis";
            this.txtSollErgebnis.Size = new System.Drawing.Size(140, 26);
            this.txtSollErgebnis.TabIndex = 4;
            // 
            // lblgleich
            // 
            this.lblgleich.AutoSize = true;
            this.lblgleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgleich.Location = new System.Drawing.Point(248, 153);
            this.lblgleich.Name = "lblgleich";
            this.lblgleich.Size = new System.Drawing.Size(19, 20);
            this.lblgleich.TabIndex = 3;
            this.lblgleich.Text = "=";
            // 
            // lblZahlB
            // 
            this.lblZahlB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZahlB.Location = new System.Drawing.Point(165, 153);
            this.lblZahlB.Name = "lblZahlB";
            this.lblZahlB.Size = new System.Drawing.Size(69, 26);
            this.lblZahlB.TabIndex = 2;
            this.lblZahlB.Text = "ZahlB";
            this.lblZahlB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOperator
            // 
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(123, 154);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(37, 22);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = ",";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZahlA
            // 
            this.lblZahlA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZahlA.Location = new System.Drawing.Point(35, 153);
            this.lblZahlA.Name = "lblZahlA";
            this.lblZahlA.Size = new System.Drawing.Size(83, 26);
            this.lblZahlA.TabIndex = 0;
            this.lblZahlA.Text = "ZahlA";
            this.lblZahlA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bntStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBerechnungsart);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radmal);
            this.groupBox1.Controls.Add(this.raddiv);
            this.groupBox1.Controls.Add(this.radminus);
            this.groupBox1.Controls.Add(this.radplus);
            this.groupBox1.Location = new System.Drawing.Point(153, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(725, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // bntStart
            // 
            this.bntStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntStart.Location = new System.Drawing.Point(395, 235);
            this.bntStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(277, 47);
            this.bntStart.TabIndex = 9;
            this.bntStart.Text = "Start";
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 66);
            this.label3.TabIndex = 8;
            this.label3.Text = "Schwierigkeitsgrad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 66);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wähle die Anzahl der Übungaufgaben aus";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBerechnungsart
            // 
            this.lblBerechnungsart.BackColor = System.Drawing.Color.Transparent;
            this.lblBerechnungsart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBerechnungsart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBerechnungsart.Location = new System.Drawing.Point(47, 32);
            this.lblBerechnungsart.Name = "lblBerechnungsart";
            this.lblBerechnungsart.Size = new System.Drawing.Size(139, 66);
            this.lblBerechnungsart.TabIndex = 6;
            this.lblBerechnungsart.Text = "Wähle eine Rechenart aus";
            this.lblBerechnungsart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBerechnungsart.Click += new System.EventHandler(this.lblBerechnungsart_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Leicht",
            "Mittel",
            "Schwer"});
            this.comboBox2.Location = new System.Drawing.Point(496, 122);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(240, 123);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // radmal
            // 
            this.radmal.AutoSize = true;
            this.radmal.BackColor = System.Drawing.Color.Transparent;
            this.radmal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmal.Location = new System.Drawing.Point(121, 130);
            this.radmal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radmal.Name = "radmal";
            this.radmal.Size = new System.Drawing.Size(41, 29);
            this.radmal.TabIndex = 3;
            this.radmal.TabStop = true;
            this.radmal.Text = "*";
            this.radmal.UseVisualStyleBackColor = false;
            // 
            // raddiv
            // 
            this.raddiv.AutoSize = true;
            this.raddiv.BackColor = System.Drawing.Color.Transparent;
            this.raddiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddiv.Location = new System.Drawing.Point(121, 101);
            this.raddiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.raddiv.Name = "raddiv";
            this.raddiv.Size = new System.Drawing.Size(39, 29);
            this.raddiv.TabIndex = 2;
            this.raddiv.TabStop = true;
            this.raddiv.Text = "/";
            this.raddiv.UseVisualStyleBackColor = false;
            // 
            // radminus
            // 
            this.radminus.AutoSize = true;
            this.radminus.BackColor = System.Drawing.Color.Transparent;
            this.radminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radminus.Location = new System.Drawing.Point(75, 130);
            this.radminus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radminus.Name = "radminus";
            this.radminus.Size = new System.Drawing.Size(40, 29);
            this.radminus.TabIndex = 1;
            this.radminus.TabStop = true;
            this.radminus.Text = "-";
            this.radminus.UseVisualStyleBackColor = false;
            // 
            // radplus
            // 
            this.radplus.AutoSize = true;
            this.radplus.BackColor = System.Drawing.Color.Transparent;
            this.radplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radplus.Location = new System.Drawing.Point(75, 101);
            this.radplus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radplus.Name = "radplus";
            this.radplus.Size = new System.Drawing.Size(45, 29);
            this.radplus.TabIndex = 0;
            this.radplus.TabStop = true;
            this.radplus.Text = "+";
            this.radplus.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 79);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hallo mein Freund. Das ist dein neuer Kinderrechnen :)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(563, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 86);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ich bin die Biene Deti, ich bin dein neuer Mathefreund :) !  \r\nGib dein bestes me" +
    "in Freund du schaffst das ! :)\r\nWenn du Hilfe brauchst klick auf Hilfe !";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(911, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hilfe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Kinderrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCoun;
        private System.Windows.Forms.Button btnZufall;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrüfen;
        private System.Windows.Forms.Label lblProzentsatz;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblFT;
        private System.Windows.Forms.Label lblIstErgebnis;
        private System.Windows.Forms.TextBox txtSollErgebnis;
        private System.Windows.Forms.Label lblgleich;
        private System.Windows.Forms.Label lblZahlB;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblZahlA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBerechnungsart;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radmal;
        private System.Windows.Forms.RadioButton raddiv;
        private System.Windows.Forms.RadioButton radminus;
        private System.Windows.Forms.RadioButton radplus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

