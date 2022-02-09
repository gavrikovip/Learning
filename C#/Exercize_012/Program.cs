// Удалить вторую цифру трёхзначного числа.

int GetNumber()
{
    return new Random().Next(100, 1000);
}
int number = GetNumber();
Console.WriteLine(number);

int firstDigital = number / 100;
int thirdDigital = number % 10;
int finalNumber = firstDigital * 10 + thirdDigital;

Console.WriteLine(finalNumber);