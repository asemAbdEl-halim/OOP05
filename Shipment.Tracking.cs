using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal abstract partial class Shipment
    {
        private string trackingStatus = "In Transit";

        // Partial Method Declaration
        partial void OnTrackingStatusChanged(string newStatus);

        // Get Tracking Status
        public virtual string GetTrackingStatus()
        {
            return trackingStatus;
        }

        // Update Tracking Status
        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                trackingStatus = newStatus;

                // Call Partial Method
                OnTrackingStatusChanged(newStatus);
            }
        }
    }
}
