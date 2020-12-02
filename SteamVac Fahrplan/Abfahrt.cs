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
    public partial class Abfahrt : Form
    {
        public Abfahrt(
            string Name,
            string Endstation,
            string AbfahrtZeit
            )
        {
            InitializeComponent();
            lblTitelAbfahrt.Text = Name + " nach " + Endstation;
            lblAbfahrtZeit.Text = AbfahrtZeit;
            lblAnkunftOrt.Text = Endstation;
        }

        private void Abfahrt_Load(object sender, EventArgs e)
        {

        }
    }
}
