// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Summ(n, 0));

int Summ(int num, int sum)
{
    sum += num % 10;
    if (num < 10)
    {
        return sum;
    }
    return Summ(num / 10, sum);
}


// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Sum(num));

// int Sum(int n)
// {
//     if(n == 0)
//     {
//         return 0;
//     }
//     return n%10 + Sum(n/10);
// }