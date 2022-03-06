// Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерной массива.

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

int[,] StructureArray(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int temp = 0;
    for (int i = 0; i < m; i++)
    {
        int max = arr[i, n - 1];
        for (int k = n - 1; k >= 1; k--)
            while (arr[i, k] > arr[i, k - 1])
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[i, j] < arr[i, j + 1])
                    {
                        temp = arr[i, j];
                        arr[i, j] = arr[i, j + 1];
                        arr[i, j + 1] = temp;
                        max = arr[i, j];
                    }
                    
                    
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

int[,] arr = FillArray(3, 5);
StructureArray(arr);
Console.WriteLine();
Console.WriteLine("Структурированный масиив");
Console.WriteLine("=========================");
PrintArray(arr);
