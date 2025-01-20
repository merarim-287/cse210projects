using System;

class Program
{
    static void Main(string[] args)
    {
        int numerators = { 0, 0, 5, 3, 1 };
        int denominators = { 1, 1, 1, 4, 3 };

        for (int i = 0; i < numerators.Length; i++)
        {
            Fraction fraction = new Fraction(numerators i, denominators i);
            Console.WriteLine($"Fraction: {fraction.GetFractionString()} - Decimal: {fraction.GetDecimalValue()}");
        }
    }
}


class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
