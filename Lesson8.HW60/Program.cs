//Задача 60

Console.WriteLine();
Console.WriteLine("Задача 60");

int noRepeat(int[,,] mas,int x,int y,int z){
    Random rnd = new Random();
    while(true)
    {
        bool flagR = true;
        int newRnd = rnd.Next(10,99);
        for(int i=0;i<x+1;i++)
        {
            for(int j=0;j<y+1;j++)
            {
                for(int k=0;k<z+1;k++)
                {
                    if(newRnd==mas[i,j,k])
                        flagR = false;
                }
            }
        }
        if(flagR==true)
            {
                return newRnd;
            }
    }
    return 0;
}


int[,,] initmas3d(int[,,] mas){

    for(int i=0;i<mas.GetLength(0);i++)
    {
        for(int j=0;j<mas.GetLength(1);j++)
        {
            for(int k=0;k<mas.GetLength(2);k++)
            {
                mas[i,j,k]= noRepeat(mas,i,j,k);
            }
        }
    }
    return mas;
}

void printmas3d(int[,,] mas)
{
    for(int i=0;i<mas.GetLength(0);i++)
    {
        for(int j=0;j<mas.GetLength(1);j++)
        {
            for(int k=0;k<mas.GetLength(2);k++)
            {
                Console.Write("["+i+","+j+","+k+"]="+mas[i,j,k]+ "  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int[,,] mas3 = new int[3,4,2];
mas3 = initmas3d(mas3);
Console.WriteLine("Массив");
printmas3d(mas3);
Console.WriteLine("Задача завершена");