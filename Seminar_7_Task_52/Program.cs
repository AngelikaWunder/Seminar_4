// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//  в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
double[] AvеrageValueColumn (int[,] array2D)
{
    double aver = 1;
    double [] array2 = new double[array2D.GetLength(1)];
    for (int j=0; j < array2D.GetLength(1); j++)
    {
     double sum = 0;   
     for (int i=0; i < array2D.GetLength(0); i++)
     {
     sum += Convert.ToDouble(array2D[i, j]);
     }
     ;
     aver = sum / Convert.ToDouble(array2D.GetLength(0));
     aver=Math.Round(aver, 2);
     array2[j] = aver;
    }
    return array2;
}
Console.Write("Введите кол-во строк row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов col = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2d = GetArray(row, col, 10, 14);
PrintArray(array2d);
double[] averElemArray = AvеrageValueColumn(array2d);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", averElemArray)}");
