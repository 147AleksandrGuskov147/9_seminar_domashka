﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = M;

int Sum(int temp)
{
    if (temp > N)
    {
        return 0;
    }
    return temp + Sum(temp + 1);
}

int sum = Sum(temp);
Console.Write(sum);