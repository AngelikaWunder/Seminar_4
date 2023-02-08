// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Sumofnumber (int num)
{
    int sum = 0;
    int rest = 1;
    if ( num == 0)
    {
        sum = 0;
    }
    else
    {
        while (num > 9)
        {
            rest = num % 10;
            sum = sum + rest;
            num /= 10;
        }
        sum = sum + num;
    }
    return sum;
}
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе равна {Sumofnumber(N)}");