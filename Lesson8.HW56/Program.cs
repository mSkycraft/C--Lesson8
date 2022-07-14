//Задача 54

//Размер матриц для задач
int x = 3;
int y = 4;

// Задача 56
Console.WriteLine();
Console.WriteLine("Задача 56");

void printmas(int[,] mas){
    for(int i=0;i<mas.GetLength(0);i++)
    {
        for(int j=0;j<mas.GetLength(1);j++)
        {
            Console.Write(mas[i,j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] initmas(int[,] mas){
    Random rnd = new Random();
    for(int i=0;i<mas.GetLength(0);i++)
    {
        for(int j=0;j<mas.GetLength(1);j++)
        {
            mas[i,j]= rnd.Next(1,10);
        }
    }
    return mas;
}

int[,] mas = new int[x,y];
mas = initmas(mas);

int minstr(int[,] mas)
{
    int sumlen = 0;
    int minid = 0;
    int minsum = 0;
    for(int i=0;i<mas.GetLength(0);i++)
    {
        sumlen = 0;
        for(int j=0;j<mas.GetLength(1);j++)
            {
                sumlen += mas[i,j];
            }
        if(i == 0)
            minsum = sumlen;
        else
            if(minsum>sumlen)
            {
                minid = i;
                minsum = sumlen;
            }
    }
    return minid+1;
}
printmas(mas);
Console.WriteLine("Строка с минимальной суммой равна - "+ minstr(mas));
Console.WriteLine("Задача завершена");