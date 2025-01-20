using System;
using System.Diagnostics;

public class Fraction()
{
    private int _top;
    private int _bottom;

    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
            throw new ArgumentException("wrong answer.");
    }

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public String GetFractionString()
    {
        String text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
