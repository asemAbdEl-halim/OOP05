using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal abstract partial class Shipment
    {
        // Partial Method Implementation
        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine(
                "Tracking status changed to: " + newStatus
            );
        }
    }
}
