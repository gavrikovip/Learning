// Спирально заполнить двумерный массив

int[,] FillArray(int m, int n)
{
    Random numberOfArray = new Random();
    int[,] arr = new int[m, n];

    m = m - 1;
    n = n - 1;
    PrintArray(arr);
    Console.WriteLine("=============");
    for (int i = 0; i <= m; i++)
    {
        for (int j = 0; j <= n; j++)
        {
            while (arr[i, j] == 0)
            {
                if(j == n && n == m)
                {
                    arr[i, j] = numberOfArray.Next(1, 100);
                    Console.Write($"Индекс[{i}, {j}] = {arr[i, j]} ");
                    return arr;
                }
                for (int f = j; f < n; f++)
                {
                    arr[i, f] = numberOfArray.Next(1, 100);
                    Console.Write($"Индекс[{i}, {f}] = {arr[i, f]} ");
                }
                for (int g = i; g < m; g++)
                {
                    arr[g, n] = numberOfArray.Next(1, 100);
                    Console.Write($"Индекс[{g}, {n}] = {arr[g, n]} ");
                }
                for (int h = n; h > j; h--)
                {
                    arr[m, h] = numberOfArray.Next(1, 100);
                    Console.Write($"Индекс[{m}, {h}] = {arr[m, h]} ");
                }
                for (int e = m; e > i; e--)
                {
                    arr[e, j] = numberOfArray.Next(1, 100);
                    Console.Write($"Индекс[{e}, {j}] = {arr[e, j]} ");
                }
                n = n - 1;
                m = m - 1;
            }

        }
    }
    return arr;
}

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

int[,] arr = FillArray(7, 5);
Console.WriteLine();
Console.WriteLine("=============");
PrintArray(arr);
