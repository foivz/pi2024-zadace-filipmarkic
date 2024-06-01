namespace Treća_zadaća
{
    partial class BrisiStanicu
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
            this.LabelNaVrhuEkrana = new System.Windows.Forms.Label();
            this.GumbOdustani = new System.Windows.Forms.Button();
            this.GumbZaBrisanje = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelNaVrhuEkrana
            // 
            this.LabelNaVrhuEkrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNaVrhuEkrana.Location = new System.Drawing.Point(364, 65);
            this.LabelNaVrhuEkrana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNaVrhuEkrana.Name = "LabelNaVrhuEkrana";
            this.LabelNaVrhuEkrana.Size = new System.Drawing.Size(364, 70);
            this.LabelNaVrhuEkrana.TabIndex = 44;
            this.LabelNaVrhuEkrana.Text = "Forma za brisanje postojeće autobusne stanice";
            this.LabelNaVrhuEkrana.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GumbOdustani
            // 
            this.GumbOdustani.Location = new System.Drawing.Point(560, 460);
            this.GumbOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.GumbOdustani.Name = "GumbOdustani";
            this.GumbOdustani.Size = new System.Drawing.Size(100, 28);
            this.GumbOdustani.TabIndex = 37;
            this.GumbOdustani.Text = "Odustani";
            this.GumbOdustani.UseVisualStyleBackColor = true;
            this.GumbOdustani.Click += new System.EventHandler(this.GumbOdustani_Click);
            // 
            // GumbZaBrisanje
            // 
            this.GumbZaBrisanje.Location = new System.Drawing.Point(408, 460);
            this.GumbZaBrisanje.Margin = new System.Windows.Forms.Padding(4);
            this.GumbZaBrisanje.Name = "GumbZaBrisanje";
            this.GumbZaBrisanje.Size = new System.Drawing.Size(100, 28);
            this.GumbZaBrisanje.TabIndex = 36;
            this.GumbZaBrisanje.Text = "Briši";
            this.GumbZaBrisanje.UseVisualStyleBackColor = true;
            this.GumbZaBrisanje.Click += new System.EventHandler(this.GumbZaBrisanje_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(432, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 45;
            // 
            // BrisiStanicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelNaVrhuEkrana);
            this.Controls.Add(this.GumbOdustani);
            this.Controls.Add(this.GumbZaBrisanje);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrisiStanicu";
            this.Text = "Brisanje autobusne stanice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelNaVrhuEkrana;
        private System.Windows.Forms.Button GumbOdustani;
        private System.Windows.Forms.Button GumbZaBrisanje;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}