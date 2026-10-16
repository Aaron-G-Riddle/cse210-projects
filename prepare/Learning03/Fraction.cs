using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _num;
    private int _den;

    public Fraction()
    {
        _num = 1;
        _den = 1;
    }

    public Fraction(int number)
    {
        _num = number;
        _den = 1;
    }

    public Fraction(int num, int den)
    {
        _num = num;
        SetDen(den);
    }

    public void SetDen(int den)
    {
        if (den != 0)
        {
            _den = den;
        }
        else
        {
            _den = 1;
            Console.WriteLine("Cannot divide by 0, denominator automatically set to 1");
        }
    }
    
    public void SetNum(int num)
    {
        _num = num;
    }

    public int GetNum()
    {
        return _num;
    }

    public int GetDen()
    {
        return _den;
    }

    public string GetFraction()
    {
        string frac = $"{_num} / {_den}";
        return frac;
    }

    public double GetDec()
    {
        return (double)_num / (double)_den;
    }
}