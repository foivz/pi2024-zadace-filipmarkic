namespace Treća_zadaća
{
    partial class AzurirajAutobusnuStanicu
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
            this.UnesiIDLabel = new System.Windows.Forms.Label();
            this.AzuriraniNazivAutobusneStanice = new System.Windows.Forms.TextBox();
            this.UnesiNazivLabel = new System.Windows.Forms.Label();
            this.AzuriranaLokacijaAutobusneStanice = new System.Windows.Forms.TextBox();
            this.UnesiLokacijuLabel = new System.Windows.Forms.Label();
            this.IDAutobusneStanice = new System.Windows.Forms.TextBox();
            this.GumbOdustani = new System.Windows.Forms.Button();
            this.GumbZaAzuriranje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNaVrhuEkrana
            // 
            this.LabelNaVrhuEkrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNaVrhuEkrana.Location = new System.Drawing.Point(265, 55);
            this.LabelNaVrhuEkrana.Name = "LabelNaVrhuEkrana";
            this.LabelNaVrhuEkrana.Size = new System.Drawing.Size(273, 57);
            this.LabelNaVrhuEkrana.TabIndex = 35;
            this.LabelNaVrhuEkrana.Text = "Forma za ažuriranje postojeće autobusne stanice";
            this.LabelNaVrhuEkrana.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UnesiIDLabel
            // 
            this.UnesiIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UnesiIDLabel.Location = new System.Drawing.Point(276, 158);
            this.UnesiIDLabel.Name = "UnesiIDLabel";
            this.UnesiIDLabel.Size = new System.Drawing.Size(57, 19);
            this.UnesiIDLabel.TabIndex = 34;
            this.UnesiIDLabel.Text = "Unesi ID:";
            // 
            // AzuriraniNazivAutobusneStanice
            // 
            this.AzuriraniNazivAutobusneStanice.Location = new System.Drawing.Point(339, 298);
            this.AzuriraniNazivAutobusneStanice.Name = "AzuriraniNazivAutobusneStanice";
            this.AzuriraniNazivAutobusneStanice.Size = new System.Drawing.Size(174, 20);
            this.AzuriraniNazivAutobusneStanice.TabIndex = 33;
            // 
            // UnesiNazivLabel
            // 
            this.UnesiNazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UnesiNazivLabel.Location = new System.Drawing.Point(256, 299);
            this.UnesiNazivLabel.Name = "UnesiNazivLabel";
            this.UnesiNazivLabel.Size = new System.Drawing.Size(77, 19);
            this.UnesiNazivLabel.TabIndex = 32;
            this.UnesiNazivLabel.Text = "Unesi naziv:";
            // 
            // AzuriranaLokacijaAutobusneStanice
            // 
            this.AzuriranaLokacijaAutobusneStanice.Location = new System.Drawing.Point(339, 228);
            this.AzuriranaLokacijaAutobusneStanice.Name = "AzuriranaLokacijaAutobusneStanice";
            this.AzuriranaLokacijaAutobusneStanice.Size = new System.Drawing.Size(174, 20);
            this.AzuriranaLokacijaAutobusneStanice.TabIndex = 31;
            // 
            // UnesiLokacijuLabel
            // 
            this.UnesiLokacijuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UnesiLokacijuLabel.Location = new System.Drawing.Point(246, 229);
            this.UnesiLokacijuLabel.Name = "UnesiLokacijuLabel";
            this.UnesiLokacijuLabel.Size = new System.Drawing.Size(93, 20);
            this.UnesiLokacijuLabel.TabIndex = 30;
            this.UnesiLokacijuLabel.Text = "Unesi lokaciju:";
            // 
            // IDAutobusneStanice
            // 
            this.IDAutobusneStanice.Location = new System.Drawing.Point(339, 157);
            this.IDAutobusneStanice.Name = "IDAutobusneStanice";
            this.IDAutobusneStanice.Size = new System.Drawing.Size(174, 20);
            this.IDAutobusneStanice.TabIndex = 29;
            this.IDAutobusneStanice.TextChanged += new System.EventHandler(this.IDAutobusneStanice_TextChanged);
            // 
            // GumbOdustani
            // 
            this.GumbOdustani.Location = new System.Drawing.Point(412, 376);
            this.GumbOdustani.Name = "GumbOdustani";
            this.GumbOdustani.Size = new System.Drawing.Size(75, 23);
            this.GumbOdustani.TabIndex = 28;
            this.GumbOdustani.Text = "Odustani";
            this.GumbOdustani.UseVisualStyleBackColor = true;
            this.GumbOdustani.Click += new System.EventHandler(this.GumbOdustani_Click);
            // 
            // GumbZaAzuriranje
            // 
            this.GumbZaAzuriranje.Location = new System.Drawing.Point(298, 376);
            this.GumbZaAzuriranje.Name = "GumbZaAzuriranje";
            this.GumbZaAzuriranje.Size = new System.Drawing.Size(75, 23);
            this.GumbZaAzuriranje.TabIndex = 27;
            this.GumbZaAzuriranje.Text = "Ažuriraj";
            this.GumbZaAzuriranje.UseVisualStyleBackColor = true;
            this.GumbZaAzuriranje.Click += new System.EventHandler(this.GumbZaAzuriranje_Click);
            // 
            // AzurirajAutobusnuStanicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelNaVrhuEkrana);
            this.Controls.Add(this.UnesiIDLabel);
            this.Controls.Add(this.AzuriraniNazivAutobusneStanice);
            this.Controls.Add(this.UnesiNazivLabel);
            this.Controls.Add(this.AzuriranaLokacijaAutobusneStanice);
            this.Controls.Add(this.UnesiLokacijuLabel);
            this.Controls.Add(this.IDAutobusneStanice);
            this.Controls.Add(this.GumbOdustani);
            this.Controls.Add(this.GumbZaAzuriranje);
            this.Name = "AzurirajAutobusnuStanicu";
            this.Text = "Azuriranje autobusne stanice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNaVrhuEkrana;
        private System.Windows.Forms.Label UnesiIDLabel;
        private System.Windows.Forms.TextBox AzuriraniNazivAutobusneStanice;
        private System.Windows.Forms.Label UnesiNazivLabel;
        private System.Windows.Forms.TextBox AzuriranaLokacijaAutobusneStanice;
        private System.Windows.Forms.Label UnesiLokacijuLabel;
        private System.Windows.Forms.TextBox IDAutobusneStanice;
        private System.Windows.Forms.Button GumbOdustani;
        private System.Windows.Forms.Button GumbZaAzuriranje;
    }
}