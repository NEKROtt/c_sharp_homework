/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int m = int.Parse(Console.ReadLine());
int[] Array = new int[m];

void First(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i+1} элемент массива ");
        Array[i] = int.Parse(Console.ReadLine());
    }
}

int Second(int[] Array)
{
    int i=0;
    int sum = 0;
    while (i < Array.Length)
    {
        if(Array[i]>0)
        sum = sum + 1;
        i = i + 1;
    }
    return sum;
}

First(m);
Console.WriteLine($"Чисел больше нуля: {Second(Array)}");