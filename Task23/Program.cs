// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n]; ;
for (int i = 1; i <= n; i++)
{
    numbers[i - 1] = Convert.ToInt32(Math.Pow(i, 3));
}
Console.WriteLine("{0}", string.Join(", ", numbers));
