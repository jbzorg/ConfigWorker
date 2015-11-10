using System;
using System.Linq;

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
