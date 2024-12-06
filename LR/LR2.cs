// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число: ");
//         double number = Convert.ToDouble(Console.ReadLine());

//         if (number > 0)
//         {
//             Console.WriteLine(1);
//         }
//         else
//         {
//             Console.WriteLine(-1);
//         }
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите первое вещественное число: ");
//         double num1 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Введите второе вещественное число: ");
//         double num2 = Convert.ToDouble(Console.ReadLine());

//         double max = (num1 > num2) ? num1 : num2;

//         Console.WriteLine($"Наибольшее число: {max}");
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите первое число: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите второе число: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите третье число: ");
//         int num3 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите четвертое число: ");
//         int num4 = Convert.ToInt32(Console.ReadLine());

//         int max = Math.Max(Math.Max(num1, num2), Math.Max(num3, num4));

//         Console.WriteLine($"Максимальное число: {max}");
//     }
// }


// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите свой возраст: ");
//         int age = Convert.ToInt32(Console.ReadLine());

//         if (age >= 0 && age <= 2)
//         {
//             Console.WriteLine("Младенец");
//         }
//         else if (age >= 3 && age <= 6)
//         {
//             Console.WriteLine("Дошкольник");
//         }
//         else if (age >= 7 && age <= 12)
//         {
//             Console.WriteLine("Юноша");
//         }
//         else if (age >= 13 && age <= 24)
//         {
//             Console.WriteLine("Молодой человек");
//         }
//         else if (age >= 25 && age <= 39)
//         {
//             Console.WriteLine("В расцвете сил");
//         }
//         else if (age >= 40 && age <= 59)
//         {
//             Console.WriteLine("Пожилой человек");
//         }
//         else if (age >= 60)
//         {
//             Console.WriteLine("Старый и немощный");
//         }
//         else
//         {
//             Console.WriteLine("Некорректный возраст");
//         }
//     }
// }
