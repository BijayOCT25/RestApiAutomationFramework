using Newtonsoft.Json;
using System.IO;

namespace RestApiAutomationFramework.Utils
{
    public static class JsonDataReader
    {
        public static T ReadFromFile<T>(string filePath)
        {
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (T)serializer.Deserialize(file, typeof(T));
            }
        }
    }
}
