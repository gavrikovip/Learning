// Найти третью цифру числа или сообщить, что ее нет

int GetNumber()
{
    return new Random().Next(1, 999999999);
}

int number = GetNumber();

Console.WriteLine(number);

string mynumber = number.ToString();

if (mynumber.Length >=3)
    Console.WriteLine(mynumber[2]);
else
    Console.WriteLine("Нет третьей цифры в числе");