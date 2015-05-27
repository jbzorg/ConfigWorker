using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigWorker.Extensions
{
    /// <summary>
    /// Extensions for type Type
    /// </summary>
    static class TypeExtensions
    {
        public static bool In(this Type obj, params Type[] types)
        {
            return types.Contains(obj);
        }
    }
}
