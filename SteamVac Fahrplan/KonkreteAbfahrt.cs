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
    public partial class KonkreteAbfahrt : UserControl
    {
        public KonkreteAbfahrt(string zugName, string endstation, string AbfahrtZeit, int Y)
        {
            InitializeComponent();
            lblZugName.Text = zugName;
            lblEndstation.Text = endstation;
            lblAbfahrt.Text = AbfahrtZeit;
            Location = new Point(20, Y);
        }

        private void KonkreteAbfahrt_Load(object sender, EventArgs e)
        {

        }
    }
}
