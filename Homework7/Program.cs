/*//Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.

void mas(int m, int n)
{
    double[,] randomArray = new double[m,n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
    Console.WriteLine();
        for (int j = 0; j < n; j++)
        {
        randomArray[i,j] = (double)rand.Next(-100,100)/10;
        Console.Write(randomArray[i,j] + "\t");
        }

    }

}

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

mas(m,n);*/



/*// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.


void mas(double[,] randomArray, int rows, int colums)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
    Console.WriteLine();
        for (int j = 0; j < colums; j++)
        {
        randomArray[i,j] = (double)rand.Next(-100,100)/10;
        Console.Write(randomArray[i,j] + "\t");
        }

    }

}
void FindValue(double[,] array, int rows, int colums, int iUser, int jUser)
{
    if(iUser < 0 || jUser < 0) Console.Write("Значение индексов не могут быть отрицательными! \t");
    if(iUser <= rows-1 && jUser <= colums-1) Console.Write($"Значение элемента в ячейке с заданными индексами {iUser}, {jUser}: {array[iUser,jUser]:F1}");
    else Console.Write("Такого элемента в массиве нет!");
}


Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];
mas(randomArray, m, n);
Console.WriteLine("\n");

Console.Write("Введите индекс строки: ");
int iUser = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int jUser = Convert.ToInt32(Console.ReadLine());

FindValue(randomArray, m, n, iUser, jUser);

// if(iUser < 0 || jUser < 0) Console.Write("Значение индексов не могут быть отрицательными! \t");
// if(iUser <= m-1 && jUser <= n-1) Console.Write($"Значение элемента в ячейке с заданными индексами {iUser}, {jUser}: {randomArray[iUser,jUser]:F1}");
// else Console.Write("Такого элемента в массиве нет!");*/


//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


/*//Мой метод

void mas(int[,] array, int rows, int colums)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < colums; j++)
        {
        array[i,j] = rand.Next(1,9);
        Console.Write(array[i,j] + "\t");
        }

    }

}

void Avg(int[,] array)                                                                  
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        //Console.Write($"{array.GetLength(1)} \n");
        Console.Write($"{sum / array.GetLength(0):F1} \t"); //если нужно найти среднее арифметическое столбца, надо делить на количество строк(НЕ СТОЛБЦОВ!!!)
    }
}


Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

mas(randomArray, m, n);
Console.WriteLine("\n");

Avg(randomArray);*/



/*//Метод из интернета

Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
    Console.WriteLine();
        for (j = 0; j < n; j++)
        {
        randomArray[i,j] = rand.Next(1,9);
        Console.Write($"{randomArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void arif(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i,j;
    Random rand = new Random();
    for (j = 0; j < n; j++)
    {
        double sum = 0;
        for (i = 0; i < m; i++)
        {
        sum = sum + randomArray[i,j];
        }
        Console.Write($"{sum/(i):F1}; ");
    }
}

mas(m,n);

arif(m,n);*/