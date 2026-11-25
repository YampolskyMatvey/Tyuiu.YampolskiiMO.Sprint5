using Tyuiu.YampolskiiMO.Sprint5.Task3.V30.Lib;

namespace Tyuiu.YampolskiiMO.Sprint5.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_WritesRoundedDouble()
        {
            string path = new DataService().SaveToFileTextData(3);
            using var reader = new BinaryReader(File.OpenRead(path));

            Assert.AreEqual(0.722, reader.ReadDouble());
            Assert.AreEqual(reader.BaseStream.Length, reader.BaseStream.Position);
        }
    }
}
