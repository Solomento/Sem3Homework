//Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.

double[,] CreateRandom2DArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().NextDouble(minValue, maxValue + 1);
    }
    return array;
}

void Show2DArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "  ");
        Console.WriteLine();
    }
}

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
double max = Convert.ToDouble(Console.ReadLine());

double[,] myArray = CreateRandom2DArray(rows, columns, min, max);
Show2DArray(myArray);
