// задача 3

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int x = int.Parse(number);

if (x % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}