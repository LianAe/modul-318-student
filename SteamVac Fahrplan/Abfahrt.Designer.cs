
namespace SteamVac_Fahrplan
{
    partial class Abfahrt
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
            this.lblAnkunftOrt = new System.Windows.Forms.Label();
            this.lblAnkunftGleisBeschriftung = new System.Windows.Forms.Label();
            this.lblAbfahrtZeit = new System.Windows.Forms.Label();
            this.lblAbfahrtBeschriftung = new System.Windows.Forms.Label();
            this.lblTitelAbfahrt = new System.Windows.Forms.Label();
            this.lblPfeil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnkunftOrt
            // 
            this.lblAnkunftOrt.AutoSize = true;
            this.lblAnkunftOrt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnkunftOrt.Location = new System.Drawing.Point(76, 197);
            this.lblAnkunftOrt.Name = "lblAnkunftOrt";
            this.lblAnkunftOrt.Size = new System.Drawing.Size(16, 20);
            this.lblAnkunftOrt.TabIndex = 19;
            this.lblAnkunftOrt.Text = "x";
            // 
            // lblAnkunftGleisBeschriftung
            // 
            this.lblAnkunftGleisBeschriftung.AutoSize = true;
            this.lblAnkunftGleisBeschriftung.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnkunftGleisBeschriftung.Location = new System.Drawing.Point(12, 197);
            this.lblAnkunftGleisBeschriftung.Name = "lblAnkunftGleisBeschriftung";
            this.lblAnkunftGleisBeschriftung.Size = new System.Drawing.Size(66, 20);
            this.lblAnkunftGleisBeschriftung.TabIndex = 18;
            this.lblAnkunftGleisBeschriftung.Text = "Ankunft in";
            // 
            // lblAbfahrtZeit
            // 
            this.lblAbfahrtZeit.AutoSize = true;
            this.lblAbfahrtZeit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbfahrtZeit.Location = new System.Drawing.Point(60, 63);
            this.lblAbfahrtZeit.Name = "lblAbfahrtZeit";
            this.lblAbfahrtZeit.Size = new System.Drawing.Size(131, 20);
            this.lblAbfahrtZeit.TabIndex = 16;
            this.lblAbfahrtZeit.Text = "dd/mm/yyyy HH:mm";
            // 
            // lblAbfahrtBeschriftung
            // 
            this.lblAbfahrtBeschriftung.AutoSize = true;
            this.lblAbfahrtBeschriftung.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbfahrtBeschriftung.Location = new System.Drawing.Point(12, 63);
            this.lblAbfahrtBeschriftung.Name = "lblAbfahrtBeschriftung";
            this.lblAbfahrtBeschriftung.Size = new System.Drawing.Size(54, 20);
            this.lblAbfahrtBeschriftung.TabIndex = 15;
            this.lblAbfahrtBeschriftung.Text = "Abfahrt:";
            // 
            // lblTitelAbfahrt
            // 
            this.lblTitelAbfahrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitelAbfahrt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitelAbfahrt.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelAbfahrt.Location = new System.Drawing.Point(0, 0);
            this.lblTitelAbfahrt.Name = "lblTitelAbfahrt";
            this.lblTitelAbfahrt.Size = new System.Drawing.Size(234, 50);
            this.lblTitelAbfahrt.TabIndex = 12;
            this.lblTitelAbfahrt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPfeil
            // 
            this.lblPfeil.AutoSize = true;
            this.lblPfeil.Font = new System.Drawing.Font("Arial Narrow", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblPfeil.Location = new System.Drawing.Point(12, 83);
            this.lblPfeil.Name = "lblPfeil";
            this.lblPfeil.Size = new System.Drawing.Size(80, 94);
            this.lblPfeil.TabIndex = 17;
            this.lblPfeil.Text = "↓";
            this.lblPfeil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Abfahrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.lblAnkunftOrt);
            this.Controls.Add(this.lblAnkunftGleisBeschriftung);
            this.Controls.Add(this.lblPfeil);
            this.Controls.Add(this.lblAbfahrtZeit);
            this.Controls.Add(this.lblAbfahrtBeschriftung);
            this.Controls.Add(this.lblTitelAbfahrt);
            this.Name = "Abfahrt";
            this.Text = "Abfahrt";
            this.Load += new System.EventHandler(this.Abfahrt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAnkunftOrt;
        private System.Windows.Forms.Label lblAnkunftGleisBeschriftung;
        private System.Windows.Forms.Label lblAbfahrtZeit;
        private System.Windows.Forms.Label lblAbfahrtBeschriftung;
        private System.Windows.Forms.Label lblTitelAbfahrt;
        private System.Windows.Forms.Label lblPfeil;
    }
}