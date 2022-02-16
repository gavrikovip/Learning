// Показать кубы чисел, заканчивающихся на четную цифру

// {1,2,3,4,5}
// {1,8,27,64,125}
// a[i]%2 = 0

int[] ArrayInit(int number)
{
    int[] arr = new int[number];
    Random randomNumber = new Random();
    //foreach( int item in arr)
    for (int i = 0; i < arr.Length; i++)
    {
        //item = randomNumber.Next(1, 999);
        arr[i] = randomNumber.Next(1, 11);
    }
    return arr;
}

void PrintArray(int[] array)
{
    foreach(int item in array)
    Console.Write(item + " ");
}

void PrintArrayCube(int[] array)
{
    foreach(int item in array)
    {
        if (item % 2 == 0)
        {
            Console.Write(item + " ");
        }
    }
}


int[] ArrayCube(int[] array)
{
    //foreach(int item in array)
    for (int i = 0; i < array.Length; i++)
    {
        //item = item*item*item;
        array[i] = array[i] * array[i] * array[i];
    }
    return array;
}

int[] array = ArrayInit(10);

Console.WriteLine("Заданы числа");
PrintArray(array);


int[] arrayCube = ArrayCube(array);


Console.WriteLine("");
Console.WriteLine("Из них кубы чисел кратные двум");
PrintArrayCube(arrayCube);
