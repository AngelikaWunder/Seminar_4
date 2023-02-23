// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int [,] GetMultiplMatrix( int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i=0; i < arrayA.GetLength(0); i++)
    {
        for (int j=0; j < arrayB.GetLength(1); j++)
        {
            for(int k=0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k]*arrayB[k, j];
            }
        }
    }
    return arrayC;
}
Console.Write("Введите количество строк 1 матрицы: ");
int rowsA= int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 матрицы: ");
int colA = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во строк 2 матрицы. Оно должно быть равно кол-ву столбцов 1 матрицы: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 матрицы: ");
int colB = int.Parse(Console.ReadLine()!);
if (colA != rowsB)
{
  Console.WriteLine("Размеры матриц не согласованы");
  return;
}
int[,] array2dA = GetArray(rowsA, colA, 2, 10);
int[,] array2dB = GetArray(rowsB, colB, 2, 10);
PrintArray (array2dA);
Console.WriteLine();
PrintArray(array2dB);
Console.WriteLine();
Console.WriteLine($"Результатиюрущая матрица:");
PrintArray (GetMultiplMatrix(array2dA, array2dB));
