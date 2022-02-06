// Найти максимальное из трех чисел

Console.WriteLine("Введите первое число");
string? numberFirst = Console.ReadLine();
int numberOne = int.Parse(numberFirst);

Console.WriteLine("Введите второе число");
string? numberSecond = Console.ReadLine();
int numberTwo = int.Parse(numberSecond);

Console.WriteLine("Введите третье число");
string? numberThird = Console.ReadLine();
int numberThree = int.Parse(numberThird);

int max = numberOne;

if (numberOne >= numberTwo)
    max = numberOne;
    else if (numberTwo >= numberThree)
        max = numberTwo;
        else
            max = numberThree;

Console.WriteLine($"{max} максимальное число");
