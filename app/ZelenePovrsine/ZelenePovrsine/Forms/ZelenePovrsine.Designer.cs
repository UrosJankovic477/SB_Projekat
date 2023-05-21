namespace ZelenePovrsine.Forms
{
    partial class ZelenePovrsine
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
            this.Parkovi = new System.Windows.Forms.ListView();
            this.IdPark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpstinaPark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UgrozenostPark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Povrsina_ha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Travnjaci = new System.Windows.Forms.ListView();
            this.IdTravnjak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpstinaTravnjak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UgrozenostTravnjak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdresaZgrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Povrsina_a = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.outerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Drvoredi = new System.Windows.Forms.ListView();
            this.IdDrvored = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpstinaDrvored = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UgrozenostDrvored = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrStabala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VrstaDrveta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PrikaziObjekte = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrikaziSefove = new System.Windows.Forms.Button();
            this.PrikaziRadnike = new System.Windows.Forms.Button();
            this.ObrisiPovrsinu = new System.Windows.Forms.Button();
            this.IzmeniPovrsinu = new System.Windows.Forms.Button();
            this.DodajPovrsinu = new System.Windows.Forms.Button();
            this.outerPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Parkovi
            // 
            this.Parkovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdPark,
            this.OpstinaPark,
            this.UgrozenostPark,
            this.Naziv,
            this.Povrsina_ha});
            this.Parkovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parkovi.FullRowSelect = true;
            this.Parkovi.GridLines = true;
            this.Parkovi.HideSelection = false;
            this.Parkovi.Location = new System.Drawing.Point(3, 16);
            this.Parkovi.Name = "Parkovi";
            this.Parkovi.Size = new System.Drawing.Size(429, 214);
            this.Parkovi.TabIndex = 0;
            this.Parkovi.UseCompatibleStateImageBehavior = false;
            this.Parkovi.View = System.Windows.Forms.View.Details;
            this.Parkovi.SelectedIndexChanged += new System.EventHandler(this.Parkovi_SelectedIndexChanged);
            // 
            // IdPark
            // 
            this.IdPark.Text = "Id";
            this.IdPark.Width = 53;
            // 
            // OpstinaPark
            // 
            this.OpstinaPark.Text = "Opština";
            this.OpstinaPark.Width = 86;
            // 
            // UgrozenostPark
            // 
            this.UgrozenostPark.Text = "Ugroženost od zagađenja";
            this.UgrozenostPark.Width = 134;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 96;
            // 
            // Povrsina_ha
            // 
            this.Povrsina_ha.Text = "Površina (ha)";
            this.Povrsina_ha.Width = 73;
            // 
            // Travnjaci
            // 
            this.Travnjaci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdTravnjak,
            this.OpstinaTravnjak,
            this.UgrozenostTravnjak,
            this.AdresaZgrade,
            this.Povrsina_a});
            this.Travnjaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Travnjaci.FullRowSelect = true;
            this.Travnjaci.GridLines = true;
            this.Travnjaci.HideSelection = false;
            this.Travnjaci.Location = new System.Drawing.Point(3, 16);
            this.Travnjaci.Name = "Travnjaci";
            this.Travnjaci.Size = new System.Drawing.Size(426, 253);
            this.Travnjaci.TabIndex = 1;
            this.Travnjaci.UseCompatibleStateImageBehavior = false;
            this.Travnjaci.View = System.Windows.Forms.View.Details;
            this.Travnjaci.SelectedIndexChanged += new System.EventHandler(this.Travnjaci_SelectedIndexChanged);
            // 
            // IdTravnjak
            // 
            this.IdTravnjak.Text = "Id";
            this.IdTravnjak.Width = 40;
            // 
            // OpstinaTravnjak
            // 
            this.OpstinaTravnjak.Text = "Opština";
            this.OpstinaTravnjak.Width = 86;
            // 
            // UgrozenostTravnjak
            // 
            this.UgrozenostTravnjak.Text = "Ugroženost od zagađenja";
            this.UgrozenostTravnjak.Width = 134;
            // 
            // AdresaZgrade
            // 
            this.AdresaZgrade.Text = "Adresa zgrade";
            this.AdresaZgrade.Width = 96;
            // 
            // Povrsina_a
            // 
            this.Povrsina_a.Text = "Površina (a)";
            this.Povrsina_a.Width = 73;
            // 
            // outerPanel
            // 
            this.outerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outerPanel.AutoScroll = true;
            this.outerPanel.AutoScrollMargin = new System.Drawing.Size(300, 0);
            this.outerPanel.AutoScrollMinSize = new System.Drawing.Size(100, 700);
            this.outerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outerPanel.Controls.Add(this.groupBox1);
            this.outerPanel.Controls.Add(this.groupBox3);
            this.outerPanel.Controls.Add(this.groupBox2);
            this.outerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.outerPanel.Location = new System.Drawing.Point(5, 12);
            this.outerPanel.Name = "outerPanel";
            this.outerPanel.Size = new System.Drawing.Size(470, 387);
            this.outerPanel.TabIndex = 16;
            this.outerPanel.WrapContents = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Drvoredi);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.MaximumSize = new System.Drawing.Size(1000, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(400, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drvoredi";
            // 
            // Drvoredi
            // 
            this.Drvoredi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdDrvored,
            this.UgrozenostDrvored,
            this.OpstinaDrvored,
            this.Ulica,
            this.VrstaDrveta,
            this.BrStabala});
            this.Drvoredi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Drvoredi.FullRowSelect = true;
            this.Drvoredi.GridLines = true;
            this.Drvoredi.HideSelection = false;
            this.Drvoredi.Location = new System.Drawing.Point(3, 16);
            this.Drvoredi.Name = "Drvoredi";
            this.Drvoredi.ShowItemToolTips = true;
            this.Drvoredi.Size = new System.Drawing.Size(429, 181);
            this.Drvoredi.TabIndex = 0;
            this.Drvoredi.UseCompatibleStateImageBehavior = false;
            this.Drvoredi.View = System.Windows.Forms.View.Details;
            this.Drvoredi.SelectedIndexChanged += new System.EventHandler(this.Drvoredi_SelectedIndexChanged);
            // 
            // IdDrvored
            // 
            this.IdDrvored.Text = "Id";
            this.IdDrvored.Width = 49;
            // 
            // OpstinaDrvored
            // 
            this.OpstinaDrvored.Text = "Opština";
            this.OpstinaDrvored.Width = 88;
            // 
            // UgrozenostDrvored
            // 
            this.UgrozenostDrvored.Text = "Ugroženost od zagađenja";
            this.UgrozenostDrvored.Width = 136;
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            this.Ulica.Width = 96;
            // 
            // BrStabala
            // 
            this.BrStabala.Text = "Br. stabala";
            this.BrStabala.Width = 73;
            // 
            // VrstaDrveta
            // 
            this.VrstaDrveta.Text = "Vrsta drveta";
            this.VrstaDrveta.Width = 97;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.Travnjaci);
            this.groupBox3.Location = new System.Drawing.Point(4, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 272);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Travnjaci";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Parkovi);
            this.groupBox2.Location = new System.Drawing.Point(3, 487);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parkovi";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PrikaziObjekte);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PrikaziSefove);
            this.panel1.Controls.Add(this.PrikaziRadnike);
            this.panel1.Controls.Add(this.ObrisiPovrsinu);
            this.panel1.Controls.Add(this.IzmeniPovrsinu);
            this.panel1.Controls.Add(this.DodajPovrsinu);
            this.panel1.Location = new System.Drawing.Point(481, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 387);
            this.panel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Opcije:";
            // 
            // PrikaziObjekte
            // 
            this.PrikaziObjekte.Location = new System.Drawing.Point(3, 295);
            this.PrikaziObjekte.Name = "PrikaziObjekte";
            this.PrikaziObjekte.Size = new System.Drawing.Size(118, 23);
            this.PrikaziObjekte.TabIndex = 15;
            this.PrikaziObjekte.Text = "Prikaži objekte";
            this.PrikaziObjekte.UseVisualStyleBackColor = true;
            this.PrikaziObjekte.Click += new System.EventHandler(this.PrikaziObjekte_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Objekti parkova";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Šefovi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Radnici";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zelene površine";
            // 
            // PrikaziSefove
            // 
            this.PrikaziSefove.Location = new System.Drawing.Point(3, 235);
            this.PrikaziSefove.Name = "PrikaziSefove";
            this.PrikaziSefove.Size = new System.Drawing.Size(118, 23);
            this.PrikaziSefove.TabIndex = 8;
            this.PrikaziSefove.Text = "Prikaži šefove";
            this.PrikaziSefove.UseVisualStyleBackColor = true;
            this.PrikaziSefove.Click += new System.EventHandler(this.PrikaziSefove_Click);
            // 
            // PrikaziRadnike
            // 
            this.PrikaziRadnike.Location = new System.Drawing.Point(3, 168);
            this.PrikaziRadnike.Name = "PrikaziRadnike";
            this.PrikaziRadnike.Size = new System.Drawing.Size(118, 23);
            this.PrikaziRadnike.TabIndex = 3;
            this.PrikaziRadnike.Text = "Prikaži radnike";
            this.PrikaziRadnike.UseVisualStyleBackColor = true;
            this.PrikaziRadnike.Click += new System.EventHandler(this.PrikaziRadnike_Click);
            // 
            // ObrisiPovrsinu
            // 
            this.ObrisiPovrsinu.Location = new System.Drawing.Point(3, 115);
            this.ObrisiPovrsinu.Name = "ObrisiPovrsinu";
            this.ObrisiPovrsinu.Size = new System.Drawing.Size(118, 23);
            this.ObrisiPovrsinu.TabIndex = 2;
            this.ObrisiPovrsinu.Text = "Obriši površinu";
            this.ObrisiPovrsinu.UseVisualStyleBackColor = true;
            this.ObrisiPovrsinu.Click += new System.EventHandler(this.ObrisiPovrsinu_Click);
            // 
            // IzmeniPovrsinu
            // 
            this.IzmeniPovrsinu.Location = new System.Drawing.Point(3, 86);
            this.IzmeniPovrsinu.Name = "IzmeniPovrsinu";
            this.IzmeniPovrsinu.Size = new System.Drawing.Size(118, 23);
            this.IzmeniPovrsinu.TabIndex = 1;
            this.IzmeniPovrsinu.Text = "Izmeni površinu";
            this.IzmeniPovrsinu.UseVisualStyleBackColor = true;
            this.IzmeniPovrsinu.Click += new System.EventHandler(this.IzmeniPovrsinu_Click);
            // 
            // DodajPovrsinu
            // 
            this.DodajPovrsinu.Location = new System.Drawing.Point(3, 57);
            this.DodajPovrsinu.Name = "DodajPovrsinu";
            this.DodajPovrsinu.Size = new System.Drawing.Size(118, 23);
            this.DodajPovrsinu.TabIndex = 0;
            this.DodajPovrsinu.Text = "Dodaj površinu";
            this.DodajPovrsinu.UseVisualStyleBackColor = true;
            this.DodajPovrsinu.Click += new System.EventHandler(this.DodajPovrsinu_Click);
            // 
            // ZelenePovrsine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.outerPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ZelenePovrsine";
            this.Text = "Zelene povrsine";
            this.Load += new System.EventHandler(this.ZelenePovrsine_Load);
            this.outerPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView Parkovi;
        private System.Windows.Forms.ColumnHeader IdPark;
        private System.Windows.Forms.ColumnHeader OpstinaPark;
        private System.Windows.Forms.ColumnHeader UgrozenostPark;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Povrsina_ha;
        private System.Windows.Forms.ListView Travnjaci;
        private System.Windows.Forms.ColumnHeader IdTravnjak;
        private System.Windows.Forms.ColumnHeader OpstinaTravnjak;
        private System.Windows.Forms.ColumnHeader UgrozenostTravnjak;
        private System.Windows.Forms.ColumnHeader AdresaZgrade;
        private System.Windows.Forms.ColumnHeader Povrsina_a;
        private System.Windows.Forms.FlowLayoutPanel outerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PrikaziRadnike;
        private System.Windows.Forms.Button ObrisiPovrsinu;
        private System.Windows.Forms.Button IzmeniPovrsinu;
        private System.Windows.Forms.Button DodajPovrsinu;
        private System.Windows.Forms.Button PrikaziSefove;
        private System.Windows.Forms.ListView Drvoredi;
        private System.Windows.Forms.ColumnHeader IdDrvored;
        private System.Windows.Forms.ColumnHeader OpstinaDrvored;
        private System.Windows.Forms.ColumnHeader UgrozenostDrvored;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader BrStabala;
        private System.Windows.Forms.ColumnHeader VrstaDrveta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PrikaziObjekte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}