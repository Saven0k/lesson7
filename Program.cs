// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
int SumElementsOnDiagonals(int[,] inarray1)
{
     int sum = 0;
    for (int i = 0; i < inarray1.GetLength(0); i++)
    {
        for (int j = 0; j < inarray1.GetLength(1); j++)
        {
            if ( i == j) sum =  sum + inarray1[i,j] ;
        }
    }
    return sum;
}
void PrintSum( int sumdiagonals)
{
   Console.WriteLine(sumdiagonals);
}
int[,] array = GetArray(rows, colomns, minValue: 1, maxValue: 10); // Не МАГИЧЕСКОЕ ЧИСЛО))
PrintArray(array);
int summ = Convert.ToInt32(SumElementsOnDiagonals(array));
Console.WriteLine();
PrintSum(summ);