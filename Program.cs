// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.    // 1 4 8 19
// 5 -2 33 -2   // 77 3 8 1
Console.Clear();
Console.WriteLine("Введите колличество строк массива");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество колоннок массива");
int colomns = int.Parse(Console.ReadLine());
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
int[,] array = GetArray(rows, colomns, minValue:0, maxValue:10); // Не МАГИЧЕСКОЕ ЧИСЛО))
PrintArray(array);