using Tyuiu.YampolskiiMO.Sprint5.Task6.V21.Lib;

string path = args.Length > 0
    ? args[0]
    : Path.Combine(Path.GetPathRoot(Environment.SystemDirectory) ?? Path.GetTempPath(), "DataSprint5", "InPutDataFileTask6V21.txt");

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #5 | Задание #6 | Вариант #21                      *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Посчитать количество удвоенных букв «тт» в тексте файла.");
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
