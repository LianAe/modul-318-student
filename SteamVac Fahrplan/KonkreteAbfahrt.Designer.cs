
namespace SteamVac_Fahrplan
{
    partial class KonkreteAbfahrt
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
            this.lblZugName = new System.Windows.Forms.Label();
            this.lblEndstation = new System.Windows.Forms.Label();
            this.lblAbfahrt = new System.Windows.Forms.Label();
            this.lblEndstationBeschriftung = new System.Windows.Forms.Label();
            this.lblAbfahrtBeschriftung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblZugName
            // 
            this.lblZugName.AutoSize = true;
            this.lblZugName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZugName.Location = new System.Drawing.Point(3, 4);
            this.lblZugName.Name = "lblZugName";
            this.lblZugName.Size = new System.Drawing.Size(0, 20);
            this.lblZugName.TabIndex = 0;
            // 
            // lblEndstation
            // 
            this.lblEndstation.AutoSize = true;
            this.lblEndstation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndstation.Location = new System.Drawing.Point(109, 4);
            this.lblEndstation.Name = "lblEndstation";
            this.lblEndstation.Size = new System.Drawing.Size(0, 20);
            this.lblEndstation.TabIndex = 1;
            // 
            // lblAbfahrt
            // 
            this.lblAbfahrt.AutoSize = true;
            this.lblAbfahrt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbfahrt.Location = new System.Drawing.Point(404, 4);
            this.lblAbfahrt.Name = "lblAbfahrt";
            this.lblAbfahrt.Size = new System.Drawing.Size(0, 20);
            this.lblAbfahrt.TabIndex = 2;
            // 
            // lblEndstationBeschriftung
            // 
            this.lblEndstationBeschriftung.AutoSize = true;
            this.lblEndstationBeschriftung.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndstationBeschriftung.Location = new System.Drawing.Point(68, 4);
            this.lblEndstationBeschriftung.Name = "lblEndstationBeschriftung";
            this.lblEndstationBeschriftung.Size = new System.Drawing.Size(41, 20);
            this.lblEndstationBeschriftung.TabIndex = 3;
            this.lblEndstationBeschriftung.Text = "nach:";
            // 
            // lblAbfahrtBeschriftung
            // 
            this.lblAbfahrtBeschriftung.AutoSize = true;
            this.lblAbfahrtBeschriftung.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbfahrtBeschriftung.Location = new System.Drawing.Point(350, 4);
            this.lblAbfahrtBeschriftung.Name = "lblAbfahrtBeschriftung";
            this.lblAbfahrtBeschriftung.Size = new System.Drawing.Size(54, 20);
            this.lblAbfahrtBeschriftung.TabIndex = 4;
            this.lblAbfahrtBeschriftung.Text = "Abfahrt:";
            // 
            // KonkreteAbfahrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.lblAbfahrtBeschriftung);
            this.Controls.Add(this.lblEndstationBeschriftung);
            this.Controls.Add(this.lblAbfahrt);
            this.Controls.Add(this.lblEndstation);
            this.Controls.Add(this.lblZugName);
            this.Name = "KonkreteAbfahrt";
            this.Size = new System.Drawing.Size(570, 64);
            this.Load += new System.EventHandler(this.KonkreteAbfahrt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZugName;
        private System.Windows.Forms.Label lblEndstation;
        private System.Windows.Forms.Label lblAbfahrt;
        private System.Windows.Forms.Label lblEndstationBeschriftung;
        private System.Windows.Forms.Label lblAbfahrtBeschriftung;
    }
}
