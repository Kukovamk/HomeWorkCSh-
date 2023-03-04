// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

string n_1 = Console.ReadLine()!;
string n_2 = Console.ReadLine()!;

int a = int.Parse(n_1);
int b = int.Parse(n_2);


if (a > b)

Console.WriteLine( a > b );

else if (a == b)

Console.WriteLine(a = b);

else if (a < b)

Console.WriteLine(a < b);

