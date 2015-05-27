using ConfigWorker.Extensions;
using ConfigWorker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigWorker.Creators
{
    /// <summary>
    /// Default implementation of ICreator
    /// </summary>
    class DefaultCreator : ICreator
    {
        /// <summary>
        /// Get instance of T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetValue<T>()
        {
            if (typeof(T).In(typeof(string)))
            { return StringCreator<T>(); }
            else
            { return Activator.CreateInstance<T>(); }
        }

        /// <summary>
        /// Get instance of string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        static T StringCreator<T>()
        {
            return (T)(object)(string.Empty);
        }
    }
}
