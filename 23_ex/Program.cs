// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int m = N; 
if (N < 0)
{
    i = N; 
    m = -N;
    N = -1; 
}
int[] result = new int[m];
int j = 0;
for (; i <= N; i++)
{
    result[j] = i * i * i;
    j++;
}
for (j = 0; j < m; j++)
{
    Console.Write($"{result[j]} ");
}