using Tyuiu.YampolskiiMO.Sprint5.Task4.V26.Lib;

string path = args.Length > 0
    ? args[0]
    : Path.Combine(Path.GetPathRoot(Environment.SystemDirectory) ?? Path.GetTempPath(), "DataSprint5", "InPutDataFileTask4V26.txt");

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #5 | Задание #4 | Вариант #26                      *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Прочитать x из файла и вычислить y = (x³ + sin(x)) × cos(x).");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(path);
if (!File.Exists(path))
{
    Console.WriteLine("Укажите путь к входному файлу при запуске приложения.");
    return;
}

Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine($"{new DataService().LoadFromDataFile(path):F3}");
