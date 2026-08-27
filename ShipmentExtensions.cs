using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal static class ShipmentExtensions
    {
        // Get Summary
        public static string GetSummary(this Shipment shipment)
        {
            string type = shipment.GetType().Name;

            // Remove "Shipment" from class name
            type = type.Replace("Shipment", "");

            return shipment.TrackingCode
                + " | "
                + type
                + " | "
                + shipment.Weight
                + " KG | "
                + shipment.GetTrackingStatus();
        }

        // Check if Delivered
        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetTrackingStatus() == "Delivered";
        }
    }
}
