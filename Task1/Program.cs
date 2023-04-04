/*Задача 19
Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом. Через строку решать нельзя.*/
Console.WriteLine("Введите целое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);
void Palindrom(int number)
{
   int  x = number/1000;
   int  y = number%100;
   int  r = 0;
    while (y > 0)
    {
        r *= 10;
        r += y %10;
        y /= 10;
        }
    if(x==r)
    {
        Console.WriteLine("Данное число является полиндромом");
    }
    else
    {
        Console.WriteLine("Данное число не является полиндромом");
    }
    
}

/*Задача 21

Напишите программу, которая принимает на вход координаты
 двух точек и находит расстояние между ними в 3D пространстве.*/

Console.Write("Введите координату x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2:");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Round(koord(x1,x2,y1,y2,z1,z2),2));
double koord( int x1, int x2 , int z1, int z2, int y1, int y2)
{
  double dist = 0;
  dist = Math.Sqrt( (x2 - x1)*(x2 - x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1 ));
  return dist;
  
};

/*Задача 23

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N. */

string  Cub(int number, string res = "1")
{
   
    if(number <= 0)
    {
        return "Вы ввели неправильное число!";
    }

    int i = 2;    
    while(i <= number)
    {
        res =  res + ", " + Convert.ToString(i*i*i);
        i++;
    }
    return res;
}

try
{
    Console.Write("Введите N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Cub(number));
}
catch
{
    Console.WriteLine("Ввели неправильные данные");
}