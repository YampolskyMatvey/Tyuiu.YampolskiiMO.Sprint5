using Tyuiu.YampolskiiMO.Sprint5.Task4.V26.Lib;

namespace Tyuiu.YampolskiiMO.Sprint5.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_ReadsAndRoundsResult()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "1");
                Assert.AreEqual(0.995, new DataService().LoadFromDataFile(path));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
