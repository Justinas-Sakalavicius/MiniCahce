using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Cache
    {
        Dictionary<string, object> store = new Dictionary<string, object>();

        public bool TryAddItem(string key, object value)
        {
            if (store.ContainsKey(key))
            {
                return false;
            }
            else
            {
                store.Add(key, value);
                return true;
            }
        }


        public void AddItem(string key, object value)
        {
            if (store.ContainsKey(key))
            {
                store[key] = value;
            }
            else
            {
                store.Add(key, value);
            }
        }

        public bool TryGetItem(string key, out object obj)
        {
            obj = store.FirstOrDefault(t => t.Key == key).Value;

            return obj != null;
        }


        public object GetItem(string key)
        {
            var ss = store.FirstOrDefault(t => t.Key == key);

            return ss.Value;
        }

        public void DeleteItem(string key)
        {
            if (store.ContainsKey(key))
            {
                store.Remove(key);
            }
        }
    }
}
