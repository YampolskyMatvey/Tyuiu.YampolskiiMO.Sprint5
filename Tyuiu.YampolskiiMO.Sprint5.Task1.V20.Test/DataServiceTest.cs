using Tyuiu.YampolskiiMO.Sprint5.Task1.V20.Lib;

namespace Tyuiu.YampolskiiMO.Sprint5.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_WritesEachRoundedValue()
        {
            string path = new DataService().SaveToFileTextData(0, 1);

            CollectionAssert.AreEqual(
                new[] { 1.83.ToString(), 4.49.ToString() },
                File.ReadAllLines(path));
        }
    }
}
