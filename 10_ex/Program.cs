Console.Clear();
Console.Write("Введите трехзначное число: ");
int num=int.Parse(Console.ReadLine());

if (num < 100 || num >= 1000)
{
    Console.WriteLine("Это не трехзначное число!");
    return;
}
int secondNum = num / 10 % 10;
Console.WriteLine($"Вторая цифра -> {secondNum}");
