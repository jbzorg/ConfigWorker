using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigWorker.Interfaces
{
    public interface IStore
    {
        string Get(string name);
        void Set(string name, string value);
    }
}
