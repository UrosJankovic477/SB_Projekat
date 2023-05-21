namespace ZelenePovrsine.Forms
{
    partial class DodajDrvored
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
            this.label2 = new System.Windows.Forms.Label();
            this.BrStabala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ulica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VrstaDrveta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.VrstaDrveta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BrStabala);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Ulica);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 303);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj stabala";
            // 
            // BrStabala
            // 
            this.BrStabala.Location = new System.Drawing.Point(3, 29);
            this.BrStabala.Name = "BrStabala";
            this.BrStabala.Size = new System.Drawing.Size(100, 20);
            this.BrStabala.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ulica";
            // 
            // Ulica
            // 
            this.Ulica.Location = new System.Drawing.Point(3, 3);
            this.Ulica.Name = "Ulica";
            this.Ulica.Size = new System.Drawing.Size(100, 20);
            this.Ulica.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vrsta drveta";
            // 
            // VrstaDrveta
            // 
            this.VrstaDrveta.Location = new System.Drawing.Point(3, 55);
            this.VrstaDrveta.Name = "VrstaDrveta";
            this.VrstaDrveta.Size = new System.Drawing.Size(100, 20);
            this.VrstaDrveta.TabIndex = 4;
            // 
            // DodajDrvored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.panel1);
            this.Name = "DodajDrvored";
            this.Text = "Dodaj drvored";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BrStabala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ulica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VrstaDrveta;
    }
}