
namespace SteamVac_Fahrplan
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.MenuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpVerbindungen = new System.Windows.Forms.GroupBox();
            this.grpVonNach = new System.Windows.Forms.GroupBox();
            this.lblVon = new System.Windows.Forms.Label();
            this.sucheAbfahrtsstation = new System.Windows.Forms.TextBox();
            this.lblNach = new System.Windows.Forms.Label();
            this.sucheAnkunftsstation = new System.Windows.Forms.TextBox();
            this.grpAbfahrten = new System.Windows.Forms.GroupBox();
            this.grpAbfahrtenSuche = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAbfahrtsstationSucheLeer = new System.Windows.Forms.Label();
            this.lblAnkunftsstationSucheLeer = new System.Windows.Forms.Label();
            this.grpKonkreteVerbindung = new System.Windows.Forms.GroupBox();
            this.lblAnkunft = new System.Windows.Forms.Label();
            this.lblAbfahrt = new System.Windows.Forms.Label();
            this.lblAbfahrtZeit = new System.Windows.Forms.Label();
            this.lblAnkunftZeit = new System.Windows.Forms.Label();
            this.lblFahrtDauer = new System.Windows.Forms.Label();
            this.MenuLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpVerbindungen.SuspendLayout();
            this.grpVonNach.SuspendLayout();
            this.grpAbfahrten.SuspendLayout();
            this.grpAbfahrtenSuche.SuspendLayout();
            this.grpKonkreteVerbindung.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuLayout
            // 
            resources.ApplyResources(this.MenuLayout, "MenuLayout");
            this.MenuLayout.Controls.Add(this.btnVerbindungen, 1, 0);
            this.MenuLayout.Controls.Add(this.btnAbfahrtstafel, 2, 0);
            this.MenuLayout.Controls.Add(this.btnKarte, 3, 0);
            this.MenuLayout.Name = "MenuLayout";
            // 
            // btnVerbindungen
            // 
            resources.ApplyResources(this.btnVerbindungen, "btnVerbindungen");
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // btnAbfahrtstafel
            // 
            resources.ApplyResources(this.btnAbfahrtstafel, "btnAbfahrtstafel");
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnKarte
            // 
            resources.ApplyResources(this.btnKarte, "btnKarte");
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MenuLayout);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpVerbindungen);
            this.splitContainer1.Panel2.Controls.Add(this.grpAbfahrten);
            // 
            // grpVerbindungen
            // 
            this.grpVerbindungen.Controls.Add(this.grpKonkreteVerbindung);
            this.grpVerbindungen.Controls.Add(this.grpVonNach);
            resources.ApplyResources(this.grpVerbindungen, "grpVerbindungen");
            this.grpVerbindungen.Name = "grpVerbindungen";
            this.grpVerbindungen.TabStop = false;
            // 
            // grpVonNach
            // 
            resources.ApplyResources(this.grpVonNach, "grpVonNach");
            this.grpVonNach.Controls.Add(this.lblAnkunftsstationSucheLeer);
            this.grpVonNach.Controls.Add(this.lblAbfahrtsstationSucheLeer);
            this.grpVonNach.Controls.Add(this.sucheAnkunftsstation);
            this.grpVonNach.Controls.Add(this.sucheAbfahrtsstation);
            this.grpVonNach.Controls.Add(this.lblNach);
            this.grpVonNach.Controls.Add(this.lblVon);
            this.grpVonNach.Name = "grpVonNach";
            this.grpVonNach.TabStop = false;
            // 
            // lblVon
            // 
            resources.ApplyResources(this.lblVon, "lblVon");
            this.lblVon.Name = "lblVon";
            // 
            // sucheAbfahrtsstation
            // 
            resources.ApplyResources(this.sucheAbfahrtsstation, "sucheAbfahrtsstation");
            this.sucheAbfahrtsstation.Name = "sucheAbfahrtsstation";
            this.sucheAbfahrtsstation.Leave += new System.EventHandler(this.sucheAbfahrtsstation_Leave);
            // 
            // lblNach
            // 
            resources.ApplyResources(this.lblNach, "lblNach");
            this.lblNach.Name = "lblNach";
            // 
            // sucheAnkunftsstation
            // 
            resources.ApplyResources(this.sucheAnkunftsstation, "sucheAnkunftsstation");
            this.sucheAnkunftsstation.Name = "sucheAnkunftsstation";
            this.sucheAnkunftsstation.Leave += new System.EventHandler(this.sucheAnkunftsstation_Leave);
            // 
            // grpAbfahrten
            // 
            this.grpAbfahrten.Controls.Add(this.grpAbfahrtenSuche);
            resources.ApplyResources(this.grpAbfahrten, "grpAbfahrten");
            this.grpAbfahrten.Name = "grpAbfahrten";
            this.grpAbfahrten.TabStop = false;
            // 
            // grpAbfahrtenSuche
            // 
            resources.ApplyResources(this.grpAbfahrtenSuche, "grpAbfahrtenSuche");
            this.grpAbfahrtenSuche.Controls.Add(this.textBox2);
            this.grpAbfahrtenSuche.Controls.Add(this.label2);
            this.grpAbfahrtenSuche.Name = "grpAbfahrtenSuche";
            this.grpAbfahrtenSuche.TabStop = false;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblAbfahrtsstationSucheLeer
            // 
            resources.ApplyResources(this.lblAbfahrtsstationSucheLeer, "lblAbfahrtsstationSucheLeer");
            this.lblAbfahrtsstationSucheLeer.ForeColor = System.Drawing.Color.Red;
            this.lblAbfahrtsstationSucheLeer.Name = "lblAbfahrtsstationSucheLeer";
            // 
            // lblAnkunftsstationSucheLeer
            // 
            resources.ApplyResources(this.lblAnkunftsstationSucheLeer, "lblAnkunftsstationSucheLeer");
            this.lblAnkunftsstationSucheLeer.ForeColor = System.Drawing.Color.Red;
            this.lblAnkunftsstationSucheLeer.Name = "lblAnkunftsstationSucheLeer";
            // 
            // grpKonkreteVerbindung
            // 
            this.grpKonkreteVerbindung.Controls.Add(this.lblFahrtDauer);
            this.grpKonkreteVerbindung.Controls.Add(this.lblAnkunftZeit);
            this.grpKonkreteVerbindung.Controls.Add(this.lblAbfahrtZeit);
            this.grpKonkreteVerbindung.Controls.Add(this.lblAbfahrt);
            this.grpKonkreteVerbindung.Controls.Add(this.lblAnkunft);
            resources.ApplyResources(this.grpKonkreteVerbindung, "grpKonkreteVerbindung");
            this.grpKonkreteVerbindung.Name = "grpKonkreteVerbindung";
            this.grpKonkreteVerbindung.TabStop = false;
            // 
            // lblAnkunft
            // 
            resources.ApplyResources(this.lblAnkunft, "lblAnkunft");
            this.lblAnkunft.Name = "lblAnkunft";
            // 
            // lblAbfahrt
            // 
            resources.ApplyResources(this.lblAbfahrt, "lblAbfahrt");
            this.lblAbfahrt.Name = "lblAbfahrt";
            // 
            // lblAbfahrtZeit
            // 
            resources.ApplyResources(this.lblAbfahrtZeit, "lblAbfahrtZeit");
            this.lblAbfahrtZeit.Name = "lblAbfahrtZeit";
            // 
            // lblAnkunftZeit
            // 
            resources.ApplyResources(this.lblAnkunftZeit, "lblAnkunftZeit");
            this.lblAnkunftZeit.Name = "lblAnkunftZeit";
            // 
            // lblFahrtDauer
            // 
            resources.ApplyResources(this.lblFahrtDauer, "lblFahrtDauer");
            this.lblFahrtDauer.Name = "lblFahrtDauer";
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.MenuLayout.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpVerbindungen.ResumeLayout(false);
            this.grpVonNach.ResumeLayout(false);
            this.grpVonNach.PerformLayout();
            this.grpAbfahrten.ResumeLayout(false);
            this.grpAbfahrtenSuche.ResumeLayout(false);
            this.grpAbfahrtenSuche.PerformLayout();
            this.grpKonkreteVerbindung.ResumeLayout(false);
            this.grpKonkreteVerbindung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MenuLayout;
        private System.Windows.Forms.Button btnVerbindungen;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpVerbindungen;
        private System.Windows.Forms.GroupBox grpVonNach;
        private System.Windows.Forms.TextBox sucheAnkunftsstation;
        private System.Windows.Forms.TextBox sucheAbfahrtsstation;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.GroupBox grpAbfahrten;
        private System.Windows.Forms.GroupBox grpAbfahrtenSuche;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAbfahrtsstationSucheLeer;
        private System.Windows.Forms.Label lblAnkunftsstationSucheLeer;
        private System.Windows.Forms.GroupBox grpKonkreteVerbindung;
        private System.Windows.Forms.Label lblFahrtDauer;
        private System.Windows.Forms.Label lblAnkunftZeit;
        private System.Windows.Forms.Label lblAbfahrtZeit;
        private System.Windows.Forms.Label lblAbfahrt;
        private System.Windows.Forms.Label lblAnkunft;
    }
}