//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
/*
int num, units, sum = 0, mun;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num > 9999 && num < 100000)
{
for(mun = num; num != 0; num = num / 10)
    {
    units = num % 10;
    sum = sum * 10 + units;
    }
    if(mun == sum)
    Console.Write($"{mun} является палиндромом.");
    else
    Console.Write($"{mun} не является палиндромом.");
} 
else
Console.Write("Введите пятизначное число!");
*/

//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.

/*
double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
int deltax = x2 - x1;
int deltay = y2 - y1;
int deltaz = z2 - z1;
return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
}

Console.Write("Введите координату X точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Растояние между точками A и B равно {dis(x1, y1, z1, x2, y2, z2):F2} ");
*/


//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

/*
void Qub(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} - {count*count*count}");
        count++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов:\n");
Qub(num);
*/



/*
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов:\n");
for (int i = 1; i <= n; i++)
{
int k = i*i*i;
Console.Write($"{k}, ");
}
*/

