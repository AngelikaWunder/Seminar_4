// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
double[] GetDoubleArray(int size, double min, double max)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round((new Random().NextDouble() * (max - min) + min), 2);
    }
    return result;
}
double difference (double[] realArray)
{
    double min = realArray[0];
    double max = realArray[0];
    for (int i = 1; i < realArray.Length; i++)
    {
        if (realArray[i] < min)
        {
            min = realArray[i];
                    }
        else if (realArray[i] > max)
        {
           max = realArray[i]; 
        }
    }
    // double diff = max - min;
    return Math.Round((max - min), 2);
}
double[] array1 = GetDoubleArray(5, 2, 79);
Console.WriteLine(String.Join(", ", array1));
Console.WriteLine($"разница между максимальным и минимальным элементами массива равна {difference(array1)}");
