// Показать четные числа от 1 до N

Console.WriteLine("Введите число");
string? numberum = Console.ReadLine();
int number = int.Parse(numberum);
int i = 1;

while (i <= number) {
    if (i %2 == 0) {
    Console.Write($"{i} ");
    i++;
    }
    else {
       i++;
    }
}