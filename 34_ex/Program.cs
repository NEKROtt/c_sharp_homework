/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
    Console.Write("[");
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(100,999);
        Console.Write($"{randomArray[i]}, ");
    }
    Console.Write($"{randomArray[randomArray.Length - 1 ]}");
    Console.Write("]");
    Console.WriteLine(); 
}

int kol(int[] randomArray)
{
    int kol = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        int k = randomArray[i];
        randomArray[i] = randomArray[randomArray.Length - i - 1];
        randomArray[randomArray.Length - i - 1] = k;
        if (randomArray[i] % 2 == 0)
        kol = kol + 1;
    }
    return kol;
}

mas(a);
Console.WriteLine($"Количество чётных чисел в массиве -> {kol(randomArray)}");