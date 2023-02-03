//  Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

// git remote set-url origin -- ссылку перезаписать на репозиторий


// int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
// Вывод массива одной строкой в массив целочисленных чисел.
// System.Console.Write(string.Join("-", arr));


System.Console.WriteLine("Введите пятизначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int[] arr = number.Length;
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


if (number > 9999 && number < 100000)
{
    if (array[1] == array[5] && array[2] == array[4])
    {
        System.Console.WriteLine("Число является палиндромом!");
    }
    else
    {
        System.Console.WriteLine("Число не является полиндромом");
    }
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число!");
}