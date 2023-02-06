//  Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

// int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
// Вывод массива одной строкой в массив целочисленных чисел.
// System.Console.Write(string.Join("-", arr));


System.Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int arr = number.Length;

if (arr == 5)
 {
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine("Число {number} является палиндромом!");
    }
    else
    {
        System.Console.WriteLine("Число {number} не является полиндромом");
    }
 }
else
 {
    System.Console.WriteLine("Вы ввели не пятизначное число!");
 }



// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine()); 
// if (num / 10000 == num % 10 && num / 1000 % 10 == num % 10000 / 1000)
// {
//     System.Console.WriteLine("Число является палиндромом");
// }
// else
// {
//     System.Console.WriteLine("Число не является палиндромом");
// }