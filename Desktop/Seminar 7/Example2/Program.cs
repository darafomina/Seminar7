// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

Console.WriteLine("Введите номер строки");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца");
int b = int.Parse(Console.ReadLine()!);

if (a > m || b > n)
    Console.WriteLine("такого числа нет");
else
{
    int result = array[a - 1, b-1];
    Console.WriteLine($"Значение элемента:  {result}");
}