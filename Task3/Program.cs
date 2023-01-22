// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m, sum = 0;
int temp = n;
while (n > 0)
{
    m = n % 10;
    sum = (sum * 10) +m;
    n = n /10;
}
if (temp == sum)
{
    Console.WriteLine("Палиндром");
}
else
{ 
    Console.WriteLine("Не палиндром");
}
