namespace Hausaufgabe_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Rechnen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Summe = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.txt_Mittelwert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_hilfe = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eingabe \"n\":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Rechnen
            // 
            this.btn_Rechnen.Location = new System.Drawing.Point(29, 91);
            this.btn_Rechnen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Rechnen.Name = "btn_Rechnen";
            this.btn_Rechnen.Size = new System.Drawing.Size(233, 28);
            this.btn_Rechnen.TabIndex = 1;
            this.btn_Rechnen.Text = "Berechnen mit (do - Schleife)";
            this.btn_Rechnen.UseVisualStyleBackColor = true;
            this.btn_Rechnen.Click += new System.EventHandler(this.btn_Rechnen_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Summe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Summe
            // 
            this.txt_Summe.Enabled = false;
            this.txt_Summe.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Summe.Location = new System.Drawing.Point(27, 226);
            this.txt_Summe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Summe.Name = "txt_Summe";
            this.txt_Summe.Size = new System.Drawing.Size(233, 28);
            this.txt_Summe.TabIndex = 3;
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(31, 56);
            this.txt_n.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(231, 22);
            this.txt_n.TabIndex = 4;
            // 
            // txt_Mittelwert
            // 
            this.txt_Mittelwert.Enabled = false;
            this.txt_Mittelwert.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mittelwert.Location = new System.Drawing.Point(27, 283);
            this.txt_Mittelwert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Mittelwert.Name = "txt_Mittelwert";
            this.txt_Mittelwert.Size = new System.Drawing.Size(233, 28);
            this.txt_Mittelwert.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mittelwert";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zinsenrechner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Berechnen mit (for - Schleife)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_hilfe
            // 
            this.btn_hilfe.Location = new System.Drawing.Point(398, 339);
            this.btn_hilfe.Name = "btn_hilfe";
            this.btn_hilfe.Size = new System.Drawing.Size(75, 23);
            this.btn_hilfe.TabIndex = 9;
            this.btn_hilfe.Text = "Hilfe";
            this.btn_hilfe.UseVisualStyleBackColor = true;
            this.btn_hilfe.Click += new System.EventHandler(this.btn_hilfe_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(398, 310);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 374);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_hilfe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Mittelwert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.txt_Summe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Rechnen);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aufgabe 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Rechnen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Summe;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.TextBox txt_Mittelwert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_hilfe;
        private System.Windows.Forms.Button btn_reset;
    }
}

