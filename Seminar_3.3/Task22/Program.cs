// Задача 22. 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void PrintSquares(int x)
{
for (int i = 1; i <= x; i++)
{
  System.Console.Write(Math.Pow(i, 2) + ", ");
}
}

System.Console.WriteLine("Введите число N");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

PrintSquares(a);


// System.Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int count = 1; count <= N; count++)
// {
//     System.Console.Write(Math.Pow(count, 2) + ", ");
// }