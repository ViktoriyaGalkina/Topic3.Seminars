// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Введите первое число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    System.Console.WriteLine("Максимальное число = " + n1);
    System.Console.WriteLine("Минимальное число = " + n2);
}
else
{
    System.Console.WriteLine("Максимальное число = " + n2);
    System.Console.WriteLine("Минимальное число = " + n1);
}