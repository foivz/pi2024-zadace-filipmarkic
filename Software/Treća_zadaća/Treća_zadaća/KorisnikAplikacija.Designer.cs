﻿namespace Treća_zadaća
{
    partial class KorisnikAplikacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KorisnikAplikacija));
            this.AutobusneStaniceLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AutobusniPulsLabel = new System.Windows.Forms.Label();
            this.GumbZaOdjavu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GumbZaPretragu = new System.Windows.Forms.Button();
            this.AutobusnaStanicaTrazi = new System.Windows.Forms.TextBox();
            this.PretraziLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AutobusneStaniceLabel
            // 
            this.AutobusneStaniceLabel.AutoSize = true;
            this.AutobusneStaniceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AutobusneStaniceLabel.Location = new System.Drawing.Point(461, 36);
            this.AutobusneStaniceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AutobusneStaniceLabel.Name = "AutobusneStaniceLabel";
            this.AutobusneStaniceLabel.Size = new System.Drawing.Size(243, 29);
            this.AutobusneStaniceLabel.TabIndex = 1;
            this.AutobusneStaniceLabel.Text = "Autobusne Stanice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 198);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(732, 303);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AutobusniPulsLabel
            // 
            this.AutobusniPulsLabel.AutoSize = true;
            this.AutobusniPulsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AutobusniPulsLabel.Location = new System.Drawing.Point(15, 118);
            this.AutobusniPulsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AutobusniPulsLabel.Name = "AutobusniPulsLabel";
            this.AutobusniPulsLabel.Size = new System.Drawing.Size(111, 17);
            this.AutobusniPulsLabel.TabIndex = 13;
            this.AutobusniPulsLabel.Text = "AutobusniPuls";
            // 
            // GumbZaOdjavu
            // 
            this.GumbZaOdjavu.Location = new System.Drawing.Point(19, 507);
            this.GumbZaOdjavu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbZaOdjavu.Name = "GumbZaOdjavu";
            this.GumbZaOdjavu.Size = new System.Drawing.Size(100, 28);
            this.GumbZaOdjavu.TabIndex = 9;
            this.GumbZaOdjavu.Text = "Odjava";
            this.GumbZaOdjavu.UseVisualStyleBackColor = true;
            this.GumbZaOdjavu.Click += new System.EventHandler(this.GumbZaOdjavu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GumbZaPretragu
            // 
            this.GumbZaPretragu.Location = new System.Drawing.Point(524, 150);
            this.GumbZaPretragu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbZaPretragu.Name = "GumbZaPretragu";
            this.GumbZaPretragu.Size = new System.Drawing.Size(140, 28);
            this.GumbZaPretragu.TabIndex = 17;
            this.GumbZaPretragu.Text = "Pretraži";
            this.GumbZaPretragu.UseVisualStyleBackColor = true;
            this.GumbZaPretragu.Click += new System.EventHandler(this.GumbZaPretragu_Click);
            // 
            // AutobusnaStanicaTrazi
            // 
            this.AutobusnaStanicaTrazi.Location = new System.Drawing.Point(492, 118);
            this.AutobusnaStanicaTrazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutobusnaStanicaTrazi.Name = "AutobusnaStanicaTrazi";
            this.AutobusnaStanicaTrazi.Size = new System.Drawing.Size(211, 22);
            this.AutobusnaStanicaTrazi.TabIndex = 21;
            // 
            // PretraziLabel
            // 
            this.PretraziLabel.AutoSize = true;
            this.PretraziLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PretraziLabel.Location = new System.Drawing.Point(541, 96);
            this.PretraziLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PretraziLabel.Name = "PretraziLabel";
            this.PretraziLabel.Size = new System.Drawing.Size(105, 18);
            this.PretraziLabel.TabIndex = 20;
            this.PretraziLabel.Text = "Lokacija/naziv:";
            // 
            // KorisnikAplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AutobusnaStanicaTrazi);
            this.Controls.Add(this.PretraziLabel);
            this.Controls.Add(this.GumbZaPretragu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AutobusniPulsLabel);
            this.Controls.Add(this.GumbZaOdjavu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AutobusneStaniceLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KorisnikAplikacija";
            this.Text = "AutobusniPuls (Korisnik)";
            this.Load += new System.EventHandler(this.KorisnikAplikacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AutobusneStaniceLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label AutobusniPulsLabel;
        private System.Windows.Forms.Button GumbZaOdjavu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GumbZaPretragu;
        private System.Windows.Forms.TextBox AutobusnaStanicaTrazi;
        private System.Windows.Forms.Label PretraziLabel;
    }
}