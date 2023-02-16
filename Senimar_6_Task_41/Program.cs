// Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int[] GetArrayFromUser()
{
    Console.Write("Задайте общее количество чисел M, которые вы будете вводить ниже:  ");
    int M = int.Parse(Console.ReadLine()!);
    int[] result = new int[M];
    for (int i=0; i < M; i++) 
    {
        Console.Write("Задайте число из  M-чисел:  ");
        int num = int.Parse(Console.ReadLine()!);
        result[i]= num;
    }
    return result;
}
int[] array = GetArrayFromUser();
Console.WriteLine(String.Join(", ", array));

int EvenNumber (int[] array2)
{
    int count = 0;
    for (int i=0; i<array2.Length; i++)
    {
        if(array2[i] > 0) count++;
    }
    return count;
}

Console.Write($"Количество чисел больше 0 равно: {EvenNumber(array)} ");
