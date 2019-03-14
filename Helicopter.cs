using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Serialization;

namespace OOTPiSP__2
{
    [Serializable]
    [DataContract]
    public class Helicopter: Aircraft
    {
        [DataMember] public int RotorDiameter { get; set; }
        [DataMember] public int EnginePower { get; set; }

        public Helicopter() { }

        public override List<string> GetValues()
        {
            List<string> values = new List<string>();
            values.Add(Name);
            values.Add(TailNumber);
            values.Add(Convert.ToString(MaxSpeed));
            values.Add(Convert.ToString(MaxFlightDistance));
            values.Add("");
            values.Add(Convert.ToString(EnginePower));
            values.Add(Convert.ToString(RotorDiameter));
            values.Add("");
            return values;
        }

        public override void SetValues(List<string> data)
        {
            Name = data[0];
            TailNumber = data[1];
            MaxSpeed = Convert.ToInt32(data[2]);
            MaxFlightDistance = Convert.ToInt32(data[3]);
            EnginePower = Convert.ToInt32(data[4]);
            RotorDiameter = Convert.ToInt32(data[5]);
        }
    }
}
