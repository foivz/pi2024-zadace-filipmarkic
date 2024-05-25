namespace Treća_zadaća
{
    partial class DodajAutobusnuStanicu
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
            this.GumbOdustani = new System.Windows.Forms.Button();
            this.GumbZaDodavanje = new System.Windows.Forms.Button();
            this.AutobusnaStanicaIDInput = new System.Windows.Forms.TextBox();
            this.AutobusnaStanicaLokacijaInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AutobusnaStanicaNazivInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelNaVrhuEkrana = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GumbOdustani
            // 
            this.GumbOdustani.Location = new System.Drawing.Point(415, 376);
            this.GumbOdustani.Name = "GumbOdustani";
            this.GumbOdustani.Size = new System.Drawing.Size(75, 23);
            this.GumbOdustani.TabIndex = 7;
            this.GumbOdustani.Text = "Odustani";
            this.GumbOdustani.UseVisualStyleBackColor = true;
            this.GumbOdustani.Click += new System.EventHandler(this.GumbOdustani_Click);
            // 
            // GumbZaDodavanje
            // 
            this.GumbZaDodavanje.Location = new System.Drawing.Point(301, 376);
            this.GumbZaDodavanje.Name = "GumbZaDodavanje";
            this.GumbZaDodavanje.Size = new System.Drawing.Size(75, 23);
            this.GumbZaDodavanje.TabIndex = 6;
            this.GumbZaDodavanje.Text = "Dodaj";
            this.GumbZaDodavanje.UseVisualStyleBackColor = true;
            this.GumbZaDodavanje.Click += new System.EventHandler(this.GumbZaDodavanje_Click);
            // 
            // AutobusnaStanicaIDInput
            // 
            this.AutobusnaStanicaIDInput.Location = new System.Drawing.Point(342, 157);
            this.AutobusnaStanicaIDInput.Name = "AutobusnaStanicaIDInput";
            this.AutobusnaStanicaIDInput.Size = new System.Drawing.Size(174, 20);
            this.AutobusnaStanicaIDInput.TabIndex = 20;
            // 
            // AutobusnaStanicaLokacijaInput
            // 
            this.AutobusnaStanicaLokacijaInput.Location = new System.Drawing.Point(342, 228);
            this.AutobusnaStanicaLokacijaInput.Name = "AutobusnaStanicaLokacijaInput";
            this.AutobusnaStanicaLokacijaInput.Size = new System.Drawing.Size(174, 20);
            this.AutobusnaStanicaLokacijaInput.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(249, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Unesi lokaciju:";
            // 
            // AutobusnaStanicaNazivInput
            // 
            this.AutobusnaStanicaNazivInput.Location = new System.Drawing.Point(342, 298);
            this.AutobusnaStanicaNazivInput.Name = "AutobusnaStanicaNazivInput";
            this.AutobusnaStanicaNazivInput.Size = new System.Drawing.Size(174, 20);
            this.AutobusnaStanicaNazivInput.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(259, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Unesi naziv:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(279, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Unesi ID:";
            // 
            // LabelNaVrhuEkrana
            // 
            this.LabelNaVrhuEkrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNaVrhuEkrana.Location = new System.Drawing.Point(226, 51);
            this.LabelNaVrhuEkrana.Name = "LabelNaVrhuEkrana";
            this.LabelNaVrhuEkrana.Size = new System.Drawing.Size(355, 28);
            this.LabelNaVrhuEkrana.TabIndex = 26;
            this.LabelNaVrhuEkrana.Text = "Forma za unos nove autobusne stanice";
            // 
            // DodajAutobusnuStanicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelNaVrhuEkrana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AutobusnaStanicaNazivInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutobusnaStanicaLokacijaInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutobusnaStanicaIDInput);
            this.Controls.Add(this.GumbOdustani);
            this.Controls.Add(this.GumbZaDodavanje);
            this.Name = "DodajAutobusnuStanicu";
            this.Text = "Dodavanje autobusne stanice";
            this.Load += new System.EventHandler(this.DodajAutobusnuStanicu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GumbOdustani;
        private System.Windows.Forms.Button GumbZaDodavanje;
        private System.Windows.Forms.TextBox AutobusnaStanicaIDInput;
        private System.Windows.Forms.TextBox AutobusnaStanicaLokacijaInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AutobusnaStanicaNazivInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelNaVrhuEkrana;
    }
}