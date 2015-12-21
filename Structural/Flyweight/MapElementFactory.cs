using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class MapElementFactory
    {
        /// <summary>
        /// Уникальный идентификатор создаваемого инстанса
        /// </summary>
        private static int Counter = 0;
        private readonly Dictionary<string, MapElement> cache = new Dictionary<string, MapElement>();
        public MapElement Create(string type)
        {
            if (!cache.ContainsKey(type))
            {
                var el = new MapElement(type, ++Counter);
                
                cache.Add(type, el);
            }
            return cache[type];
        }
    }
}
