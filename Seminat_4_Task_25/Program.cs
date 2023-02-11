// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

double Exponent (int numA, int numB)
{
   int res = 1;
   for (int i=1; i <= numB; i++)
   {
      res = res*numA;
   }
   return res;
}
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($" -> {Exponent (A, B)}");
