// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++)
        for (var j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(1, 10);
    return result;
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]}, ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m)) Console.WriteLine("Всё плохо");
Console.WriteLine("Введите число столбцов (n)");

if (!int.TryParse(Console.ReadLine()!, out var n)) Console.WriteLine("Всё плохо");
int[,] array = CreateArrayWithRandomNumbers(m, n);

PrintArray(array);
Console.WriteLine();
        
Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += array[j, i];
  }
  arithmeticMean = arithmeticMean / m;
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}