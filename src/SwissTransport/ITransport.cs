using System.Device.Location;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        Stations GetStationsMitStandort(GeoCoordinate coordinate);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion);
    }
}