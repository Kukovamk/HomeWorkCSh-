// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

int num = int.Parse(Console.ReadLine()!);
int i = 2;

while (i <= num)
{
    Console.WriteLine(i);
    i += 2;
}
