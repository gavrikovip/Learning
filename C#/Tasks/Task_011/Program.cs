// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int GetRandomNumber()
{
    return new Random().Next(10, 100);
}

int number = GetRandomNumber();
Console.WriteLine(number);

int firstNumber = number / 10;
int secondNumber = number % 10;

if (firstNumber > secondNumber) 
    Console.WriteLine($"Большее из цифр {firstNumber}");
else 
    Console.WriteLine($"Большее из цифр {secondNumber}");