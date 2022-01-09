// int[,] GetRandomArray(int rows, int columns)
// {
//     Random random = new Random();
//     var result = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {                                                            
//         for (int j = 0; j < columns; j++)
//         {
//             result[i,j] = random.Next(100);
//         }   
//     }
//     return result;
// }
// void Main()
// {
//     int rows = 10;
//     int columns = 5;
//     var myArray = GetRandomArray(rows, columns);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)                            >>> Заполнение матрицы <<<
//         {
//             System.Console.Write($"{myArray[i,j]}\t");
//         }
//         System.Console.WriteLine(); 
//     }
// }
// Main();
// =====================================================================================================================================================================

// Console.Write("Введите высоту треугольника: ");
// string? msg = Console.ReadLine();
// int height = Convert.ToInt32(msg);
// for (int i = 0; i < height; i++)
// {
//     for (int j = height; j > i; j--)                                 >>> Рисует треугольник из символов <<<
//     {                                                
//         System.Console.Write(" ");
//     }
//     for (int j = 0; j <= i; j++)
//     {
//         System.Console.Write("*");
//     }
//     System.Console.WriteLine();
// }
// =====================================================================================================================================================================

// int [] myArray = new int [5] {1,4,2,6,3};
// System.Console.WriteLine(myArray[3]);
// или
// int [] myArray = new int [] {1,4,2,6,3};
// System.Console.WriteLine(myArray[3]);                            >>> выделение памяти под массив и заполнение массива <<<
// или
// int [] myArray = {1,4,2,6,3};
// System.Console.WriteLine(myArray[3]);
// int [] myArray = Enumerable.Repeat(5,10).ToArray();              >>> заполняет массив из 10 элементов цифрами 5 <<<
// int [] myArray = Enumerable.Range(4,5).ToArray();                >>> заполняет массив из 5 элементов цифрами от 4 далее <<<


// =====================================================================================================================================================================

// System.Console.Write("Введите количество элементов массива:\t");

// int elementScout = int.Parse(Console.ReadLine());                          

// int [] myArray = new int[elementScout];

// for (int i = 0; i < myArray.Length ; i++)
// {
//     System.Console.Write($"\nВведите элемент массива под индексом {i}:\t ");               \n позволяет перейти на следующую строку, т.е. эту запись делает строкой ниже
//     myArray[i] = int.Parse(Console.ReadLine());
// }

// System.Console.WriteLine("\nВывод массива:");

// for (int i = 0; i < myArray.Length; i++)
// {
//     System.Console.WriteLine(myArray[i]);
   
// }

// =====================================================================================================================================================================
// using System;
// using System.Linq;                                                                   // использует расширение Linq
// using System.Text;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// int[] myArray = { 13, 24, 12, 31, 34, 36, 14, 23, 15 };                    
// System.Console.WriteLine(myArray.Max());                                             // чтобы найти максимальное значение в 1 строчку
// System.Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());                      // нахождение суммы положительных чисел
// System.Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());                      // нахождение минимального нечетного элемента
// int[] result = myArray.Distinct().ToArray();                                         // создание нового массива в котором только уникальные элементы первого
// int[] result = myArray.OrderBy(i => i).ToArray();                                    // сортировка по возрастанию
// int[] result = myArray.OrderByDescending(i => i).ToArray();                          // сортировка по убыванию
// Array.Sort(myArray);                                                                 // сортировка по возрастанию
// int result = Array.Find(myArray, i => i < 15);                                       // ищет элемент < 15 и присваивает первый на пути (с начала)
// int result = Array.FindLast(myArray, i => i < 15);                                   // ищет элемент < 15 и присваивает первый на пути (с конца)
// int[] result = Array.FindAll(myArray, i => i < 15);                                  // ищет элемент < 15 и формирует массив со всеми элементами < 15
// int result = Array.FindIndex(myArray, i => i == 15);                                 // ищет индекс элемента = 15 и присваивает первый на пути (с начала)
// int result = Array.FindIndexLast(myArray, i => i == 15);                             // ищет индекс элемента = 15 и присваивает первый на пути (с конца)
// Array.Reverse(myArray);                                                              // переписывает массив в обратном порядке(реверс)
// int[] result = myArray.Where(i => i < 15).ToArray();                                 // формирует массив удовлетворяющий условию где элементы < 15 (через Linq)
// int result = myArray.Where(i => i < 15).First();                                     // ищет первый элемент удовлетворяющий условию < 15 (через Linq)
// int result = myArray.Where(i => i < 15).FirstOrDefault();                            // ищет первый элемент удовлетворяющий условию < 15 (через Linq), если такого нет, то возвращ дефолтное
// System.Console.WriteLine(myArray[^1]);                                               // [^1] это означает последний номер индекса в массиве

// System.Console.WriteLine(myArray[^1]);

// for (int i = 0; i < myArray.Length; i++)
// {
//     System.Console.Write($"{myArray[i]} ");  
// }