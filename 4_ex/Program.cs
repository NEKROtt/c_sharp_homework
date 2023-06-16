Console.Clear(); 
Console.Write("num1: "); 
int num1 = int.Parse(Console.ReadLine()); 
Console.Write("num2: "); 
int num2 = int.Parse(Console.ReadLine()); 
Console.Write("num3: "); 
int num3 = int.Parse(Console.ReadLine()); 
int max = num1; 
 
if (num1 < num2) max = num2; 
if (num2 < num3) max = num3; 
 
Console.WriteLine(max);