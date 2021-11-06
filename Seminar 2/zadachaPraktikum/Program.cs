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
Console.WriteLine("Последовательность исключающая элементы нарушения возрастания:");
Console.WriteLine();
// Исключение элементов нарушения возрастания
index = 1;
int CurrentElement = A[0];
Console.WriteLine(CurrentElement);
while (index < 10)
{
    if(A[index] > CurrentElement)
    {
        Console.WriteLine($"{A[index]} "); 
        CurrentElement = A[index];    
    }
    index++;
}

//================== 2 подзадача ======================
index = 0;
double SAR = 0;
while (index < 10)
{
    SAR = SAR + A[index];
    index++;
}
SAR = SAR / 10;
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое массива А = {SAR}");
Console.WriteLine();
Console.WriteLine("Последовательность, которая больше среднего арифметического элементов A:");
Console.WriteLine();

index = 0;

while (index < 10)
{
    if(A[index] > SAR)
    {
        Console.Write($"{A[index]} ");   
    }
    index++;
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Четные элементы массива A:");

index = 0;

while (index < 10)
{
    if(A[index] % 2 == 0)
    {
        Console.Write($"{A[index]} "); 
    }
    index++;
}
Console.WriteLine();
