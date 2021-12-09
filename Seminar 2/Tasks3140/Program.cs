// Почувствуй себя сеньором*
// 31. Задать массив из 8 элементов и вывести их на экран
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// ========================== Задача 31 ===========================
// 31. Задать массив из 8 элементов и вывести их на экран

// int[] Array = new int[8];
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = new Random().Next(1,10);
//     System.Console.WriteLine(Array[i]);   
// }

// ========================== Задача 32 ===========================
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// int[] Array = new int[8];
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = new Random().Next(0,2);
//     System.Console.WriteLine(Array[i]);   
// }

// ========================== Задача 33 ===========================
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

// int[] Array = new int[12];
// int Summ = 0;
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = new Random().Next(0,10);
//     Summ += Array[i];
//     System.Console.WriteLine(Array[i]);
// }
// System.Console.WriteLine($"Сумма чисел данного масиива равно: {Summ}");

// ========================== Задача 34 ===========================
// 34. Написать программу замену элементов массива на противоположные

// int[] Array = new int[8];
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = new Random().Next(1, 10);
//     System.Console.Write($"{Array[i]} ");
// }
// System.Console.WriteLine();
// System.Console.WriteLine("новый массив");
// for (int i = Array.Length-1; i >= 0; i--)
// {
//     System.Console.Write($"{Array[i]} ");
// }
// ========================== Задача 35 ===========================
// 35. Определить, присутствует ли в заданном массиве, некоторое число

// void SearchNum(int num)
// {
//     int[] Array = new int[8];
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = new Random().Next(1, 10);
//         System.Console.WriteLine(Array[i]);
//     }
//     for (int i = 0; i < Array.Length; i++)
//     {
//         if (Array[i] == num)
//         {
//             System.Console.WriteLine($"Число найдено на {i} позиции");
//             break;
//         }
//     }
// }
// SearchNum(5);

// ========================== Задача 36 ===========================
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// int[] Array = new int[6];
// int SearchNum(int[] Array)
// {
//     int chet = 0;
//     int nechet = 0;
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = new Random().Next(100, 1000);
//         System.Console.WriteLine(Array[i]);
//         if (Array[i] % 2 == 0)
//         {
//             chet++;
//         }
//         else
//         {
//             nechet++;
//         }
//     }
//     System.Console.Write($"в данной последовательности трехзначных чисел {chet} четных чисел");
//     System.Console.Write(", а нечетных - ");
//     return nechet;
// }
// System.Console.WriteLine(SearchNum(Array)); 


// ========================== Задача 37 ===========================
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] Array = new int[123];
// int SearchNum(int[] Array)
// {
//     int count = 0;
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = new Random().Next(0, 150);
//         System.Console.WriteLine(Array[i]);
//         if (Array[i] >= 10 & Array[i] <= 99)
//         {
//             count++;
//         }
//     }
//     System.Console.Write("Число из отрезка [10,99] встречается в данной последовательности раз - ");
//     return count;
// }
// System.Console.WriteLine(SearchNum(Array));

// ========================== Задача 38 ===========================
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// int[] Array = new int[12];
// int SearchNum(int[] Array)
// {
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = new Random().Next(1, 10);
//         System.Console.WriteLine(Array[i]);
//     }
//     int summ = 0;
//         for (int i = 1; i < Array.Length; i++)
//         {
//             summ += Array[i];
//             i += 1;
//         }
//         System.Console.Write("Сумма чисел массива, стоящих на нечетной позиции, равна - ");
//         return summ;
// }
// System.Console.WriteLine(SearchNum(Array));

// ========================== Задача 39 ===========================
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] Array = new int[8];
// int proiz = 1;
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = new Random().Next(1, 10);
//     System.Console.WriteLine(Array[i]);
// }
// System.Console.WriteLine();
// for (int i = 0; i < Array.Length; i++)
// {
//     proiz = Array[i] * Array[Array.Length-1-i];
//     System.Console.Write($"элемент массива - {Array[i]}, произведение с противоположным значением = {proiz}");
//     System.Console.WriteLine();
// }

// ========================== Задача 40 ===========================
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// double[] Array = new double[8];
// double razn = 0; 
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = new Random().NextDouble();
//         System.Console.WriteLine(Array[i]);             
//     }
//         double max = Array[1];
//         double min = Array[0];
//         for (int i = 1; i < Array.Length; i++)
//         {
//             if (Array[i]>=max)
//             {
//                 max = Array[i];
//             }
//             else
//             {
//                 if (Array[i] < min)
//                 {
//                     min = Array[i];
//                 }    
//             }
//         }
// razn = max - min;
// System.Console.WriteLine($"Разность между максималдьным и минимальным числом равна {razn}");
