//Программа, которая принимает на вход 3-значное число и на выходе показывает последнюю цифру этого числа

Console.Write("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine()!);
if (N<0) {N=-N;}
if(N>99 & N<1000) {
Console.WriteLine(N % 10);
}
else {
    Console.WriteLine("Это не трехзначное число");
}

