// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

double []arr = new double[]{12, -2, 3, 4, -5, 69.2, 3, 2, 0};

void MaxMinArray()
{
    double max = arr[0];
    double min = arr[0];
    foreach(double item in arr)
    {
        if (item >= max)
        {
            max = item;
        }
        else
        {
            if (item <= min)
            {
                min = item;
            }
        }
    }
    Console.WriteLine($"Максимальный элемент {max}, Минимальный элемент {min}");
    double difference = max - min;
    Console.WriteLine($"Разница межде числами = {difference}");
}

MaxMinArray();