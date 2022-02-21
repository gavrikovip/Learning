// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

int Even = 0;
int Odd = 0;

int[] FillPrintArray()
{
    int[] arr = new int[10];
    Random number = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(100, 1000);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

void EvenOddNumberOfArray(int[] arr) // количество четных и нечетных чисел в массиве
{
    foreach (int item in arr)
    {
        if (item % 2 == 0)
        {
            Even++;
        }
        else Odd++;
    }
    Console.WriteLine($"Количество четных чисел {Even}, а нечетных {Odd}");
}

int[] arr = FillPrintArray();
Console.WriteLine();
EvenOddNumberOfArray(arr);


