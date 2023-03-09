using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ShipIt.Models.DataModels;

namespace ShipIt.Models.ApiModels
{
    public class Truck{
        public float TruckWeight {get; set;}
        public List<OrderLine> ItemList {get; set;}
    

        public Truck(float truckWeight, List<OrderLine> itemList)
        {
            TruckWeight = truckWeight;
            ItemList = itemList;
        }

    }
}

// Create Truck model that contains List<OrderLines> and TruckWeight
