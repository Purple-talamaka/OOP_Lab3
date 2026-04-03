using System;

public class Model
{
    private int _a;
    private int _b;
    private int _c;

    public int A
    {
        get { return _a; }
    }

    public int B
    {
        get { return _b; }
    }

    public int C
    {
        get { return _c; }
    }

    public void SetA(int value)
    {
        value = Math.Clamp(value, 0, 100);
        _a = value;

        if (_b < _a)
        {
            _b = _a;
        }

        if (_c < _b)
        {
            _c = _b;
        }
    }

    public void SetB(int value)
    {
        value = Math.Clamp(value, _a, _c);
        _b = value;
    }

    public void SetC(int value)
    {
        value = Math.Clamp(value, 0, 100);
        _c = value;

        if (_b > _c)
        {
            _b = _c;
        }

        if (_a > _b)
        {
            _a = _b;
        }
    }
}

