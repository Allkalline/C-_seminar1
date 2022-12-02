//Программа, которая на вход принимает одно число (N), а на выходе показывает все целые число в промежутке от -N до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
if (N<0) {
    N = -N;
}
int a = -N;

while (a<=N) {

    Console.Write (" " + a + " ");
    a++;
}