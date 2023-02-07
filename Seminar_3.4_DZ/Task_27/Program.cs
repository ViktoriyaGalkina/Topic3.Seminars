// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// 1 версия (математическая).

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Sum(int number)
{
    int SumIndex = 0;
    for (int i = 0; i <= number; i++) 
    {
        SumIndex = SumIndex + number % 10;
        number = number / 10;
    }
    return SumIndex;
}

int N = GetNumber("Введите число: ");
System.Console.WriteLine($"Сумма цифр в числе равна: {Sum(N)} ");



// 2 версия(через массив).

// int[] GetNumber(int[] text)
// {
//     System.Console.WriteLine[text];
//     return Convert.ToInt32(Console.ReadLine(text));
// }

// int[] N = GetNumber("Введите число: ");
