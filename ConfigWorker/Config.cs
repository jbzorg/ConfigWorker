using ConfigWorker.Creators;
using ConfigWorker.Deserializers;
using ConfigWorker.Interfaces;
using ConfigWorker.Serializers;
using ConfigWorker.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigWorker
{
    //TODO: добавить поддержку лога (возможно через интерфейс)
    //TODO: добавить поддержку nallable type value
    public static class Config
    {
        static object lockStore = new object();

        public static IStore Store { get; set; }
        public static IDeserializer Deserializer { get; set; }
        public static ISerializer Serializer { get; set; }
        public static ICreator Creator { get; set; }

        static Config()
        {
            Creator = new DefaultCreator();
            Serializer = new DefaultSerializer();
            Deserializer = new DefaultDeserializer();
            Store = new DefaultStore();
        }

        public static T GetSettings<T>(string settingName)
        { return GetSettings<T>(settingName, Creator.GetValue<T>()); }

        public static T GetSettings<T>(string settingName, T defaultValue, Func<T, string> serializer = null, Func<string, T> deserializer = null, IStore store = null)
        {
            if (string.IsNullOrWhiteSpace(settingName))
            { throw new ArgumentNullException("settingName"); }

            serializer = serializer ?? Serializer.GetValue<T>;
            deserializer = deserializer ?? Deserializer.GetValue<T>;
            store = store ?? Store;

            string rawData = null;
            lock (lockStore)
            {
                rawData = store.Get(settingName);
                if (rawData == null)
                {
                    rawData = (defaultValue == null) ? string.Empty : serializer(defaultValue);
                    store.Set(settingName, rawData);
                }
            }

            T result;
            try
            { result = deserializer(rawData); }
            catch (Exception ex)
            { result = defaultValue; }
            return result;
        }
    }
}
