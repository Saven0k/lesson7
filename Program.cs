// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4     // 0,5 7 -2 -0,2    // 1 -3,3 8 -9,9    // 8 7,8 -7,1 9
Console.Clear();
Console.Write("Введите колличество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите колличество колоннок массива: ");
int  colomns = int.Parse(Console.ReadLine());

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue) / 10.0);
        }
    }
    return result;
}
void PrintArray(double[,] inarray)
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
double[,] array = GetArray(rows, colomns, minValue: 0, maxValue: 100);
PrintArray(array);