using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamVac_Fahrplan
{
    public partial class Verbindung : Form
    {
        public Verbindung(
            string AbfahrtZeit,
            string AnkunftsZeit,
            string FahrtDauer,
            string AnkunftGleis,
            string AbfahrtGleis,
            string AnkunftsOrt,
            string AbfahrtsOrt)
        {
            InitializeComponent();
            lblAbfahrtGleis.Text = AbfahrtGleis;
            lblAnkunftGleis.Text = AnkunftGleis;
            lblDauer.Text = FahrtDauer;
            lblAbfahrt.Text = AbfahrtZeit;
            lblAnkunftZeit.Text = AnkunftsZeit;
            lblTitelVerbindung.Text = "Verbindung von " + AbfahrtsOrt + " nach " + AnkunftsOrt;
        }

        private void Verbindung_Load(object sender, EventArgs e)
        {
        }
    }
}
