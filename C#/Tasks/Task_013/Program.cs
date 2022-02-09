// Выяснить, кратно ли число заданному. Если нет, то вывести остаток

int GetNumber()
{
    return new Random().Next(20, 100);
}

int constNumber = GetNumber();
int number = GetNumber();
//Console.WriteLine(number);
int ostatok = number % constNumber;

if (ostatok == 0 )
    Console.WriteLine($"{number} кратно {constNumber}");
else
    Console.WriteLine($"Остаток от деления {number} на {constNumber} равен {ostatok}");