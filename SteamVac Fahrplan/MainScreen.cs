using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Device.Location;

namespace SteamVac_Fahrplan
{
    public partial class MainScreen : Form
    {
        private ITransport abfahrtsstationSuche;
        private ITransport ankunftsstationSuche;
        private ITransport verbindungen;
        private ITransport abfahrtstafelSuche;

        //zum überprüfen ob der standort das erste mal gesucht wird
        private bool ErstesMalStandortSuche = false;
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
            grpVerbindungen.Height = splitMainScreen.Panel2.Height - 5;
        }

        private void MainScreen_SizeChanged(object sender, EventArgs e)
        {
            //Die Gruppe mit den verbindungen passt sich der grösse vom fenster an.
            //Die "-5" ist damit es nicht ein scrollbar anzeit
            if (grpVerbindungen.Controls.ContainsKey(nameof(KonkreteVerbindung)) == false)
                grpVerbindungen.Height = splitMainScreen.Panel2.Height - 5;

            if(grpVerbindungen.Controls.ContainsKey(nameof(KonkreteVerbindung)) && splitMainScreen.Panel2.Height > 400)
                grpVerbindungen.Height = splitMainScreen.Panel2.Height - 5;

            if (grpAbfahrten.Controls.ContainsKey(nameof(KonkreteAbfahrt)) == false)
                grpAbfahrten.Height = splitMainScreen.Panel2.Height - 5;

        }

        private void btnVerbindungen_Click(object sender, EventArgs e)
        {
            //das Verbindugen Menu wird angezeigt
            grpVerbindungen.Enabled = true;
            grpVerbindungen.Visible = true;

            //die anderen Menus werden Versteckt und deaktiviert
            grpAbfahrten.Enabled = false;
            grpAbfahrten.Visible = false;

            //die gösse wird angepasst
            grpVerbindungen.Height = splitMainScreen.Panel2.Height - 5;
        }

        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            //die Abfahrtstafel wird angezeigt
            grpAbfahrten.Enabled = true;
            grpAbfahrten.Visible = true;

            //die anderen Menus werden Versteckt und deaktiviert
            grpVerbindungen.Enabled = false;
            grpVerbindungen.Visible = false;

