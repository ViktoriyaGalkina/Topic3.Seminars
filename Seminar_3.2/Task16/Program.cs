// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b*b)
{
System.Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else if (b == a*a)
{
   System.Console.WriteLine($"Число {b} является квадратом числа {a}"); 
}
else{
    System.Console.WriteLine("Ни одно число не является квадратом другого");
}