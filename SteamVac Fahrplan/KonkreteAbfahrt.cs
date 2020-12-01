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
        public KonkreteAbfahrt(string zugName, string endstation, string AbfahrtZeit,int posX, int posY)
        {
            InitializeComponent();
            lblZugName.Text = zugName;
            lblEndstation.Text = endstation;
            lblAbfahrt.Text = AbfahrtZeit;
            Location = new Point(posX, posY);
        }

        private void KonkreteAbfahrt_Load(object sender, EventArgs e)
        {

        }
    }
}
