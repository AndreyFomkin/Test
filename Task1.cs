double CalculateFormula ( int a, int b, int c, int d)
{
    double  numenator = a * b;
    double denumenator = c + d;
    double result = numenator/denumenator;
    return result;
}
double result = CalculateFormula (4,5,6,7);
Console.Write (result);