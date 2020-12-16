using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MyBikesFactoryDataLayer
{
    public class XmlFileHandler : FileHandler
    {
        public XmlFileHandler() : base(FileType.xml) { }

        public override void WriteToFile<T>(string fileName, List<T> list)
        {
            CreateFileStream<T>(fileName);
            var filePointer = XmlWriter.Create(fileStream);

            //Here we call the method WriteToFile from base the class.
            //To be able to serialize the xml properly, it is very
            //important to use the constructor like XmlSerializer(typeof(List<T>), new Type[] { }))
            //This way, XmlSerializer is able to handle a List<T> (where T is a base class)
            //containing diversified derived classes instances in the list:
            WriteToFile<T>(list, filePointer, new XmlSerializer(typeof(List<T>), new Type[] { }));
        }

        public override List<T> ReadFromFile<T>(string fileName)
        {
            //Again it is very important to use the constructor like XmlSerializer(typeof(List<T>), new Type[] { }))
            //To deal with a List<T> (where T is a base class)
            //containing diversified derived classes instances in the list:
            return ReadFromFile<T>(new XmlSerializer(typeof(List<T>), new Type[] { }), fileName);
        }
    }
}
