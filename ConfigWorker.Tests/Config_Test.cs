using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConfigWorker.Tests
{
    [TestClass]
    public class Config_Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "GetSettings_Test_01_01")]
        public void GetSettings_Test_01()
        {
            Config.Store = new StoreMock();
            Config.GetSettings<bool>("");
        }

        [TestMethod]
        public void GetSettings_Test_03()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<bool>(Config.GetSettings<bool>("setting_bool01"), false, "GetSettings_Test_03_01");
            Assert.AreEqual<bool>(Config.GetSettings<bool>("setting_bool02", true), true, "GetSettings_Test_03_02");
            Assert.AreEqual<bool>(Config.GetSettings<bool>("setting_bool03", false), false, "GetSettings_Test_03_03");
            Assert.AreEqual<bool>(Config.GetSettings<bool>("setting_bool05", false, deserializer: (z) => bool.Parse(z)), false, "GetSettings_Test_03_05");
            Assert.AreEqual<bool>(Config.GetSettings<bool>("setting_bool06", true, deserializer: (z) => bool.Parse(z)), true, "GetSettings_Test_03_06");
            Assert.AreEqual<bool>(Config.GetSettings<bool>("setting_bool02", false), true, "GetSettings_Test_03_07");
        }

        [TestMethod]
        public void GetSettings_Test_04()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<byte>(Config.GetSettings<byte>("setting_byte01"), byte.MinValue, "GetSettings_Test_04_01");
            Assert.AreEqual<byte>(Config.GetSettings<byte>("setting_byte02", byte.MaxValue), byte.MaxValue, "GetSettings_Test_04_02");
            Assert.AreEqual<byte>(Config.GetSettings<byte>("setting_byte03", byte.MinValue), byte.MinValue, "GetSettings_Test_04_03");
            Assert.AreEqual<byte>(Config.GetSettings<byte>("setting_byte05", byte.MinValue, deserializer: (z) => byte.Parse(z)), byte.MinValue, "GetSettings_Test_04_05");
            Assert.AreEqual<byte>(Config.GetSettings<byte>("setting_byte06", byte.MaxValue, deserializer: (z) => byte.Parse(z)), byte.MaxValue, "GetSettings_Test_04_06");
            Assert.AreEqual<byte>(Config.GetSettings<byte>("setting_byte02", byte.MinValue), byte.MaxValue, "GetSettings_Test_04_07");
        }

        [TestMethod]
        public void GetSettings_Test_05()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<sbyte>(Config.GetSettings<sbyte>("setting_sbyte01"), 0, "GetSettings_Test_05_01");
            Assert.AreEqual<sbyte>(Config.GetSettings<sbyte>("setting_sbyte02", sbyte.MaxValue), sbyte.MaxValue, "GetSettings_Test_05_02");
            Assert.AreEqual<sbyte>(Config.GetSettings<sbyte>("setting_sbyte03", sbyte.MinValue), sbyte.MinValue, "GetSettings_Test_05_03");
            Assert.AreEqual<sbyte>(Config.GetSettings<sbyte>("setting_sbyte05", sbyte.MinValue, deserializer: (z) => sbyte.Parse(z)), sbyte.MinValue, "GetSettings_Test_05_05");
            Assert.AreEqual<sbyte>(Config.GetSettings<sbyte>("setting_sbyte06", sbyte.MaxValue, deserializer: (z) => sbyte.Parse(z)), sbyte.MaxValue, "GetSettings_Test_05_06");
            Assert.AreEqual<sbyte>(Config.GetSettings<sbyte>("setting_sbyte02", sbyte.MinValue), sbyte.MaxValue, "GetSettings_Test_05_07");
        }

        [TestMethod]
        public void GetSettings_Test_06()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<ushort>(Config.GetSettings<ushort>("setting_ushort01"), ushort.MinValue, "GetSettings_Test_06_01");
            Assert.AreEqual<ushort>(Config.GetSettings<ushort>("setting_ushort02", ushort.MaxValue), ushort.MaxValue, "GetSettings_Test_06_02");
            Assert.AreEqual<ushort>(Config.GetSettings<ushort>("setting_ushort03", ushort.MinValue), ushort.MinValue, "GetSettings_Test_06_03");
            Assert.AreEqual<ushort>(Config.GetSettings<ushort>("setting_ushort05", ushort.MinValue, deserializer: (z) => ushort.Parse(z)), ushort.MinValue, "GetSettings_Test_06_05");
            Assert.AreEqual<ushort>(Config.GetSettings<ushort>("setting_ushort06", ushort.MaxValue, deserializer: (z) => ushort.Parse(z)), ushort.MaxValue, "GetSettings_Test_06_06");
            Assert.AreEqual<ushort>(Config.GetSettings<ushort>("setting_ushort02", ushort.MinValue), ushort.MaxValue, "GetSettings_Test_06_07");
        }

        [TestMethod]
        public void GetSettings_Test_07()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<short>(Config.GetSettings<short>("setting_short01"), 0, "GetSettings_Test_07_01");
            Assert.AreEqual<short>(Config.GetSettings<short>("setting_short02", short.MaxValue), short.MaxValue, "GetSettings_Test_07_02");
            Assert.AreEqual<short>(Config.GetSettings<short>("setting_short03", short.MinValue), short.MinValue, "GetSettings_Test_07_03");
            Assert.AreEqual<short>(Config.GetSettings<short>("setting_short05", short.MinValue, deserializer: (z) => short.Parse(z)), short.MinValue, "GetSettings_Test_07_05");
            Assert.AreEqual<short>(Config.GetSettings<short>("setting_short06", short.MaxValue, deserializer: (z) => short.Parse(z)), short.MaxValue, "GetSettings_Test_07_06");
            Assert.AreEqual<short>(Config.GetSettings<short>("setting_short02", short.MinValue), short.MaxValue, "GetSettings_Test_07_07");
        }

        [TestMethod]
        public void GetSettings_Test_08()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<uint>(Config.GetSettings<uint>("setting_uint01"), uint.MinValue, "GetSettings_Test_08_01");
            Assert.AreEqual<uint>(Config.GetSettings<uint>("setting_uint02", uint.MaxValue), uint.MaxValue, "GetSettings_Test_08_02");
            Assert.AreEqual<uint>(Config.GetSettings<uint>("setting_uint03", uint.MinValue), uint.MinValue, "GetSettings_Test_08_03");
            Assert.AreEqual<uint>(Config.GetSettings<uint>("setting_uint05", uint.MinValue, deserializer: (z) => uint.Parse(z)), uint.MinValue, "GetSettings_Test_08_05");
            Assert.AreEqual<uint>(Config.GetSettings<uint>("setting_uint06", uint.MaxValue, deserializer: (z) => uint.Parse(z)), uint.MaxValue, "GetSettings_Test_08_06");
            Assert.AreEqual<uint>(Config.GetSettings<uint>("setting_uint02", uint.MinValue), uint.MaxValue, "GetSettings_Test_08_07");
        }

        [TestMethod]
        public void GetSettings_Test_09()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<int>(Config.GetSettings<int>("setting_int01"), 0, "GetSettings_Test_09_01");
            Assert.AreEqual<int>(Config.GetSettings<int>("setting_int02", int.MaxValue), int.MaxValue, "GetSettings_Test_09_02");
            Assert.AreEqual<int>(Config.GetSettings<int>("setting_int03", int.MinValue), int.MinValue, "GetSettings_Test_09_03");
            Assert.AreEqual<int>(Config.GetSettings<int>("setting_int05", int.MinValue, deserializer: (z) => int.Parse(z)), int.MinValue, "GetSettings_Test_09_05");
            Assert.AreEqual<int>(Config.GetSettings<int>("setting_int06", int.MaxValue, deserializer: (z) => int.Parse(z)), int.MaxValue, "GetSettings_Test_09_06");
            Assert.AreEqual<int>(Config.GetSettings<int>("setting_int02", int.MinValue), int.MaxValue, "GetSettings_Test_09_07");
        }

        [TestMethod]
        public void GetSettings_Test_10()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<ulong>(Config.GetSettings<ulong>("setting_ulong01"), ulong.MinValue, "GetSettings_Test_10_01");
            Assert.AreEqual<ulong>(Config.GetSettings<ulong>("setting_ulong02", ulong.MaxValue), ulong.MaxValue, "GetSettings_Test_10_02");
            Assert.AreEqual<ulong>(Config.GetSettings<ulong>("setting_ulong03", ulong.MinValue), ulong.MinValue, "GetSettings_Test_10_03");
            Assert.AreEqual<ulong>(Config.GetSettings<ulong>("setting_ulong05", ulong.MinValue, deserializer: (z) => ulong.Parse(z)), ulong.MinValue, "GetSettings_Test_10_05");
            Assert.AreEqual<ulong>(Config.GetSettings<ulong>("setting_ulong06", ulong.MaxValue, deserializer: (z) => ulong.Parse(z)), ulong.MaxValue, "GetSettings_Test_10_06");
            Assert.AreEqual<ulong>(Config.GetSettings<ulong>("setting_ulong02", ulong.MinValue), ulong.MaxValue, "GetSettings_Test_10_07");
        }

        [TestMethod]
        public void GetSettings_Test_11()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<long>(Config.GetSettings<long>("setting_long01"), 0, "GetSettings_Test_11_01");
            Assert.AreEqual<long>(Config.GetSettings<long>("setting_long02", long.MaxValue), long.MaxValue, "GetSettings_Test_11_02");
            Assert.AreEqual<long>(Config.GetSettings<long>("setting_long03", long.MinValue), long.MinValue, "GetSettings_Test_11_03");
            Assert.AreEqual<long>(Config.GetSettings<long>("setting_long05", long.MinValue, deserializer: (z) => long.Parse(z)), long.MinValue, "GetSettings_Test_11_05");
            Assert.AreEqual<long>(Config.GetSettings<long>("setting_long06", long.MaxValue, deserializer: (z) => long.Parse(z)), long.MaxValue, "GetSettings_Test_11_06");
            Assert.AreEqual<long>(Config.GetSettings<long>("setting_long02", long.MinValue), long.MaxValue, "GetSettings_Test_11_07");
        }

        [TestMethod]
        public void GetSettings_Test_12()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<char>(Config.GetSettings<char>("setting_char01"), char.MinValue, "GetSettings_Test_12_01");
            Assert.AreEqual<char>(Config.GetSettings<char>("setting_char02", char.MaxValue), char.MaxValue, "GetSettings_Test_12_02");
            Assert.AreEqual<char>(Config.GetSettings<char>("setting_char03", char.MinValue), char.MinValue, "GetSettings_Test_12_03");
            Assert.AreEqual<char>(Config.GetSettings<char>("setting_char05", char.MinValue, deserializer: (z) => char.Parse(z)), char.MinValue, "GetSettings_Test_12_05");
            Assert.AreEqual<char>(Config.GetSettings<char>("setting_char06", char.MaxValue, deserializer: (z) => char.Parse(z)), char.MaxValue, "GetSettings_Test_12_06");
            Assert.AreEqual<char>(Config.GetSettings<char>("setting_char02", char.MinValue), char.MaxValue, "GetSettings_Test_12_07");
        }

        [TestMethod]
        public void GetSettings_Test_13()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<double>(Config.GetSettings<double>("setting_double01"), 0, "GetSettings_Test_13_01");
            Assert.AreEqual<double>(Config.GetSettings<double>("setting_double02", double.MaxValue), double.MaxValue, "GetSettings_Test_13_02");
            Assert.AreEqual<double>(Config.GetSettings<double>("setting_double03", double.MinValue), double.MinValue, "GetSettings_Test_13_03");
            Assert.AreEqual<double>(Config.GetSettings<double>("setting_double05", double.MinValue, deserializer: (z) => double.Parse(z)), double.MinValue, "GetSettings_Test_13_05");
            Assert.AreEqual<double>(Config.GetSettings<double>("setting_double06", double.MaxValue, deserializer: (z) => double.Parse(z)), double.MaxValue, "GetSettings_Test_13_06");
            Assert.AreEqual<double>(Config.GetSettings<double>("setting_double02", double.MinValue), double.MaxValue, "GetSettings_Test_13_07");
        }

        [TestMethod]
        public void GetSettings_Test_14()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<float>(Config.GetSettings<float>("setting_float01"), 0, "GetSettings_Test_14_01");
            Assert.AreEqual<float>(Config.GetSettings<float>("setting_float02", float.MaxValue), float.MaxValue, "GetSettings_Test_14_02");
            Assert.AreEqual<float>(Config.GetSettings<float>("setting_float03", float.MinValue), float.MinValue, "GetSettings_Test_14_03");
            Assert.AreEqual<float>(Config.GetSettings<float>("setting_float05", float.MinValue, deserializer: (z) => float.Parse(z)), float.MinValue, "GetSettings_Test_14_05");
            Assert.AreEqual<float>(Config.GetSettings<float>("setting_float06", float.MaxValue, deserializer: (z) => float.Parse(z)), float.MaxValue, "GetSettings_Test_14_06");
            Assert.AreEqual<float>(Config.GetSettings<float>("setting_float07", float.NegativeInfinity), float.NegativeInfinity, "GetSettings_Test_14_07");
            Assert.AreEqual<float>(Config.GetSettings<float>("setting_float08", float.PositiveInfinity), float.PositiveInfinity, "GetSettings_Test_14_08");
            Assert.AreEqual<float>(Config.GetSettings<float>("setting_float09", float.NaN), float.NaN, "GetSettings_Test_14_09");
            Assert.AreEqual<float>(Config.GetSettings<float>("setting_float10", float.Epsilon), float.Epsilon, "GetSettings_Test_14_10");
            Assert.AreEqual<float>(Config.GetSettings<float>("setting_float02", float.MinValue), float.MaxValue, "GetSettings_Test_14_11");
        }

        [TestMethod]
        public void GetSettings_Test_15()
        {
            Config.Store = new StoreMock();
            Assert.AreEqual<string>(Config.GetSettings<string>("setting_string01"), string.Empty, "GetSettings_Test_15_01");
            Assert.AreEqual<string>(Config.GetSettings<string>("setting_string02", string.Empty), string.Empty, "GetSettings_Test_15_02");
            Assert.AreEqual<string>(Config.GetSettings<string>("setting_string03", "abc"), "abc", "GetSettings_Test_15_03");
            Assert.AreEqual<string>(Config.GetSettings<string>("setting_string04", (string)null), string.Empty, "GetSettings_Test_15_04");
            Assert.AreEqual<string>(Config.GetSettings<string>("setting_string05", "abc", deserializer: (z) => z), "abc", "GetSettings_Test_15_06");
            Assert.AreEqual<string>(Config.GetSettings<string>("setting_string03", string.Empty), "abc", "GetSettings_Test_15_07");
        }
    }
}
