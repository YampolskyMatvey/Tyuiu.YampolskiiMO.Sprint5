using Tyuiu.YampolskiiMO.Sprint5.Task5.V1.Lib;

namespace Tyuiu.YampolskiiMO.Sprint5.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_SumsMultiplesOfTwo()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "8, -4\n3; 0 2.5 10");
                Assert.AreEqual(14.0, new DataService().LoadFromDataFile(path));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
