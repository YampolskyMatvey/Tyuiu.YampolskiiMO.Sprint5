using Tyuiu.YampolskiiMO.Sprint5.Task0.V15.Lib;

const int x = 3;

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #5 | Задание #0 | Вариант #15                      *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Вычислить y = x / (x³ + 2) и записать результат в файл.");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine($"x = {x}");
Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");

string path = new DataService().SaveToFileTextData(x);
Console.WriteLine(File.ReadAllText(path));
Console.WriteLine($"Файл: {path}");
