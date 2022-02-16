// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] ArrayInit()
{
    int[] arr = new int[8] {0,0,0,0,0,0,0,0};
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetNumber();
    }
    return arr;
}

void PrintArray(int[] array)
{
    foreach(int item in array)
    {
        Console.Write(item + " ");
    }
}

int GetNumber()
{
    int number = new Random().Next(0, 2);
    return number;
}

int[] arr = ArrayInit();
PrintArray(arr);