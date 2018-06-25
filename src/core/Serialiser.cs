using System;
using System.Collections.Generic;
using System.Text;

namespace Awesome.Xml
{
    public sealed class Serialiser : ISerialiser
    {
        public T Deserialise<T>(string data) where T : class
        {
            throw new NotImplementedException();
        }

        public string Serialise<T>(T instance) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
