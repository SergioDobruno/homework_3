// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.WriteLine ("введите 5-ти значное число: ");

// string num = Console.ReadLine();

// int len = num.Length;

// if (len == 5)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {
//         System.Console.WriteLine($"число {num} является Палиндромом");
//     }
//     else
//     {
//         System.Console.WriteLine($"число {num} не является Палиндромом");
//     }
// }
// else
// {
// System.Console.WriteLine("Ошибка! Условие ввода не выполнено");
// }




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.WriteLine("Введите координаты xA: ");
int xA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координаты yA: ");
int yA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координаты zA: ");
int zA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты xB: ");
int xB = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координаты yB: ");
int yB = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координаты zB: ");
int zB = int.Parse(Console.ReadLine());

double LengthAB = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

System.Console.WriteLine($"Расстояние между A и B равно {LengthAB}");

