/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using System;
using static System.Console;
Clear();

Write("Введите кол-во строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите кол-во столбцов массива: ");
int n = int.Parse(ReadLine());

double[,] array = new double[m, n];

Write("Введите номер строки: ");
int m2 = int.Parse(ReadLine());
Write("Введите номер столбца: ");
int n2 = int.Parse(ReadLine());

void First(int m, int n)
{
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

First(m, n);
if (m2 < m+1 && n2 < n+1)
{
    WriteLine($"элемент -> {array[m2-1,n2-1]} ");
}
else 
{
    WriteLine("Такого элемента нет в массиве");
}
