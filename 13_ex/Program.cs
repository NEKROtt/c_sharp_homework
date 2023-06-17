Console.Clear();

int Prompt(string text)
{
    Console.WriteLine(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int ThirdNum(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return (number % 10);
}
bool AnoNum(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
        return true;
    }
    return false;
}

int number = Prompt("Введите число: ");
if (AnoNum(number) != true)
{
    Console.WriteLine(ThirdNum(number));
}
