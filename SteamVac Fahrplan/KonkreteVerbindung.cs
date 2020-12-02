using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamVac_Fahrplan
{

    public partial class KonkreteVerbindung : UserControl
    {
        string ankunftGleis;
        string abfahrtGleis;
        string ankunftsOrt;
        string abfahrtsOrt;
        public KonkreteVerbindung(
            string AbfahrtZeit, 
            string AnkunftsZeit, 
            string FahrtDauer, 
            int posX, 
            int posY,
            string AnkunftGleis,
            string AbfahrtGleis,
            string AnkunftsOrt,
            string AbfahrtsOrt)
        {
            InitializeComponent();
            lblAbfahrtZeit.Text = DateTime.Parse(AbfahrtZeit).ToString("g");
            lblAnkunftsZeit.Text = DateTime.Parse(AnkunftsZeit).ToString("g");
            lblFahrtDauer.Text = DateTimeOffset.Parse(FahrtDauer.Substring(3)).ToString("t");
            Location = new Point(posX, posY);
            ankunftGleis = AnkunftGleis;
            abfahrtGleis = AbfahrtGleis;
            ankunftsOrt = AnkunftsOrt;
            abfahrtsOrt = AbfahrtsOrt;
        }

        private void KonkreteVerbindung_Load(object sender, EventArgs e)
        {

        }

        private void KonkreteVerbindung_Click(object sender, EventArgs e)
        {
            Verbindung infosVerbindung = new Verbindung(
                lblAbfahrtZeit.Text,
                lblAnkunftsZeit.Text, 
                lblFahrtDauer.Text, 
                ankunftGleis, 
                abfahrtGleis,
                ankunftsOrt,
                abfahrtsOrt);
            infosVerbindung.Show();
        }
    }
}
