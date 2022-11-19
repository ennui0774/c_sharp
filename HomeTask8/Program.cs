// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число N:");
int count = 1;
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write($"{n} -> ");
while (count <= n)
{
    if (count % 2 == 0) Console.Write($"{count} ");
    count++;
}