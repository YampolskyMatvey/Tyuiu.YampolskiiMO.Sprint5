using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YampolskiiMO.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            string result = Regex.Replace(text, @"[ \t]*\b[А-Яа-яЁё]+\b", string.Empty);
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V23.txt");
            File.WriteAllText(outputPath, result);
            return outputPath;
        }
    }
}
