using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JsonLibrary
{
    public class JSonHelper
    {
        public string ConvertObjectToJSon<T>(T obj)
        {
            var ser = new DataContractJsonSerializer(typeof(T));
            var ms = new MemoryStream();
            ser.WriteObject(ms, obj);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return jsonString;
        }

        public T ConvertJSonToObject<T>(string jsonString)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            T obj = (T)serializer.ReadObject(ms);
            return obj;
        }
    }
}
