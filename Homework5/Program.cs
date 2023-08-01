/*//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

int ChetNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        {
        if (array[i] % 2 == 0)
            count++;
        }
    return count;
}


Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
Console.Write("Четных чисел в массиве: " + ChetNumbers(myArray));*/

/*//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

int Sum(int[] array)
{
    int sumArray = 0;
    for(int i = 1; i < array.Length; i += 2)
        sumArray += array[i];
    return sumArray;

} 

Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
Console.Write("Сумма нечетных позиций в массиве: " + Sum(myArray));*/

/*//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным 
//элементов массива.

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

double MinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
        {
            if(max < array[i])
                max = array[i];
            if(min > array[i])
                min = array[i];
        }
    return max - min;
}

Console.Write("Введите размер массива: ");
int elementsCount = int.Parse(Console.ReadLine());
double[] array = new double[elementsCount];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите цифру числа по порядку {i}: ");
    array[i] = double.Parse(Console.ReadLine());
}

ShowArray(array);
Console.Write("Разница между максимальным и минимальным значинием массива: " + Math.Round(MinMax(array),2));*/