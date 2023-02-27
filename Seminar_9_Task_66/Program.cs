//  Задайте значения M и N. Напишите программу,
//   которая найдёт сумму натуральных элементов
//  в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
int SumFor(int M, int N)
{
    if (M == N) return N;
    return M + SumFor(M+1, N);
}
Console.Write("Введите число M = ");
int numM = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N = ");
int numN = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{SumFor(numM, numN)}");
