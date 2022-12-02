// Программа принимает 2 числа и проверяет, является ли первое число квадратом второго

Console.Write("Введите число 1:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2:");
int b = int.Parse(Console.ReadLine()!);

if (a==b*b) 
{Console.WriteLine("да");}
else
{
    Console.WriteLine("нет");
}

