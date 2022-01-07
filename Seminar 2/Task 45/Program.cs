// 44. Показать числа Фибоначчи
void Fibonacci()
{
    int first = 0;
    int second = 1;
    for (int i = 0; i < 45; i++)
    {
        int result = first + second;
        first = second;
        second = result;
        System.Console.WriteLine(result);
    }
}
Fibonacci();