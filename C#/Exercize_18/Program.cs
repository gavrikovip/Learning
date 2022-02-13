// Проверить истинность утверждения не(X или Y) = не X и не Y

//bool x = true;
//bool y = true;

bool [] arrX = {true, true, false, false};
bool [] arrY = {true, true, false, false};
int coin = 0;

for (int i = 0; i < arrX.Length; i++)
    {
        for (int j = 0; j < arrY.Length; j++)
        if ((!(arrY[i] | arrX[i])) == (!arrX[i] && !arrY[i]))
        coin = coin + i;
    
    else
    coin = 0;
    }

/*void PrintArray(int [] arr)
{
    (for int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

string [] ArrayInit()
{
    string [] arr = new Array[];
    (for int i = 0; i < 1; i++)
    {
        arr[i] = true;
    }
    (for int i = 2; i < 3; i++)
    {
        arr[i] = false;
    }
    return arr;
}

string[] logic = ArrayInit();
PrintArray(logic); */

if (coin != 0)
{
    Console.WriteLine("Утверждение в задании верно");
}
//Console.WriteLine(!(x | y));
//Console.WriteLine(!x && !y);
