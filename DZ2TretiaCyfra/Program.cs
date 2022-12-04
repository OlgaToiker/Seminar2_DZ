// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = num / 100;
if (num > 99 && num < 1000)
{
    Console.WriteLine($"Третья цифра числа {num} -> {result}");
}
else if (num < -99 && num > -1000)
{
Console.WriteLine($"Третья цифра числа {num} -> {-result}");    
}

else if (num > 999)
{
    result = num%1000/100;
    Console.WriteLine($"Третья цифра числа {num} -> {result}");
}
else if (num < 999)
{
    result = num % 1000 / 100;
    Console.WriteLine($"Третья цифра числа {num} -> {-result}");
}
else Console.WriteLine($"У заданного числа нет третьей цифры!");