using Tyuiu.YampolskiiMO.Sprint5.Task7.V23.Lib;

string path = args.Length > 0
    ? args[0]
    : Path.Combine(Path.GetPathRoot(Environment.SystemDirectory) ?? Path.GetTempPath(), "DataSprint5", "InPutDataFileTask7V23.txt");

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #5 | Задание #7 | Вариант #23                      *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Удалить русские слова из текста и сохранить результат в файле.");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(path);
if (!File.Exists(path))
{
    Console.WriteLine("Укажите путь к входному файлу при запуске приложения.");
    return;
}

string outputPath = new DataService().LoadDataAndSave(path);
Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(File.ReadAllText(outputPath));
Console.WriteLine($"Файл: {outputPath}");
