namespace ZelenePovrsine.Forms
{
    partial class IzmeniTravnjak
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
            this.Dodaj = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ugrozenost = new System.Windows.Forms.ComboBox();
            this.Opstina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PovrsinaAri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dodaj
            // 
            this.Dodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Dodaj.Location = new System.Drawing.Point(156, 321);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 8;
            this.Dodaj.Text = "Izmeni";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Nazad
            // 
            this.Nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Nazad.Location = new System.Drawing.Point(75, 321);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(75, 23);
            this.Nazad.TabIndex = 7;
            this.Nazad.Text = "Nazad";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Ugrozenost);
            this.panel1.Controls.Add(this.Opstina);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PovrsinaAri);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Adresa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 303);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.MaximumSize = new System.Drawing.Size(210, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Polja koja ne želite da menjate ostavite prazna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Opština";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 6);
            this.label4.MaximumSize = new System.Drawing.Size(100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ugroženost od zagađenja";
            // 
            // Ugrozenost
            // 
            this.Ugrozenost.FormattingEnabled = true;
            this.Ugrozenost.Items.AddRange(new object[] {
            "Niska",
            "Srednja",
            "Visoka"});
            this.Ugrozenost.Location = new System.Drawing.Point(3, 3);
            this.Ugrozenost.Name = "Ugrozenost";
            this.Ugrozenost.Size = new System.Drawing.Size(105, 21);
            this.Ugrozenost.TabIndex = 8;
            // 
            // Opstina
            // 
            this.Opstina.Location = new System.Drawing.Point(3, 46);
            this.Opstina.Name = "Opstina";
            this.Opstina.Size = new System.Drawing.Size(100, 20);
            this.Opstina.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Površina u arima";
            // 
            // PovrsinaAri
            // 
            this.PovrsinaAri.Location = new System.Drawing.Point(3, 106);
            this.PovrsinaAri.Name = "PovrsinaAri";
            this.PovrsinaAri.Size = new System.Drawing.Size(100, 20);
            this.PovrsinaAri.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresa zgrade";
            // 
            // Adresa
            // 
            this.Adresa.Location = new System.Drawing.Point(3, 80);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(100, 20);
            this.Adresa.TabIndex = 0;
            // 
            // IzmeniTravnjak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.panel1);
            this.Name = "IzmeniTravnjak";
            this.Text = "IzmeniTravnjak";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Ugrozenost;
        private System.Windows.Forms.TextBox Opstina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PovrsinaAri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Adresa;
    }
}