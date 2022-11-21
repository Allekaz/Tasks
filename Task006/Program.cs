/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Пример:
4 -> да
-3 -> нет
7 -> нет
*/
Console.Clear();
Console.WriteLine("Является ли число четным");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remainder = number % 2;

if (remainder == 0) Console.WriteLine("Да, это число является четным");
else Console.WriteLine("Нет, это число является нечетным");