/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/ 

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine());
int[] randomArray = new int[a];

void First(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(0, 9);
        Console.Write(randomArray[i] + " ");
    }
    Console.WriteLine();

}

int Second(int[] randomArray)
{
    int sum = 0;
    int i = 1;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2 ;
    }
    return sum;
}

First(a);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {Second(randomArray)}");