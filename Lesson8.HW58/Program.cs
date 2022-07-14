int x = 3;
int y = 4;

//Задача 58

Console.WriteLine();
Console.WriteLine("Задача 58");

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

int[,] proizvedenie(int[,] mas,int[,] mas2){
    int[,] result = new int[mas.GetLength(0),mas.GetLength(1)];
    for(int i=0;i<mas.GetLength(0);i++)
    {
        for(int j=0;j<mas.GetLength(1);j++)
        {
            result[i,j]= mas[i,j]*mas2[i,j];
        }
    }
    return result;
}

int[,] mas = new int[x,y];
int[,] mas2 = new int[x,y];
mas = initmas(mas);
mas2 = initmas(mas2);
Console.WriteLine("Массив 1");
printmas(mas);
Console.WriteLine("Массив 2");
printmas(mas2);
Console.WriteLine("Произведение массивов");
printmas(proizvedenie(mas,mas2));
Console.WriteLine("Задача завершена");