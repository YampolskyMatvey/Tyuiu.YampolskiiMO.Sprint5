using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YampolskiiMO.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            string[] fields = data.Split(new[] { ',', ';', ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            foreach (string field in fields)
            {
                double value = double.Parse(field, NumberStyles.Float, CultureInfo.InvariantCulture);
                if (value % 2 == 0)
                {
                    sum += value;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}
