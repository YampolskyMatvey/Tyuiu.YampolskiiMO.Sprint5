using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YampolskiiMO.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            double result = Math.Round((Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2)), 3);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            using var writer = new BinaryWriter(File.Create(path));
            writer.Write(result);
            return path;
        }
    }
}
