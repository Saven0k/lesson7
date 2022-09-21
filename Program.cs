// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
Console.Clear();
Console.Write("Введите колличество строк массива: ");
int rows = Math.Abs(int.Parse(Console.ReadLine()));

Console.Write("Введите колличество колоннок массива: ");
int colomns = Math.Abs(int.Parse(Console.ReadLine()));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write($"{inarray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите первый индекс х: ");
int x = Math.Abs(int.Parse(Console.ReadLine()));

Console.Write("Введите второй индекс y: ");
int y = Math.Abs(int.Parse(Console.ReadLine()));

void FindIndexInArray(int[,] arra, int inx, int iny)
{
    int count = 0;
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            if (i == inx && j == iny) Console.WriteLine($"{inx} {iny} -> число под этим индексом {arra[inx, iny]}");
            else
            {
                count++;
            }
        }
    }
    if (count == arra.Length) Console.WriteLine($"{inx}{iny} -> числа с такими индексами нет");
    else { }
}
int[,] array = GetArray(rows, colomns, minValue: 1, maxValue: 10); // Не МАГИЧЕСКОЕ ЧИСЛО))
PrintArray(array);
Console.WriteLine();

FindIndexInArray(array, x, y);