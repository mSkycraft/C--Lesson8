// Задача 62

void printmas(int[,] mas){
    for(int i=0;i<mas.GetLength(0);i++)
    {
        for(int j=0;j<mas.GetLength(1);j++)
        {
            Console.Write(" {0,-2} ",mas[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine("Задача 62");

int[,] initmasZ(int[,] mas){
    Random rnd = new Random();
    for(int i=0;i<mas.GetLength(0);i++)
    {
        for(int j=0;j<mas.GetLength(1);j++)
        {
            mas[i,j]= 0;
        }
    }
    return mas;
}
int[,] masZ = new int[5,5];
masZ = initmasZ(masZ);

int[,] loadmas(int[,] mas){
    int count = 1;
    int i = 0;
    int j = 0;
    int step = 0;
    int sizeX = mas.GetLength(0);
    int sizeY = mas.GetLength(1);
    int chet = sizeX%2;
    while(count<sizeX*sizeY+chet)
    {
        while(j<sizeY-1-step)
        {
            mas[i,j] = count;
            count++;
            if(j==sizeY-1-step) break;
            j++;
            
            if(count==sizeX*sizeY)
            {
                mas[i,j] = count;
                count++;
            }
        }
        while(i<sizeX-1-step)
        {
            mas[i,j] = count;
            count++;
            if(i==sizeX-1-step) break;
            i++;
        }
        while(j>step)
        {
            mas[i,j] = count;
            count++;
            if(chet==0)
                if(j-1==step) 
                {
                    j--;
                    mas[i,j] = count;
                    break;
                }
            else
                if(j-1<step) break;
            j--;
        }
        step++;
        while(i>step)
        {
            mas[i,j] = count;
            count++;
            if(i-1<step) break;
            i--;
        }
    }
    return mas;
}
masZ = loadmas(masZ);
printmas(masZ);