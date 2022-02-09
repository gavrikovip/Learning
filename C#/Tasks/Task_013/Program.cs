// Выяснить, кратно ли число заданному. Если нет, то вывести остаток

int GetNumber()
{
    return new Random().Next(20, 100);
}

int constNumber = GetNumber();
int number = GetNumber();
//Console.WriteLine(number);
void IsMultiple(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        int ostatok = firstNumber % secondNumber;
        if (ostatok == 0)
            Console.WriteLine($"{firstNumber} кратно {secondNumber}");
        else
            Console.WriteLine($"Остаток от деления {firstNumber} на {secondNumber} равен {ostatok}");
    }
    else
    {
        int ostatok = secondNumber % firstNumber;
        if (ostatok == 0)
            Console.WriteLine($"{secondNumber} кратно {firstNumber}");
        else
            Console.WriteLine($"Остаток от деления {secondNumber} на {firstNumber} равен {ostatok}");
    }
}

IsMultiple(constNumber, number);