// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



System.Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int B = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int result = 1;
for (int i = 1; i <= B; i++)
{
    result = result * A;
}

System.Console.WriteLine($"{A} в степени {B} равно: {result}");