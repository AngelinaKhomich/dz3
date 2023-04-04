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
