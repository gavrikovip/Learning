// Выяснить является ли число четным

Console.WriteLine("Введите число");
string? numberum = Console.ReadLine();
int number = int.Parse(numberum);

if (number %2 == 0)
    Console.WriteLine($"{number} четное число");
    else
        Console.WriteLine($"{number} нечетное число");