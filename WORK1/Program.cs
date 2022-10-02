// задача 1

Console.WriteLine("Введите число 1: ");
string number1 = Console.ReadLine();
int x1 = int.Parse(number1);
Console.WriteLine("Введите чмсло 2: ");
string number2 = Console.ReadLine();
int x2 = int.Parse(number2);

if (x1 > x2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}