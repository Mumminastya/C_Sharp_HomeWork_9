﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных
//числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Если честно, решение было в Википедии. Стыдно,но вообще не поняла этой функции(((

int AkkerFunc (int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (n != 0 && m == 0)
    {
        return AkkerFunc(n - 1, 1);
    }
    else
    {
        return AkkerFunc(n - 1, AkkerFunc(n, m - 1));
    }
}

System.Console.Write("Введите первое неотрицательное число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе неотрицательное число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
int result= AkkerFunc(numb1, numb2);
System.Console.Write($"Результат: {result}");