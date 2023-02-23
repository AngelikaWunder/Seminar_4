// // Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, 
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i=0; i < size; i++)
    {
    result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
int CountPositiveInteger (int[] array) 
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)  count++; 
    }
    return count;
}   
int[] array1 = GetArray (4, 100, 1000);
Console.WriteLine(String.Join(", ", array1));
Console.WriteLine($"Количество четных чисел в массиве равно {CountPositiveInteger(array1)}");
