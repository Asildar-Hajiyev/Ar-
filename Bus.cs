using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAround
{
    class Bus : Vehicle
    {
        public void GetSpeed(int driveway, int drivetime)
        {
            driveway = 12;
            drivetime = 3;
            Console.WriteLine(driveway);
        }
    }
}
