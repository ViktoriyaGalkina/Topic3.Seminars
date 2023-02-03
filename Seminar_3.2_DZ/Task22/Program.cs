// Задача 22. 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int count = 1; count <= N; count++)
{
    System.Console.Write(Math.Pow(count, 2) + ", ");
}


// int count = 1;

// while (count <= N)
// {
//     System.Console.Write(Math.Pow(count, 2) + ", ");
//     count++;
// }