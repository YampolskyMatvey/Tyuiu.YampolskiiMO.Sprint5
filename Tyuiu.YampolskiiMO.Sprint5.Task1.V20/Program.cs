using Tyuiu.YampolskiiMO.Sprint5.Task1.V20.Lib;

const int start = -5;
const int stop = 5;
Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #5 | Задание #1 | Вариант #20                      *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Табулировать F(x) = (5x + 2,5) / (sin(x) + 3) + 2x + cos(x).");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine($"Интервал [{start}; {stop}], шаг 1.");
Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine($"{"x",4} | {"F(x)",8}");

string path = new DataService().SaveToFileTextData(start, stop);
int x = start;
foreach (string line in File.ReadLines(path))
{
    Console.WriteLine($"{x,4} | {double.Parse(line),8:F2}");
    x++;
}

Console.WriteLine($"Файл: {path}");
