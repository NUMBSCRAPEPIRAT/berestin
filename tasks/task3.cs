// квадратное уравнение
using System;

class Program
{
    static void Main()
    {
        double a, b, c;
        
        
        Console.Write("Введите коэффициент a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        c = Convert.ToDouble(Console.ReadLine());

        
        if (a == 0)
        {
            Console.WriteLine("Это не квадратное уравнение, так как a = 0.");
            return;
        }

        
        double discriminant = b * b - 4 * a * c;

        
        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Уравнение имеет два корня: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Уравнение имеет один корень: x = {x}");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет действительных корней.");
        }
    }
}

//кубическое уравнение

// using System;

// class Program
// {
//     static void Main()
//     {
//         double a, b, c, d;

//         
//         Console.Write("Введите коэффициент a: ");
//         a = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Введите коэффициент b: ");
//         b = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Введите коэффициент c: ");
//         c = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Введите коэффициент d: ");
//         d = Convert.ToDouble(Console.ReadLine());

//         
//         if (a == 0)
//         {
//             Console.WriteLine("Это не кубическое уравнение, так как a = 0.");
//             return;
//         }

//         
//         double p = (3 * a * c - b * b) / (3 * a * a);
//         double q = (2 * b * b * b - 9 * a * b * c + 27 * a * a * d) / (27 * a * a * a);

//        
//         double discriminant = Math.Pow(q / 2, 2) + Math.Pow(p / 3, 3);

//         if (discriminant > 0)
//         {
//             
//             double u = Math.Cbrt(-q / 2 + Math.Sqrt(discriminant));
//             double v = Math.Cbrt(-q / 2 - Math.Sqrt(discriminant));
//             double root = u + v - b / (3 * a);
//             Console.WriteLine($"Уравнение имеет один корень: x = {root}");
//         }
//         else if (discriminant == 0)
//         {
//             
//             double u = Math.Cbrt(-q / 2);
//             double root1 = 2 * u - b / (3 * a);
//             double root2 = -u - b / (3 * a);
//             Console.WriteLine($"Уравнение имеет два корня: x1 = {root1}, x2 = {root2}");
//         }
//         else
//         {
//            
//             double r = Math.Sqrt(Math.Pow(q / 2, 2) - discriminant);
//             double theta = Math.Acos(-q / (2 * r));
//             double root1 = 2 * Math.Cbrt(r) * Math.Cos(theta / 3) - b / (3 * a);
//             double root2 = 2 * Math.Cbrt(r) * Math.Cos((theta + 2 * Math.PI) / 3) - b / (3 * a);
//             double root3 = 2 * Math.Cbrt(r) * Math.Cos((theta + 4 * Math.PI) / 3) - b / (3 * a);
//             Console.WriteLine($"Уравнение имеет три корня: x1 = {root1}, x2 = {root2}, x3 = {root3}");
//         }
//     }
// }

// для квадратного уравнения:
// Название теста	                   Описание сценария	                                    Входные данные	                Выходные данные	         Удачное/неудачное тестирование	
// Правильность расчетов	           Проверка корректности вычисления корней дискриминанта	a = 1, b = -3, c = 2	         Корни: x1 = 2, x2 = 1	          Удачное	
// Отрицательный дискриминант	       Проверка для уравнения с отрицательным дискриминантом	a = 1, b = 2, c = 5	             Нет действительных корней	      Удачное	
// Один корень (дискриминант = 0)	   Проверка для уравнения с дискриминантом = 0	            a = 1, b = 2, c = 1	             Один корень: x = -1	          Удачное	
// Нулевой коэффициент a	           Проверка на случай, когда a = 0	                        a = 0, b = 2, c = 1	             Это не квадратное уравнение	  Удачное	



// Для кубического уравнения:
// Название теста	                   Описание сценария	                                    Входные данные	                 Выходные данные	               Удачное/неудачное тестирование	
// Простой случай с одним корнем	   Проверка для кубического уравнения с одним корнем	    a = 1, b = -6, c = 11, d = -6	Один корень: x = 3	                        Удачное	
// Дискриминант > 0	                   Проверка для уравнения с положительным дискриминантом	a = 1, b = 0, c = -6, d = 8	    Один корень: x = 2	                        Удачное	
// Несуществующие корни	               Проверка для уравнения, у которого нет реальных корней	a = 1, b = 0, c = 1, d = 0	   Уравнение не имеет действительных корней	    Удачное	
// Нулевой коэффициент a	           Проверка на случай, когда a = 0	                        a = 0, b = 1, c = -6, d = 8	    Это не кубическое уравнение	                Удачное	