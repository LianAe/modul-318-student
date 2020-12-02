using System;
using System.Device.Location;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        Stations GetStationsMitStandort(GeoCoordinate coordinate);
        StationBoardRoot GetStationBoard(string station, string id);
        StationBoardRoot GetStationBoardAtTime(string station, string id, string atDateTime);
        Connections GetConnections(string fromStation, string toStattion);
        Connections GetConnectionsAtTime(string fromStation, string toStattion, DateTime atDate, DateTime atTime, int isArrivalTime);
    }
}