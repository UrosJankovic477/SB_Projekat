namespace ZelenePovrsine.Forms
{
    partial class DodajZelenaPovrsina
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
            this.Ugrozenost = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TipPovrsine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Opstina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nazad = new System.Windows.Forms.Button();
            this.Dalje = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Ugrozenost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TipPovrsine);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Opstina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 303);
            this.panel1.TabIndex = 1;
            // 
            // Ugrozenost
            // 
            this.Ugrozenost.FormattingEnabled = true;
            this.Ugrozenost.Items.AddRange(new object[] {
            "Niska",
            "Srednja",
            "Visoka"});
            this.Ugrozenost.Location = new System.Drawing.Point(3, 6);
            this.Ugrozenost.Name = "Ugrozenost";
            this.Ugrozenost.Size = new System.Drawing.Size(105, 21);
            this.Ugrozenost.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip površine";
            // 
            // TipPovrsine
            // 
            this.TipPovrsine.FormattingEnabled = true;
            this.TipPovrsine.Items.AddRange(new object[] {
            "Drvored",
            "Park",
            "Travnjak"});
            this.TipPovrsine.Location = new System.Drawing.Point(3, 71);
            this.TipPovrsine.Name = "TipPovrsine";
            this.TipPovrsine.Size = new System.Drawing.Size(121, 21);
            this.TipPovrsine.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opština";
            // 
            // Opstina
            // 
            this.Opstina.Location = new System.Drawing.Point(3, 45);
            this.Opstina.Name = "Opstina";
            this.Opstina.Size = new System.Drawing.Size(100, 20);
            this.Opstina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 6);
            this.label1.MaximumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ugroženost od zagađenja";
            // 
            // Nazad
            // 
            this.Nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Nazad.Location = new System.Drawing.Point(75, 321);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(75, 23);
            this.Nazad.TabIndex = 3;
            this.Nazad.Text = "Nazad";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Dalje
            // 
            this.Dalje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Dalje.Location = new System.Drawing.Point(156, 321);
            this.Dalje.Name = "Dalje";
            this.Dalje.Size = new System.Drawing.Size(75, 23);
            this.Dalje.TabIndex = 4;
            this.Dalje.Text = "Dalje";
            this.Dalje.UseVisualStyleBackColor = true;
            this.Dalje.Click += new System.EventHandler(this.Dalje_Click);
            // 
            // DodajZelenaPovrsina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.Dalje);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.panel1);
            this.Name = "DodajZelenaPovrsina";
            this.Text = "Doda površinu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Opstina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipPovrsine;
        private System.Windows.Forms.Button Dalje;
        private System.Windows.Forms.ComboBox Ugrozenost;
    }
}