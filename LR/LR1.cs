
// // Задание 1
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите первое число: ");
//         int num1 = int.Parse(Console.ReadLine());

//         Console.Write("Введите второе число: ");
//         int num2 = int.Parse(Console.ReadLine());

//         double average = (num1 + num2) / 2.0; // Среднее арифметическое
//         Console.WriteLine("Среднее арифметическое: " + average);
//     }
// }

// //задание 2
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите коэффициент a: ");
//         double a = double.Parse(Console.ReadLine());

//         Console.Write("Введите коэффициент b: ");
//         double b = double.Parse(Console.ReadLine());

//         Console.Write("Введите коэффициент c: ");
//         double c = double.Parse(Console.ReadLine());

//         double D = b * b - 4 * a * c;

//         if (D > 0)
//         {
//             double x1 = (-b + Math.Sqrt(D)) / (2 * a);
//             double x2 = (-b - Math.Sqrt(D)) / (2 * a);
//             Console.WriteLine($"Корни уравнения: x1 = {x1}, x2 = {x2}");
//         }
//         else
//         {
//             Console.WriteLine("Дискриминант меньше или равен нулю, решение невозможно.");
//         }
//     }
// }


// //задание 3
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите коэффициент a: ");
//         double a = double.Parse(Console.ReadLine());

//         Console.Write("Введите коэффициент b: ");
//         double b = double.Parse(Console.ReadLine());

//         Console.Write("Введите коэффициент c: ");
//         double c = double.Parse(Console.ReadLine());

//         double D = b * b - 4 * a * c;

//         if (D > 0)
//         {
//             double x1 = (-b + Math.Sqrt(D)) / (2 * a);
//             double x2 = (-b - Math.Sqrt(D)) / (2 * a);
//             Console.WriteLine($"Корни уравнения: x1 = {x1}, x2 = {x2}");
//         }
//         else
//         {
//             Console.WriteLine("Дискриминант меньше или равен нулю, решение невозможно.");
//         }
//     }
// }

// //задание 4
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите трехзначное число: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number >= 100 && number <= 999)
//         {
//             int hundreds = number / 100;
//             int tens = (number / 10) % 10;
//             int ones = number % 10;

//             Console.WriteLine($"Сотни: {hundreds}, Десятки: {tens}, Единицы: {ones}");
//         }
//         else
//         {
//             Console.WriteLine("Введено не трехзначное число.");
//         }
//     }
// }


// //задание 5
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите первый угол треугольника: ");
//         double angle1 = double.Parse(Console.ReadLine());

//         Console.Write("Введите второй угол треугольника: ");
//         double angle2 = double.Parse(Console.ReadLine());

//         double angle3 = 180 - (angle1 + angle2); // Третий угол

//         if (angle1 > 0 && angle2 > 0 && angle3 > 0)
//         {
//             if (angle1 == 90 || angle2 == 90 || angle3 == 90)
//             {
//                 Console.WriteLine("Треугольник прямоугольный.");
//             }
//             else
//             {
//                 Console.WriteLine("Треугольник не является прямоугольным.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Треугольник не существует.");
//         }
//     }
// }


// //Задание 6

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите температуру воды: ");
//         double temperature = double.Parse(Console.ReadLine());

//         if (temperature <= 0)
//         {
//             Console.WriteLine("Вода в твердом состоянии (лед).");
//         }
//         else if (temperature >= 100)
//         {
//             Console.WriteLine("Вода в газообразном состоянии (пар).");
//         }
//         else
//         {
//             Console.WriteLine("Вода в жидком состоянии.");
//         }
//     }
// }



// //задание 7
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число: ");
//         int num = int.Parse(Console.ReadLine());

//         if (num % 2 == 0)
//         {
//             Console.WriteLine("Число четное.");
//         }
//         else
//         {
//             Console.WriteLine("Число нечетное.");
//         }
//     }
// }


// //задание 8

// using System;
// class Program
// {
//     static void Main()
//     {
//         // 5 + 3^2 - 18 * 4 + (120 / 5)
//         double result1 = 5 + Math.Pow(3, 2) - 18 * 4 + (120 / 5.0);
//         Console.WriteLine("Результат выражения 5 + 3^2 - 18 * 4 + (120 / 5) = " + result1);
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         // 25.5 + 4.2^2 - (125 / 5)
//         double result2 = 25.5 + Math.Pow(4.2, 2) - (125 / 5.0);
//         Console.WriteLine("Результат выражения 25.5 + 4.2^2 - (125 / 5) = " + result2);
//     }
// }

// // задание 9
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите первое число: ");
//         double num1 = double.Parse(Console.ReadLine());

//         Console.Write("Введите второе число: ");
//         double num2 = double.Parse(Console.ReadLine());

//         double power = Math.Pow(num1, num2);
//         double division = power / num1;
//         double remainder = num1 % (int)num2;

//         Console.WriteLine($"Число {num1} в степени {num2}: {power}");
//         Console.WriteLine($"Результат деления: {division}");
//         Console.WriteLine($"Остаток от деления: {remainder}");
//     }
// }


// // задание 10
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите первое число: ");
//         double num1 = double.Parse(Console.ReadLine());

//         Console.Write("Введите второе число: ");
//         double num2 = double.Parse(Console.ReadLine());

//         double regularDivision = num1 / num2;
//         int integerDivision = (int)(num1 / num2);

//         Console.WriteLine($"Обычное деление: {regularDivision}");
//         Console.WriteLine($"Целочисленное деление: {integerDivision}");
//     }
// }


// //задание 11
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите дробное число: ");
//         double decimalNumber = double.Parse(Console.ReadLine());

//         Console.Write("Введите целое число: ");
//         int integerNumber = int.Parse(Console.ReadLine());

//         double remainder = decimalNumber % integerNumber;

//         Console.WriteLine($"Остаток от деления {decimalNumber} на {integerNumber}: {remainder}");
//     }
// }
