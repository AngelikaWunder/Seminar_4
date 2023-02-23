// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] getArray8()
{
    int[] arrayeight = new int[8];
    for (int i = 0; i < arrayeight.Length; i++)
    {
        arrayeight[i] = new Random().Next(1, 99);
    }
    return arrayeight;
}
void PrintArray8(int[] arrayel)
{
    int i = 0;
    Console.Write($"[{arrayel[i]}, ");
    i = 1;
    while (i < arrayel.Length - 1)
    {
        Console.Write($" {arrayel[i]}, ");
        i++;
    }
    i = arrayel.Length-1;
    Console.Write($" {arrayel[i]} ]");
}
int[] arrayof8el = getArray8();
PrintArray8(arrayof8el);