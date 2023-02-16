//  Напишите программу, которая найдёт точку пересечения двух прямых,
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//   значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)  
Console.Clear();
string FindPosition()
{
    Console.Write("Задайте b1 =   ");
    int b1 = int.Parse(Console.ReadLine()!);
    Console.Write("Задайте k1 =  ");
    int k1 = int.Parse(Console.ReadLine()!);
    Console.Write("Задайте b2 =  ");
    int b2 = int.Parse(Console.ReadLine()!);
    Console.Write("Задайте k2 =  ");
    int k2 = int.Parse(Console.ReadLine()!);

    int X =1;
    int Y =1;
    string text = String.Empty;
    // if ((k1 - k2) == 0)
    // {
    //     text = text + $"Прямые параллельны и не имеют точку пересечения.";
    //  }
    // else if ((k2 / k1) == (b2 / b1))
    // {
    //     text = text + $"Прямые совпадают и имеют бесконечное число точек пересечения.";
    // }
    if (((k1 - k2) != 0) && ((k2 / k1) != (b2 / b1)) )
    {
        X = (b2 - b1) / (k1 - k2);
        Y = X * k2 + b2;
        text = text + $"{ X.ToString()}, " + Y.ToString();
    }
    
    return text;
}  

Console.WriteLine($"координаты точки {FindPosition()} ");
