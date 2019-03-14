using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP__2
{
    [Serializable]
    [DataContract]
    public class Plane: Airplane
    {
        [DataMember] public int EnginePower { get; set; }

        public Plane() { }

        public override List<string> GetValues()
        {
            List<string> values = new List<string>();
            values.Add(Name);
            values.Add(TailNumber);
            values.Add(Convert.ToString(MaxSpeed));
            values.Add(Convert.ToString(MaxFlightDistance));
            values.Add(Convert.ToString(Wingspan));
            values.Add(Convert.ToString(EnginePower));
            values.Add("");
            values.Add("");
            return values;
        }

        public override void SetValues(List<string> data)
        {
            Name = data[0];
            TailNumber = data[1];
            MaxSpeed = Convert.ToInt32(data[2]);
            MaxFlightDistance = Convert.ToInt32(data[3]);
            Wingspan = Convert.ToInt32(data[4]);
            EnginePower = Convert.ToInt32(data[5]);
        }
    }
}
