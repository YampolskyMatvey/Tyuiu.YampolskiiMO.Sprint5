using Tyuiu.YampolskiiMO.Sprint5.Task5.V1.Lib;

string path = args.Length > 0
    ? args[0]
    : Path.Combine(Path.GetPathRoot(Environment.SystemDirectory) ?? Path.GetTempPath(), "DataSprint5", "InPutDataFileTask5V1.txt");

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #5 | Задание #5 | Вариант #1                       *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Найти сумму чисел из файла, которые делятся на 2.");
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
Console.WriteLine(new DataService().LoadFromDataFile(path));
