using Tyuiu.YampolskiiMO.Sprint5.Task6.V21.Lib;

namespace Tyuiu.YampolskiiMO.Sprint5.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_CountsCyrillicLowercasePairs()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "оттепель и аттестат; tt; ТТ");
                Assert.AreEqual(2, new DataService().LoadFromDataFile(path));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
