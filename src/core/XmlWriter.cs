using System;
using System.IO;

namespace Awesome.Xml
{
    internal sealed class XmlWriter<T> where T : class, new()
    {
        readonly TextWriter writer;

        public XmlWriter(TextWriter writer)
        {
            this.writer = writer;
        }

        public void Write(T instance)
        {
            throw new NotImplementedException();
        }
    }
}