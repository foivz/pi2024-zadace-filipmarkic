namespace Treća_zadaća
{
    partial class AutobusniPuls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutobusniPuls));
            this.GumbZaPrijavu = new System.Windows.Forms.Button();
            this.AutobusniPulsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GumbZaPrijavu
            // 
            this.GumbZaPrijavu.Location = new System.Drawing.Point(324, 217);
            this.GumbZaPrijavu.Name = "GumbZaPrijavu";
            this.GumbZaPrijavu.Size = new System.Drawing.Size(162, 30);
            this.GumbZaPrijavu.TabIndex = 0;
            this.GumbZaPrijavu.Text = "Prijava";
            this.GumbZaPrijavu.UseVisualStyleBackColor = true;
            this.GumbZaPrijavu.Click += new System.EventHandler(this.GumbZaPrijavu_Click);
            // 
            // AutobusniPulsLabel
            // 
            this.AutobusniPulsLabel.AutoSize = true;
            this.AutobusniPulsLabel.BackColor = System.Drawing.Color.Transparent;
            this.AutobusniPulsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AutobusniPulsLabel.Location = new System.Drawing.Point(318, 31);
            this.AutobusniPulsLabel.Name = "AutobusniPulsLabel";
            this.AutobusniPulsLabel.Size = new System.Drawing.Size(201, 31);
            this.AutobusniPulsLabel.TabIndex = 1;
            this.AutobusniPulsLabel.Text = "AutobusniPuls";
            this.AutobusniPulsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AutobusniPuls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 457);
            this.Controls.Add(this.AutobusniPulsLabel);
            this.Controls.Add(this.GumbZaPrijavu);
            this.Name = "AutobusniPuls";
            this.Text = "AutobusniPuls";
            this.Load += new System.EventHandler(this.AutobusniPuls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GumbZaPrijavu;
        private System.Windows.Forms.Label AutobusniPulsLabel;
    }
}

