﻿
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
            this.splitMainScreen = new System.Windows.Forms.SplitContainer();
            this.MenuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.grpAbfahrten = new System.Windows.Forms.GroupBox();
            this.grpAbfahrtenSuche = new System.Windows.Forms.GroupBox();
            this.auswahlDatumZeitAbfahrten = new System.Windows.Forms.CheckBox();
            this.datumZeitAbfahrten = new System.Windows.Forms.DateTimePicker();
            this.btnStandort = new System.Windows.Forms.Button();
            this.lblAbfahrtstafelSucheLeer = new System.Windows.Forms.Label();
            this.sucheAbfahrtstafel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpVerbindungen = new System.Windows.Forms.GroupBox();
            this.grpVonNach = new System.Windows.Forms.GroupBox();
            this.auswahlDatumZeitVerbindungen = new System.Windows.Forms.CheckBox();
            this.datumZeitVerbindungen = new System.Windows.Forms.DateTimePicker();
            this.btnAbfahrtAnkunftTauschen = new System.Windows.Forms.Button();
            this.btnVerbindungSuchen = new System.Windows.Forms.Button();
            this.lblAnkunftsstationSucheLeer = new System.Windows.Forms.Label();
            this.lblAbfahrtsstationSucheLeer = new System.Windows.Forms.Label();
            this.sucheAnkunftsstation = new System.Windows.Forms.TextBox();
            this.sucheAbfahrtsstation = new System.Windows.Forms.TextBox();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitMainScreen)).BeginInit();
            this.splitMainScreen.Panel1.SuspendLayout();
            this.splitMainScreen.Panel2.SuspendLayout();
            this.splitMainScreen.SuspendLayout();
            this.MenuLayout.SuspendLayout();
            this.grpAbfahrten.SuspendLayout();
            this.grpAbfahrtenSuche.SuspendLayout();
            this.grpVerbindungen.SuspendLayout();
            this.grpVonNach.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMainScreen
            // 
            resources.ApplyResources(this.splitMainScreen, "splitMainScreen");
            this.splitMainScreen.Name = "splitMainScreen";
            // 
            // splitMainScreen.Panel1
            // 
            this.splitMainScreen.Panel1.Controls.Add(this.MenuLayout);
            // 
            // splitMainScreen.Panel2
            // 
            resources.ApplyResources(this.splitMainScreen.Panel2, "splitMainScreen.Panel2");
            this.splitMainScreen.Panel2.Controls.Add(this.grpAbfahrten);
            this.splitMainScreen.Panel2.Controls.Add(this.grpVerbindungen);
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
            // grpAbfahrten
            // 
            resources.ApplyResources(this.grpAbfahrten, "grpAbfahrten");
            this.grpAbfahrten.Controls.Add(this.grpAbfahrtenSuche);
            this.grpAbfahrten.Name = "grpAbfahrten";
            this.grpAbfahrten.TabStop = false;
            // 
            // grpAbfahrtenSuche
            // 
            resources.ApplyResources(this.grpAbfahrtenSuche, "grpAbfahrtenSuche");
            this.grpAbfahrtenSuche.Controls.Add(this.auswahlDatumZeitAbfahrten);
            this.grpAbfahrtenSuche.Controls.Add(this.datumZeitAbfahrten);
            this.grpAbfahrtenSuche.Controls.Add(this.btnStandort);
            this.grpAbfahrtenSuche.Controls.Add(this.lblAbfahrtstafelSucheLeer);
            this.grpAbfahrtenSuche.Controls.Add(this.sucheAbfahrtstafel);
            this.grpAbfahrtenSuche.Controls.Add(this.label2);
            this.grpAbfahrtenSuche.Name = "grpAbfahrtenSuche";
            this.grpAbfahrtenSuche.TabStop = false;
            // 
            // auswahlDatumZeitAbfahrten
            // 
            resources.ApplyResources(this.auswahlDatumZeitAbfahrten, "auswahlDatumZeitAbfahrten");
            this.auswahlDatumZeitAbfahrten.Name = "auswahlDatumZeitAbfahrten";
            this.auswahlDatumZeitAbfahrten.UseVisualStyleBackColor = true;
            this.auswahlDatumZeitAbfahrten.CheckedChanged += new System.EventHandler(this.auswahlDatumZeitAbfahrten_CheckedChanged);
            // 
            // datumZeitAbfahrten
            // 
            resources.ApplyResources(this.datumZeitAbfahrten, "datumZeitAbfahrten");
            this.datumZeitAbfahrten.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.datumZeitAbfahrten.MinDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.datumZeitAbfahrten.Name = "datumZeitAbfahrten";
            this.datumZeitAbfahrten.Value = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            // 
            // btnStandort
            // 
            resources.ApplyResources(this.btnStandort, "btnStandort");
            this.btnStandort.Name = "btnStandort";
            this.btnStandort.UseVisualStyleBackColor = true;
            this.btnStandort.Click += new System.EventHandler(this.btnStandort_Click);
            // 
            // lblAbfahrtstafelSucheLeer
            // 
            resources.ApplyResources(this.lblAbfahrtstafelSucheLeer, "lblAbfahrtstafelSucheLeer");
            this.lblAbfahrtstafelSucheLeer.ForeColor = System.Drawing.Color.Red;
            this.lblAbfahrtstafelSucheLeer.Name = "lblAbfahrtstafelSucheLeer";
            // 
            // sucheAbfahrtstafel
            // 
            resources.ApplyResources(this.sucheAbfahrtstafel, "sucheAbfahrtstafel");
            this.sucheAbfahrtstafel.Name = "sucheAbfahrtstafel";
            this.sucheAbfahrtstafel.Leave += new System.EventHandler(this.sucheAbfahrtstafel_Leave);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // grpVerbindungen
            // 
            this.grpVerbindungen.Controls.Add(this.grpVonNach);
            resources.ApplyResources(this.grpVerbindungen, "grpVerbindungen");
            this.grpVerbindungen.Name = "grpVerbindungen";
            this.grpVerbindungen.TabStop = false;
            // 
            // grpVonNach
            // 
            resources.ApplyResources(this.grpVonNach, "grpVonNach");
            this.grpVonNach.Controls.Add(this.auswahlDatumZeitVerbindungen);
            this.grpVonNach.Controls.Add(this.datumZeitVerbindungen);
            this.grpVonNach.Controls.Add(this.btnAbfahrtAnkunftTauschen);
            this.grpVonNach.Controls.Add(this.btnVerbindungSuchen);
            this.grpVonNach.Controls.Add(this.lblAnkunftsstationSucheLeer);
            this.grpVonNach.Controls.Add(this.lblAbfahrtsstationSucheLeer);
            this.grpVonNach.Controls.Add(this.sucheAnkunftsstation);
            this.grpVonNach.Controls.Add(this.sucheAbfahrtsstation);
            this.grpVonNach.Controls.Add(this.lblNach);
            this.grpVonNach.Controls.Add(this.lblVon);
            this.grpVonNach.Name = "grpVonNach";
            this.grpVonNach.TabStop = false;
            // 
            // auswahlDatumZeitVerbindungen
            // 
            resources.ApplyResources(this.auswahlDatumZeitVerbindungen, "auswahlDatumZeitVerbindungen");
            this.auswahlDatumZeitVerbindungen.Name = "auswahlDatumZeitVerbindungen";
            this.auswahlDatumZeitVerbindungen.UseVisualStyleBackColor = true;
            this.auswahlDatumZeitVerbindungen.CheckedChanged += new System.EventHandler(this.auswahlDatumZeitVerbindungen_CheckedChanged);
            // 
            // datumZeitVerbindungen
            // 
            resources.ApplyResources(this.datumZeitVerbindungen, "datumZeitVerbindungen");
            this.datumZeitVerbindungen.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.datumZeitVerbindungen.MinDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.datumZeitVerbindungen.Name = "datumZeitVerbindungen";
            this.datumZeitVerbindungen.Value = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            // 
            // btnAbfahrtAnkunftTauschen
            // 
            resources.ApplyResources(this.btnAbfahrtAnkunftTauschen, "btnAbfahrtAnkunftTauschen");
            this.btnAbfahrtAnkunftTauschen.Name = "btnAbfahrtAnkunftTauschen";
            this.btnAbfahrtAnkunftTauschen.UseVisualStyleBackColor = true;
            this.btnAbfahrtAnkunftTauschen.Click += new System.EventHandler(this.btnAbfahrtAnkunftTauschen_Click);
            // 
            // btnVerbindungSuchen
            // 
            resources.ApplyResources(this.btnVerbindungSuchen, "btnVerbindungSuchen");
            this.btnVerbindungSuchen.Name = "btnVerbindungSuchen";
            this.btnVerbindungSuchen.UseVisualStyleBackColor = true;
            this.btnVerbindungSuchen.Click += new System.EventHandler(this.btnVerbindungSuchen_Click);
            // 
            // lblAnkunftsstationSucheLeer
            // 
            resources.ApplyResources(this.lblAnkunftsstationSucheLeer, "lblAnkunftsstationSucheLeer");
            this.lblAnkunftsstationSucheLeer.ForeColor = System.Drawing.Color.Red;
            this.lblAnkunftsstationSucheLeer.Name = "lblAnkunftsstationSucheLeer";
            // 
            // lblAbfahrtsstationSucheLeer
            // 
            resources.ApplyResources(this.lblAbfahrtsstationSucheLeer, "lblAbfahrtsstationSucheLeer");
            this.lblAbfahrtsstationSucheLeer.ForeColor = System.Drawing.Color.Red;
            this.lblAbfahrtsstationSucheLeer.Name = "lblAbfahrtsstationSucheLeer";
            // 
            // sucheAnkunftsstation
            // 
            resources.ApplyResources(this.sucheAnkunftsstation, "sucheAnkunftsstation");
            this.sucheAnkunftsstation.Name = "sucheAnkunftsstation";
            this.sucheAnkunftsstation.Leave += new System.EventHandler(this.sucheAnkunftsstation_Leave);
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
            // lblVon
            // 
            resources.ApplyResources(this.lblVon, "lblVon");
            this.lblVon.Name = "lblVon";
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitMainScreen);
            this.Name = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.SizeChanged += new System.EventHandler(this.MainScreen_SizeChanged);
            this.splitMainScreen.Panel1.ResumeLayout(false);
            this.splitMainScreen.Panel2.ResumeLayout(false);
            this.splitMainScreen.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMainScreen)).EndInit();
            this.splitMainScreen.ResumeLayout(false);
            this.MenuLayout.ResumeLayout(false);
            this.grpAbfahrten.ResumeLayout(false);
            this.grpAbfahrtenSuche.ResumeLayout(false);
            this.grpAbfahrtenSuche.PerformLayout();
            this.grpVerbindungen.ResumeLayout(false);
            this.grpVonNach.ResumeLayout(false);
            this.grpVonNach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MenuLayout;
        private System.Windows.Forms.Button btnVerbindungen;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.SplitContainer splitMainScreen;
        private System.Windows.Forms.GroupBox grpVerbindungen;
        private System.Windows.Forms.GroupBox grpVonNach;
        private System.Windows.Forms.TextBox sucheAnkunftsstation;
        private System.Windows.Forms.TextBox sucheAbfahrtsstation;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.GroupBox grpAbfahrten;
        private System.Windows.Forms.GroupBox grpAbfahrtenSuche;
        private System.Windows.Forms.TextBox sucheAbfahrtstafel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAbfahrtsstationSucheLeer;
        private System.Windows.Forms.Label lblAnkunftsstationSucheLeer;
        private System.Windows.Forms.Label lblAbfahrtstafelSucheLeer;
        private System.Windows.Forms.Button btnVerbindungSuchen;
        private System.Windows.Forms.Button btnAbfahrtAnkunftTauschen;
        private System.Windows.Forms.Button btnStandort;
        private System.Windows.Forms.CheckBox auswahlDatumZeitAbfahrten;
        private System.Windows.Forms.DateTimePicker datumZeitAbfahrten;
        private System.Windows.Forms.CheckBox auswahlDatumZeitVerbindungen;
        private System.Windows.Forms.DateTimePicker datumZeitVerbindungen;
    }
}