﻿double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denuminator = c + d;
    double result = numenator / denuminator;
    return result;
}
double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);