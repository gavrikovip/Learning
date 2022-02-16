// Подсчитать сумму цифр в числе

// 123 1+2+3
// 123%10 = 3
// 123/10 = 12
// 12%10 = 2
// 12/10 = 1
// 1%10 = 1
// 1/10 = 0
int GetNumber()
{
    int number = new Random().Next(1,99999999);
    return number;
}

int number = GetNumber();
Console.WriteLine($"Выпало число {number}");
int ostatokTen = 0;

while (number != 0)
{
    ostatokTen = number % 10 + ostatokTen;
    int celoeTen = number / 10;
    number = celoeTen;
}

Console.WriteLine($"Сумма цифр в числе = {ostatokTen}");