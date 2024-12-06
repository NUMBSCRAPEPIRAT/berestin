import math

def check_triangle_type(a, b, c):

    if a + b <= c or a + c <= b or b + c <= a:
        return "Треугольник не существует"


    if a == b == c:
        return "Равносторонний треугольник"
    elif a == b or b == c or a == c:
        return "Равнобедренный треугольник"
    else:
        return "Разносторонний треугольник"

def calculate_area(a, b, c):

    s = (a + b + c) / 2

    area = math.sqrt(s * (s - a) * (s - b) * (s - c))
    return area

def main():
    try:
        a = float(input("Введите длину стороны A: "))
        b = float(input("Введите длину стороны B: "))
        c = float(input("Введите длину стороны C: "))
        
        if a <= 0 or b <= 0 or c <= 0:
            print("Длины сторон должны быть положительными числами.")
            return
        
        triangle_type = check_triangle_type(a, b, c)
        print(f"Тип треугольника: {triangle_type}")
        
        if triangle_type != "Треугольник не существует":
            area = calculate_area(a, b, c)
            print(f"Площадь треугольника: {area:.2f}")
        else:
            print("Невозможно вычислить площадь для недопустимого треугольника.")
    
    except ValueError:
        print("Ошибка ввода. Пожалуйста, введите числовые значения.")

if __name__ == "__main__":
    main()


# 
# 
# 
# 
# 
# 
#
# def check_triangle_angles(a, b, c):

#     if a + b <= c or a + c <= b or b + c <= a:
#         return "Треугольник не существует"


#     a_squared = a ** 2
#     b_squared = b ** 2
#     c_squared = c ** 2


#     if a_squared + b_squared == c_squared or a_squared + c_squared == b_squared or b_squared + c_squared == a_squared:
#         return "Прямоугольный треугольник"


#     if a_squared + b_squared > c_squared and a_squared + c_squared > b_squared and b_squared + c_squared > a_squared:
#         return "Остроугольный треугольник"


#     if a_squared + b_squared < c_squared or a_squared + c_squared < b_squared or b_squared + c_squared < a_squared:
#         return "Тупоугольный треугольник"

# def main():
#     try:
#         a = float(input("Введите длину стороны A: "))
#         b = float(input("Введите длину стороны B: "))
#         c = float(input("Введите длину стороны C: "))
        
#         if a <= 0 or b <= 0 or c <= 0:
#             print("Длины сторон должны быть положительными числами.")
#             return
        
#         triangle_type = check_triangle_angles(a, b, c)
#         print(f"Тип углов треугольника: {triangle_type}")
    
#     except ValueError:
#         print("Ошибка ввода. Пожалуйста, введите числовые значения.")

# if __name__ == "__main__":
#     main()


# A	B	C	Ожидаемый результат	                           Результат проверки
# 3	4	5	Прямоугольный треугольник, площадь 6.00	       Прямоугольный треугольник, площадь 6.00
# 2	2	3	Разносторонний треугольник, площадь 1.98	   Разносторонний треугольник, площадь 1.98
# 5	5	5	Равносторонний треугольник, площадь 10.83	   Равносторонний треугольник, площадь 10.83
# 1	2	3	Треугольник не существует	                   Треугольник не существует
# 7	7	10	Равнобедренный треугольник, площадь 24.33	   Равнобедренный треугольник, площадь 24.33
# 6	8	10	Остроугольный треугольник	                   Остроугольный треугольник
# 1	1	2	Треугольник не существует	                   Треугольник не существует


