using Tyuiu.YampolskiiMO.Sprint5.Task2.V21.Lib;

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #5 | Задание #2 | Вариант #21                      *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Заменить нечётные элементы массива 3 × 3 на нули и записать в CSV.");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");

int[,] matrix = new int[3, 3];
for (int row = 0; row < matrix.GetLength(0); row++)
{
    Console.Write($"Строка {row + 1} (три числа через пробел или точку с запятой): ");
    string? input = Console.ReadLine();
    if (input is null)
    {
        return;
    }

    string[] fields = input.Split(new[] { ' ', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
    if (fields.Length != matrix.GetLength(1) || !fields.All(field => int.TryParse(field, out _)))
    {
        Console.WriteLine("Введите три целых числа.");
        row--;
        continue;
    }

    for (int column = 0; column < fields.Length; column++)
    {
        matrix[row, column] = int.Parse(fields[column]);
    }
}

string path = new DataService().SaveToFileTextData(matrix);
Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
foreach (string line in File.ReadLines(path))
{
    Console.WriteLine(line.Replace(';', ' '));
}

Console.WriteLine($"Файл: {path}");
