﻿/* 
Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using System;
using static System.Console;
Clear();

Write("Введите кол-во строк и столбцов: ");
int n = int.Parse(ReadLine());
int[,] matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    {
        j++;
    }
    else
    {
        if (i < j && i + j >= matrix.GetLength(0) - 1)
        {
            i++;
        }
        else
        {
            if (i >= j && i + j > matrix.GetLength(1) - 1)
            {
                j--;
            }
            else
            {
                i--;
            }
        }
    }
}

PrintArray(matrix);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
            {
                Write($" {array[i, j]} ");                
            }
            else
            {
                Write($"{array[i, j]} ");
            }
        }
        WriteLine();
    }
}
