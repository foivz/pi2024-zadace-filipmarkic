namespace Treća_zadaća
{
    partial class AzurirajStanicu
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // UnesiIDLabel
            // 
            this.UnesiIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UnesiIDLabel.Location = new System.Drawing.Point(368, 194);
            this.UnesiIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnesiIDLabel.Name = "UnesiIDLabel";
            this.UnesiIDLabel.Size = new System.Drawing.Size(76, 23);
            this.UnesiIDLabel.TabIndex = 34;
            this.UnesiIDLabel.Text = "Unesi ID:";
            // 
            // AzuriraniNazivAutobusneStanice
            // 
            this.AzuriraniNazivAutobusneStanice.Location = new System.Drawing.Point(452, 367);
            this.AzuriraniNazivAutobusneStanice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AzuriraniNazivAutobusneStanice.Name = "AzuriraniNazivAutobusneStanice";
            this.AzuriraniNazivAutobusneStanice.Size = new System.Drawing.Size(231, 22);
            this.AzuriraniNazivAutobusneStanice.TabIndex = 33;
            // 
            // UnesiNazivLabel
            // 
            this.UnesiNazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UnesiNazivLabel.Location = new System.Drawing.Point(341, 368);
            this.UnesiNazivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnesiNazivLabel.Name = "UnesiNazivLabel";
            this.UnesiNazivLabel.Size = new System.Drawing.Size(103, 23);
            this.UnesiNazivLabel.TabIndex = 32;
            this.UnesiNazivLabel.Text = "Unesi naziv:";
            // 
            // AzuriranaLokacijaAutobusneStanice
            // 
            this.AzuriranaLokacijaAutobusneStanice.Location = new System.Drawing.Point(452, 281);
            this.AzuriranaLokacijaAutobusneStanice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AzuriranaLokacijaAutobusneStanice.Name = "AzuriranaLokacijaAutobusneStanice";
            this.AzuriranaLokacijaAutobusneStanice.Size = new System.Drawing.Size(231, 22);
            this.AzuriranaLokacijaAutobusneStanice.TabIndex = 31;
            // 
            // UnesiLokacijuLabel
            // 
            this.UnesiLokacijuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UnesiLokacijuLabel.Location = new System.Drawing.Point(328, 282);
            this.UnesiLokacijuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnesiLokacijuLabel.Name = "UnesiLokacijuLabel";
            this.UnesiLokacijuLabel.Size = new System.Drawing.Size(124, 25);
            this.UnesiLokacijuLabel.TabIndex = 30;
            this.UnesiLokacijuLabel.Text = "Unesi lokaciju:";
            // 
            // IDAutobusneStanice
            // 
            this.IDAutobusneStanice.Location = new System.Drawing.Point(452, 193);
            this.IDAutobusneStanice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDAutobusneStanice.Name = "IDAutobusneStanice";
            this.IDAutobusneStanice.Size = new System.Drawing.Size(231, 22);
            this.IDAutobusneStanice.TabIndex = 29;
            this.IDAutobusneStanice.TextChanged += new System.EventHandler(this.IDAutobusneStanice_TextChanged);
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
            this.comboBox1.Location = new System.Drawing.Point(722, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AzurirajStanicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelNaVrhuEkrana);
            this.Controls.Add(this.UnesiIDLabel);
            this.Controls.Add(this.AzuriraniNazivAutobusneStanice);
            this.Controls.Add(this.UnesiNazivLabel);
            this.Controls.Add(this.AzuriranaLokacijaAutobusneStanice);
            this.Controls.Add(this.UnesiLokacijuLabel);
            this.Controls.Add(this.IDAutobusneStanice);
            this.Controls.Add(this.GumbOdustani);
            this.Controls.Add(this.GumbZaAzuriranje);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AzurirajStanicu";
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}