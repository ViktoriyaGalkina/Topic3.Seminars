// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (M > 0 && N == 0)
    {
        return Akkerman(M - 1, 1);
    }
    else if (M > 0 && N > 0)
    {
        return Akkerman(M-1,Akkerman(M,N-1));
    }
    return Akkerman(M,N);
}


int m = ReadInt("Введите неотрицательное число M: ");
int n = ReadInt("Введите неотрицательное число N: ");
System.Console.WriteLine($"A({m},{n}) = {Akkerman(m,n)}");


// Console.WriteLine("Введите начальное число M:");
// int numberM = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите начальное число N:");
// int numberN = int.Parse(Console.ReadLine());

// ///Метод вычисления функции Аккермана:
// int AckermannFunction (int numberM, int numberN)
// {
//     if (numberM == 0) return numberN + 1;
//     if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
//     if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
// return AckermannFunction(numberM, numberN);
// }

// Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");