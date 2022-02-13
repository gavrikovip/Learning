//Найти расстояние между точками в пространстве 2D/3D

int Input(string msg)
{
    Console.Write(msg);
    string num1 = Console.ReadLine();
    return int.Parse(num1);
}

void GetCoordination2D(int x1, int y1, int x2, int y2)
{
    double merge = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
    Console.WriteLine(merge);;
}

void GetCoordination3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double merge = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    Console.WriteLine(merge);;
}

int prostranstvo = 0;
while (prostranstvo != 1 && prostranstvo !=2)
{
prostranstvo = Input("Выберите про странство: 1. 2D, 2. 3D\n");
}

if (prostranstvo == 1)
    {
        int x1 = Input("x1:=");
        int y1 = Input("y1:=");
        int x2 = Input("x2:=");
        int y2 = Input("y2:=");
        GetCoordination2D(x1, y1, x2, y2);
    }
    else
        {
            if (prostranstvo == 2)
                {
                    int x1 = Input("x1:=");
                    int y1 = Input("y1:=");
                    int z1 = Input("z1:=");
                    int x2 = Input("x2:=");
                    int y2 = Input("y2:=");
                    int z2 = Input("z2:=");
                    GetCoordination3D(x1, y1, z1, x2, y2, z2);
                }
        }

