// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int[] ResultArray(int a, int b)
{
    int[] arr = new int[b - a + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = a + i;
    }
    return arr;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}


int firstNumber = GetNumber("Введите первое число");
int secondNumber = GetNumber("Введите второе число");

int[] arr = ResultArray(firstNumber, secondNumber);
PrintArray(arr);