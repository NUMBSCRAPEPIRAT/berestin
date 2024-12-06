// //задача 1
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите строку: ");
//         string input = Console.ReadLine();

//         if (input.Length > 1)
//         {
//             string result = "!" + input.Substring(1, input.Length - 2) + "!";
//             Console.WriteLine("Результат: " + result);
//         }
//         else if (input.Length == 1)
//         {
//             Console.WriteLine("Результат: !");
//         }
//         else
//         {
//             Console.WriteLine("Строка пуста.");
//         }
//     }
// }



// //задача 2
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите слово: ");
//         string word = Console.ReadLine();

//         if (word.Length > 0)
//         {
//             Console.WriteLine("Длина слова: " + word.Length);
//             Console.WriteLine("Первая буква: " + word[0]);
//             Console.WriteLine("Последняя буква: " + word[word.Length - 1]);
//         }
//         else
//         {
//             Console.WriteLine("Вы не ввели слово.");
//         }
//     }
// }



// //задача 3
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите максимальную длину строки (k): ");
//         int k = int.Parse(Console.ReadLine());

//         Console.Write("Введите строку: ");
//         string input = Console.ReadLine();

//         if (input.Length > k)
//         {
//             string excess = input.Substring(k);
//             Console.WriteLine("Лишние символы: " + excess);
//         }
//         else
//         {
//             Console.WriteLine("Строка не превышает заданную длину.");
//         }
//     }
// }



// //задача 4
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите строку (два слова через пробел): ");
//         string input = Console.ReadLine();

//         string[] words = input.Split(' ');

//         if (words.Length == 2)
//         {
//             Console.WriteLine("Второе слово: " + words[1]);
//         }
//         else
//         {
//             Console.WriteLine("Ошибка: введено больше или меньше двух слов.");
//         }
//     }
// }



// //задача 5
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите строку слов, разделенных пробелами: ");
//         string input = Console.ReadLine();

//         string[] words = input.Split(' ');
//         string longestWord = words[0];

//         foreach (var word in words)
//         {
//             if (word.Length > longestWord.Length)
//             {
//                 longestWord = word;
//             }
//         }

//         Console.WriteLine("Самое длинное слово: " + longestWord);
//     }
// }



// //задача 6
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите строку: ");
//         string input = Console.ReadLine();

//         int lowercaseCount = 0;
//         int uppercaseCount = 0;

//         foreach (char c in input)
//         {
//             if (char.IsLower(c))
//             {
//                 lowercaseCount++;
//             }
//             else if (char.IsUpper(c))
//             {
//                 uppercaseCount++;
//             }
//         }

//         Console.WriteLine($"Количество строчных букв: {lowercaseCount}");
//         Console.WriteLine($"Количество прописных букв: {uppercaseCount}");
//     }
// }
