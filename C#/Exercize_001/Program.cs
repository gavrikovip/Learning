// Даны два числа. Показать большее и меньшее число


Console.WriteLine("Введите первое число");
string? numberFirst = Console.ReadLine();
int numberOne = int.Parse(numberFirst);

Console.WriteLine("Введите второе число");
string? numberSecond = Console.ReadLine();
int numberTwo = int.Parse(numberSecond);

if (numberOne == numberTwo) 
    Console.Write("Числа одинаковые");

else if (numberOne > numberTwo) 
    Console.WriteLine($"{numberOne} большее, {numberTwo} меньшее");

else Console.WriteLine($"{numberTwo} большее, {numberOne} меньшее");