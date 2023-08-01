/*//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

double Positiv(double[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0)
            count++;
        }
    return count;
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
Console.Write("Клличество положительных цифр: " + Positiv(array));*/

/*//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"\n Точка пересечения двух прямых: [{Math.Round(x,2)},{Math.Round(y,2)}]");*/