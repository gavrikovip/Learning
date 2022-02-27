// В матрице чисел найти сумму элементов главной диагонали.

Random numberOfArray = new Random();
int sum = 0;
// Заполнение и вывод двумерного массива
int[,] FillArray(int m, int k)
{
    int[,] arr = new int[m, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < k; j++)
        {
            arr[i, j] = numberOfArray.Next(1, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

int SumMainDiagonalyOfArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + arr[i, j];
        }
    }
    return sum;
}

int[,] arr = FillArray(3, 3);
sum = SumMainDiagonalyOfArray(arr);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");

//[0,0] [1,1] [2,2] [...,...] [n,n]


