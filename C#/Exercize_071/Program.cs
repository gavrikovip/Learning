// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n = n + 1;
    }
    else
    if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

int firstNumber = GetNumber("Введите первое число");
int secondNumber = GetNumber("Введите второе число");

int result = AkkermanFunction(firstNumber, secondNumber);
Console.WriteLine($"m = {firstNumber}, n = {secondNumber} -> A(m,n) = {result}");