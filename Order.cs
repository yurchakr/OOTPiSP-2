﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP__2
{
    class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Aircraft Aircraft { get; set; }
        public DateTime OnWhen { get; set; }
        public int DurationOfFlight { get; set; }
        public bool NeedPilot { get; set; }

        public string GetOrderInfo(Aircraft aircraft)
        {
            return string.Format("{0} have an order of {1} for {2}", User.Profile.Name, Aircraft.Name, OnWhen.Date.ToString());
        }
    }
}
