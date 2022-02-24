// Написать программу масштабирования фигуры
using System.Text;

string strValue = "(0,2) (2,3) (1,0) (2,2)";
Console.WriteLine("Введите множитель");
double k = double.Parse(Console.ReadLine());

// Убираем скобки и запятые
strValue = strValue.Replace("(", "").Replace(")", "").Replace(",", " ");


// Создание массива на базе строки
string[] strArray = strValue.Split();

// Вывод массива без лишних символов
foreach (var item in strArray)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

//Использование StringBuilder для сохранения оперативной памяти при создании строки с множителем
StringBuilder newString = new StringBuilder();

for (int i = 0; i < strArray.Length - 1; i = i + 2)
{
    double x = k * int.Parse(strArray[i]);
    double y = k * int.Parse(strArray[i + 1]);
    newString.Append($"({x}, {y}) ");
}

Console.WriteLine(newString);

