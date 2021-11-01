﻿// 1. Поиск максимального числа стихийный подход

    // int a1 = 11;
    // int b1 = 21;
    // int c1 = 39;
    // int a2 = 12;
    // int b2 = 23;
    // int c2 = 33;
    // int a3 = 13;
    // int b3 = 23;
    // int c3 = 31;

    // int max = a1;
    // if(b1 > max) max = b1;
    // if(c1 > max) max = c1;

    // if(a2 > max) max = a2;
    // if(b2 > max) max = b2;
    // if(c2 > max) max = c2;

    // if(a3 > max) max = a3;
    // if(b3 > max) max = b3;
    // if(c3 > max) max = c3;

    // Console.WriteLine(max);

// 2. Поиск максимального числа с помощью МЕТОДА

    // int Max(int arg1, int arg2, int arg3) // Метод(функция) поиска 
    //                                       // максимального значения из 3-х
    // {
    //     int result = arg1;
    //     if(arg2 > result) result = arg2;
    //     if(arg3 > result) result = arg3;
    //     return result;
    // }

    // int a1 = 11;
    // int b1 = 21;
    // int c1 = 39;
    // int a2 = 12;
    // int b2 = 2344;
    // int c2 = 33;
    // int a3 = 1333;
    // int b3 = 232;
    // int c3 = 31;

    // int max1 = Max(a1, b1, c1);
    // int max2 = Max(a2, b2, c2);
    // int max3 = Max(a3, b3, c3);
    // int max = Max(max1, max2, max3);

    // Console.WriteLine($"Максимальное число = {max}");

// 3. Задаем значения массивом
    // int Max(int arg1, int arg2, int arg3)
    // {
    //     int result = arg1;
    //     if(arg2 > result) result = arg2;
    //     if(arg3 > result) result = arg3;
    //     return result;
    // }
    // //тип    имя      значения
    // int [] array = { 15, 22, 13, 43 ,15 ,63 ,47 ,28 ,91 };

    // int find = 

    // int max = Max(
    //     Max(array[0], array[1],array[2]),
    //     Max(array[3], array[4],array[5]),
    //     Max(array[6], array[7],array[8])
    //     );

    // Console.WriteLine(max);
// 4. Поиск индекса значения, совпадающего с заданным

    // int[] array = { 12, 23, 13, 4, 57, 62, 4, 18 };
    // int n = array.Length;
    // int find = 4;

    // int index = 0;
    // while (index < n)
    // {
    //     if(array[index] == find)
    //     {
    //         Console.WriteLine(index);
    //         break;
    //     }
    //     index++;
    // }

// 5. Перепишем код прошлой задачи с использованием 
//    генератора случайных чисел

    // void FillArray(int[] collection) // это функция для внесения случайных 
    //                                 //чисел в массив

    // {
    //     int lenght = collection.Length;
    //     int index = 0;
    //     while (index < lenght)
    //     {
    //         collection[index] = new Random().Next(1,10);
    //         index++;
    //     }
    // }

    // void PrintArray(int[] col)
    // {
    //     int count = col.Length;
    //     int position =0;
    //     while (position < count)
    //     {
    //         Console.WriteLine(col[position]);
    //         position++;
    //     }
    // }

    // int[] array = new int[10]; // создай новый массив с 10 элементами

    // FillArray(array);
    // PrintArray(array);

// 6. Решаем 4. задачу с помощью 5.

void FillArray(int[] collection) // это функция для внесения случайных 
                                 //чисел в массив

{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position =0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index =0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай новый массив с 10 элементами

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);