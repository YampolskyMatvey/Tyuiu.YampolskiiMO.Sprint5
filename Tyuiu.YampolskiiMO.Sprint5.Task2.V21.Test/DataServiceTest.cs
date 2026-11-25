using Tyuiu.YampolskiiMO.Sprint5.Task2.V21.Lib;

namespace Tyuiu.YampolskiiMO.Sprint5.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_ReplacesOddNumbersInCsv()
        {
            int[,] matrix = { { 4, 8, 5 }, { 6, 3, 2 }, { 9, 4, 5 } };

            string path = new DataService().SaveToFileTextData(matrix);

            CollectionAssert.AreEqual(new[] { "4;8;0", "6;0;2", "0;4;0" }, File.ReadAllLines(path));
        }
    }
}
