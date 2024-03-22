using System;
using System.Collections;

namespace library
{
    public class SortByBattery : IComparer
    {
        public int Compare(object? x1, object? x2)
        {
            if (x1 == null || x2 == null)
            {
                return 1;
            }

            if (x1 is not ElectricTools || x2 is not ElectricTools)
            {
                return 1;
            }

            int batteryLife1 = (x1 as ElectricTools).BatteryLife;
            int batteryLife2 = (x2 as ElectricTools).BatteryLife;

            return batteryLife2 - batteryLife1;
        }
    }
}

