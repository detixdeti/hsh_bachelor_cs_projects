namespace _3.Stunde
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
            this.lblHelp = new System.Windows.Forms.Label();
            this.radplus = new System.Windows.Forms.RadioButton();
            this.radminus = new System.Windows.Forms.RadioButton();
            this.txtZahla = new System.Windows.Forms.TextBox();
            this.txtZahlb = new System.Windows.Forms.TextBox();
            this.btnRechne = new System.Windows.Forms.Button();
            this.lblErgebniss = new System.Windows.Forms.Label();
            this.raddiv = new System.Windows.Forms.RadioButton();
            this.radmal = new System.Windows.Forms.RadioButton();
            this.lblArt = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHelp.Location = new System.Drawing.Point(50, 28);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(327, 50);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "Bitte geben Sie zwei Zahlen ein und \r\nwählen Sie die Rechenart aus.\r\n";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radplus
            // 
            this.radplus.AutoSize = true;
            this.radplus.BackColor = System.Drawing.Color.Transparent;
            this.radplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radplus.ForeColor = System.Drawing.SystemColors.Control;
            this.radplus.Location = new System.Drawing.Point(60, 150);
            this.radplus.Name = "radplus";
            this.radplus.Size = new System.Drawing.Size(36, 24);
            this.radplus.TabIndex = 1;
            this.radplus.TabStop = true;
            this.radplus.Text = "+";
            this.radplus.UseVisualStyleBackColor = false;
            // 
            // radminus
            // 
            this.radminus.AutoSize = true;
            this.radminus.BackColor = System.Drawing.Color.Transparent;
            this.radminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radminus.ForeColor = System.Drawing.SystemColors.Control;
            this.radminus.Location = new System.Drawing.Point(60, 173);
            this.radminus.Name = "radminus";
            this.radminus.Size = new System.Drawing.Size(32, 24);
            this.radminus.TabIndex = 2;
            this.radminus.TabStop = true;
            this.radminus.Text = "-";
            this.radminus.UseVisualStyleBackColor = false;
            // 
            // txtZahla
            // 
            this.txtZahla.Location = new System.Drawing.Point(60, 100);
            this.txtZahla.Name = "txtZahla";
            this.txtZahla.Size = new System.Drawing.Size(100, 20);
            this.txtZahla.TabIndex = 3;
            // 
            // txtZahlb
            // 
            this.txtZahlb.Location = new System.Drawing.Point(244, 100);
            this.txtZahlb.Name = "txtZahlb";
            this.txtZahlb.Size = new System.Drawing.Size(100, 20);
            this.txtZahlb.TabIndex = 4;
            // 
            // btnRechne
            // 
            this.btnRechne.Location = new System.Drawing.Point(244, 150);
            this.btnRechne.Name = "btnRechne";
            this.btnRechne.Size = new System.Drawing.Size(100, 47);
            this.btnRechne.TabIndex = 5;
            this.btnRechne.Text = "Berechnen";
            this.btnRechne.UseVisualStyleBackColor = true;
            this.btnRechne.Click += new System.EventHandler(this.btnRechne_Click);
            // 
            // lblErgebniss
            // 
            this.lblErgebniss.AutoSize = true;
            this.lblErgebniss.BackColor = System.Drawing.Color.Transparent;
            this.lblErgebniss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErgebniss.ForeColor = System.Drawing.SystemColors.Control;
            this.lblErgebniss.Location = new System.Drawing.Point(96, 217);
            this.lblErgebniss.Name = "lblErgebniss";
            this.lblErgebniss.Size = new System.Drawing.Size(0, 20);
            this.lblErgebniss.TabIndex = 6;
            // 
            // raddiv
            // 
            this.raddiv.AutoSize = true;
            this.raddiv.BackColor = System.Drawing.Color.Transparent;
            this.raddiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddiv.ForeColor = System.Drawing.SystemColors.Control;
            this.raddiv.Location = new System.Drawing.Point(122, 150);
            this.raddiv.Name = "raddiv";
            this.raddiv.Size = new System.Drawing.Size(31, 24);
            this.raddiv.TabIndex = 7;
            this.raddiv.TabStop = true;
            this.raddiv.Text = "/";
            this.raddiv.UseVisualStyleBackColor = false;
            // 
            // radmal
            // 
            this.radmal.AutoSize = true;
            this.radmal.BackColor = System.Drawing.Color.Transparent;
            this.radmal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radmal.Location = new System.Drawing.Point(122, 173);
            this.radmal.Name = "radmal";
            this.radmal.Size = new System.Drawing.Size(33, 24);
            this.radmal.TabIndex = 8;
            this.radmal.TabStop = true;
            this.radmal.Text = "*";
            this.radmal.UseVisualStyleBackColor = false;
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.BackColor = System.Drawing.Color.Transparent;
            this.lblArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblArt.Location = new System.Drawing.Point(187, 100);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(0, 20);
            this.lblArt.TabIndex = 9;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(361, 261);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(52, 22);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(425, 295);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.radmal);
            this.Controls.Add(this.raddiv);
            this.Controls.Add(this.lblErgebniss);
            this.Controls.Add(this.btnRechne);
            this.Controls.Add(this.txtZahlb);
            this.Controls.Add(this.txtZahla);
            this.Controls.Add(this.radminus);
            this.Controls.Add(this.radplus);
            this.Controls.Add(this.lblHelp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.RadioButton radplus;
        private System.Windows.Forms.RadioButton radminus;
        private System.Windows.Forms.TextBox txtZahla;
        private System.Windows.Forms.TextBox txtZahlb;
        private System.Windows.Forms.Button btnRechne;
        private System.Windows.Forms.Label lblErgebniss;
        private System.Windows.Forms.RadioButton raddiv;
        private System.Windows.Forms.RadioButton radmal;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Button btnReset;
    }
}

