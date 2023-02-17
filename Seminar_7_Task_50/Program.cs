//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
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
void ValueOfElemenArray2D (int i, int j, int[,] array2D)
{
    if (i < array2D.GetLength(0) && j < array2D.GetLength(1))
    {
        Console.WriteLine($"значение элемента равно {array2D[i, j]}");
    }
    else
    {
         Console.WriteLine( " -> элемента с такой позицией в массиве нет");
    }
}
Console.Clear();
Console.Write("Введите кол-во строк row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов col = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2d = GetArray(row, col, -20, 20);
PrintArray (array2d);
Console.Write("Для любого элемента введите позицию строки  i= ");
int indexRow = int.Parse(Console.ReadLine()!);
Console.Write("Для любого элемента введите позицию столбца  j= ");
int indexCol = int.Parse(Console.ReadLine()!);
ValueOfElemenArray2D (indexRow, indexCol, array2d);
