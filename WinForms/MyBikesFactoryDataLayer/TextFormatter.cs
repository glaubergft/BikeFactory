using MyBikesFactoryBusinessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactoryDataLayer
{
    public class TextFormatter
    {
        public void Serialize(FileStream fileStream, List<SerializableItem> list)
        {
            using (var file = new StreamWriter(fileStream))
            {
                list.ForEach(s =>
                       file.WriteLine(
                           SerializeItem<SerializableItem>(s)
                       ));
            }
        }

        private string SerializeItem<T>(T item)
        {
            //Here we use Reflection to dynamically serialize the item
            //to a text file entry by splitting columns with '|'

            var sb = new StringBuilder();

            //Getting Type of Generic Class Model
            Type tModelType = item.GetType();

            //We will be defining a PropertyInfo Object which contains details about the class property 
            PropertyInfo[] arrayPropertyInfos = tModelType.GetProperties();

            sb.Append(tModelType);


            //Now we will loop in all properties one by one to get value
            foreach (PropertyInfo property in arrayPropertyInfos)
            {
                sb.Append('|');

                var value = property.GetValue(item);

                if (property.PropertyType == typeof(Color))
                    sb.Append(ColorTranslator.ToHtml((Color)value));
                else
                    sb.Append(value);
            }

            return sb.ToString();
        }

        public List<SerializableItem> Deserialize(FileStream fileStream)
        {
            //Here we use Reflection to dynamically deserialize each
            //entry in the text file to the correspondent derived object
            //from Shape2D

            var list = new List<SerializableItem>();
            using (var sr = new StreamReader(fileStream))
            {

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var values = line.Split('|');

                    //var type = values[0];
                    Type type = Type.GetType($"{values[0]},MyBikesFactoryBusinessLayer");
                    var item = (SerializableItem)Activator.CreateInstance(type);

                    //We will be defining a PropertyInfo Object which contains details about the class property 
                    PropertyInfo[] arrayPropertyInfos = type.GetProperties();

                    for (int i = 1; i < values.Length; i++)
                    {
                        var currentValue = values[i];
                        PropertyInfo property = arrayPropertyInfos[i - 1];
                        if (property.PropertyType == typeof(double))
                            property.SetValue(item, double.Parse(currentValue));
                        else if (property.PropertyType == typeof(int))
                            property.SetValue(item, int.Parse(currentValue));
                        else if (property.PropertyType == typeof(Color))
                            property.SetValue(item, ColorTranslator.FromHtml(currentValue));
                        //else if (property.PropertyType == typeof(ShapeType?))
                        //{
                        //    ShapeType shapeType;
                        //    Enum.TryParse<ShapeType>(currentValue, out shapeType);
                        //    property.SetValue(item, shapeType);
                        //}
                        else
                            property.SetValue(item, currentValue);
                    }
                    list.Add(item);
                }
            }

            return list;
        }

    }
}
