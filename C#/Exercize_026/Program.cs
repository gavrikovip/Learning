// Возведите число А в натуральную степень B используя цикл

int GetNumber(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberA = GetNumber("Введите число А: ");
int numberB = GetNumber("Введите число B: ");
int numberFirstA = numberA;
for (int i = 1; i < numberB; i++)
{
    numberA *= numberFirstA; 
}

Console.WriteLine($"Число {numberFirstA} в степени {numberB} = {numberA}");