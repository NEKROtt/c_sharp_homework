Console.Clear();
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Показать четные числа от 1 до {n}");
void printEvenNumbers(int n)
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
    }
}
printEvenNumbers(n);
Console.WriteLine("\n");
    