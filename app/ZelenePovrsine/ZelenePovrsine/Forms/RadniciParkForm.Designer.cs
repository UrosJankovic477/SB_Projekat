namespace ZelenePovrsine.Forms
{
    partial class RadniciParkForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radnici = new System.Windows.Forms.ListView();
            this.Mbr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrRK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumRodjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odrzava = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumOd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IzbaciRadnika = new System.Windows.Forms.Button();
            this.DodajRadnika = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radnici);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radnici";
            // 
            // Radnici
            // 
            this.Radnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mbr,
            this.BrRK,
            this.Ime,
            this.Adresa,
            this.DatumRodjenja,
            this.Odrzava,
            this.DatumOd,
            this.DatumDo});
            this.Radnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Radnici.FullRowSelect = true;
            this.Radnici.GridLines = true;
            this.Radnici.HideSelection = false;
            this.Radnici.Location = new System.Drawing.Point(3, 16);
            this.Radnici.Name = "Radnici";
            this.Radnici.ShowItemToolTips = true;
            this.Radnici.Size = new System.Drawing.Size(452, 356);
            this.Radnici.TabIndex = 1;
            this.Radnici.UseCompatibleStateImageBehavior = false;
            this.Radnici.View = System.Windows.Forms.View.Details;
            this.Radnici.SelectedIndexChanged += new System.EventHandler(this.Radnici_SelectedIndexChanged);
            // 
            // Mbr
            // 
            this.Mbr.Text = "Matični br.";
            this.Mbr.Width = 66;
            // 
            // BrRK
            // 
            this.BrRK.Text = "Br. radne knjižice";
            this.BrRK.Width = 77;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 136;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 94;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.Text = "Datum rođenja";
            this.DatumRodjenja.Width = 82;
            // 
            // Odrzava
            // 
            this.Odrzava.Text = "Održava";
            this.Odrzava.Width = 192;
            // 
            // DatumOd
            // 
            this.DatumOd.Text = "Priključio se grupi";
            this.DatumOd.Width = 121;
            // 
            // DatumDo
            // 
            this.DatumDo.Text = "Napustio grupu";
            this.DatumDo.Width = 124;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.IzbaciRadnika);
            this.panel1.Controls.Add(this.DodajRadnika);
            this.panel1.Location = new System.Drawing.Point(475, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 387);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 101);
            this.label1.MaximumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iz grupe se mogu izbaciti samo trenutni članovi grupe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Opcije:";
            // 
            // IzbaciRadnika
            // 
            this.IzbaciRadnika.Location = new System.Drawing.Point(3, 75);
            this.IzbaciRadnika.Name = "IzbaciRadnika";
            this.IzbaciRadnika.Size = new System.Drawing.Size(118, 23);
            this.IzbaciRadnika.TabIndex = 7;
            this.IzbaciRadnika.Text = "Izbaci radnika";
            this.IzbaciRadnika.UseVisualStyleBackColor = true;
            this.IzbaciRadnika.Click += new System.EventHandler(this.IzbaciRadnika_Click);
            // 
            // DodajRadnika
            // 
            this.DodajRadnika.Location = new System.Drawing.Point(3, 46);
            this.DodajRadnika.Name = "DodajRadnika";
            this.DodajRadnika.Size = new System.Drawing.Size(118, 23);
            this.DodajRadnika.TabIndex = 6;
            this.DodajRadnika.Text = "Dodeli radnika grupi";
            this.DodajRadnika.UseVisualStyleBackColor = true;
            this.DodajRadnika.Click += new System.EventHandler(this.DodajRadnika_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 385);
            this.panel2.TabIndex = 18;
            // 
            // RadniciParkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RadniciParkForm";
            this.Text = "Radnici zaposleni u parku";
            this.Load += new System.EventHandler(this.RadniciParkForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView Radnici;
        private System.Windows.Forms.ColumnHeader Mbr;
        private System.Windows.Forms.ColumnHeader BrRK;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader DatumRodjenja;
        private System.Windows.Forms.ColumnHeader Odrzava;
        private System.Windows.Forms.Button IzbaciRadnika;
        private System.Windows.Forms.Button DodajRadnika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader DatumOd;
        private System.Windows.Forms.ColumnHeader DatumDo;
        private System.Windows.Forms.Label label1;
    }
}