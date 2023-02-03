// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int minus_n = - n;

do
{
    System.Console.Write(minus_n + ", ");
    minus_n++;
}
while (minus_n <= n);