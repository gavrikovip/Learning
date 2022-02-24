// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

int b1 = 4;
int b2 = 1;
int k1 = 5;
int k2 = 2;

// k1x + b1 = k2x + b2
// x = (b1 - b2) / (k2 - k1)
// 

if (k2 == k1)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    double x = (b1 - b2) / (k2 - k1);
    Console.Write($"x = {x}, ");
    double y = k1*x + b1;
    Console.Write($"y = {y}");
}