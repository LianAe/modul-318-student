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
        public KonkreteAbfahrt(
            string zugName, 
            string Endstation, 
            string AbfahrtZeit,
            int posX, 
            int posY)
        {
            InitializeComponent();
            lblZugName.Text = zugName;
            lblEndstation.Text = Endstation;
            lblAbfahrt.Text = DateTime.Parse(AbfahrtZeit).ToString("g");
            Location = new Point(posX, posY);
        }

        private void KonkreteAbfahrt_Load(object sender, EventArgs e)
        {

        }

        private void KonkreteAbfahrt_Click(object sender, EventArgs e)
        {
            Abfahrt abfahrt = new Abfahrt(lblZugName.Text, lblEndstation.Text, lblAbfahrt.Text);
            abfahrt.Show();
        }
    }
}
