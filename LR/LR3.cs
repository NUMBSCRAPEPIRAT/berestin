// // задача 1
// using System;

// class Program
// {
//     static void Main()
//     {
//         int sum = 0;
//         for (int i = 1; i <= 100; i++)
//         {
//             sum += i;
//         }
//         Console.WriteLine("Сумма чисел от 1 до 100: " + sum);
//     }
// }



// // задача 2
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число: ");
//         int a = int.Parse(Console.ReadLine());
//         long factorial = 1;

//         for (int i = 1; i <= a; i++)
//         {
//             factorial *= i;
//         }

//         Console.WriteLine($"Факториал числа {a} равен: {factorial}");
//     }
// }




// // задача 3
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите количество элементов ряда Фибоначчи: ");
//         int n = int.Parse(Console.ReadLine());

//         int a = 1, b = 1;

//         Console.WriteLine("Ряд Фибоначчи:");
//         for (int i = 1; i <= n; i++)
//         {
//             Console.Write(a + " ");
//             int next = a + b;
//             a = b;
//             b = next;
//         }
//     }
// }



// // задача 4
// using System;

// class Program
// {
//     static void Main()
//     {
//         Random random = new Random();
//         int number = random.Next(1, 101);  // Загадать число от 1 до 100

//         Console.WriteLine("Загадано число от 1 до 100. Попробуйте угадать. Для выхода введите 'exit'.");

//         while (true)
//         {
//             Console.Write("Введите ваше предположение: ");
//             string input = Console.ReadLine();

//             if (input.ToLower() == "exit")
//             {
//                 Console.WriteLine("Выход из игры.");
//                 break;
//             }

//             int guess = 0;
//             if (int.TryParse(input, out guess))
//             {
//                 if (guess < number)
//                 {
//                     Console.WriteLine("Загаданное число больше.");
//                 }
//                 else if (guess > number)
//                 {
//                     Console.WriteLine("Загаданное число меньше.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Поздравляю, вы угадали!");
//                     break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Некорректный ввод. Попробуйте снова.");
//             }
//         }
//     }
// }



// // задача 5
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите первое число: ");
//         int a = int.Parse(Console.ReadLine());
//         Console.Write("Введите второе число: ");
//         int b = int.Parse(Console.ReadLine());

//         while (a != b)
//         {
//             if (a > b)
//                 a -= b;
//             else
//                 b -= a;
//         }

//         Console.WriteLine("Наибольший общий делитель: " + a);
//     }
// }



// // задача 6
// using System;

// class Program
// {
//     static void Main()
//     {
//         Random random = new Random();
//         int number = random.Next(0, 101);  // Загадать число от 0 до 100
//         int attempts = 0;
//         const int maxAttempts = 10;

//         Console.WriteLine("Попробуйте угадать число от 0 до 100. У вас есть 10 попыток.");

//         while (attempts < maxAttempts)
//         {
//             Console.Write("Введите ваше предположение: ");
//             int guess = int.Parse(Console.ReadLine());
//             attempts++;

//             if (guess < number)
//             {
//                 Console.WriteLine("Загаданное число больше.");
//             }
//             else if (guess > number)
//             {
//                 Console.WriteLine("Загаданное число меньше.");
//             }
//             else
//             {
//                 Console.WriteLine("Поздравляю, вы угадали число!");
//                 break;
//             }

//             if (attempts == maxAttempts)
//             {
//                 Console.WriteLine($"Вы не угадали число за {maxAttempts} попыток. Загаданное число: {number}");
//             }
//         }
//     }
// }
