using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializers
{
    public class BinarySerializer
    {
        public void Serialize<T>(T obj, string fileName) where T : class
        {
            using (var fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, obj);
            }
        }

        public T Deserialize<T>(string fileName) where T : class
        {
            using (var fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var binaryFormatter = new BinaryFormatter();
                return binaryFormatter.Deserialize(fileStream) as T;
            }
        }
    }
}