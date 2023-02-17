// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] GetArrayDouble (int m, int n, double min, double max)
{
    double[,] result = new double[m, n];
    for (int i=0; i < m; i++)
    {
        for (int j=0; j < n; j++)
        {
            result[i, j]=Math.Round((new Random().NextDouble() * (max - min) + min), 2);
        }
    }
    return result;
}
void PrintArrayDouble (double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите кол-во строк m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов n = ");
int n = int.Parse(Console.ReadLine()!);
double[,] doubleArray2 = GetArrayDouble(m, n, -10, 10);
PrintArrayDouble (doubleArray2);