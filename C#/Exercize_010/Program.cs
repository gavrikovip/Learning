// Показать вторую цифру трёхзначного числа.

int GetNumber()
{
    return new Random().Next(100, 1000);
}
int number = GetNumber();
Console.WriteLine(number);
//142 = 1*10(2) + 4*10(1) + 2*10(0)

int SecondDigital = (number / 10) % 10;
Console.WriteLine(SecondDigital);