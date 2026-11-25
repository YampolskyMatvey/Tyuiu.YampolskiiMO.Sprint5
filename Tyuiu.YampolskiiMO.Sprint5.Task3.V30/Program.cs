using Tyuiu.YampolskiiMO.Sprint5.Task3.V30.Lib;

const int x = 3;
Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #5 | Задание #3 | Вариант #30                      *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Вычислить y = (x³ − 1) / (4x²) и записать результат в бинарный файл.");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine($"x = {x}");

string path = new DataService().SaveToFileTextData(x);
using var reader = new BinaryReader(File.OpenRead(path));

Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine($"{reader.ReadDouble():F3}");
Console.WriteLine($"Файл: {path}");
