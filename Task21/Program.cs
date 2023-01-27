// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты Ax: ");
Double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Ay: ");
Double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Az: ");
Double Az = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Bx: ");
Double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты By: ");
Double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Bz: ");
Double Bz = Convert.ToDouble(Console.ReadLine());

Double distance = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));

Console.WriteLine($"Расстояние между двумя точками в 3D пространстве - {distance}");