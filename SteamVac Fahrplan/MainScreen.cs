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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVerbindungen_Click(object sender, EventArgs e)
        {
            grpVerbindungen.Enabled = true;
            grpVerbindungen.Visible = true;
            grpAbfahrten.Enabled = false;
            grpAbfahrten.Visible = false;
        }

        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            grpAbfahrten.Enabled = true;
            grpAbfahrten.Visible = true;
            grpVerbindungen.Enabled = false;
            grpVerbindungen.Visible = false;

        }
    }
}
