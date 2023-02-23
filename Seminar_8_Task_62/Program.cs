// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] GetArraySpiral(int size)
{
    int[,] array2D = new int[size, size];
    int count = 1;
    int i = 0;
    int j = 0;
    int col = size - 1;
    int row = size - 1;
    bool left = true;
    bool top = true;
    int rowDecrease = 0;
    int columnDecrease = 0;
    while (count <= size * size)
    {
        array2D[i, j] = count;
        count++;
// идем направо
        if (left && top)
        {
            if (j == col)
            {
                rowDecrease++;
                left = false;
                i++; continue;
            }
            else j++; continue;
        }
 // идем вниз
        if (!left && top)
        {
            if (i == row)
            {
                col--;
                top = false;
                j--; continue;
            }
            else i++; continue;
        }
 //  идем налево
        if (!left && !top) 
        {
            if (j == columnDecrease)
            {
                row--;
                left = true;
                i--; continue;
            }
            else j--; continue;
        }
// идем вверх
        if (left && !top)
        {
            if (i == rowDecrease)
            {
                columnDecrease++;
                top = true;
                j++; continue;
            }
            else i--; continue;
        }

    }
    return array2D;
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
Console.Write("Введите  размер квадратного массива size = ");
int size = int.Parse(Console.ReadLine()!);
int[,] array2d = GetArraySpiral(size);
PrintArray(array2d);
