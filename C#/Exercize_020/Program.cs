// Задать номер четверти, показать диапазоны для возможных координат

int Input(string msg)
{
    Console.WriteLine(msg);
    string num1 = Console.ReadLine();
    return int.Parse(num1);
}

int number = Input("Выберите номер четверти. Варианты 1, 2, 3, 4");

void NumberFinish(int number)
{
    while (number < 1 | number > 4)
    {
        Console.WriteLine("Повнимательнее к варинтам");
        number = Input("Выберите номер четверти. Варианты 1, 2, 3, 4");
    }   
        if (number == 1)
        {
        Console.WriteLine("Координаты точки x и y > 0"); 
        }
        else 
            if (number == 2)
            {
                Console.WriteLine("Координаты точки x > 0, а y < 0");
            }
            else
                if (number == 3)
                {
                    Console.WriteLine("Координаты точки x и y < 0");
                }
                    else
                        Console.WriteLine("Координаты точки x < 0, а y > 0");
}
NumberFinish(number);