// Показать двумерный массив размером m×n заполненный целыми числами.
Random numberArray = new Random();

void FillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = numberArray.Next(1, 100);
            Console.Write($"{arr[i, j]} ");
        }
    Console.WriteLine();
    }
}

int m = numberArray.Next(1, 5);
int n = numberArray.Next(1, 5);

Console.WriteLine($"m = {m} ");
Console.WriteLine($"n = {n} ");
FillArray(m, n);
