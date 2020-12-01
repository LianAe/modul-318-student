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
        public KonkreteVerbindung(string AbfahrtZeit, string AnkunftsZeit, string FahrtDauer, int posX, int posY)
        {
            InitializeComponent();
            lblAbfahrtZeit.Text = DateTime.Parse(AbfahrtZeit).ToString("g");
            lblAnkunftsZeit.Text = DateTime.Parse(AnkunftsZeit).ToString("g");
            lblFahrtDauer.Text = DateTimeOffset.Parse(FahrtDauer.Substring(3)).ToString("t");
            Location = new Point(posX, posY);
        }

        private void KonkreteVerbindung_Load(object sender, EventArgs e)
        {
        }
    }
}
