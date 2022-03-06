// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int sum = 0;

int[,] FillArray(int m, int n)
{
    Random numberOfArray = new Random();
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = numberOfArray.Next(1, 20);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

int[] MinimalString(int[,] arr)
{
    int[] arrSum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        arrSum[i] = sum;
        sum = 0;
    }
    return arrSum;
}

void PrintArray(int[] arr)
{
    int index = 0;
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            index = i;
        }
    }
    index = index + 1;
    Console.WriteLine($"{index} - минимальная строка в массиве");
}

int[,] array = FillArray(4, 4);
int[] minimalString = MinimalString(array);
PrintArray(minimalString);