using System;
using System.CodeDom;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Device.Location;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            query = System.Uri.EscapeDataString(query);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message
                    , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return stations;
            }

            return null;
        }

        public Stations GetStationsMitStandort(GeoCoordinate coordinate)
        {
            //coordinate = System.Uri.EscapeDataString(coordinate);
            double X = coordinate.Latitude;
            double Y = coordinate.Longitude;
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?x=" + X + "&y=" + Y);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message
                    , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return stations;
            }

            return null;
        }
        public StationBoardRoot GetStationBoard(string station, string id)
        {
            station = System.Uri.EscapeDataString(station);
            id = System.Uri.EscapeDataString(id);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station + "&id=" + id);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }
        public StationBoardRoot GetStationBoardAtTime(string station, string id, string atDateTime)
        {
            station = System.Uri.EscapeDataString(station);
            id = System.Uri.EscapeDataString(id);
            atDateTime = System.Uri.EscapeDataString(atDateTime);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station 
                + "&id=" + id
                + "&datetime=" + atDateTime);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStation)
        {
            fromStation = System.Uri.EscapeDataString(fromStation);
            toStation = System.Uri.EscapeDataString(toStation);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        public Connections GetConnectionsAtTime(string fromStation, string toStation, DateTime atDate, DateTime atTime, int isArrivalTime)
        {
            fromStation = System.Uri.EscapeDataString(fromStation);
            toStation = System.Uri.EscapeDataString(toStation);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation 
                + "&to=" + toStation 
                + "&date=" + atDate.ToString("d").Replace('/', '-')
                + "&time=" + atTime.ToString("t")
                + "&isArrivalTime=" + isArrivalTime
                );
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
