/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] GenerateArray(int len, double min, double max)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble()*(max+1 - min) + min;
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("{0:0.00}", array[i]);
        System.Console.Write("   ");
    }
    System.Console.WriteLine();
}

double DiffMaxMin(double[] array)
{
    double currentmin = array[0];
    double currentmax = array[0];
    double diff = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > currentmax)
        {
            currentmax = array[i];
        }
        if (array[i] < currentmin)
        {
            currentmin = array[i];
        }
    }
    diff = currentmax - currentmin;
    return diff;
}

double[] arrayone = GenerateArray(10, - 99, 99);
ShowArray(arrayone);
double diff = DiffMaxMin(arrayone);
Console.Write($"Разница между максимальным и минимальным элементам равна - ");
Console.Write("{0:0.00}", diff);