using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Nu_iMero.Client.Services
{
    public class SerializationService
    {
        // JSON Serialization
        public void SerializeToJson<T>(T obj, string filePath)
        {
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public T DeserializeFromJson<T>(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File {filePath} not found!");

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json)!; // Deserialize JSON to object
        }

        // XML Serialization
        public void SerializeToXml<T>(T obj, string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(stream, obj);
            }
        }

        public T DeserializeFromXml<T>(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File {filePath} not found!");

            var serializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                return (T)serializer.Deserialize(stream)!; // Deserialize XML to object
            }
        }
    }
}
