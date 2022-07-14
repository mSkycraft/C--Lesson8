//Задача 54

//Размер матриц для задач
int x = 3;
int y = 4;

int[,] sort (int[,] mas){
    
    for(int i=0;i<mas.GetLength(0);i++)
        for(int j=0;j<mas.GetLength(1);j++)
            {
                for(int k=0; k < mas.GetLength(1)-1;k++)
                    {
                        if(mas[i,k]<mas[i,k+1])
                        {
                            int buf = mas[i,k+1];
                            mas[i,k+1] = mas[i,k];
                            mas[i,k] = buf;
                        }
                    }
            }
    return mas;
}

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
Console.WriteLine();
Console.WriteLine("Задача 54");

int[,] mas = new int[x,y];
mas = initmas(mas);
Console.WriteLine("Массив не сортированный");
printmas(mas);
Console.WriteLine("Массив отсортированный");
printmas(sort(mas));
Console.WriteLine("Задание завершено");