
namespace SteamVac_Fahrplan
{
    partial class KonkreteVerbindung
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAbfahrt = new System.Windows.Forms.Label();
            this.lblAnkunft = new System.Windows.Forms.Label();
            this.lblAbfahrtZeit = new System.Windows.Forms.Label();
            this.lblAnkunftsZeit = new System.Windows.Forms.Label();
            this.lblFahrtDauer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAbfahrt
            // 
            this.lblAbfahrt.AutoSize = true;
            this.lblAbfahrt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbfahrt.Location = new System.Drawing.Point(3, 6);
            this.lblAbfahrt.Name = "lblAbfahrt";
            this.lblAbfahrt.Size = new System.Drawing.Size(54, 20);
            this.lblAbfahrt.TabIndex = 0;
            this.lblAbfahrt.Text = "Abfahrt:";
            // 
            // lblAnkunft
            // 
            this.lblAnkunft.AutoSize = true;
            this.lblAnkunft.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnkunft.Location = new System.Drawing.Point(3, 26);
            this.lblAnkunft.Name = "lblAnkunft";
            this.lblAnkunft.Size = new System.Drawing.Size(56, 20);
            this.lblAnkunft.TabIndex = 1;
            this.lblAnkunft.Text = "Ankunft:";
            // 
            // lblAbfahrtZeit
            // 
            this.lblAbfahrtZeit.AutoSize = true;
            this.lblAbfahrtZeit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbfahrtZeit.Location = new System.Drawing.Point(56, 6);
            this.lblAbfahrtZeit.Name = "lblAbfahrtZeit";
            this.lblAbfahrtZeit.Size = new System.Drawing.Size(0, 20);
            this.lblAbfahrtZeit.TabIndex = 2;
            // 
            // lblAnkunftsZeit
            // 
            this.lblAnkunftsZeit.AutoSize = true;
            this.lblAnkunftsZeit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnkunftsZeit.Location = new System.Drawing.Point(56, 26);
            this.lblAnkunftsZeit.Name = "lblAnkunftsZeit";
            this.lblAnkunftsZeit.Size = new System.Drawing.Size(0, 20);
            this.lblAnkunftsZeit.TabIndex = 3;
            // 
            // lblFahrtDauer
            // 
            this.lblFahrtDauer.AutoSize = true;
            this.lblFahrtDauer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrtDauer.Location = new System.Drawing.Point(501, 6);
            this.lblFahrtDauer.Name = "lblFahrtDauer";
            this.lblFahrtDauer.Size = new System.Drawing.Size(0, 20);
            this.lblFahrtDauer.TabIndex = 4;
            // 
            // KonkreteVerbindung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblFahrtDauer);
            this.Controls.Add(this.lblAnkunftsZeit);
            this.Controls.Add(this.lblAbfahrtZeit);
            this.Controls.Add(this.lblAnkunft);
            this.Controls.Add(this.lblAbfahrt);
            this.Name = "KonkreteVerbindung";
            this.Size = new System.Drawing.Size(570, 64);
            this.Load += new System.EventHandler(this.KonkreteVerbindung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbfahrt;
        private System.Windows.Forms.Label lblAnkunft;
        private System.Windows.Forms.Label lblAbfahrtZeit;
        private System.Windows.Forms.Label lblAnkunftsZeit;
        private System.Windows.Forms.Label lblFahrtDauer;
    }
}
