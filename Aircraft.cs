using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOTPiSP__2
{
    [Serializable]
    [KnownType(typeof(Airplane))]
    [KnownType(typeof(Glider))]
    [KnownType(typeof(Helicopter))]
    [KnownType(typeof(Plane))]
    [DataContract]
    [XmlInclude(typeof(Airplane))]
    [XmlInclude(typeof(Glider))]
    [XmlInclude(typeof(Helicopter))]
    [XmlInclude(typeof(Plane))]
    public abstract class Aircraft
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string Name { get; set; }
        [DataMember] public string TailNumber { get; set; }
        [DataMember] public int MaxSpeed { get; set; }
        [DataMember] public int MaxFlightDistance { get; set; }

        public Aircraft() { }

        public abstract void SetValues(List<string> data);
        public abstract List<string> GetValues();
    }
}
