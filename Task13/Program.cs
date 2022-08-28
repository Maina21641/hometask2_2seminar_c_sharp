// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Number = new Random().Next(1, 32680);
Console.WriteLine($"Дано число: {Number}");

if (Number / 10000 > 0)
{
    Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 100 % 10}");
}
else if (Number / 1000 > 0)
{
Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 10 % 10}");
}
else if (Number / 100 > 0)
{
Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number % 10}");
}
else Console.WriteLine($"У числа {Number} нет третьей цифры");