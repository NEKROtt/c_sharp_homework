// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да 

Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int i = 0;
int sum =0, t;

if(num>9999 && num<100000)
{
    for(t=num;num!=0;num=num/10)
    {
    i=num % 10;
    sum=sum*10+i;
    }
    if(t==sum)
    Console.WriteLine($"{t} -> является палиндромом.");
    else
    Console.WriteLine($"{t} -> не является палиндромом.");
} 
else
Console.WriteLine("Это не пятизначное число! ");

