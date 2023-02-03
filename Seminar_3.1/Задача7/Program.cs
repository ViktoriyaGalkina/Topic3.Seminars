// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

System.Console.WriteLine("Введите число N: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (N > 99 && N < 1000)
{
    System.Console.WriteLine(N % 10);
}
else
{
    System.Console.WriteLine("Введено не трёхзачное число");
}