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
            this.LokacijaAutobusneStaniceZaBrisanje = new System.Windows.Forms.TextBox();
            this.UnesiLokacijuLabel = new System.Windows.Forms.Label();
            this.GumbOdustani = new System.Windows.Forms.Button();
            this.GumbZaBrisanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNaVrhuEkrana
            // 
            this.LabelNaVrhuEkrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNaVrhuEkrana.Location = new System.Drawing.Point(273, 53);
            this.LabelNaVrhuEkrana.Name = "LabelNaVrhuEkrana";
            this.LabelNaVrhuEkrana.Size = new System.Drawing.Size(273, 57);
            this.LabelNaVrhuEkrana.TabIndex = 44;
            this.LabelNaVrhuEkrana.Text = "Forma za brisanje postojeće autobusne stanice";
            this.LabelNaVrhuEkrana.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // LokacijaAutobusneStaniceZaBrisanje
            // 
            this.LokacijaAutobusneStaniceZaBrisanje.Location = new System.Drawing.Point(356, 160);
            this.LokacijaAutobusneStaniceZaBrisanje.Name = "LokacijaAutobusneStaniceZaBrisanje";
            this.LokacijaAutobusneStaniceZaBrisanje.Size = new System.Drawing.Size(174, 20);
            this.LokacijaAutobusneStaniceZaBrisanje.TabIndex = 40;
 
            // 
            // UnesiLokacijuLabel
            // 
            this.UnesiLokacijuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UnesiLokacijuLabel.Location = new System.Drawing.Point(249, 161);
            this.UnesiLokacijuLabel.Name = "UnesiLokacijuLabel";
            this.UnesiLokacijuLabel.Size = new System.Drawing.Size(107, 20);
            this.UnesiLokacijuLabel.TabIndex = 39;
            this.UnesiLokacijuLabel.Text = "Lokacija stanice:";
 
            // 
            // GumbOdustani
            // 
            this.GumbOdustani.Location = new System.Drawing.Point(420, 374);
            this.GumbOdustani.Name = "GumbOdustani";
            this.GumbOdustani.Size = new System.Drawing.Size(75, 23);
            this.GumbOdustani.TabIndex = 37;
            this.GumbOdustani.Text = "Odustani";
            this.GumbOdustani.UseVisualStyleBackColor = true;
            this.GumbOdustani.Click += new System.EventHandler(this.GumbOdustani_Click);
            // 
            // GumbZaBrisanje
            // 
            this.GumbZaBrisanje.Location = new System.Drawing.Point(306, 374);
            this.GumbZaBrisanje.Name = "GumbZaBrisanje";
            this.GumbZaBrisanje.Size = new System.Drawing.Size(75, 23);
            this.GumbZaBrisanje.TabIndex = 36;
            this.GumbZaBrisanje.Text = "Briši";
            this.GumbZaBrisanje.UseVisualStyleBackColor = true;
            this.GumbZaBrisanje.Click += new System.EventHandler(this.GumbZaBrisanje_Click);
            // 
            // BrisiAutobusnuStanicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelNaVrhuEkrana);
            this.Controls.Add(this.LokacijaAutobusneStaniceZaBrisanje);
            this.Controls.Add(this.UnesiLokacijuLabel);
            this.Controls.Add(this.GumbOdustani);
            this.Controls.Add(this.GumbZaBrisanje);
            this.Name = "BrisiAutobusnuStanicu";
            this.Text = "Brisanje autobusne stanice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNaVrhuEkrana;
        private System.Windows.Forms.TextBox LokacijaAutobusneStaniceZaBrisanje;
        private System.Windows.Forms.Label UnesiLokacijuLabel;
        private System.Windows.Forms.Button GumbOdustani;
        private System.Windows.Forms.Button GumbZaBrisanje;
    }
}