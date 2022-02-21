// Написать программу замену элементов массива на противоположные.

double []FillArray(int numbersOfElements)
{
    Random elementOfArr = new Random();
    double []arr = new double[numbersOfElements];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = elementOfArr.Next(-1000, 1001);
    }
    return arr;
}

void PrintArray(double []arr)
{
    foreach(int item in arr)
    {
        Console.Write($"{item} ");
    }
}

int GetNumber()
{
    Console.WriteLine("Введите количество элементов массива");
    return int.Parse(Console.ReadLine());
}

void PrintArrayNaoborot(double []arr)
{
  for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] - 2 * arr[i];
        Console.Write($"{arr[i]} ");
    }  
}


double []arr = FillArray(GetNumber());
PrintArray(arr);
Console.WriteLine();
PrintArrayNaoborot(arr);