//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.WriteLine("Введите любое число: ");
int N = Math.Abs(Convert.ToInt32(System.Console.ReadLine()));

if (N > 99)
{
    while (N > 1000)
    N = N / 10;
    System.Console.WriteLine($"Третья цифра числа: {N % 10}");
}
else
{
    System.Console.WriteLine("Третья цифра числа не найдена(");
}


// Задача 13.Второй вариант.

// System.Console.WriteLine("Введите число:");

// int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
// int lenNumber = numberA.ToString().Length;

// if (lenNumber < 3)
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     int multiplier = lenNumber - 3;

//     int result = numberA / (Convert.ToInt32(Math.Pow(10, multiplier))) % 10;

//     System.Console.WriteLine(result);
// }
///