// В двумерном массиве n×k заменить четные элементы на противоположные.
Random numberArray = new Random();

double[,] FillArray(int n, int k)
{
    double[,] array = new double[n, k];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = numberArray.Next(-100, 100);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}
void EvenArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
                array[i, j] = -array[i, j];
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] arr = FillArray(4, 4);
Console.WriteLine("===========================");
EvenArray(arr);