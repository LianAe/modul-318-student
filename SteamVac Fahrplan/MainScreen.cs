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

        /*
        private bool brauchtAutovervolständigungAbfahrtsstation = true;
        private bool brauchtAutovervolständigungAnkunftsstation = true;
        private AutoCompleteStringCollection autovervollständigung = new AutoCompleteStringCollection();
        */

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

            if (grpAbfahrten.Controls.ContainsKey(nameof(KonkreteAbfahrt)) && splitMainScreen.Panel2.Height > 400)
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

        //nicht fertig
        /*private void sucheAbfahrtsstation_TextChanged(object sender, EventArgs e)
        {
            if (sucheAbfahrtsstation.Text.Length > 4 && brauchtAutovervolständigungAbfahrtsstation)
            {
                autovervollständigung.Clear();
                var abfahrtsstation = abfahrtsstationSuche.GetStations(sucheAbfahrtsstation.Text);
                if (abfahrtsstation.StationList[0].Name == null)
                {
                    MessageBox.Show("Keine Station gefunden");
                }
                else
                {
                    for (int i = 0; i < abfahrtsstation.StationList.Count && i < 10; i++)
                    {
                        autovervollständigung.Add(abfahrtsstation.StationList[i].Name);
                    }
                    sucheAbfahrtsstation.AutoCompleteCustomSource = autovervollständigung;
                    sucheAbfahrtsstation.AutoCompleteMode = AutoCompleteMode.Suggest;
                    brauchtAutovervolständigungAbfahrtsstation = false;
                }
            }
        }
            
    

        private void sucheAnkunftsstation_TextChanged(object sender, EventArgs e)
        {
            if (sucheAnkunftsstation.Text.Length > 4 && brauchtAutovervolständigungAnkunftsstation)
            {
                autovervollständigung.Clear();
                var ankunftsstation = ankunftsstationSuche.GetStations(sucheAnkunftsstation.Text);
                if (ankunftsstation.StationList[0].Name == null)
                {
                    MessageBox.Show("Keine Station gefunden");
                }
                else
                {
                for (int i = 0; i < ankunftsstation.StationList.Count && i < 10; i++)
                {
                    autovervollständigung.Add(ankunftsstation.StationList[i].Name);
                }
                
                sucheAnkunftsstation.AutoCompleteCustomSource = autovervollständigung;
                sucheAnkunftsstation.AutoCompleteMode = AutoCompleteMode.Suggest;
                brauchtAutovervolständigungAnkunftsstation = false;
                    
                }
            }
        }*/

        private void sucheAbfahrtstafel_Leave(object sender, EventArgs e)
        {
            if (sucheAbfahrtstafel.Text != "")
            {
                try
                {
                    lblAbfahrtstafelSucheLeer.Visible = false; 
                    if (abfahrtsstationSuche.GetStations(sucheAbfahrtstafel.Text).StationList[0].Name == null)
                    {
                        sucheAbfahrtstafel.Text = abfahrtsstationSuche.GetStations(sucheAbfahrtstafel.Text).StationList[1].Name;
                    }
                    else
                    {
                        sucheAbfahrtstafel.Text = abfahrtsstationSuche.GetStations(sucheAbfahrtstafel.Text).StationList[0].Name;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Standort nicht gefunden!");
                }
            }
            else
            {
                lblAbfahrtstafelSucheLeer.Visible = true;//eine meldung weist den User darauf das, dass Feld leer ist
            }
        }

        private void btnAbfahrtenSuchen_Click(object sender, EventArgs e)
        {
            findeAbfahrten();
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
                
                

                //Die gewälte Station wird im such feld angezeigt.
                sucheAbfahrtstafel.Text = abfahrtsOrt.StationList[1].Name;

            }
            else
            {
                MessageBox.Show("Standort nicht gefunden");
            }
            
        }

        private void auswahlDatumZeitAbfahrten_CheckedChanged(object sender, EventArgs e)
        {
            if (auswahlDatumZeitAbfahrten.Checked)
            {
                datumAbfahrten.Enabled = true;
                zeitAbfahrt.Enabled = true;
            }

            if (auswahlDatumZeitAbfahrten.Checked == false)
            {
                datumAbfahrten.Enabled = false;
                zeitAbfahrt.Enabled = true;
            }
        }

        private void auswahlDatumZeitNutzen_CheckedChanged(object sender, EventArgs e)
        {
            if (auswahlDatumZeitVerbindungen.Checked)
            {
                datumVerbindungen.Enabled = true;
                zeitVerbindungen.Enabled = true;
                auswahlAnkunftAbfahrt.Enabled = true;
                auswahlAnkunftAbfahrt.SelectedIndex = 0;
            }


            if (auswahlDatumZeitVerbindungen.Checked == false)
            {
                datumVerbindungen.Enabled = false;
                zeitVerbindungen.Enabled = false;
                auswahlAnkunftAbfahrt.Enabled = false;
            }
        }


        private void überprüfeSuchfeldAbfahrtstation()
        {
            if (sucheAbfahrtsstation.Text != "")//Es wird geschaut das der wert nicht null ist
            {

                var abfahrtsstation = abfahrtsstationSuche.GetStations(sucheAbfahrtsstation.Text);
                lblAbfahrtsstationSucheLeer.Visible = false;

                //Fals es an beiden Stellen null ist popt ein Fenster auf.
                try
                {
                    if (abfahrtsstation.StationList[0].Name == null)
                    {
                        sucheAbfahrtsstation.Text = abfahrtsstation.StationList[1].Name.ToString();
                    }
                    else
                    {
                        sucheAbfahrtsstation.Text = abfahrtsstation.StationList[0].Name.ToString();
                    }
                }
                catch (Exception)//Es wird eine Fehlermeldung angezeigt fals keine Station gefunden wird
                {
                    MessageBox.Show("Station wurde nicht gefunden");

                    sucheAbfahrtsstation.Text = "";
                }
            }
            else
            {
                //eine meldung weist den User darauf das, dass Feld leer ist
                lblAbfahrtsstationSucheLeer.Visible = true;
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
                    if (ankunftsstation.StationList[0].Name == null)
                    {
                        sucheAnkunftsstation.Text = ankunftsstation.StationList[1].Name.ToString();
                    }
                    else
                    {
                        sucheAnkunftsstation.Text = ankunftsstation.StationList[0].Name.ToString();
                    }
                }
                catch (Exception)//Es wird eine Fehlermeldung angezeigt fals keine Station gefunden wird
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

            Connections Verbindung;
            //Es wird überprüft ob die DatumZeit auswahl genutzt werden soll.
            if (datumVerbindungen.Checked)
            {
                Verbindung = verbindungen.GetConnectionsAtTime(
                    sucheAbfahrtsstation.Text, 
                    sucheAnkunftsstation.Text,
                    datumVerbindungen.Value,
                    zeitVerbindungen.Value,
                    auswahlAnkunftAbfahrt.SelectedIndex);
            }
            else
            {
                Verbindung = verbindungen.GetConnections(sucheAbfahrtsstation.Text, sucheAnkunftsstation.Text);
            }

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
                        i * 70 + 100,
                        Verbindung.ConnectionList[i].To.Platform,
                        Verbindung.ConnectionList[i].From.Platform,
                        Verbindung.ConnectionList[i].To.Station.Name,
                        Verbindung.ConnectionList[i].From.Station.Name

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
                        abfahrtstafel.Entries[i].Stop.Departure.ToString("g"),
                        posXkonkreteAbfahrten,
                        i * 80 + 120
                    );
                    konkreteAbfahrten.Add(konkreteAbfahrt);
                    grpAbfahrten.Controls.Add(konkreteAbfahrten[i]);
                }

            }
        }

        private GeoCoordinate findeStandort()
        {

            GeoCoordinateWatcher tracker = new GeoCoordinateWatcher();

            tracker.TryStart(false, TimeSpan.FromMilliseconds(2000));

            //Die Position die der Tracker hat wird eine Variable zugewiesen
            GeoCoordinate aktuelleKordinate = tracker.Position.Location;
            
            //Es wird noch mehr mals die Kordinate abgefragt, weil es sonst oft kein Standort findet
            for (int i = 0; i < 10; i++)
            {
                if (aktuelleKordinate != null)
                {
                    return aktuelleKordinate;
                }
                else
                {
                    aktuelleKordinate = tracker.Position.Location;
                    tracker.TryStart(false, TimeSpan.FromMilliseconds(1000));
                }

            }

            return null;
            
        }

        private void findeAbfahrten()
        {
            
                StationBoardRoot abfahrtstafel;
                if (auswahlDatumZeitAbfahrten.Checked)
                {
                    string datumZeitAbfahrt = datumAbfahrten.Value.ToString("yyyy-MM-dd")
                                              + " "
                                              + zeitAbfahrt.Value.ToString("t");

                    abfahrtstafel = abfahrtstafelSuche.GetStationBoardAtTime(
                        sucheAbfahrtstafel.Text,
                        abfahrtstafelSuche.GetStations(sucheAbfahrtstafel.Text).StationList[0].Id,
                        datumZeitAbfahrt
                    );
                }
                else
                {
                    abfahrtstafel = abfahrtstafelSuche.GetStationBoard(
                        sucheAbfahrtstafel.Text,
                        abfahrtstafelSuche.GetStations(sucheAbfahrtstafel.Text).StationList[0].Id
                    );
                }
                abfahrtstafelAusfüllen(abfahrtstafel);
        }
    }
}
