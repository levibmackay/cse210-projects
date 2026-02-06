using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor 1: default 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: whole number / 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor 3: top / bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom);
    }

    // Setter for top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Setter for bottom (prevents divide by zero)
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            _bottom = 1;
        }
    }

    // Getter for top
    public int GetTop()
    {
        return _top;
    }

    // Getter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Returns fraction string (ex: 3/4)
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns decimal value
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
