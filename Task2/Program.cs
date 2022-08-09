// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
int max = a;
if ( b > a )
{
    max = b;
    Console.WriteLine($"Максимальное число {b}, оно больше числа {a}");
}
if (a > b)
{
    max = a;
    Console.WriteLine($"Максимальное число {a}, оно больше числа {b}");
}
if (a == b)
{
    Console.WriteLine($"Числа {a} и {b} равны"); 
}
