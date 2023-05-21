namespace ZelenePovrsine.Forms
{
    partial class DodajRadnik
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ImeRoditelja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.TextBox();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mbr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.StrucnaSprema = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OdrzavaZelenila = new System.Windows.Forms.CheckBox();
            this.OdrzavaHigijenu = new System.Windows.Forms.CheckBox();
            this.OdrzavaObjekte = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.OdrzavaObjekte);
            this.panel1.Controls.Add(this.OdrzavaHigijenu);
            this.panel1.Controls.Add(this.OdrzavaZelenila);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.StrucnaSprema);
            this.panel1.Controls.Add(this.DatumRodjenja);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Adresa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Mbr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Prezime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ImeRoditelja);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Ime);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 303);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime roditelja";
            // 
            // ImeRoditelja
            // 
            this.ImeRoditelja.Location = new System.Drawing.Point(3, 29);
            this.ImeRoditelja.Name = "ImeRoditelja";
            this.ImeRoditelja.Size = new System.Drawing.Size(100, 20);
            this.ImeRoditelja.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(3, 3);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(100, 20);
            this.Ime.TabIndex = 0;
            // 
            // Dodaj
            // 
            this.Dodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Dodaj.Location = new System.Drawing.Point(156, 321);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 5;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Nazad
            // 
            this.Nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Nazad.Location = new System.Drawing.Point(75, 321);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(75, 23);
            this.Nazad.TabIndex = 4;
            this.Nazad.Text = "Nazad";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezime";
            // 
            // Prezime
            // 
            this.Prezime.Location = new System.Drawing.Point(3, 55);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(100, 20);
            this.Prezime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Matični broj";
            // 
            // Mbr
            // 
            this.Mbr.Location = new System.Drawing.Point(3, 81);
            this.Mbr.Name = "Mbr";
            this.Mbr.Size = new System.Drawing.Size(100, 20);
            this.Mbr.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adresa";
            // 
            // Adresa
            // 
            this.Adresa.Location = new System.Drawing.Point(3, 107);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(100, 20);
            this.Adresa.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Datum rođenja";
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.Location = new System.Drawing.Point(3, 146);
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.Size = new System.Drawing.Size(208, 20);
            this.DatumRodjenja.TabIndex = 12;
            this.DatumRodjenja.Value = new System.DateTime(2023, 5, 20, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stručna sprema";
            // 
            // StrucnaSprema
            // 
            this.StrucnaSprema.Location = new System.Drawing.Point(3, 172);
            this.StrucnaSprema.Name = "StrucnaSprema";
            this.StrucnaSprema.Size = new System.Drawing.Size(100, 20);
            this.StrucnaSprema.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dužnosti";
            // 
            // OdrzavaZelenila
            // 
            this.OdrzavaZelenila.AutoSize = true;
            this.OdrzavaZelenila.Location = new System.Drawing.Point(3, 214);
            this.OdrzavaZelenila.Name = "OdrzavaZelenila";
            this.OdrzavaZelenila.Size = new System.Drawing.Size(104, 17);
            this.OdrzavaZelenila.TabIndex = 20;
            this.OdrzavaZelenila.Text = "Održava zelenila";
            this.OdrzavaZelenila.UseVisualStyleBackColor = true;
            // 
            // OdrzavaHigijenu
            // 
            this.OdrzavaHigijenu.AutoSize = true;
            this.OdrzavaHigijenu.Location = new System.Drawing.Point(3, 237);
            this.OdrzavaHigijenu.Name = "OdrzavaHigijenu";
            this.OdrzavaHigijenu.Size = new System.Drawing.Size(105, 17);
            this.OdrzavaHigijenu.TabIndex = 21;
            this.OdrzavaHigijenu.Text = "Održava higijenu";
            this.OdrzavaHigijenu.UseVisualStyleBackColor = true;
            // 
            // OdrzavaObjekte
            // 
            this.OdrzavaObjekte.AutoSize = true;
            this.OdrzavaObjekte.Location = new System.Drawing.Point(3, 260);
            this.OdrzavaObjekte.Name = "OdrzavaObjekte";
            this.OdrzavaObjekte.Size = new System.Drawing.Size(104, 17);
            this.OdrzavaObjekte.TabIndex = 22;
            this.OdrzavaObjekte.Text = "Održava objekte";
            this.OdrzavaObjekte.UseVisualStyleBackColor = true;
            // 
            // DodajRadnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Nazad);
            this.Name = "DodajRadnik";
            this.Text = "DodajRadnik";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ImeRoditelja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.CheckBox OdrzavaObjekte;
        private System.Windows.Forms.CheckBox OdrzavaHigijenu;
        private System.Windows.Forms.CheckBox OdrzavaZelenila;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StrucnaSprema;
        private System.Windows.Forms.DateTimePicker DatumRodjenja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Mbr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Prezime;
    }
}