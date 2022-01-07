// 43. Написать программу преобразования десятичного числа в двоичное

string Transformation(int value)
{
    string binary = Convert.ToString(value, 2);
    return binary;
}

System.Console.WriteLine(Transformation(22127));