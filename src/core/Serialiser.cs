using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Awesome.Xml
{
    public sealed class Serialiser : ISerialiser
    {
        public T Deserialise<T>(string data) where T : class, new()
        {
            var reader = new XmlReader<T>();

            return reader.Read(data);
        }

        public string Serialise<T>(T instance) where T : class, new()
        {
            var builder = new StringBuilder(500);

            var writer = new XmlWriter<T>(new StringWriter(builder));

            writer.Write(instance);

            return builder.ToString();
        }
    }
}
