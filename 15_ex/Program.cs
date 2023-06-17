Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num > 5 && num < 8)
{
    Console.WriteLine($"{num} -> да, выходной");
    return;
}
if (num > 0 && num < 6)
{
    Console.WriteLine($"{num} -> нет(");
    return;
}
else 
{
    Console.WriteLine($"{num} -> данные не коректны");
}