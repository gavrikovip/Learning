//Найти кубы чисел от 1 до N

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{i+1} в кубе = {arr[i]}");
    }
}

int[] InitArray(int number)
{
    int [] array = new int[number]; 
    for (int i = 0; i < number; i++)
    {
        array[i] = (i+1)*(i+1)*(i+1);
    }
    return array;
}

int coin = new Random().Next(1,50);

int [] a = InitArray(coin);
PrintArray(a);