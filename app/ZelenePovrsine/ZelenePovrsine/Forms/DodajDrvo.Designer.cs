namespace ZelenePovrsine.Forms
{
    partial class DodajDrvo
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
            this.label4 = new System.Windows.Forms.Label();
            this.Povrsina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Visina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Vrsta = new System.Windows.Forms.TextBox();
            this.Obim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DatSadjenja = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Zastita = new System.Windows.Forms.CheckBox();
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
            this.panel1.Controls.Add(this.Zastita);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DatSadjenja);
            this.panel1.Controls.Add(this.Obim);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Povrsina);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Visina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Vrsta);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 303);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vrsta drveta";
            // 
            // Povrsina
            // 
            this.Povrsina.Location = new System.Drawing.Point(3, 55);
            this.Povrsina.Name = "Povrsina";
            this.Povrsina.Size = new System.Drawing.Size(100, 20);
            this.Povrsina.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Površina krošnje";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Visina
            // 
            this.Visina.Location = new System.Drawing.Point(3, 29);
            this.Visina.Name = "Visina";
            this.Visina.Size = new System.Drawing.Size(100, 20);
            this.Visina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visina krošnje";
            // 
            // Vrsta
            // 
            this.Vrsta.Location = new System.Drawing.Point(3, 3);
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.Size = new System.Drawing.Size(100, 20);
            this.Vrsta.TabIndex = 0;
            // 
            // Obim
            // 
            this.Obim.Location = new System.Drawing.Point(3, 81);
            this.Obim.Name = "Obim";
            this.Obim.Size = new System.Drawing.Size(100, 20);
            this.Obim.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Obim debla";
            // 
            // DatSadjenja
            // 
            this.DatSadjenja.Location = new System.Drawing.Point(3, 131);
            this.DatSadjenja.Name = "DatSadjenja";
            this.DatSadjenja.Size = new System.Drawing.Size(200, 20);
            this.DatSadjenja.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum sađenja";
            // 
            // Zastita
            // 
            this.Zastita.AutoSize = true;
            this.Zastita.Location = new System.Drawing.Point(3, 158);
            this.Zastita.Name = "Zastita";
            this.Zastita.Size = new System.Drawing.Size(86, 17);
            this.Zastita.TabIndex = 10;
            this.Zastita.Text = "Pod zaštitom";
            this.Zastita.UseVisualStyleBackColor = true;
            // 
            // DodajDrvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.panel1);
            this.Name = "DodajDrvo";
            this.Text = "DodajDrvo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Povrsina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Visina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Vrsta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DatSadjenja;
        private System.Windows.Forms.TextBox Obim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Zastita;
    }
}