namespace ZelenePovrsine.Forms
{
    partial class Pocetna
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
            this.label1 = new System.Windows.Forms.Label();
            this.ZelenePovrsine = new System.Windows.Forms.Button();
            this.Radnici = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zelene Površine";
            // 
            // ZelenePovrsine
            // 
            this.ZelenePovrsine.Location = new System.Drawing.Point(32, 261);
            this.ZelenePovrsine.Name = "ZelenePovrsine";
            this.ZelenePovrsine.Size = new System.Drawing.Size(167, 23);
            this.ZelenePovrsine.TabIndex = 1;
            this.ZelenePovrsine.Text = "Zelene površine";
            this.ZelenePovrsine.UseVisualStyleBackColor = true;
            this.ZelenePovrsine.Click += new System.EventHandler(this.ZelenePovrsine_Click);
            // 
            // Radnici
            // 
            this.Radnici.Location = new System.Drawing.Point(32, 290);
            this.Radnici.Name = "Radnici";
            this.Radnici.Size = new System.Drawing.Size(167, 23);
            this.Radnici.TabIndex = 2;
            this.Radnici.Text = "Radnici";
            this.Radnici.UseVisualStyleBackColor = true;
            this.Radnici.Click += new System.EventHandler(this.Radnici_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::ZelenePovrsine.Properties.Resources.ZelenePovrsinePocetna1;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(32, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 205);
            this.panel1.TabIndex = 0;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.Radnici);
            this.Controls.Add(this.ZelenePovrsine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Pocetna";
            this.Text = "Zelene Površine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ZelenePovrsine;
        private System.Windows.Forms.Button Radnici;
    }
}