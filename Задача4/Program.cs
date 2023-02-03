// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


System.Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    if (n1 > n3)
    {
        System.Console.WriteLine("Максимальное число: " + n1);
    }
    else
        System.Console.WriteLine("Максимальное число: " + n3);
}
else if (n2 > n3)
{
    System.Console.WriteLine("Максимальное число: " + n2);
}
else
{
    System.Console.WriteLine("Максимальное число: " + n3);
}