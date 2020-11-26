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
    public partial class KonkreteVerbindung : UserControl
    {
        public KonkreteVerbindung(string AbfahrtZeit, string AnkunftsZeit, string FahrtDauer)
        {
            InitializeComponent();
            lblAbfahrtZeit.Text = AbfahrtZeit;
            lblAnkunftsZeit.Text = AnkunftsZeit;
            lblFahrtDauer.Text = FahrtDauer;
        }

        private void KonkreteVerbindung_Load(object sender, EventArgs e)
        {

        }
    }
}
