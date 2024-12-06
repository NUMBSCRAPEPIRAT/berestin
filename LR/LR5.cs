// //задача 1
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
        
//         List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        
//         Console.WriteLine("Элемент по индексу 2: " + numbers[2]);

       
//         numbers[2] = 10;
//         Console.WriteLine("После замены: " + string.Join(", ", numbers));

        
//         numbers.Add(6);
//         Console.WriteLine("После добавления: " + string.Join(", ", numbers));

        
//         numbers.RemoveAt(3); 
//         Console.WriteLine("После удаления: " + string.Join(", ", numbers));

        
//         List<int> duplicateList = new List<int>(numbers);
//         Console.WriteLine("Дублированный список: " + string.Join(", ", duplicateList));
//     }
// }

// //задача 2
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
        
//         List<int> numbers = new List<int> { 5, 2, 8, 1, 4, 7 };

        
//         int min = numbers[0];
//         int minIndex = 0;
//         for (int i = 1; i < numbers.Count; i++)
//         {
//             if (numbers[i] < min)
//             {
//                 min = numbers[i];
//                 minIndex = i;
//             }
//         }

//         Console.WriteLine("Минимальный элемент: " + min);
//         Console.WriteLine("Индекс минимального элемента: " + minIndex);
//     }
// }



// //задача 3
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
        
//         List<int> numbers = new List<int> { -3, 2, 5, -8, 0, 7, -1 };

        
//         List<int> positiveNumbers = new List<int>();
//         List<int> nonPositiveNumbers = new List<int>();

//         foreach (int num in numbers)
//         {
//             if (num > 0)
//             {
//                 positiveNumbers.Add(num);
//             }
//             else
//             {
//                 nonPositiveNumbers.Add(num);
//             }
//         }

//         Console.WriteLine("Положительные элементы: " + string.Join(", ", positiveNumbers));
//         Console.WriteLine("Неположительные элементы: " + string.Join(", ", nonPositiveNumbers));
//     }
// }

// //задача 4
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
        
//         List<int> D = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

      
//         int sum = 0;
//         for (int i = 1; i < D.Count; i += 2) 
//         {
//             sum += D[i];
//         }

//         Console.WriteLine("Список D: " + string.Join(", ", D));
//         Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
//     }
// }



// //задача 5
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
        
//         List<int> numbers = new List<int> { 5, 12, 16, 8, 20, 7, 3, 10 };

        
//         for (int i = 0; i < numbers.Count; i++)
//         {
//             if (numbers[i] < 15)
//             {
//                 numbers[i] *= 2;
//             }
//         }

//         Console.WriteLine("Преобразованный список: " + string.Join(", ", numbers));
//     }
// }

// //задача 6
// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
       
//         List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//         List<int> list2 = new List<int> { 5, 6, 7, 8, 9, 10, 11 };

        
//         var intersection = list1.Intersect(list2).OrderBy(x => x).ToList();

//         Console.WriteLine("Общие числа в порядке возрастания: " + string.Join(", ", intersection));
//     }
// }
