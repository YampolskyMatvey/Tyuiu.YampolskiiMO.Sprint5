using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YampolskiiMO.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            double result = Math.Round(x / (Math.Pow(x, 3) + 2), 3);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(path, result.ToString("F3"));

            return path;
        }
    }
}
