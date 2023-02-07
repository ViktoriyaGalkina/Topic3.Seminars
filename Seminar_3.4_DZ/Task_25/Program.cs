// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Degree(int x, int y)
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    return result;
}

int A = GetNumber("Введите первое число: ");
int B = GetNumber("Введите второе число: ");
int res = Degree(A, B);
System.Console.WriteLine($"{A} в степени {B} равно: {res}");