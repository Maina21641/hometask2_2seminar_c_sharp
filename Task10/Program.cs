// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
//// 1 вариант с рандомным числом
// System.Console.WriteLine();
// int threedigit = new Random().Next(100, 1000);
//// 2 вариант на ввод числа вручную
Console.WriteLine ("Введите 3-х значное число: ");
int threedigit = int.Parse (Console.ReadLine());
System.Console.WriteLine($"Второй цифрой числа {threedigit} является {threedigit / 10 % 10} ");