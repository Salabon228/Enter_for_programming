﻿//         Почувствуй себя интерном*
// 0. Вывести квадрат числа
// 1. По двум заданным числам проверять является ли первое квадратом второго
// 2. Даны два числа. Показать большее и меньшее число
// 3. По заданному номеру дня недели вывести его название
// 4. Найти максимальное из трех чисел
// 5. Написать программу вычисления значения функции y = f(a)
// 6. Выяснить является ли число чётным
// 7. Показать числа от -N до N
// 8. Показать четные числа от 1 до N
// 9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет

// Почувствуй себя джуном*
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// Программа проверяет пятизначное число на палиндромом.
// Найти расстояние между точками в пространстве 2D/3D

// Почувствуй себя мидлом*
// 1. Показать таблицу квадратов чисел от 1 до N
// 2. Найти кубы чисел от 1 до N
// 3. Найти сумму чисел от 1 до А
// 4. Возведите число А в натуральную степень B используя цикл
// 5. Определить количество цифр в числе
// 6. Подсчитать сумму цифр в числе
// 7. Написать программу вычисления произведения чисел от 1 до N
// 8. Показать кубы чисел, заканчивающихся на четную цифру

// Почувствуй себя мидлом*
// 1. Показать таблицу квадратов чисел от 1 до N
// 2. Найти кубы чисел от 1 до N
// 3. Найти сумму чисел от 1 до А
// 4. Возведите число А в натуральную степень B используя цикл
// 5. Определить количество цифр в числе
// 6. Подсчитать сумму цифр в числе
// 7. Написать программу вычисления произведения чисел от 1 до N
// 8. Показать кубы чисел, заканчивающихся на четную цифру

        // ========================== Задача 0 ===========================
        // int Method1(int a)
        // {
        //     int proizv = a * a;
        //     return proizv;
        // }
        // int A = Method1(5);
        // Console.WriteLine($"Квадрат введенного числа равен: {A}");

        // ========================== Задача 1 ===========================
        // По двум заданным числам проверять является ли первое квадратом второго
        // bool FirstSquerOrNo(int a, int b)
        // {

        // if ( b * b == a) 
        //         {
        //         return true;
        //         }
        //         else 
        //         {
        //         return false;
        //         }
        // }
        // Console.WriteLine(FirstSquerOrNo(8, 3));


        // ========================== Задача 2 ===========================

        // Вывести большее число из 2-х
     //    int WhoMore(int a, int b)
     //    {
     //    return a > b? a : b;
     //    }

     //    Console.WriteLine(WhoMore(2, 177));



        // ========================== Задача 3 ===========================
        //По заданному номеру дня недели вывести его название


             // понедельник вторник среда четверг пятница суббота воскресенье

        // string weekDays(int day)
        // {
        //         if(day <= 0 || day >= 8) return "Вы с другой планеты";
        //         string[] weekDays = new string[] {  "Пн", "Вт", "Ср", "Чт", "Пт", "Сб" , "Вс"}; 
                
        //         return weekDays[day-1];  // Спасибо Сергею за спасенные ячейки памяти!
        //                         //         int length = weekDays.Length;
        //                         //         string result = String.Empty;
        //                         //         for (int i = 0; i < length; i++)
        //                         //         {
        //                         //                 if( day > 7)
        //                         //                 {
        //                         //                 Console.WriteLine("Такого дня недели не существует");
        //                         //                 break;
        //                         //                 }
        //                         //                 else
        //                         //                 {
        //                         //                 if (day - 1 == i)
        //                         //                 result = result + weekDays[i];  
        //                         //                 }           
        //                         //         }
        //                         //                 return result;  
        // } 
        // Console.WriteLine(weekDays(5));     



        // ========================== Задача 4 ===========================

        // Найти максимальное из трех чисел 
        // int MaxOfThree(int a, int b, int c)
        // {
        //         int max = a;
        //         if(b > a) max = b;
        //         if(c > b)
        //         {
        //                 if(c > a) max = c;
        //         }
        //         return max;
        // }

        // Console.WriteLine($"Максимальное число = {MaxOfThree(122, 12, 33)}");
        
        
        
        // ========================== Задача 5 ===========================

        //Написать программу вычисления значения функции sin^10(a)
        //в скобках угол в градусах

     //    double UseCombinedSineCosine(double degrees)
     //    {
     //            double angle = Math.PI * degrees / 180.0;
     //            double sinAngle = Math.Sin(angle);
     //            // double result = sinAngle * sinAngle * sinAngle * sinAngle * sinAngle * sinAngle * sinAngle * sinAngle * sinAngle * sinAngle;
     //            double result = Math.Pow( sinAngle, 1 );
     //    return result;
     //    }

     //    Console.WriteLine(UseCombinedSineCosine(30));



        // ========================== Задача 6 ===========================
        
          // bool ChetOrNo (int num)
          // {
          //      return num % 2 == 0;
          // }
          // Console.WriteLine(ChetOrNo(4));
        
        // ========================== Задача 7 ===========================

          // Показать числа от -N до N
               
          // int Method7(int N)
          // {
          //      for (int i = -N; i <= N; i++)
          //      {
          //           Console.Write(i + " ");
          //      }
          //      return N;
          // }
          // Method7(5);
          // ========================== Задача 8 ===========================

          // Показать четные числа от 1 до N
          // int Method8(int N)
          // {
          //      for (int i = 1; i <= N; i++)
          //      {
          //           if ( i % 2 == 0)
          //           {
          //           Console.Write(i + " ");
          //           }
          //      }
          //      return N;
          // }
          // Method8(15);

          // ========================== Задача 9 ===========================

          //Показать последнюю цифру трёхзначного числа
          
          // int Method9(int N)
          // {
          //      int num = N % 10;
          //      return num;
          // }
          // Console.WriteLine(Method9(991)); 

          // ========================== Задача 10 ===========================
          
          //Показать вторую цифру трёхзначного числа  

          // int Method10(int N)
          // {
          //      int num = (N / 10) % 10;

          //      return num;
          // }
          // Console.WriteLine(Method10(971)); 

          // ========================== Задача 11 ===========================

          //Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

          // int Method11(int N)
          // {
          //      int perv = N / 10;
          //      int vtor = N % 10;
          //      int num = perv;
          //      if (perv < vtor)
          //      {
          //           num = vtor;
          //      }
          //      return num;
          // }
          // Console.WriteLine(Method11(86));


          // ========================== Задача 12 ===========================

          // Удалить вторую цифру трёхзначного числа










         // ========================== Задача 19 ===========================

int Method(int x, int y)
{
    if(x > 0)
    {
         if (y > 0) 
         {
              return 1;
         }
         else
         {
             return 4;
         }
    }
    else
    {
        if (y > 0) 
         {
              return 2;
         }
         else
         {
             return 3;
         }
    }
                                        //      if(x > 0)                  // Этот код помог записать Сергей
                                        //     {
                                        //           return y > 0? 1:4;
                                        //     }
                                        //     else
                                        //     {
                                        //         return y > 0? 2:3;
                                        //     }
}
// Console.WriteLine("Введите число x: ");
// int x = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Введите число y: ");
// int y = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(Method(x, y));



          // ========================== Задача 20 ===========================
          // 20. Задать номер четверти, показать диапазоны для возможных координаn

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
             + "ежели бы вас послали вместо нашего милого Винценгероде,"
             + "вы бы взяли приступом согласие прусского короля. "
             + "Вы так красноречивы. Вы дадите мне чаю?";
string Method20(string text, int num)
{
     int index = 0;
     if (num == 1) 
     {
          index = 0;
     }
     
}
Method20();
