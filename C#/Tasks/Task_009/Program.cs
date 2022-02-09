//Показать последнюю цифру трехзначного числа

int GetLastDigit(int number)
{
    return number % 10;
}

int GetIntegerFromConsole(int min, int max)
{
    int result = 0;
    bool isError = true;
    while (isError)
    {
        Console.WriteLine($"Введите целое число от {min} по {max}:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out result)) isError = result < min || result > max;
    }
    return result;

}

int number = GetIntegerFromConsole(100, 999);
int lasDigit = GetLastDigit(number);
Console.WriteLine(lasDigit);