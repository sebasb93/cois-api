using System;
using System.Collections.Generic;
using System.Text;

namespace UtilsJson.contracts
{
    public interface IJsonService
    {
        T Deserialization<T>(string obj);
        string Serialization<T>(T obj);
    }
}
