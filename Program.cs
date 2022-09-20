// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Console.Clear();
Console.Write("Введите колличество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите колличество колоннок массива: ");
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
int[,] GetPow(int[,] innarray)
{
    for (int i = 0; i < innarray.GetLength(0); i++)
    {
        for (int j = 0; j < innarray.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0) && (i != 0) && (j != 0)) innarray[i, j] = innarray[i, j] * innarray[i, j];
        }
    }
    return innarray;
}
int[,] array = GetArray(rows, colomns, minValue: 1, maxValue: 10); // Не МАГИЧЕСКОЕ ЧИСЛО))
int[,] array1 = GetPow(array);
PrintArray(array1);