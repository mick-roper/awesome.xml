using System;

namespace Awesome.Xml
{
    internal sealed class XmlReader<T> where T : class, new()
    {
        public T Read(string data)
        {
            throw new NotImplementedException();
        }
    }
}