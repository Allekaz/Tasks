// Задача 15:
// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Является ли день выходным? ");
Console.Write("Введите число обозначающее день недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 5)
{
    Console.WriteLine("Нет!");
}
else if (day >= 6 && day <= 7)
{
    Console.WriteLine("Да!");
}
else Console.Write(" Нет такого дня недели!");