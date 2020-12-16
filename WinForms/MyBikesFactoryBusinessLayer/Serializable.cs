using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyBikesFactoryBusinessLayer
{
    [Serializable]
    [XmlInclude(typeof(MountainBike))]
    [XmlInclude(typeof(RoadBike))]
    public abstract class SerializableItem
    {
    }
}
