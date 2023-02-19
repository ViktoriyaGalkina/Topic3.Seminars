// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double FindPointX(double b1, double k1, double b2, double k2)
{
    double numberX = 0;
    numberX = (b2 - b1) / (k1 - k2);
    return numberX;
}

double FindPointY(double b1, double k1, double b2, double k2)
{
    double numberY = 0;
    numberY = k2 * FindPointX(b1, k1, b2, k2) + b2;
    return numberY;
}

double N = GetNumber("введите значение b1");
double M = GetNumber("введите значение k1");
double T = GetNumber("введите значение b2");
double Q = GetNumber("введите значение k2");
System.Console.WriteLine($"Координаты точки пересечения: ({FindPointX(N, M, T, Q)};{FindPointY(N, M, T, Q)})");
