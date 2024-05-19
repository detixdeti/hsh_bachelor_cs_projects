namespace _7Stunde
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
            this.btn_Würfel = new System.Windows.Forms.Button();
            this.txtLsg = new System.Windows.Forms.TextBox();
            this.txtAnzahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Sechs = new System.Windows.Forms.Label();
            this.comb_Zahl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Prozent = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pic_Würfel1 = new System.Windows.Forms.PictureBox();
            this.pic_Würfel2 = new System.Windows.Forms.PictureBox();
            this.pic_Würfel3 = new System.Windows.Forms.PictureBox();
            this.pic_Würfel4 = new System.Windows.Forms.PictureBox();
            this.pic_Würfel5 = new System.Windows.Forms.PictureBox();
            this.pic_Würfel6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel6)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Würfel
            // 
            this.btn_Würfel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Würfel.Location = new System.Drawing.Point(347, 89);
            this.btn_Würfel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Würfel.Name = "btn_Würfel";
            this.btn_Würfel.Size = new System.Drawing.Size(249, 42);
            this.btn_Würfel.TabIndex = 0;
            this.btn_Würfel.Text = "Würfeln";
            this.btn_Würfel.UseVisualStyleBackColor = true;
            this.btn_Würfel.Click += new System.EventHandler(this.btn_Würfel_Click);
            // 
            // txtLsg
            // 
            this.txtLsg.Enabled = false;
            this.txtLsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLsg.Location = new System.Drawing.Point(13, 66);
            this.txtLsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLsg.Name = "txtLsg";
            this.txtLsg.Size = new System.Drawing.Size(323, 30);
            this.txtLsg.TabIndex = 1;
            // 
            // txtAnzahl
            // 
            this.txtAnzahl.Location = new System.Drawing.Point(348, 59);
            this.txtAnzahl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnzahl.Name = "txtAnzahl";
            this.txtAnzahl.Size = new System.Drawing.Size(248, 22);
            this.txtAnzahl.TabIndex = 2;
            this.txtAnzahl.TextChanged += new System.EventHandler(this.txtAnzahl_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wie oft wollen Sie würfeln";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sie haben gewürfelt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Sechs
            // 
            this.lbl_Sechs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sechs.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sechs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Sechs.Location = new System.Drawing.Point(9, 220);
            this.lbl_Sechs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sechs.Name = "lbl_Sechs";
            this.lbl_Sechs.Size = new System.Drawing.Size(317, 25);
            this.lbl_Sechs.TabIndex = 5;
            this.lbl_Sechs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comb_Zahl
            // 
            this.comb_Zahl.FormattingEnabled = true;
            this.comb_Zahl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comb_Zahl.Location = new System.Drawing.Point(13, 178);
            this.comb_Zahl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comb_Zahl.Name = "comb_Zahl";
            this.comb_Zahl.Size = new System.Drawing.Size(323, 24);
            this.comb_Zahl.TabIndex = 6;
            this.comb_Zahl.Text = "6";
            this.comb_Zahl.SelectedIndexChanged += new System.EventHandler(this.comb_Zahl_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wählen sie die Zahl aus die rausgefiltert werden soll";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Prozent
            // 
            this.lbl_Prozent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Prozent.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prozent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Prozent.Location = new System.Drawing.Point(13, 261);
            this.lbl_Prozent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Prozent.Name = "lbl_Prozent";
            this.lbl_Prozent.Size = new System.Drawing.Size(320, 62);
            this.lbl_Prozent.TabIndex = 8;
            this.lbl_Prozent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Prozent.Click += new System.EventHandler(this.lbl_Prozent_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(534, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(12, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Hilfe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pic_Würfel1
            // 
            this.pic_Würfel1.Image = ((System.Drawing.Image)(resources.GetObject("pic_Würfel1.Image")));
            this.pic_Würfel1.Location = new System.Drawing.Point(276, 109);
            this.pic_Würfel1.Name = "pic_Würfel1";
            this.pic_Würfel1.Size = new System.Drawing.Size(60, 60);
            this.pic_Würfel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Würfel1.TabIndex = 11;
            this.pic_Würfel1.TabStop = false;
            this.pic_Würfel1.Visible = false;
            // 
            // pic_Würfel2
            // 
            this.pic_Würfel2.Image = ((System.Drawing.Image)(resources.GetObject("pic_Würfel2.Image")));
            this.pic_Würfel2.Location = new System.Drawing.Point(276, 109);
            this.pic_Würfel2.Name = "pic_Würfel2";
            this.pic_Würfel2.Size = new System.Drawing.Size(60, 60);
            this.pic_Würfel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Würfel2.TabIndex = 12;
            this.pic_Würfel2.TabStop = false;
            this.pic_Würfel2.Visible = false;
            // 
            // pic_Würfel3
            // 
            this.pic_Würfel3.Image = ((System.Drawing.Image)(resources.GetObject("pic_Würfel3.Image")));
            this.pic_Würfel3.Location = new System.Drawing.Point(276, 109);
            this.pic_Würfel3.Name = "pic_Würfel3";
            this.pic_Würfel3.Size = new System.Drawing.Size(60, 60);
            this.pic_Würfel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Würfel3.TabIndex = 13;
            this.pic_Würfel3.TabStop = false;
            this.pic_Würfel3.Visible = false;
            // 
            // pic_Würfel4
            // 
            this.pic_Würfel4.Image = ((System.Drawing.Image)(resources.GetObject("pic_Würfel4.Image")));
            this.pic_Würfel4.Location = new System.Drawing.Point(276, 109);
            this.pic_Würfel4.Name = "pic_Würfel4";
            this.pic_Würfel4.Size = new System.Drawing.Size(60, 60);
            this.pic_Würfel4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Würfel4.TabIndex = 14;
            this.pic_Würfel4.TabStop = false;
            this.pic_Würfel4.Visible = false;
            // 
            // pic_Würfel5
            // 
            this.pic_Würfel5.Image = ((System.Drawing.Image)(resources.GetObject("pic_Würfel5.Image")));
            this.pic_Würfel5.Location = new System.Drawing.Point(276, 109);
            this.pic_Würfel5.Name = "pic_Würfel5";
            this.pic_Würfel5.Size = new System.Drawing.Size(60, 60);
            this.pic_Würfel5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Würfel5.TabIndex = 15;
            this.pic_Würfel5.TabStop = false;
            this.pic_Würfel5.Visible = false;
            // 
            // pic_Würfel6
            // 
            this.pic_Würfel6.Image = ((System.Drawing.Image)(resources.GetObject("pic_Würfel6.Image")));
            this.pic_Würfel6.Location = new System.Drawing.Point(276, 109);
            this.pic_Würfel6.Name = "pic_Würfel6";
            this.pic_Würfel6.Size = new System.Drawing.Size(60, 60);
            this.pic_Würfel6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Würfel6.TabIndex = 16;
            this.pic_Würfel6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 405);
            this.Controls.Add(this.pic_Würfel6);
            this.Controls.Add(this.pic_Würfel5);
            this.Controls.Add(this.pic_Würfel4);
            this.Controls.Add(this.pic_Würfel3);
            this.Controls.Add(this.pic_Würfel2);
            this.Controls.Add(this.pic_Würfel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Prozent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comb_Zahl);
            this.Controls.Add(this.lbl_Sechs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnzahl);
            this.Controls.Add(this.txtLsg);
            this.Controls.Add(this.btn_Würfel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Würfel";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Würfel6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Würfel;
        private System.Windows.Forms.TextBox txtLsg;
        private System.Windows.Forms.TextBox txtAnzahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Sechs;
        private System.Windows.Forms.ComboBox comb_Zahl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Prozent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pic_Würfel1;
        private System.Windows.Forms.PictureBox pic_Würfel2;
        private System.Windows.Forms.PictureBox pic_Würfel3;
        private System.Windows.Forms.PictureBox pic_Würfel4;
        private System.Windows.Forms.PictureBox pic_Würfel5;
        private System.Windows.Forms.PictureBox pic_Würfel6;
    }
}

