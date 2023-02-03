// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// // 34, 5 -> не кратно, остаток 4 
// // 16, 4 -> кратно


System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());


if (b % a == 0)
{
    System.Console.WriteLine("Числа кратны");
}
else 
{
    System.Console.WriteLine($"Числа не кратны и остаток от деления: {b % a}");
}