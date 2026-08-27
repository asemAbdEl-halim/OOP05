using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;
        // Static Field
        public static int TotalShipmentsCreated = 0;

        // Static Constructor
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        // Static Method
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }


        // Constructor 1
        public Shipment(string trackingCode)
            : this(
                trackingCode,
                "Unknown",
                1,
                50,
                new DeliveryAddress("Cairo", "Unknown", 1))
        {
        }


        // Constructor 2
        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = trackingCode;
            else
                this.trackingCode = "Unknown";

            if (!string.IsNullOrWhiteSpace(description))
                this.description = description;
            else
                this.description = "Unknown";

            if (weight > 0)
                this.weight = weight;
            else
                this.weight = 1;

            if (deliveryFee > 0)
                this.deliveryFee = deliveryFee;
            else
                this.deliveryFee = 50;

            this.destination = destination;

            // Increase counter
            TotalShipmentsCreated++;
        }


        // Tracking Code - Read Only
        public string TrackingCode
        {
            get { return trackingCode; }
        }


        // Description - Read / Write
        public string Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }


        // Weight - Read / Write
        public decimal Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                    weight = value;
            }
        }


        // Delivery Fee - Public Getter / Private Setter
        public decimal DeliveryFee
        {
            get { return deliveryFee; }

            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }


        // Destination - Read / Write
        public DeliveryAddress Destination
        {
            get { return destination; }

            set
            {
                destination = value;
            }
        }


        // Abstract Estimated Cost
        public abstract decimal EstimatedCost { get; }


        // Abstract Print Shipment
        public abstract void PrintShipment();


        // Update Delivery Fee
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }


        // Update Weight
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }


        // Update Weight + Packing Weight
        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            if (newWeight > 0 && packingWeight >= 0)
            {
                Weight = newWeight + packingWeight;
            }
        }


        // Copy Shipment
        public Shipment CopyShipment()
        {
            return (Shipment)this.MemberwiseClone();
        }


        // Shallow Copy
        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }


        // Deep Copy
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();

            copy.Destination = new DeliveryAddress(
                this.Destination.City,
                this.Destination.Street,
                this.Destination.BuildingNumber
            );

            return copy;
        }

        public abstract string GetTrackingStatus();

    }
}
