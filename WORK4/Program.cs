// задача 4

Console.WriteLine("Введите число 1: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int y = int.Parse(Console.ReadLine());

for (int i = 1; i <= y; i += 1)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
