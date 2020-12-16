using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactoryDataLayer
{
    public abstract class FileHandler : IDisposable
    {
        protected FileStream fileStream;

        protected FileType type;
        protected FileType Type { get => type; set => type = value; }
        
        public string FilePath
        {
            get
            {
                string path = Assembly.GetExecutingAssembly().Location;
                path = path.Substring(0, path.LastIndexOf(@"\"));
                return $@"{path}\..\..\..\MyBikesFactoryDataLayer\PERMANENT_STORAGE\";
            }
        }

        public string FullFileName<T>(string fileName)
        {
            string result = $@"{FilePath}{fileName.ToString()}.{type.ToString()}";
            return result;
        }

        protected FileHandler(FileType type)
        {
            this.type = type;
        }

        public abstract void WriteToFile<T>(string fileName, List<T> list);
        public abstract List<T> ReadFromFile<T>(string fileName);

        protected void CreateFileStream<T>(string fileName)
        {
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            string fullfileName = FullFileName<T>(fileName);
            fileStream = new FileStream(fullfileName, FileMode.Create, FileAccess.Write);
        }

        protected void WriteToFile<T>(List<T> list, dynamic filePointer, dynamic serializer)
        {
            serializer.Serialize(filePointer, list);
            fileStream.Close();
        }

        protected List<T> ReadFromFile<T>(dynamic deserializer, string fileName)
        {
            var list = new List<T>();
            string fullfileName = FullFileName<T>(fileName);
            if (File.Exists(fullfileName))
            {
                fileStream = new FileStream(fullfileName, FileMode.Open, FileAccess.Read);
                list = (List<T>)deserializer.Deserialize(fileStream);
                fileStream.Close();
            }
            else
                throw new Exception("File not found!");
            return list;
        }

        public void Dispose()
        {
            if (fileStream != null)
                fileStream.Dispose();
        }
    }
}
