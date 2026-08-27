using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments = new Shipment[20];

        // Integer Indexer
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return null;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }

        // String Indexer
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }

        // Add Shipment
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        // Remove Shipment
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        // Print All Shipments
        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();
                    Console.WriteLine();
                }
            }
        }

        // Print Tracking Statuses
        public void PrintTrackingStatuses()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null && shipment is ITrackable)
                {
                    ITrackable item = (ITrackable)shipment;

                    Console.WriteLine(item.GetTrackingStatus());
                }
            }
        }

        // Print Insurance
        public void PrintInsurance()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null && shipment is IInsurable)
                {
                    IInsurable item = (IInsurable)shipment;

                    Console.WriteLine(
                        "Insurance Cost: " +
                        item.CalculateInsurance() +
                        " EGP");
                }
            }
        }
    }
}
