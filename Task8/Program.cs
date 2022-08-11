/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Чётные числа от 0 до {num} :");

int count = 0;
int temp = 1;

while (count < num)
{
    if (temp % 2 == 0)
    {
        Console.WriteLine(temp);
    }
    temp++;
    count++;
}
