using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Project.Service
{
    public class Counter<T> : IEnumerable
    {
        private Dictionary<T, int> GetKeyValuePairs { get; }

        public Counter(IEnumerable items)
        {
            GetKeyValuePairs = FillDictionary(items);
        }

        private Dictionary<T, int> FillDictionary(IEnumerable items)
        {
            Dictionary<T, int> dictionary = new Dictionary<T, int>();
            foreach (object item in items)
            {
                if (item is T key)
                {
                    if (dictionary.ContainsKey(key))
                    {
                        dictionary[key]++;
                    }
                    else
                    {
                        dictionary[key] = 1;
                    }
                }
            }
            return dictionary.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public T[] GetKeys()
        {
            return GetKeyValuePairs.Keys.ToArray();
        }

        public int this[T key] => GetKeyValuePairs[key];

        public int TryGetValue(T key)
        {
            GetKeyValuePairs.TryGetValue(key, out int result);
            return result;
        }

        public int GetValue(T key)
        {
            return GetKeyValuePairs[key];
        }

        public int Total
        {
            get
            {
                return GetKeyValuePairs.Values.Sum();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T key in GetKeyValuePairs.Keys)
            {
                yield return key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
