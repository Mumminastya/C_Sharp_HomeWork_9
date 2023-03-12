// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
//от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NifNaf(int m, int n)
{
    if(n == m)
    {
        return n;
    }
    return m + NifNaf(m+1, n);
}

System.Console.Write("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
int result = NifNaf(numb1, numb2);
System.Console.Write($"Результат: {result}");

