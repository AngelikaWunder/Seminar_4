// адайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int SumOddElements (int[] array)
{
    int sum = 0;
    for (int i=0; i < array.Length; i++)
    {
        if ( i % 2 > 0) sum = sum + array[i];
    }
    return sum;
}
int[] array1 = GetArray(5, -9, 99);
Console.WriteLine(String.Join(", ", array1));
Console.WriteLine($"Сумма элементов,стоящих на нечетных позициях равна {SumOddElements(array1)}");

