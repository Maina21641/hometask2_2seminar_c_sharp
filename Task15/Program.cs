// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void Check (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Этот день выходной");
  }
  else if (dayNumber == 1 || dayNumber <= 5) {
    Console.WriteLine("Этот день не выходной");
  }
  else Console.WriteLine("Дня недели под таким номером не существует");
}

Check(dayNumber);