using SwissTransport;
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
        private ITransport abfahrtsstationSuche;
        private ITransport ankunftsstationSuche;
        private ITransport verbindungen;
        private ITransport abfahrtstafelSuche;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            abfahrtsstationSuche = new Transport();//eine Neue Klasse wird für die Abfahrtsstations-Suche zugewiesen
            ankunftsstationSuche = new Transport();//eine Neue Klasse wird für die Ankunftsstations-Suche zugewiesen
            verbindungen = new Transport();//eine Neue Klasse wird für die verbindungen zugewiesen
            abfahrtstafelSuche = new Transport();//eine Neue Klasse wird für die abfahrtstafel zugewiesen

        }

        private void btnVerbindungen_Click(object sender, EventArgs e)
        {

            grpVerbindungen.Enabled = true;//das Verbindugen Menu wird angezeigt
            grpVerbindungen.Visible = true;
            grpAbfahrten.Enabled = false;//die anderen Menus werden Versteckt und deaktiviert
            grpAbfahrten.Visible = false;
        }

        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            grpAbfahrten.Enabled = true;//die Abfahrtstafel wird angezeigt
            grpAbfahrten.Visible = true;
            grpVerbindungen.Enabled = false;//die anderen Menus werden Versteckt und deaktiviert
            grpVerbindungen.Visible = false;

        }

        private void sucheAbfahrtsstation_Leave(object sender, EventArgs e)
        {
            if (sucheAbfahrtsstation.Text != "")//Es wird geschaut das der wert nicht null ist
            {
                lblAbfahrtsstationSucheLeer.Visible = false;
                var abfahrtsstation = abfahrtsstationSuche.GetStations(sucheAbfahrtsstation.Text);
                try
                {
                    sucheAbfahrtsstation.Text = abfahrtsstation.StationList[0].Name.ToString();
                } catch (Exception exception)//Es wird überprüft ob es eine Station mit änlchen namen nicht gibt
                {
                    MessageBox.Show("Station wurde nicht gefunden");//\nError Meldung:  + exception.Message

                    sucheAbfahrtsstation.Text = "";
                }
                if (sucheAnkunftsstation.Text != "")
                {
                    List<KonkreteVerbindung> KonkreteVerbindungen = new List<KonkreteVerbindung>();
                    for (int i = 0; i != 4; i++)
                    {
                        var Verbindung = verbindungen.GetConnections(sucheAbfahrtsstation.Text, sucheAnkunftsstation.Text);
                        if (Verbindung != null)
                        {
                            KonkreteVerbindung konkreteVerbindung = new KonkreteVerbindung(
                                Verbindung.ConnectionList[i].From.Departure,
                                Verbindung.ConnectionList[i].To.Arrival,
                                Verbindung.ConnectionList[i].Duration,
                                12,
                                i * 70 + 100
                            );
                            KonkreteVerbindungen.Add(konkreteVerbindung);
                            KonkreteVerbindungen[i].CreateControl();
                            grpVerbindungen.Controls.Add(KonkreteVerbindungen[i]);
                            if (KonkreteVerbindungen[i].Created == true)
                            {
                                KonkreteVerbindungen[i].Visible = true;
                                MessageBox.Show(KonkreteVerbindungen[i].Location.X.ToString(), KonkreteVerbindungen[i].Location.Y.ToString());
                            }

                        }
                        //KonkreteVerbindungen[i].Location.X = 12;
                    }

                }
            }
            else
            {
                lblAbfahrtsstationSucheLeer.Visible = true;//eine meldung weist den User darauf das, dass Feld leer ist
            }

        }

        private void sucheAnkunftsstation_Leave(object sender, EventArgs e)
        {
            if (sucheAnkunftsstation.Text != "")//Es wird geschaut das der wert nicht null ist
            {
                lblAnkunftsstationSucheLeer.Visible = false;
                var ankunftsstation = ankunftsstationSuche.GetStations(sucheAnkunftsstation.Text);

                try
                {
                    sucheAnkunftsstation.Text = ankunftsstation.StationList[0].Name.ToString();//die erste station die einen änlichen namen hat wird ausgewählt 
                }
                catch (Exception exception)//Es wird überprüft ob es eine Station mit änlchen namen nicht gibt
                {
                    MessageBox.Show("Station wurde nicht gefunden");//\nError Meldung:  + exception.Message
                    sucheAnkunftsstation.Text = "";
                }

                if(sucheAbfahrtsstation.Text != "")
                {
                    List<KonkreteVerbindung> KonkreteVerbindungen = new List<KonkreteVerbindung>();
                    for(int i = 0; i != 4; i++)
                    {
                        var Verbindung = verbindungen.GetConnections(sucheAbfahrtsstation.Text, sucheAnkunftsstation.Text);
                        if (Verbindung != null)
                        {
                            KonkreteVerbindung konkreteVerbindung = new KonkreteVerbindung(
                                Verbindung.ConnectionList[i].From.Departure, 
                                Verbindung.ConnectionList[i].To.Arrival,
                                Verbindung.ConnectionList[i].Duration,
                                12,
                                i * 70 + 100
                                );
                            KonkreteVerbindungen.Add(konkreteVerbindung);
                            KonkreteVerbindungen[i].CreateControl();
                            grpVerbindungen.Controls.Add(KonkreteVerbindungen[i]);
                            if (KonkreteVerbindungen[i].Created == true)
                            {
                                KonkreteVerbindungen[i].Visible = true;
                                MessageBox.Show(KonkreteVerbindungen[i].Location.X.ToString(), KonkreteVerbindungen[i].Location.Y.ToString());
                            }
                                
                        }
                        //KonkreteVerbindungen[i].Location.X = 12;
                    }
                    
                }
            }
            else
            {
                lblAnkunftsstationSucheLeer.Visible = true;//eine meldung weist den User darauf das, dass Feld leer ist
            }

        }


        private void sucheAbfahrtstafel_Leave(object sender, EventArgs e)
        {
            if (sucheAbfahrtstafel.Text != "")
            {
                lblAbfahrtstafelSucheLeer.Visible = false;
                var abfahrtstafel = abfahrtstafelSuche.GetStationBoard(
                        sucheAbfahrtstafel.Text, 
                        abfahrtstafelSuche.GetStations(sucheAbfahrtstafel.Text).StationList[0].Id
                    );
                if (abfahrtstafel != null)
                {
                    List<KonkreteAbfahrt> konkreteAbfahrten = new List<KonkreteAbfahrt>();
                    if (konkreteAbfahrten.Count > 0)
                    {
                        foreach (KonkreteAbfahrt konkreteAbfahrt in grpAbfahrten.Controls)
                        {
                            grpAbfahrten.Controls.Remove(konkreteAbfahrt);
                        }
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        KonkreteAbfahrt konkreteAbfahrt = new KonkreteAbfahrt(
                            abfahrtstafel.Entries[i].Name,
                            abfahrtstafel.Entries[i].To,
                            abfahrtstafel.Entries[i].Stop.Departure.Hour.ToString() + ":" + abfahrtstafel.Entries[i].Stop.Departure.Minute.ToString(),
                            i * 80 + 80
                            );
                        konkreteAbfahrten.Add(konkreteAbfahrt);
                        grpAbfahrten.Controls.Add(konkreteAbfahrten[i]);
                    }
                    
                }
            }
            else
            {
                lblAbfahrtstafelSucheLeer.Visible = true;//eine meldung weist den User darauf das, dass Feld leer ist
            }
        }
    }
}
