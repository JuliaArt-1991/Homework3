// Сбор черники

Console.Clear();
Console.Write("Введите количество элементов массива от 3 до 1000: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = new Random().Next(1,1001);
}
Console.WriteLine("\nМассив: {0}",String.Join(" ",arr));
int sum = 0, maxsum=0;
for (int i =0; i < n-2; i++)
{
    sum = arr[i]+arr[i+1]+arr[i+2];
    if ( sum > maxsum)
    {
        maxsum = sum;
    }
}
Console.WriteLine(maxsum);