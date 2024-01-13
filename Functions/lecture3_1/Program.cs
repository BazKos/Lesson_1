//Вычислить значение формулы(a*b)/(c+d),
//где a, b, c, d - некоторые целые числа.
//Решение оформить в виде функции.

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denominator = c + d;
    double result = numenator / denominator;
    return result;
}
double result = CalculateFormula(4, 6, 1, 5);
Console.WriteLine(result);
