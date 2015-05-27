using ConfigWorker.Extensions;
using ConfigWorker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConfigWorker.Serializers
{
    /// <summary>
    /// Default implementation of ISerializer
    /// </summary>
    class DefaultSerializer : ISerializer
    {
        /// <summary>
        /// Convert T to string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public string GetValue<T>(T value)
        {
            if (typeof(T).In(typeof(double), typeof(float)))
            { return FloatingPointSerializer<T>(value); }
            else
            { return value.ToString(); }
        }

        /// <summary>
        /// Convert floating point type to string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        static string FloatingPointSerializer<T>(T value)
        {
            MethodInfo methodInfo = typeof(T).GetMethod("ToString", new Type[] { typeof(string) });
            if (methodInfo != null)
            { return (string)methodInfo.Invoke(value, new string[] { "r" }); }
            else
            { throw new NotSupportedException(string.Format("Type {0} is floating-point type, but not contain \"ToString\" method with format", typeof(T).FullName)); }
        }
    }
}
