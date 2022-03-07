// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 15
// M = 4; N = 8. -> 5

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int Result(int a, int b)
{
    int result = b - a + 1;
    return result;
}

int ResultSum(int a, int b)
{
    int[] arr = new int[b - a + 1];
    int sum = a;
    arr[0] = sum;
    for (int i = 1; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + 1;
        sum = sum + arr[i];
    }
    return sum;
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

int result = Result(firstNumber, secondNumber);
Console.WriteLine($"M = {firstNumber}; N = {secondNumber} -> {result}");

int sum = ResultSum(firstNumber, secondNumber);
Console.WriteLine($"Сумма элементов = {sum}");