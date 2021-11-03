// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные

// Функция для заполнения массива случайными числами
int GetRandom(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
// Задали массив
int[] A = new int[10];

// Создание массива
int index = 0;
while (index < 10)
{
    A[index] = GetRandom(10, 100);
    index++;
}
// Вывод массива на экран
index = 0;
while (index < 10)
{
    Console.WriteLine(A[index]);
    index++;
}
Console.WriteLine();
// Исключение элементов нарушения возрастания
index = 1;
int CurrentElement = A[0];
Console.WriteLine(CurrentElement);
while (index < 10)
{
    if(A[index] > CurrentElement)
    {
        Console.WriteLine(A[index]);
        CurrentElement = A[index];
        
    }

    index++;
}
