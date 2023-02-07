﻿// Задача 23: 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// * Видимо ошибка в условии: 3-> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// 1 вариант.
// System.Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//    System.Console.Write(Math.Pow(i, 3) + ", ");
// }


// 2 вариант.
void PrintSquares(int x)
{
  for (int i = 1; i <= x; i++)
{
   System.Console.Write(Math.Pow(i, 3) + ", ");
}  
}

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
PrintSquares(N);