// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

Random numberOfArray = new Random();

// Заполнение двумерного массива
int[,] FillArray(int m, int k)
{
    int[,] arr = new int[m, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < k; j++)
        {
            arr[i, j] = numberOfArray.Next(1, 10);
        }
    }
    return arr;
}

// Печать массива
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Возведение четных индексов в квадрат
int[,] SquadArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
    return arr;
}

int[,] array = FillArray(4, 4);
PrintArray(array);
Console.WriteLine();
array = SquadArray(array);
PrintArray(array);
