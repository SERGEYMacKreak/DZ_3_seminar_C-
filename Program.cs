// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введи пятизначное число: ");
// int nomber = Convert.ToInt32(Console.ReadLine());
// string nomberText = Convert.ToString(nomber);
// if (nomber >= 10000 && nomber < 100000)
//   {
//     if  (nomberText [0] == nomberText [4] && nomberText [1] == nomberText [3])
//     {
//       Console.WriteLine("является палиндромом");
//     }
//     if (!(nomberText [0] == nomberText [4] && nomberText [1] == nomberText [3]))
//     {
//       Console.WriteLine("НЕ является палиндромом");
//     }
//   }
// else
// {
//   Console.WriteLine("Ввели НЕ пятизначное число");
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите число x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine()); // string text_x1 = Console.ReadLine(); // int x1 = Convert.ToInt32(text_x1);
// Console.Write("Введите число y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// double x = Math.Pow((x1 - x2), 2);
// double y = Math.Pow((y1 - y2), 2);
// double b = Math.Pow((b1 - b2), 2);
// double AB = Math.Sqrt((x + y + b));

// либо 
// double AB = Math.Sqrt(((Math.Pow((x1 - x2), 2)) + (Math.Pow((y1 - y2), 2)) + (Math.Pow((b1 - b2), 2))));

// Console.WriteLine($"Расстояние между точками А и В: {AB:f2}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// первый способ
// Console.Write("Введи число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string nText = Convert.ToString(n);
// double i = 1;
// double x = 0;
// while (i <= n)
// {
//   x = Math.Pow(i, 3); // либо x = i * i * i;
//   Console.Write(x + ", ");
//   i++;
// }

// второй способ
// Console.WriteLine("Введите число: ");
// int W = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= W; Console.Write(i * i * i + ", "), i++);