            //die grösse wird angepasst
            grpAbfahrten.Height = splitMainScreen.Panel2.Height - 5;
        }

        private void sucheAbfahrtsstation_Leave(object sender, EventArgs e)
        {
            überprüfeSuchfeldAbfahrtstation();
        }

        private void sucheAnkunftsstation_Leave(object sender, EventArgs e)
        {
            überprüfeSuchfeldAnkunftstation();
        }


        private void sucheAbfahrtstafel_Leave(object sender, EventArgs e)
        {
            if (sucheAbfahrtstafel.Text != "")
            {
                lblAbfahrtstafelSucheLeer.Visible = false;
                sucheAbfahrtstafel.Text = abfahrtsstationSuche.GetStations(sucheAbfahrtstafel.Text).StationList[0].Name;
                StationBoardRoot abfahrtstafel = abfahrtstafelSuche.GetStationBoard(
                    sucheAbfahrtstafel.Text,
                    abfahrtstafelSuche.GetStations(sucheAbfahrtstafel.Text).StationList[0].Id
                );
                abfahrtstafelAusfüllen(abfahrtstafel);
            }
            else
            {
                lblAbfahrtstafelSucheLeer.Visible = true;//eine meldung weist den User darauf das, dass Feld leer ist
            }
        }

        private void btnVerbindungSuchen_Click(object sender, EventArgs e)
        {
            if (sucheAbfahrtsstation.Text != "" && sucheAnkunftsstation.Text != "")
            {
                lblAnkunftsstationSucheLeer.Visible = false;
                lblAbfahrtsstationSucheLeer.Visible = false;
                var abfahrtsstation = abfahrtsstationSuche.GetStations(sucheAbfahrtsstation.Text);
                var ankunftsstation = ankunftsstationSuche.GetStations(sucheAnkunftsstation.Text);
                VerbindungenAusfüllen();
            }
            else
            {
                while (grpVerbindungen.Controls.ContainsKey("KonkreteVerbindung"))
                {
                    grpVerbindungen.Controls.RemoveByKey("KonkreteVerbindung");
                }
            }
        }
        private void btnAbfahrtAnkunftTauschen_Click(object sender, EventArgs e)
        {
            string temp; //damit man die Stationen tauschen kann
            temp = sucheAbfahrtsstation.Text;
            sucheAbfahrtsstation.Text = sucheAnkunftsstation.Text;
            sucheAnkunftsstation.Text = temp;
            überprüfeSuchfeldAbfahrtstation();
            überprüfeSuchfeldAnkunftstation();
        }

        private void btnStandort_Click(object sender, EventArgs e)
        {
            lblAbfahrtstafelSucheLeer.Visible = false;

            //Die aktuelen Kordinaten werden gesucht. 
            GeoCoordinate Standort = findeStandort();

            //Es wird überprüft ob etwas gefunden wurde.
            if (Standort != GeoCoordinate.Unknown)
            {
                //die nachste Station wird mit hilfe von den Kordinaten gesucht.
                Stations abfahrtsOrt = abfahrtstafelSuche.GetStationsMitStandort(Standort);

                //Die abfahrten von der 2 gefundenen Station werden angezeigt. Die erste ist die andresse vom aktuellen Standort.
                StationBoardRoot abfahtstafel = abfahrtstafelSuche.GetStationBoard(
                    abfahrtsOrt.StationList[1].Name,
                    abfahrtsOrt.StationList[1].Id
                    );

                //Die gewälte Station wird im such feld angezeigt.
                sucheAbfahrtstafel.Text = abfahrtsOrt.StationList[1].Name;

                //Die Abfahrtstafel wird ausgefüllt.
                abfahrtstafelAusfüllen(abfahtstafel);
            }
            else
            {
                MessageBox.Show("Standort nicht gefunden");
            }
            
        }

        private void überprüfeSuchfeldAbfahrtstation()
        {
            if (sucheAbfahrtsstation.Text != "")//Es wird geschaut das der wert nicht null ist
            {
                var abfahrtsstation = abfahrtsstationSuche.GetStations(sucheAbfahrtsstation.Text);
                lblAbfahrtsstationSucheLeer.Visible = false;
                try
                {
                    sucheAbfahrtsstation.Text = abfahrtsstation.StationList[0].Name.ToString();
                }
                catch (Exception exception)//Es wird eine Fehlermeldung angezeigt fals keine Station gefunden wird
                {
                    MessageBox.Show("Station wurde nicht gefunden");

                    sucheAbfahrtsstation.Text = "";
                }
            }
            else
            {
                lblAbfahrtsstationSucheLeer.Visible = true;//eine meldung weist den User darauf das, dass Feld leer ist
            }
        }

        private void überprüfeSuchfeldAnkunftstation()
        {
            if (sucheAnkunftsstation.Text != "")//Es wird geschaut das der wert nicht null ist
            {
                var ankunftsstation = ankunftsstationSuche.GetStations(sucheAnkunftsstation.Text);
                lblAnkunftsstationSucheLeer.Visible = false;
                try
                {
                    sucheAnkunftsstation.Text = ankunftsstation.StationList[0].Name.ToString();
                }
                catch (Exception exception)//Es wird eine Fehlermeldung angezeigt fals keine Station gefunden wird
                {
                    MessageBox.Show("Station wurde nicht gefunden");

                    sucheAnkunftsstation.Text = "";
                }
            }
            else
            {
                lblAnkunftsstationSucheLeer.Visible = true;//eine meldung weist den User darauf das, dass Feld leer ist
            }
        }

        //Methode die die Verbindungen als felder auflistet
        private void VerbindungenAusfüllen()
        {
            var Verbindung = verbindungen.GetConnections(sucheAbfahrtsstation.Text, sucheAnkunftsstation.Text);

            //überprüfung ob es Verbindungen gibt
            if (Verbindung.ConnectionList.Count == 0)
                MessageBox.Show("Keine Verbindungen gefunden");

            //liste für alle Verbindungen wird erstelt
            List<KonkreteVerbindung> KonkreteVerbindungen = new List<KonkreteVerbindung>();

            //die exestierenden Werte und Felder löschen
            while (grpVerbindungen.Controls.ContainsKey("KonkreteVerbindung"))
            {
                grpVerbindungen.Controls.RemoveByKey("KonkreteVerbindung");
            }
            KonkreteVerbindungen.Clear();

            //die possition von den konkreten Verbindungen wird zentriert 
            int posXkonkreteVerbindungen = (grpVerbindungen.Width - 570) / 2;
            if (posXkonkreteVerbindungen < 0)
                posXkonkreteVerbindungen = 0;

            //Neue felder mit den konkreten Verbindungen weren ersstelt
            for (int i = 0; i != Verbindung.ConnectionList.Count; i++)
            {
                    KonkreteVerbindung konkreteVerbindung = new KonkreteVerbindung(
                        Verbindung.ConnectionList[i].From.Departure,
                        Verbindung.ConnectionList[i].To.Arrival,
                        Verbindung.ConnectionList[i].Duration,
                        posXkonkreteVerbindungen,
                        i * 70 + 100
                    );
                    KonkreteVerbindungen.Add(konkreteVerbindung);
                    grpVerbindungen.Height = 70 + KonkreteVerbindungen[i].Location.Y;
                    grpVerbindungen.Controls.Add(KonkreteVerbindungen[i]);
            }

        }

        private void abfahrtstafelAusfüllen(StationBoardRoot abfahrtstafel)
        {
            //die abfahrtstafel wird ausgefüllt
            if (abfahrtstafel != null)
            {
                List<KonkreteAbfahrt> konkreteAbfahrten = new List<KonkreteAbfahrt>();
                
                //fals es schon konkrete Abfahrtenfenster hat werden sie entfernt
                while (grpAbfahrten.Controls.ContainsKey(nameof(KonkreteAbfahrt)))
                    grpAbfahrten.Controls.RemoveByKey(nameof(KonkreteAbfahrt));

                //Entfernt alle abfahrten die erst in mehr als 24 Stunden sind.
                for (int i = 0; i < abfahrtstafel.Entries.Count; i++)
                {
                    if (abfahrtstafel.Entries[i].Stop.Departure > DateTime.Now + TimeSpan.FromHours(24))
                        abfahrtstafel.Entries.RemoveAt(i);
                }

                //die position wird zentriert
                int posXkonkreteAbfahrten = (grpAbfahrten.Width - 570) / 2;
                if (posXkonkreteAbfahrten < 0)
                    posXkonkreteAbfahrten = 0;

                //die konkreten Abfahrtsfenster werden erstellt und hinzugefügt
                for (int i = 0; i < 20; i++)
                {
                    KonkreteAbfahrt konkreteAbfahrt = new KonkreteAbfahrt(
                        abfahrtstafel.Entries[i].Name,
                        abfahrtstafel.Entries[i].To,
                        abfahrtstafel.Entries[i].Stop.Departure.Hour.ToString() + ":" + abfahrtstafel.Entries[i].Stop.Departure.Minute.ToString(),
                        posXkonkreteAbfahrten,
                        i * 80 + 80
                    );
                    konkreteAbfahrten.Add(konkreteAbfahrt);
                    grpAbfahrten.Controls.Add(konkreteAbfahrten[i]);
                }

            }
        }

        private GeoCoordinate findeStandort()
        {

            GeoCoordinateWatcher tracker = new GeoCoordinateWatcher();

            tracker.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate aktuelleKordinate = tracker.Position.Location;

            if (aktuelleKordinate != null)
            {
                return aktuelleKordinate;
            }
            else
            {
                return null;
            }
        }

        private void auswahlDatumZeitVerbindungen_CheckedChanged(object sender, EventArgs e)
        {
            if (auswahlDatumZeitVerbindungen.Checked)
                datumZeitVerbindungen.Enabled = true;

            if (auswahlDatumZeitVerbindungen.Checked == false)
                datumZeitVerbindungen.Enabled = false;
        }


        private void auswahlDatumZeitAbfahrten_CheckedChanged(object sender, EventArgs e)
        {
            if (auswahlDatumZeitAbfahrten.Checked)
                datumZeitAbfahrten.Enabled = true;

            if (auswahlDatumZeitAbfahrten.Checked == false)
                datumZeitAbfahrten.Enabled = false;
        }
    }
}
