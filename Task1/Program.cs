// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n/n;
while (m < n + 1) {
Console.Write($"{Math.Pow(m, 3)} ");
m = m +1;
}