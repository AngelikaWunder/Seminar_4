// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
//  и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int[] FindSumInRow (int[,] array2D)
{
    int[] array1D = new int[array2D.GetLength(0)];

    for (int i=0; i < array2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j=0; j < array2D.GetLength(1); j++)
        {
            sum += array2D[i, j];
        }
        array1D[i]=sum;
    }
    return array1D;
}
void FindMinSumInRow (int[] array1d)
{
    int min = array1d[0];
    int index = 0;
    for (int i=1; i < array1d.Length; i++)
    {
        
        if (array1d[i] < min)
        {
             min = array1d[i];
             index = i;
        }     
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов: {index+1} строка");
}
Console.Write("Введите кол-во строк row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов, не равное кол-ву строк col = ");
int col = int.Parse(Console.ReadLine()!);
while (col == row) 
{
    Console.Write("Введите кол-во столбцов, не равное кол-ву строк col = ");
    col = int.Parse(Console.ReadLine()!);  
}
int[,] array2d = GetArray(row, col, -10, 10);
PrintArray(array2d);
Console.WriteLine();
int[] array = FindSumInRow(array2d);
FindMinSumInRow(array);
