// Дано число обозначающее день недели. Выяснить является номер дня выходным.

int Nomer()
{
    return new Random().Next(1,32);
}

int nomer = Nomer();

if (nomer % 7 == 6 || nomer % 7 == 0)
    Console.WriteLine($"Номер {nomer} выпадает на выходной день.");
else
{
    Console.WriteLine($"Номер {nomer} не выпадает на выходной день.");
}