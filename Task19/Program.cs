//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число");

int n = Convert.ToInt32(Console.ReadLine());

string str = n.ToString();

if (str.Length == 5)
{
    string n1 = str.Substring(0, 2);
    char[] chars = str.Substring(3, 2).ToCharArray();
    Array.Reverse(chars);
    string n2 = string.Join("", chars);
    if (n1 == n2)
    {
        Console.WriteLine($"Число {str} - палиндром");
    }
    else
    {
        Console.WriteLine($"Число {str} - не палиндром");
    }
}
else
{
    Console.WriteLine($"Число {str} - не пятизначное");
}