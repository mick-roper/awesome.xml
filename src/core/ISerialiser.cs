using System;
using System.Collections.Generic;
using System.Text;

namespace Awesome.Xml
{
    public interface ISerialiser
    {
        string Serialise<T>(T instance) where T : class, new();
        T Deserialise<T>(string data) where T : class, new();
    }
}
