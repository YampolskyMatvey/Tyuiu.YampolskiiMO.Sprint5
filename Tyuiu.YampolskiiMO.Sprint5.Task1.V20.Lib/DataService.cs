using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YampolskiiMO.Sprint5.Task1.V20.Lib
{
    public class DataService : ISprint5Task1V20
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            using var writer = new StreamWriter(path);

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 3;
                double y = denominator == 0 ? 0 : (5 * x + 2.5) / denominator + 2 * x + Math.Cos(x);
                writer.WriteLine(Math.Round(y, 2));
            }

            return path;
        }
    }
}
