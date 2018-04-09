using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using UtilsJson.contracts;

namespace UtilsJson.service
{
    public class JsonService : IJsonService
    {
        public T Deserialization<T>(string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj); ;
        }

        public string Serialization<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
