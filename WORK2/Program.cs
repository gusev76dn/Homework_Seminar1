// задача 2

Console.WriteLine("Введите число 1: ");
string number1 = Console.ReadLine();
int x1 = int.Parse(number1);
Console.WriteLine("Введите число 2: ");
string number2 = Console.ReadLine();
int x2 = int.Parse(number2);
Console.WriteLine("Введите число 3: ");
string number3 = Console.ReadLine();
int x3 = int.Parse(number3);

int max = x1;

if (x1 > max) max = x1;
if (x2 > max) max = x2;
if (x3 > max) max = x3;

Console.Write("max = ");
Console.WriteLine(max);