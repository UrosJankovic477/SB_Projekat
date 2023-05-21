namespace ZelenePovrsine.Forms
{
    partial class DodajRadnikaParkuForm
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
            this.DodeliRadnika = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Mbr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrRK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumRodjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odrzava = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DodeliRadnika);
            this.panel1.Location = new System.Drawing.Point(475, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 387);
            this.panel1.TabIndex = 18;
            // 
            // DodeliRadnika
            // 
            this.DodeliRadnika.Location = new System.Drawing.Point(3, 3);
            this.DodeliRadnika.Name = "DodeliRadnika";
            this.DodeliRadnika.Size = new System.Drawing.Size(118, 23);
            this.DodeliRadnika.TabIndex = 0;
            this.DodeliRadnika.Text = "Dodeli radnika";
            this.DodeliRadnika.UseVisualStyleBackColor = true;
            this.DodeliRadnika.Click += new System.EventHandler(this.DodeliRadnika_Click);
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
            this.panel2.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radnici";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mbr,
            this.BrRK,
            this.Ime,
            this.Adresa,
            this.DatumRodjenja,
            this.Odrzava});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(452, 356);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Mbr
            // 
            this.Mbr.Text = "Matični br.";
            this.Mbr.Width = 66;
            // 
            // BrRK
            // 
            this.BrRK.Text = "Br. radne knjižice";
            this.BrRK.Width = 102;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 135;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.MaximumSize = new System.Drawing.Size(140, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite radnika kog želite da pridružite grupi za održavanje parka";
            // 
            // DodajRadnikaParkuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DodajRadnikaParkuForm";
            this.Text = "Radnici";
            this.Load += new System.EventHandler(this.DodajRadnikaParkuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DodeliRadnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Mbr;
        private System.Windows.Forms.ColumnHeader BrRK;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader DatumRodjenja;
        private System.Windows.Forms.ColumnHeader Odrzava;
    }
}