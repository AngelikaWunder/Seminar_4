// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[, ,] GetArray3D(int m, int n, int l, int minValue, int maxValue)
{
    int[, ,] result = new int[m, n, l]; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int k=0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(minValue, maxValue + 1);
                if (FindElement(result, element)) continue;
                result[i, j, k]=element;
                k++;                                  
            }
        }
    }
    return result;
}
bool FindElement (int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    } 
    return false;   
}
void PrintArray(int[, ,] inArray)
{
    for (int k = 0; k < inArray.GetLength(2); k++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j=0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j, k]} {(i, j, k)}\t ");
            }
            Console.WriteLine();
        }
        
    }
}
Console.Write("Введите кол-во строк row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов, не равное кол-ву строк col = ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье измерение матрицы l = ");
int l = int.Parse(Console.ReadLine()!);
int[, ,] array3d = GetArray3D(row, col, l, 10, 99);
PrintArray(array3d);
