namespace ZelenePovrsine.Forms
{
    partial class ObjektiParka
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
            this.outerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox = new System.Windows.Forms.GroupBox();
            this.Drvece = new System.Windows.Forms.ListView();
            this.IdObj1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Visina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Povrsina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Obim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatSadjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Igralista = new System.Windows.Forms.ListView();
            this.IdObj3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrIgracaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uzrast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pesak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ostalo = new System.Windows.Forms.ListView();
            this.IdObj4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ObrisiPovrsinu = new System.Windows.Forms.Button();
            this.DodajPovrsinu = new System.Windows.Forms.Button();
            this.outerPanel.SuspendLayout();
            this.comboBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.outerPanel.Controls.Add(this.comboBox);
            this.outerPanel.Controls.Add(this.groupBox4);
            this.outerPanel.Controls.Add(this.groupBox2);
            this.outerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.outerPanel.Location = new System.Drawing.Point(6, 12);
            this.outerPanel.Name = "outerPanel";
            this.outerPanel.Size = new System.Drawing.Size(470, 387);
            this.outerPanel.TabIndex = 18;
            this.outerPanel.WrapContents = false;
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox.Controls.Add(this.Drvece);
            this.comboBox.Location = new System.Drawing.Point(3, 3);
            this.comboBox.MaximumSize = new System.Drawing.Size(1000, 0);
            this.comboBox.MinimumSize = new System.Drawing.Size(400, 200);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(435, 200);
            this.comboBox.TabIndex = 0;
            this.comboBox.TabStop = false;
            this.comboBox.Text = "Drveće";
            // 
            // Drvece
            // 
            this.Drvece.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdObj1,
            this.Vrsta,
            this.Visina,
            this.Povrsina,
            this.Obim,
            this.DatSadjenja});
            this.Drvece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Drvece.FullRowSelect = true;
            this.Drvece.GridLines = true;
            this.Drvece.HideSelection = false;
            this.Drvece.Location = new System.Drawing.Point(3, 16);
            this.Drvece.Name = "Drvece";
            this.Drvece.ShowItemToolTips = true;
            this.Drvece.Size = new System.Drawing.Size(429, 181);
            this.Drvece.TabIndex = 0;
            this.Drvece.UseCompatibleStateImageBehavior = false;
            this.Drvece.View = System.Windows.Forms.View.Details;
            // 
            // IdObj1
            // 
            this.IdObj1.Text = "Id";
            this.IdObj1.Width = 49;
            // 
            // Vrsta
            // 
            this.Vrsta.Text = "Vrsta";
            this.Vrsta.Width = 136;
            // 
            // Visina
            // 
            this.Visina.Text = "Visina krošnje";
            this.Visina.Width = 88;
            // 
            // Povrsina
            // 
            this.Povrsina.Text = "Površina krošnje";
            this.Povrsina.Width = 96;
            // 
            // Obim
            // 
            this.Obim.Text = "Obim debla";
            this.Obim.Width = 97;
            // 
            // DatSadjenja
            // 
            this.DatSadjenja.Text = "Datum sađenja";
            this.DatSadjenja.Width = 73;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.Igralista);
            this.groupBox4.Location = new System.Drawing.Point(3, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 233);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Igrališta";
            // 
            // Igralista
            // 
            this.Igralista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdObj3,
            this.BrIgracaka,
            this.Uzrast,
            this.Pesak});
            this.Igralista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Igralista.FullRowSelect = true;
            this.Igralista.GridLines = true;
            this.Igralista.HideSelection = false;
            this.Igralista.Location = new System.Drawing.Point(3, 16);
            this.Igralista.Name = "Igralista";
            this.Igralista.Size = new System.Drawing.Size(429, 214);
            this.Igralista.TabIndex = 0;
            this.Igralista.UseCompatibleStateImageBehavior = false;
            this.Igralista.View = System.Windows.Forms.View.Details;
            // 
            // IdObj3
            // 
            this.IdObj3.Text = "Id";
            this.IdObj3.Width = 53;
            // 
            // BrIgracaka
            // 
            this.BrIgracaka.Text = "Broj igračaka";
            this.BrIgracaka.Width = 86;
            // 
            // Uzrast
            // 
            this.Uzrast.Text = "Uzrast";
            this.Uzrast.Width = 134;
            // 
            // Pesak
            // 
            this.Pesak.Text = "Da li ima pesak";
            this.Pesak.Width = 96;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Ostalo);
            this.groupBox2.Location = new System.Drawing.Point(3, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Svetiljke, klupe i fontane";
            // 
            // Ostalo
            // 
            this.Ostalo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdObj4,
            this.Tip2});
            this.Ostalo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ostalo.FullRowSelect = true;
            this.Ostalo.GridLines = true;
            this.Ostalo.HideSelection = false;
            this.Ostalo.Location = new System.Drawing.Point(3, 16);
            this.Ostalo.Name = "Ostalo";
            this.Ostalo.Size = new System.Drawing.Size(429, 214);
            this.Ostalo.TabIndex = 0;
            this.Ostalo.UseCompatibleStateImageBehavior = false;
            this.Ostalo.View = System.Windows.Forms.View.Details;
            // 
            // IdObj4
            // 
            this.IdObj4.Text = "Id";
            this.IdObj4.Width = 53;
            // 
            // Tip2
            // 
            this.Tip2.Text = "Tip";
            this.Tip2.Width = 86;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ObrisiPovrsinu);
            this.panel1.Controls.Add(this.DodajPovrsinu);
            this.panel1.Location = new System.Drawing.Point(482, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 387);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Zaštićeni objekti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Objekti";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Prikaži zaštićene objekte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // ObrisiPovrsinu
            // 
            this.ObrisiPovrsinu.Location = new System.Drawing.Point(3, 86);
            this.ObrisiPovrsinu.Name = "ObrisiPovrsinu";
            this.ObrisiPovrsinu.Size = new System.Drawing.Size(118, 23);
            this.ObrisiPovrsinu.TabIndex = 2;
            this.ObrisiPovrsinu.Text = "Obriši Objekat";
            this.ObrisiPovrsinu.UseVisualStyleBackColor = true;
            this.ObrisiPovrsinu.Click += new System.EventHandler(this.ObrisiPovrsinu_Click);
            // 
            // DodajPovrsinu
            // 
            this.DodajPovrsinu.Location = new System.Drawing.Point(3, 57);
            this.DodajPovrsinu.Name = "DodajPovrsinu";
            this.DodajPovrsinu.Size = new System.Drawing.Size(118, 23);
            this.DodajPovrsinu.TabIndex = 0;
            this.DodajPovrsinu.Text = "Dodaj Objekat";
            this.DodajPovrsinu.UseVisualStyleBackColor = true;
            this.DodajPovrsinu.Click += new System.EventHandler(this.DodajPovrsinu_Click);
            // 
            // ObjektiParka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.outerPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ObjektiParka";
            this.Text = "ObjektiParka";
            this.Load += new System.EventHandler(this.ObjektiParka_Load);
            this.outerPanel.ResumeLayout(false);
            this.comboBox.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel outerPanel;
        private System.Windows.Forms.GroupBox comboBox;
        private System.Windows.Forms.ListView Drvece;
        private System.Windows.Forms.ColumnHeader IdObj1;
        private System.Windows.Forms.ColumnHeader Vrsta;
        private System.Windows.Forms.ColumnHeader Visina;
        private System.Windows.Forms.ColumnHeader Povrsina;
        private System.Windows.Forms.ColumnHeader Obim;
        private System.Windows.Forms.ColumnHeader DatSadjenja;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView Igralista;
        private System.Windows.Forms.ColumnHeader IdObj3;
        private System.Windows.Forms.ColumnHeader BrIgracaka;
        private System.Windows.Forms.ColumnHeader Uzrast;
        private System.Windows.Forms.ColumnHeader Pesak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView Ostalo;
        private System.Windows.Forms.ColumnHeader IdObj4;
        private System.Windows.Forms.ColumnHeader Tip2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ObrisiPovrsinu;
        private System.Windows.Forms.Button DodajPovrsinu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}