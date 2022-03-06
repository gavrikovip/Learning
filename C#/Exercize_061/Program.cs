// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

int[,,] FillArray(int m, int n, int l)
{
    int numberOfArray = 10;
    int[,,] arr = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                arr[i, j, k] = numberOfArray;
                numberOfArray = numberOfArray + 1;
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] array)
{
    if (array.GetLength(0) * array.GetLength(1) * array.GetLength(2) < 90)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"Индекс[{i}, {j}, {k}] = {array[i, j, k]} ");
                }
                Console.WriteLine();
            }
        }
    }
    else Console.WriteLine("Массив слишком большой, чтобы заполнить его неповторяющимеся двузначными числами!");
}

int[,,] arr = FillArray(5, 5, 3);
PrintArray(arr);
