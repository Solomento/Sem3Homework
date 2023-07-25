/*//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int Step(int A, int B)
{
    int result = 1;
    for(int i = 0; i < B; i++)
        result *= A;
    return result;
}

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

int C = Step(A, B);
Console.Write($"A в степени B: {C}"); */

/*//Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.

int NumLen(int num)
{
    int index = 0;
    while(num > 0)
    {
        num /= 10;
        index++;
    }
    return index;
}

int NumSum(int num, int len)
{
    int sum = 0;
    for(int i = 0; i < len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;    
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int len = NumLen(num);
Console.Write($"Сумма цифр числа {num}: {NumSum(num, len)}");*/

/*//Напишите программу, которая задаёт массив из m элементов
  //и выводит их на экран. Разработать метод 
  //CreateArray(int size), генерирующий массив на основе данных,
  //вводимых пользователем.

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] array = new int[elementsCount];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите цифру числа по порядку {i}: ");
    array[i] = int.Parse(Console.ReadLine());
}
ShowArray(array);*/
