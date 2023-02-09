/*
Задача 38
Задайте массив вещественных чисел. Найдите разницу
между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/
Console.Write("Введите количество элементов массива: ");
int elementArray = Convert.ToInt32(Console.ReadLine());

double[] myArray = new double[elementArray];
ArrayOfRealNumbers(myArray);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < myArray.Length; j++)
{
    if (myArray[j] > max)
    {
        max = myArray[j];
    }
    if (myArray[j] < min)
    {
        min = myArray[j];
    }
}

void ArrayOfRealNumbers(double[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 10;
    }
}


Console.Write($"Разница между максимальным и минимальным элементов массива[{string.Join(" ", myArray)}] -> {max - min} ");