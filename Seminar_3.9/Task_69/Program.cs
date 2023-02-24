﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

System.Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetResult(a, b, 1));

int GetResult (int numA, int numB, int res)
{
    numB--;
    if (numB >= 0)
    {
        res = res * numA;
        return GetResult (numA, numB, res);
    }
    else
    {
        return res;
    }
}


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Power(int n, int m)
// {
//     if (m == 1)
//     {
//         return n;
//     }
//     return n * Power(n, m--);
// }

// int n = ReadInt("Введите N: ");
// int m = ReadInt("Введите M: ");
// System.Console.WriteLine(Power(n, m));