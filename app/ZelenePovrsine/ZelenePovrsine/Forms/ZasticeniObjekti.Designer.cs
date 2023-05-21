namespace ZelenePovrsine.Forms
{
    partial class ZasticeniObjekti
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Drvece = new System.Windows.Forms.ListView();
            this.IdObj1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Visina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Povrsina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Obim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatSadjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrvoOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrvoInstitucija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrvoStavljenPodZastitu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrvoGodTroskovi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpomeniciSkulpture = new System.Windows.Forms.GroupBox();
            this.Ostalo = new System.Windows.Forms.ListView();
            this.IdObj2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Institucija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StavljenPodZastitu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GodTroskovi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ObrisiPovrsinu = new System.Windows.Forms.Button();
            this.outerPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SpomeniciSkulpture.SuspendLayout();
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
            this.outerPanel.Controls.Add(this.groupBox1);
            this.outerPanel.Controls.Add(this.SpomeniciSkulpture);
            this.outerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.outerPanel.Location = new System.Drawing.Point(12, 12);
            this.outerPanel.Name = "outerPanel";
            this.outerPanel.Size = new System.Drawing.Size(467, 387);
            this.outerPanel.TabIndex = 19;
            this.outerPanel.WrapContents = false;
            this.outerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.outerPanel_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.Drvece);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.MaximumSize = new System.Drawing.Size(1000, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(400, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drveće";
            // 
            // Drvece
            // 
            this.Drvece.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdObj1,
            this.Vrsta,
            this.Visina,
            this.Povrsina,
            this.Obim,
            this.DatSadjenja,
            this.DrvoOpis,
            this.DrvoInstitucija,
            this.DrvoStavljenPodZastitu,
            this.DrvoGodTroskovi});
            this.Drvece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Drvece.FullRowSelect = true;
            this.Drvece.GridLines = true;
            this.Drvece.HideSelection = false;
            this.Drvece.Location = new System.Drawing.Point(3, 16);
            this.Drvece.Name = "Drvece";
            this.Drvece.ShowItemToolTips = true;
            this.Drvece.Size = new System.Drawing.Size(456, 181);
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
            this.Obim.Width = 91;
            // 
            // DatSadjenja
            // 
            this.DatSadjenja.Text = "Datum sađenja";
            this.DatSadjenja.Width = 73;
            // 
            // DrvoOpis
            // 
            this.DrvoOpis.Text = "Opis";
            this.DrvoOpis.Width = 205;
            // 
            // DrvoInstitucija
            // 
            this.DrvoInstitucija.Text = "Institucija odgovorna za zaštitu";
            // 
            // DrvoStavljenPodZastitu
            // 
            this.DrvoStavljenPodZastitu.Text = "Stavljen pod zaštitu";
            // 
            // DrvoGodTroskovi
            // 
            this.DrvoGodTroskovi.Text = "Godišnji troškovi";
            // 
            // SpomeniciSkulpture
            // 
            this.SpomeniciSkulpture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpomeniciSkulpture.Controls.Add(this.Ostalo);
            this.SpomeniciSkulpture.Location = new System.Drawing.Point(3, 209);
            this.SpomeniciSkulpture.Name = "SpomeniciSkulpture";
            this.SpomeniciSkulpture.Size = new System.Drawing.Size(462, 272);
            this.SpomeniciSkulpture.TabIndex = 18;
            this.SpomeniciSkulpture.TabStop = false;
            this.SpomeniciSkulpture.Text = "Spomenici i skulpture";
            // 
            // Ostalo
            // 
            this.Ostalo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdObj2,
            this.Tip1,
            this.Opis,
            this.Institucija,
            this.StavljenPodZastitu,
            this.GodTroskovi});
            this.Ostalo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ostalo.FullRowSelect = true;
            this.Ostalo.GridLines = true;
            this.Ostalo.HideSelection = false;
            this.Ostalo.Location = new System.Drawing.Point(3, 16);
            this.Ostalo.Name = "Ostalo";
            this.Ostalo.Size = new System.Drawing.Size(456, 253);
            this.Ostalo.TabIndex = 1;
            this.Ostalo.UseCompatibleStateImageBehavior = false;
            this.Ostalo.View = System.Windows.Forms.View.Details;
            // 
            // IdObj2
            // 
            this.IdObj2.Text = "Id";
            this.IdObj2.Width = 40;
            // 
            // Tip1
            // 
            this.Tip1.Text = "Tip";
            this.Tip1.Width = 86;
            // 
            // Opis
            // 
            this.Opis.Text = "Opis";
            this.Opis.Width = 205;
            // 
            // Institucija
            // 
            this.Institucija.Text = "Institucija odgovorna za zaštitu";
            this.Institucija.Width = 103;
            // 
            // StavljenPodZastitu
            // 
            this.StavljenPodZastitu.Text = "Stavljen pod zaštitu";
            this.StavljenPodZastitu.Width = 73;
            // 
            // GodTroskovi
            // 
            this.GodTroskovi.Text = "Godišnji troškovi";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ObrisiPovrsinu);
            this.panel1.Location = new System.Drawing.Point(485, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 387);
            this.panel1.TabIndex = 20;
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
            this.ObrisiPovrsinu.Location = new System.Drawing.Point(3, 54);
            this.ObrisiPovrsinu.Name = "ObrisiPovrsinu";
            this.ObrisiPovrsinu.Size = new System.Drawing.Size(118, 23);
            this.ObrisiPovrsinu.TabIndex = 2;
            this.ObrisiPovrsinu.Text = "Obriši Objekat";
            this.ObrisiPovrsinu.UseVisualStyleBackColor = true;
            this.ObrisiPovrsinu.Click += new System.EventHandler(this.ObrisiPovrsinu_Click);
            // 
            // ZasticeniObjekti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.outerPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ZasticeniObjekti";
            this.Text = "ZasticeniObjekti";
            this.Load += new System.EventHandler(this.ZasticeniObjekti_Load);
            this.outerPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.SpomeniciSkulpture.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel outerPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView Drvece;
        private System.Windows.Forms.ColumnHeader IdObj1;
        private System.Windows.Forms.ColumnHeader Vrsta;
        private System.Windows.Forms.ColumnHeader Visina;
        private System.Windows.Forms.ColumnHeader Povrsina;
        private System.Windows.Forms.ColumnHeader Obim;
        private System.Windows.Forms.ColumnHeader DatSadjenja;
        private System.Windows.Forms.GroupBox SpomeniciSkulpture;
        private System.Windows.Forms.ListView Ostalo;
        private System.Windows.Forms.ColumnHeader IdObj2;
        private System.Windows.Forms.ColumnHeader Tip1;
        private System.Windows.Forms.ColumnHeader Opis;
        private System.Windows.Forms.ColumnHeader Institucija;
        private System.Windows.Forms.ColumnHeader StavljenPodZastitu;
        private System.Windows.Forms.ColumnHeader GodTroskovi;
        private System.Windows.Forms.ColumnHeader DrvoOpis;
        private System.Windows.Forms.ColumnHeader DrvoInstitucija;
        private System.Windows.Forms.ColumnHeader DrvoStavljenPodZastitu;
        private System.Windows.Forms.ColumnHeader DrvoGodTroskovi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ObrisiPovrsinu;
    }
}