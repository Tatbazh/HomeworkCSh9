﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumRecursion(int start, int end)
{
    if (start + 1 == end)
    {
        return start + end;
    }
    return start + SumRecursion(start + 1, end);
}

Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumRecursion(m, n));