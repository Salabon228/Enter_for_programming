﻿// Почувствуй себя джуном*
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D

// ========================== Задача 15 ===========================
// Дано число. Проверить кратно ли оно 7 и 23
// int Kratnoli(int num)
// {
//     if (num % 7 == 0)
//     {
//         System.Console.WriteLine("Заданное число кратно 7");
//     }
//     else
//     {
//         if (num % 23 == 0)
//         {
//             System.Console.WriteLine("Заданное число НЕ кратно 7, но кратно 23");
//         }
//         else
//         {
//             System.Console.WriteLine("Заданное число НЕ кратно 7 и НЕ кратно 23");
//         }
//     }
// return num;
// }
// System.Console.WriteLine(Kratnoli(23));


// ========================== Задача 16 ===========================

// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// int WeekDay(int num)
// {
//     if (num <=0 & num > 7)
//     {
//         System.Console.WriteLine("Такого для недели не существует, нужно ввести цифру от 1 до 7");
//     }
//     else
//     {
//         if (num == 6 | num == 7)
//         {
//             System.Console.WriteLine("Этот день - выходной");
//         }
//         else
//         {
//             System.Console.WriteLine("Этот день НЕ выходной");
//         }
//     }
//     return num;
// }
// WeekDay(6);

// ========================== Задача 17 ===========================
// По двум заданным числам проверять является ли одно квадратом другого

// bool Square(int numA, int numB)
// {
//     if (numA == numB * numB)
//     {
//         System.Console.WriteLine("первое число является квадратом второго");
//         return true;
//     }
    
//     else
//     {
//         if (numB == numA * numA)
//         {
//             System.Console.WriteLine("второе число является квадратом первого");
//             return true;
//         }
//         else
//         {
//             System.Console.WriteLine("ни одно число не является квадратом второго");
//             return false;
//         }
//     } 
// }
// Square(13,169);

// ========================== Задача 18 ===========================
// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// bool Truth(bool X, bool Y)
// {
//     if (!(X | Y) == !X & !Y)
//     {
//         System.Console.WriteLine("Утверждение истинно");
//         return true;
//     }
//     else
//     {
//         System.Console.WriteLine("Утверждение ложно");
//         return false;
//     }
// }
// Truth(true, true);


// ========================== Задача 19 ===========================
// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// int Method(int x, int y)
// {
//     if(x > 0)
//     {
//          if (y > 0) 
//          {
//               return 1;
//          }
//          else
//          {
//              return 4;
//          }
//     }
//     else
//     {
//         if (y > 0) 
//          {
//               return 2;
//          }
//          else
//          {
//              return 3;
//          }
//     }
//      if(x > 0)                  // Этот код помог записать Сергей
//     {
//           return y > 0? 1:4;
//     }
//     else
//     {
//         return y > 0? 2:3;
//     }
//  }
// Console.WriteLine("Введите число x: ");
// int x = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Введите число y: ");
// int y = Convert.ToInt16(Console.ReadLine());

// Console.WriteLine(Method(x, y));



// ========================== Задача 20 ===========================
// 20. Задать номер четверти, показать диапазоны для возможных координаn
string[] text = { "нет такой четверти",
                  "координаты х от 0 до бесконечности координаты у от 0 до бесконечности",
                  "координаты х от 0 до минус бесконечности координаты у от 0 до бесконечности",
                  "координаты х от 0 до минус бесконечности координаты у от 0 до минус бесконечности",
                  "координаты х от 0 до бесконечности координаты у от 0 до минус бесконечности"
                };
string Method20(string text, int num)
{
     int index = 0;
     if (num == 1) 
     {
          index = 0;
     }

}
Method20();
// пока не закончил