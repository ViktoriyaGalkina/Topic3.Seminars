// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

void PrintArray(int[] arr)
{
    if (arr.Length != 5)
    {
        System.Console.WriteLine("Массив введён некоректно ");
    }
    else
    {
        System.Console.WriteLine(string.Join(", ", arr));
    }
}

int PositiveNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int[] M = GetNumber("Введите 5 чисел через пробел: ");
PrintArray(M);
System.Console.WriteLine($"Вы ввели положительных чисел: " + PositiveNumbers(M));



