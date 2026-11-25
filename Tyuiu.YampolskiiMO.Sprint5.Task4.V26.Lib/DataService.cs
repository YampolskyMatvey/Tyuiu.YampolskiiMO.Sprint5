using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YampolskiiMO.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            if (!double.TryParse(data, NumberStyles.Float, CultureInfo.CurrentCulture, out double x))
            {
                x = double.Parse(data.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture);
            }

            return Math.Round((Math.Pow(x, 3) + Math.Sin(x)) * Math.Cos(x), 3);
        }
    }
}
