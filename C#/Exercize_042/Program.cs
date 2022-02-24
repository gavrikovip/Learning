// Определить сколько чисел больше 0 введено с клавиатуры

// Метод для введения числа

double NumberAtKeyboard()
{
    Console.WriteLine("ВВедите число от -100 до 100");
    double number = double.Parse(Console.ReadLine());
    return number;
}


// Метод количества введений числа
int sum = 0;
void Input(int num)
{
    while (num != 0)
    {
        if (NumberAtKeyboard() > 0)
        {
            num--;
            sum = sum + 1;
        }
        else
            num--;
    }
}



Console.WriteLine("Сколько чисел хотите ввести? Напечатайте цифру, иначе программа не продолжит работу :)");
int count = int.Parse(Console.ReadLine());
Input(count);
Console.WriteLine($"Количество положительных чисел = {sum}");
