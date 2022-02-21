// Найти сумму чисел одномерного массива стоящих на нечетной позиции.

int GetNumber()
{
    Console.WriteLine("Введите количество элементов массива:");
    string input = Console.ReadLine();
    return int.Parse(input);
}

int[] InitArray(int number)
{
    int[] arr = new int[number];
    Random randomNumber = new Random();
    for (int i = 0; i < number; i++)
    {
        arr[i] = randomNumber.Next(1, 51);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintSumOfArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++) // считаем, что позиция числа начинается с 1 а не с 0. Иначе меняем условаие на !=0.
    {
        if (i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine($"Сумма = {sum}");
}

int getInt = GetNumber();
int[] arr = InitArray(getInt);
PrintArray(arr);
Console.WriteLine();
PrintSumOfArray(arr);