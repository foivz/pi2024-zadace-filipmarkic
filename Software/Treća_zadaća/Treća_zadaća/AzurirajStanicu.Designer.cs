namespace Treća_zadaća
{
    partial class LabelID
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
            this.AzuriraniNazivAutobusneStanice = new System.Windows.Forms.TextBox();
            this.AzuriranaLokacijaAutobusneStanice = new System.Windows.Forms.TextBox();
            this.GumbOdustani = new System.Windows.Forms.Button();
            this.GumbZaAzuriranje = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelLokacija = new System.Windows.Forms.Label();
            this.LabelNaziv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelNaVrhuEkrana
            // 
            this.LabelNaVrhuEkrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNaVrhuEkrana.Location = new System.Drawing.Point(353, 68);
            this.LabelNaVrhuEkrana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNaVrhuEkrana.Name = "LabelNaVrhuEkrana";
            this.LabelNaVrhuEkrana.Size = new System.Drawing.Size(364, 70);
            this.LabelNaVrhuEkrana.TabIndex = 35;
            this.LabelNaVrhuEkrana.Text = "Forma za ažuriranje postojeće autobusne stanice";
            this.LabelNaVrhuEkrana.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AzuriraniNazivAutobusneStanice
            // 
            this.AzuriraniNazivAutobusneStanice.Location = new System.Drawing.Point(418, 366);
            this.AzuriraniNazivAutobusneStanice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AzuriraniNazivAutobusneStanice.Name = "AzuriraniNazivAutobusneStanice";
            this.AzuriraniNazivAutobusneStanice.Size = new System.Drawing.Size(231, 22);
            this.AzuriraniNazivAutobusneStanice.TabIndex = 33;
            this.AzuriraniNazivAutobusneStanice.Text = "Naziv";
            // 
            // AzuriranaLokacijaAutobusneStanice
            // 
            this.AzuriranaLokacijaAutobusneStanice.Location = new System.Drawing.Point(418, 280);
            this.AzuriranaLokacijaAutobusneStanice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AzuriranaLokacijaAutobusneStanice.Name = "AzuriranaLokacijaAutobusneStanice";
            this.AzuriranaLokacijaAutobusneStanice.Size = new System.Drawing.Size(231, 22);
            this.AzuriranaLokacijaAutobusneStanice.TabIndex = 31;
            this.AzuriranaLokacijaAutobusneStanice.Text = "Lokacija";
            this.AzuriranaLokacijaAutobusneStanice.TextChanged += new System.EventHandler(this.AzuriranaLokacijaAutobusneStanice_TextChanged);
            // 
            // GumbOdustani
            // 
            this.GumbOdustani.Location = new System.Drawing.Point(549, 463);
            this.GumbOdustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbOdustani.Name = "GumbOdustani";
            this.GumbOdustani.Size = new System.Drawing.Size(100, 28);
            this.GumbOdustani.TabIndex = 28;
            this.GumbOdustani.Text = "Odustani";
            this.GumbOdustani.UseVisualStyleBackColor = true;
            this.GumbOdustani.Click += new System.EventHandler(this.GumbOdustani_Click);
            // 
            // GumbZaAzuriranje
            // 
            this.GumbZaAzuriranje.Location = new System.Drawing.Point(397, 463);
            this.GumbZaAzuriranje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbZaAzuriranje.Name = "GumbZaAzuriranje";
            this.GumbZaAzuriranje.Size = new System.Drawing.Size(100, 28);
            this.GumbZaAzuriranje.TabIndex = 27;
            this.GumbZaAzuriranje.Text = "Ažuriraj";
            this.GumbZaAzuriranje.UseVisualStyleBackColor = true;
            this.GumbZaAzuriranje.Click += new System.EventHandler(this.GumbZaAzuriranje_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(418, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LabelLokacija
            // 
            this.LabelLokacija.AutoSize = true;
            this.LabelLokacija.Location = new System.Drawing.Point(415, 260);
            this.LabelLokacija.Name = "LabelLokacija";
            this.LabelLokacija.Size = new System.Drawing.Size(90, 16);
            this.LabelLokacija.TabIndex = 37;
            this.LabelLokacija.Text = "Nova lokacija";
            this.LabelLokacija.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelNaziv
            // 
            this.LabelNaziv.AutoSize = true;
            this.LabelNaziv.Location = new System.Drawing.Point(418, 346);
            this.LabelNaziv.Name = "LabelNaziv";
            this.LabelNaziv.Size = new System.Drawing.Size(69, 16);
            this.LabelNaziv.TabIndex = 38;
            this.LabelNaziv.Text = "Novi naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID (ne mijenjaj ručno)";
            // 
            // LabelID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelNaziv);
            this.Controls.Add(this.LabelLokacija);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelNaVrhuEkrana);
            this.Controls.Add(this.AzuriraniNazivAutobusneStanice);
            this.Controls.Add(this.AzuriranaLokacijaAutobusneStanice);
            this.Controls.Add(this.GumbOdustani);
            this.Controls.Add(this.GumbZaAzuriranje);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LabelID";
            this.Text = "Azuriranje autobusne stanice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNaVrhuEkrana;
        private System.Windows.Forms.TextBox AzuriraniNazivAutobusneStanice;
        private System.Windows.Forms.TextBox AzuriranaLokacijaAutobusneStanice;
        private System.Windows.Forms.Button GumbOdustani;
        private System.Windows.Forms.Button GumbZaAzuriranje;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelLokacija;
        private System.Windows.Forms.Label LabelNaziv;
        private System.Windows.Forms.Label label1;
    }
}