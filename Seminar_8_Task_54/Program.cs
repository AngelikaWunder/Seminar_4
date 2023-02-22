// Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
void SortElememtOfRow(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1) - 1; j++)
        {
            for (int k = j; k < array2D.GetLength(1)-1; k++)
            {
                if (array2D[i, j] < array2D[i, k + 1])
                {
                    int temp = array2D[i, j];
                    array2D[i, j] = array2D[i, k + 1];
                    array2D[i, k + 1] = temp;
                }
            }
        }
    }
}


Console.Write("Введите кол-во строк row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов col = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2d = GetArray(row, col, -10, 10);
PrintArray(array2d);
Console.WriteLine();
SortElememtOfRow(array2d);
PrintArray(array2d);
