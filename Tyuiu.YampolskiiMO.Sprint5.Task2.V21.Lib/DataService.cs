using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YampolskiiMO.Sprint5.Task2.V21.Lib
{
    public class DataService : ISprint5Task2V21
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            using var writer = new StreamWriter(path);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] values = new int[matrix.GetLength(1)];
                for (int column = 0; column < values.Length; column++)
                {
                    int value = matrix[row, column];
                    values[column] = value % 2 == 0 ? value : 0;
                }

                writer.WriteLine(string.Join(";", values));
            }

            return path;
        }
    }
}
