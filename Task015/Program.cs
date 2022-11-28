Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 5)
{
        Console.WriteLine("Рабочий день!");
} 
else if (day >= 6 && day <= 7)
{
    Console.WriteLine("Выходной день!");
}
else Console.Write(" Нет такого дня недели!");