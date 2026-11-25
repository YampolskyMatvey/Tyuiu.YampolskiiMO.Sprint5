using Tyuiu.YampolskiiMO.Sprint5.Task7.V23.Lib;

namespace Tyuiu.YampolskiiMO.Sprint5.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadDataAndSave_RemovesRussianWordsAndPreservesOtherText()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "Hello, ёж!\nМир world 123.");
                string outputPath = new DataService().LoadDataAndSave(path);

                Assert.AreEqual("Hello,!\n world 123.", File.ReadAllText(outputPath));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
