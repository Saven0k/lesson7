// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int ArithmeticMean(int[,] arra1)
{
    int a = 0;
    for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < colomns; j++)
                {
                    a += arra1[j, i];
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(int)a/rows}");
            }


    return a;
}
int[,] array = GetArray(rows, colomns, minValue: 1, maxValue: 10); // Не МАГИЧЕСКОЕ ЧИСЛО))
PrintArray(array);
ArithmeticMean(array);