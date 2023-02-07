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

int N = GetNumber("Введите число: ");

int Sum(int number)
{
    int SumIndex = 0;
    for (int i = 0; i <= number; i++) 
    {
        SumIndex = SumIndex + N % 10;
        N = N / 10;
    }
    return SumIndex;
}

System.Console.WriteLine($"Сумма цифр в числе равна: {Sum(N)} ");



// 2 версия(через массив).
