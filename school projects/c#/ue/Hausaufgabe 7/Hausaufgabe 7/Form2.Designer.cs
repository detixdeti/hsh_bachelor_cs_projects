namespace Hausaufgabe_7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txt_Anfangskapital = new System.Windows.Forms.TextBox();
            this.txt_Laufzeit = new System.Windows.Forms.TextBox();
            this.txt_Zinssatz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Endbetrag = new System.Windows.Forms.TextBox();
            this.btn_Berechnen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_inklZ = new System.Windows.Forms.TextBox();
            this.txt_zinsen = new System.Windows.Forms.TextBox();
            this.Kapital_je_Jahr = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_Anfangskapital
            // 
            this.txt_Anfangskapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Anfangskapital.Location = new System.Drawing.Point(307, 274);
            this.txt_Anfangskapital.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Anfangskapital.Name = "txt_Anfangskapital";
            this.txt_Anfangskapital.Size = new System.Drawing.Size(116, 30);
            this.txt_Anfangskapital.TabIndex = 0;
            // 
            // txt_Laufzeit
            // 
            this.txt_Laufzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Laufzeit.Location = new System.Drawing.Point(307, 338);
            this.txt_Laufzeit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Laufzeit.Name = "txt_Laufzeit";
            this.txt_Laufzeit.Size = new System.Drawing.Size(116, 30);
            this.txt_Laufzeit.TabIndex = 1;
            // 
            // txt_Zinssatz
            // 
            this.txt_Zinssatz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Zinssatz.Location = new System.Drawing.Point(307, 306);
            this.txt_Zinssatz.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Zinssatz.Name = "txt_Zinssatz";
            this.txt_Zinssatz.Size = new System.Drawing.Size(116, 30);
            this.txt_Zinssatz.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anfangskapital";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zinsatz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Laufzeit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Endbetrag
            // 
            this.txt_Endbetrag.Enabled = false;
            this.txt_Endbetrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endbetrag.Location = new System.Drawing.Point(307, 371);
            this.txt_Endbetrag.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Endbetrag.Name = "txt_Endbetrag";
            this.txt_Endbetrag.Size = new System.Drawing.Size(116, 30);
            this.txt_Endbetrag.TabIndex = 6;
            // 
            // btn_Berechnen
            // 
            this.btn_Berechnen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Berechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Berechnen.Location = new System.Drawing.Point(89, 422);
            this.btn_Berechnen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Berechnen.Name = "btn_Berechnen";
            this.btn_Berechnen.Size = new System.Drawing.Size(416, 42);
            this.btn_Berechnen.TabIndex = 8;
            this.btn_Berechnen.Text = "Berechnen";
            this.btn_Berechnen.UseVisualStyleBackColor = true;
            this.btn_Berechnen.Click += new System.EventHandler(this.btn_Berechnen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monate",
            "Jahre"});
            this.comboBox1.Location = new System.Drawing.Point(428, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Jahre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 371);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Endkapital";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Euro";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "% p. a.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Euro";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(469, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kenndaten  [weiße Felder ausfüllen]";
            // 
            // txt_inklZ
            // 
            this.txt_inklZ.Enabled = false;
            this.txt_inklZ.Location = new System.Drawing.Point(89, 471);
            this.txt_inklZ.Name = "txt_inklZ";
            this.txt_inklZ.Size = new System.Drawing.Size(416, 22);
            this.txt_inklZ.TabIndex = 18;
            this.txt_inklZ.Text = "Das erzielte Endkapital inkl. Zinsen beträgt:\t";
            // 
            // txt_zinsen
            // 
            this.txt_zinsen.Enabled = false;
            this.txt_zinsen.Location = new System.Drawing.Point(89, 499);
            this.txt_zinsen.Name = "txt_zinsen";
            this.txt_zinsen.Size = new System.Drawing.Size(416, 22);
            this.txt_zinsen.TabIndex = 19;
            this.txt_zinsen.Text = "Zinsen gesamt:";
            // 
            // Kapital_je_Jahr
            // 
            this.Kapital_je_Jahr.FormattingEnabled = true;
            this.Kapital_je_Jahr.ItemHeight = 16;
            this.Kapital_je_Jahr.Location = new System.Drawing.Point(89, 549);
            this.Kapital_je_Jahr.Name = "Kapital_je_Jahr";
            this.Kapital_je_Jahr.Size = new System.Drawing.Size(416, 100);
            this.Kapital_je_Jahr.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 698);
            this.Controls.Add(this.Kapital_je_Jahr);
            this.Controls.Add(this.txt_zinsen);
            this.Controls.Add(this.txt_inklZ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Berechnen);
            this.Controls.Add(this.txt_Endbetrag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Zinssatz);
            this.Controls.Add(this.txt_Laufzeit);
            this.Controls.Add(this.txt_Anfangskapital);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zinsenrechner";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Anfangskapital;
        private System.Windows.Forms.TextBox txt_Laufzeit;
        private System.Windows.Forms.TextBox txt_Zinssatz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Endbetrag;
        private System.Windows.Forms.Button btn_Berechnen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_inklZ;
        private System.Windows.Forms.TextBox txt_zinsen;
        private System.Windows.Forms.ListBox Kapital_je_Jahr;
    }
}