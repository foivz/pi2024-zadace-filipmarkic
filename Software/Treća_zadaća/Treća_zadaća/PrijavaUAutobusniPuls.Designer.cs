namespace Treća_zadaća
{
    partial class PrijavaUAutobusniPuls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaUAutobusniPuls));
            this.KorisnickoImeLabel = new System.Windows.Forms.Label();
            this.LozinkaLabel = new System.Windows.Forms.Label();
            this.KorisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.LozinkaTextBox = new System.Windows.Forms.TextBox();
            this.PrijavaUSustav = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KorisnickoImeLabel
            // 
            this.KorisnickoImeLabel.AutoSize = true;
            this.KorisnickoImeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KorisnickoImeLabel.Location = new System.Drawing.Point(125, 107);
            this.KorisnickoImeLabel.Name = "KorisnickoImeLabel";
            this.KorisnickoImeLabel.Size = new System.Drawing.Size(111, 18);
            this.KorisnickoImeLabel.TabIndex = 0;
            this.KorisnickoImeLabel.Text = "Korisničko ime:";
            this.KorisnickoImeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LozinkaLabel
            // 
            this.LozinkaLabel.AutoSize = true;
            this.LozinkaLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LozinkaLabel.Location = new System.Drawing.Point(146, 178);
            this.LozinkaLabel.Name = "LozinkaLabel";
            this.LozinkaLabel.Size = new System.Drawing.Size(62, 17);
            this.LozinkaLabel.TabIndex = 1;
            this.LozinkaLabel.Text = "Lozinka:";
            this.LozinkaLabel.Click += new System.EventHandler(this.LozinkaLabel_Click);
            // 
            // KorisnickoImeTextBox
            // 
            this.KorisnickoImeTextBox.Location = new System.Drawing.Point(99, 128);
            this.KorisnickoImeTextBox.Name = "KorisnickoImeTextBox";
            this.KorisnickoImeTextBox.Size = new System.Drawing.Size(160, 20);
            this.KorisnickoImeTextBox.TabIndex = 2;
            this.KorisnickoImeTextBox.TextChanged += new System.EventHandler(this.KorisnickoImeTextBox_TextChanged);
            // 
            // LozinkaTextBox
            // 
            this.LozinkaTextBox.Location = new System.Drawing.Point(99, 198);
            this.LozinkaTextBox.Name = "LozinkaTextBox";
            this.LozinkaTextBox.Size = new System.Drawing.Size(160, 20);
            this.LozinkaTextBox.TabIndex = 3;
            this.LozinkaTextBox.UseSystemPasswordChar = true;
            this.LozinkaTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PrijavaUSustav
            // 
            this.PrijavaUSustav.Location = new System.Drawing.Point(128, 263);
            this.PrijavaUSustav.Name = "PrijavaUSustav";
            this.PrijavaUSustav.Size = new System.Drawing.Size(100, 28);
            this.PrijavaUSustav.TabIndex = 4;
            this.PrijavaUSustav.Text = "Prijava";
            this.PrijavaUSustav.UseVisualStyleBackColor = true;
            this.PrijavaUSustav.Click += new System.EventHandler(this.PrijavaUSustav_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 71);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PrijavaUAutobusniPuls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PrijavaUSustav);
            this.Controls.Add(this.LozinkaTextBox);
            this.Controls.Add(this.KorisnickoImeTextBox);
            this.Controls.Add(this.LozinkaLabel);
            this.Controls.Add(this.KorisnickoImeLabel);
            this.Name = "PrijavaUAutobusniPuls";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.PrijavaUAutobusniPuls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KorisnickoImeLabel;
        private System.Windows.Forms.Label LozinkaLabel;
        private System.Windows.Forms.TextBox KorisnickoImeTextBox;
        private System.Windows.Forms.TextBox LozinkaTextBox;
        private System.Windows.Forms.Button PrijavaUSustav;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}