// Пользователь вводит скобочные последовательности. В
// последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность,
// составленная в алфавите, состоящем из символов, сгруппированных в
// упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная
// последовательность была введена
Console.Clear();
Console.Write("Согласно условию задачи введите скобочную последовательность:");
// string word = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string word = Console.ReadLine();

string alphabet = "()[]{}";
string open = $"{alphabet[0]}" + $"{alphabet[2]}" + $"{alphabet[4]}";
string closed = $"{alphabet[1]}" + $"{alphabet[3]}" + $"{alphabet[5]}";

string stackOpen = String.Empty;
string stackClosed = String.Empty;
// отбрасываем "слова" с нечетным кол-вом скобок
if (word.Length / 2 == 0)
{
    Console.WriteLine("введена неправильная скобочная последовательность");
}
else
{
    // формируем стeки с открытыми и закрытыми скобками
    int k = 0;
    int l = 0;
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == open[0] || word[i] == open[1] || word[i] == open[2])
        {
            stackOpen = stackOpen + word[i]; k++;
        }
        else
        {
            if (word[i] == closed[0] || word[i] == closed[1] || word[i] == closed[2])
            {
                stackClosed = stackClosed + word[i]; l++;
            }
        }
    }
    // отбрасываем случаи, когда стеки получились не равны по длине
    if (stackOpen.Length != stackClosed.Length)
    {
        Console.WriteLine("введена неправильная скобочная последовательность");
    }
    else
    {
        // сравниваем скобки снизу из открытого и снизу из закрытого стеков
        for (int i = 0; i < stackOpen.Length; i++)
        {
            if (stackOpen[i] == open[0])
            {
                if (stackClosed[i] == closed[0])
                {
                    if (i != (stackOpen.Length - 1)) continue;
                    else
                    {
                        Console.WriteLine("введена правильная скобочная последовательность");
                    }
                }
                else
                {
                    Console.WriteLine("введена неправильная скобочная последовательность");
                    break;
                }
            }
            else if (stackOpen[i] == open[1])
            {
                if (stackClosed[i] == closed[1])
                {
                    if (i != (stackOpen.Length - 1)) continue;
                    else
                    {
                        Console.WriteLine("введена правильная скобочная последовательность");
                    }
                }
                else
                {
                    Console.WriteLine("введена неправильная скобочная последовательность");
                    break;
                }
            }
            else if (stackOpen[i] == open[2])
            {
                if (stackClosed[i] == closed[2])
                {
                    if (i != (stackOpen.Length - 1)) continue;
                    else
                    {
                        Console.WriteLine("введена правильная скобочная последовательность");
                    }
                }
                else
                {
                    Console.WriteLine("введена неправильная скобочная последовательность");
                    break;
                }
            }
            else
            {
                Console.WriteLine("введена неправильная скобочная последовательность");
            }

        }
    }
}
// Console.WriteLine($"{word}");
// Console.WriteLine($"{alphabet}");
// Console.WriteLine($"{stackOpen}");
// Console.WriteLine();
// Console.WriteLine($"{stackClosed}");