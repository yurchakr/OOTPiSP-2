using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP__2
{
    class PlaneFactory : AircraftFactory
    {
        public override Aircraft createAircraft()
        {
            return new Plane();
        }
    }
}
