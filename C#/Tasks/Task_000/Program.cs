// Вывести квадрат числа

// Выводим на консоль сообщение
Console.WriteLine("Введите число->");

string? numberStr = Console.ReadLine();

int number = int.Parse(numberStr);

Console.WriteLine($"Квадрат числа: {number * number}");