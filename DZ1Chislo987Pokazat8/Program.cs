// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает
// вторую цифру этого числа. 
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int a1 = num / 100;
int a2 = num % 10;
int result = (num - a1 * 100 - a2) / 10;
if (num > 99 && num < 1000)
{
    Console.WriteLine($"{num} -> {result}");
}
else 
    if (num < -99 && num > -1000)
    {
        Console.WriteLine($"{num} -> {-result}");
    }
else Console.WriteLine($"Вы ввели не трехзначное число!!!");