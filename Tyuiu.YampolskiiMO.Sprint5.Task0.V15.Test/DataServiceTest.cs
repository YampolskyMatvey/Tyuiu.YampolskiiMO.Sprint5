using Tyuiu.YampolskiiMO.Sprint5.Task0.V15.Lib;

namespace Tyuiu.YampolskiiMO.Sprint5.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_WritesRoundedResultToTempFile()
        {
            string path = new DataService().SaveToFileTextData(3);

            Assert.AreEqual(Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt"), path);
            Assert.AreEqual(0.103.ToString("F3"), File.ReadAllText(path));
        }
    }
}
