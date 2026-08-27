using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal static class DeliveryUtilities
    {
        // Print Separator
        public static void PrintSeparator()
        {
            Console.WriteLine("==========================================");
        }

        // Print System Title
        public static void PrintSystemTitle()
        {
            PrintSeparator();
            Console.WriteLine("Delivery Center");
            PrintSeparator();
        }
    }
}
