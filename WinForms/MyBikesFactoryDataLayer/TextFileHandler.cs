using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactoryDataLayer
{
    public class TextFileHandler : FileHandler
    {
        public TextFileHandler() : base(FileType.txt) { }

        public override void WriteToFile<T>(string fileName, List<T> list)
        {
            CreateFileStream<T>(fileName);
            WriteToFile<T>(list, fileStream, new TextFormatter());
        }

        public override List<T> ReadFromFile<T>(string fileName)
        {
            return ReadFromFile<T>(new TextFormatter(), fileName);
        }
    }
}
