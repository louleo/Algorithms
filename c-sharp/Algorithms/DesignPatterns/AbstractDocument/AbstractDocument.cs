using System.Collections.Generic;

namespace DesignPatterns.AbstractDocument
{
    public abstract class AbstractDocument: Document
    {
        private readonly Dictionary<string, object> _properties;

        public AbstractDocument(Dictionary<string, object> properties)
        {
            _properties = properties;
        }

        public void put(string key, object value)
        {
            if (!_properties.TryAdd(key, value))
            {
                _properties[key] = value;
            }
        }

        public object get(string key)
        {
            if (_properties.TryGetValue(key, out object value))
            {
                return value;
            }

            return null;
        }
    }
}