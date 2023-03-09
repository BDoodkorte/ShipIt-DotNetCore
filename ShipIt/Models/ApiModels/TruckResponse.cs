using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ShipIt.Models.DataModels;

namespace ShipIt.Models.ApiModels
{
    public class TruckResponse
    {
        public double TruckCount { get; set; }
        public List<Truck> Trucks { get; set; }

        public TruckResponse(double truckCount, List<Truck> trucks)
        {
            TruckCount = truckCount;
            Trucks = trucks;
        }

    }
}

// Create Trucks response model that contains TruckCount List<Truck>
