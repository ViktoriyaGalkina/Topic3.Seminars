// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// 1 версия (математическая).(не работает с числами,которые начинаются с 1)

// int GetNumber(string text)
// {
//     System.Console.WriteLine(text);
//     return Math.Abs(Convert.ToInt32(Console.ReadLine()));
// }

// int Sum(int number)
// {
//     int SumIndex = 0;
//     for (int i = 0; i < number; i++)
//     {
//         SumIndex = SumIndex + number % 10;
//         number = number / 10;
//     }
//     return SumIndex;
// }

// int N = GetNumber("Введите число: ");
// System.Console.WriteLine($"Сумма цифр в числе равна: {Sum(N)} ");



// 2.1 версия(через массив)(1 вариант)  // Работает,но без второй функции.

string GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine();
}

string N = GetNumber("Введите число: ");

int res = 0;
for (int i = 0; i < N.Length; i++)
{
    int Converted = Convert.ToInt32(Convert.ToString(N[i]));
    res = res + Converted;
}
System.Console.WriteLine($"Сумма цифр в числе равна: " + res);



// 2.2 версия(через массив)(2 вариант - если все преобразую в функции - выдает ошибку : 
// (73,25): error CS1503: Аргумент 1: не удается преобразовать из "int" в "int[]".


// int GetNumber(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumNumbers(int[] len)
// {
//     int res = 0;
//     for (int i = 0; i < len.Length; i++)
//     {
//         res = res + len[i];
//     }
//     return res;
// }

// int N = GetNumber("Введите число: ");
// int result = SumNumbers(N);
// System.Console.WriteLine($"Сумма цифр в числе равна: " + result);