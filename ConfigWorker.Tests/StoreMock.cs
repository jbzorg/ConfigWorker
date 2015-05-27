using ConfigWorker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigWorker.Tests
{
    public class StoreMock : IStore
    {
        Dictionary<string, string> store = new Dictionary<string, string>();

        public string Get(string name)
        {
            string res = null;
            store.TryGetValue(name, out res);
            return res;
        }

        public void Set(string name, string value)
        { store[name] = value; }
    }
}
