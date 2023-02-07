// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int N = GetNumber("Введите число: ");

int Sum(int number)
{
    int SumIndex = 0;
    for (int i = 0; i <= N; i++)
    {
        SumIndex = SumIndex + N % 10;
        N = N / 10;
    }
    return SumIndex;
}
int res = Sum(N);
System.Console.WriteLine($"Сумма цифр в числе равна: {res} ");


// if (N > 99)
// {
//     while (N > 1000)
//         N = N / 10;
//     System.Console.WriteLine($"Третья цифра числа: {N % 10}");